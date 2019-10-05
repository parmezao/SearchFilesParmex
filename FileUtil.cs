using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchFilesPmx
{
    public class FileUtil
    {
        public static IEnumerable<string> GetFiles(string root, string searchPattern)
        {
            Stack<string> pending = new Stack<string>();
            pending.Push(root);

            while (pending.Count != 0)
            {
                var path = pending.Pop();
                string[] files = null;

                files = Directory.GetFiles(path, searchPattern);

                if (files != null && files.Length != 0)
                    foreach (var file in files)
                        yield return file;

                try
                {
                    files = Directory.GetDirectories(path);
                    foreach (var subdir in files)
                        pending.Push(subdir);
                }
                catch
                {
                } 
            }           
        }

        public static List<string> FindInFile(string fileName, string searchTerm)
        {
            List<string> files = new List<string>();
            const Int32 BufferSize = 1024;

            try
            {
                using (var fileStream = File.OpenRead(fileName))
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
                {
                    String line;
                    Int32 counter = 0;
                    string nameFile = "";
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        string linha = line;
                        counter++;

                        if (Regex.IsMatch(linha, searchTerm, RegexOptions.IgnoreCase))
                        //if (linha.Contains(searchTerm))
                        {
                            if (counter == 1)
                            {
                                files.Add($"{fileName}");
                                files.Add($"    Linha: {counter} - {linha}");
                            }
                            else
                            {
                                if (String.IsNullOrEmpty(nameFile))
                                    files.Add($"{fileName}");
                                files.Add($"    Linha: {counter} - {linha}");
                            }

                            nameFile = fileName;
                        }
                    }
                }
            }
            catch (IOException e)
            {
                files.Add($"*{e.Message}");
                return files;
            }
            catch (UnauthorizedAccessException e)
            {
                files.Add($"*{e.Message}");
                return files;
            }

            return files;
        }

        public static async Task<IEnumerable<string>> TraverseTreeParallelForEach(string root, string searchPattern, 
            IProgress<string> progresso, CancellationToken ct, string searchTerm = "")
        {
            var TaskSchedulerUI = TaskScheduler.FromCurrentSynchronizationContext();
            
            int fileCount = 0;
            var sw = Stopwatch.StartNew();

            // Determina se deve paralelizar o processamento de arquivos em cada pasta com base na contagem de processadores.
            int procCount = System.Environment.ProcessorCount;

            // Estrutura(Pilha) de dados para armazenar nomes de subpastas a serem examinados para arquivos.
            Stack<string> dirs = new Stack<string>();

            // Diretório não existente
            if (!Directory.Exists(root))
            {
                throw new ArgumentException();
            }

            dirs.Push(root);

            var diretorios = Task.Factory.StartNew(() =>
            {
                while (dirs.Count > 0)
                {
                    string currentDir = dirs.Pop();
                    IEnumerable<string> subDirs = null;
                    List<string> files = new List<string>();

                    try
                    {
                        ct.ThrowIfCancellationRequested();
                        subDirs = Directory.EnumerateDirectories(currentDir);
                    }
                    catch (UnauthorizedAccessException e)
                    {
                        // Se não tivermos permissão de acesso no diretório.
                        progresso.Report($"*{e.Message}");
                        continue;
                    }
                    catch (DirectoryNotFoundException e)
                    {
                        // Se outro processo tiver excluído o diretório depois que recuperamos seu nome.
                        progresso.Report($"*{e.Message}");
                        continue;
                    }
                    catch (OperationCanceledException)
                    {
                        throw new OperationCanceledException();
                    }

                    try
                    {
                        ct.ThrowIfCancellationRequested();
                        files.AddRange(Directory.EnumerateFiles(currentDir, searchPattern));
                        //files = Directory.GetFiles(currentDir, searchPattern);
                    }
                    catch (UnauthorizedAccessException e)
                    {
                        progresso.Report($"*{e.Message}");
                        continue;
                    }
                    catch (DirectoryNotFoundException e)
                    {
                        progresso.Report($"*{e.Message}");
                        continue;
                    }
                    catch (IOException e)
                    {
                        progresso.Report($"*{e.Message}");
                        continue;
                    }
                    catch (OperationCanceledException)
                    {
                        throw new OperationCanceledException();
                    }
                    
                    // Execute in parallel if there are enough files in the directory.
                    // Otherwise, execute sequentially.Files are opened and processed
                    // synchronously but this could be modified to perform async I/O.
                    try
                    {
                        if (files.Count < procCount)
                        {
                            foreach (var file in files)
                            {
                                //action(file);
                                ct.ThrowIfCancellationRequested();

                                var locatedFiles = (!String.IsNullOrEmpty(searchTerm)) ? FindInFile(file, searchTerm) : new List<string> { file };

                                foreach (var item in locatedFiles)
                                {
                                    progresso.Report(item);
                                    fileCount++;
                                }
                            }
                        }
                        else
                        {
                            Parallel.ForEach(files, () => 0, (file, loopState, localCount) =>
                            {
                                //action(file);
                                ct.ThrowIfCancellationRequested();

                                var locatedFiles = (!String.IsNullOrEmpty(searchTerm)) ? FindInFile(file, searchTerm) : new List<string> { file };

                                foreach (var item in locatedFiles)
                                {
                                    progresso.Report(item);
                                    fileCount++;
                                }

                                return (int)++localCount;
                            },
                            (c) =>
                            {
                                Interlocked.Add(ref fileCount, c);
                            });
                        }
                    }
                    catch (AggregateException ae)
                    {
                        ae.Handle((ex) =>
                        {
                            if (ex is UnauthorizedAccessException)
                            {
                                return true;
                            }

                            return false;
                        });
                    }
                    catch (OperationCanceledException)
                    {
                        throw new OperationCanceledException();
                    }

                    try
                    {
                        // Push the subdirectories onto the stack for traversal.
                        // This could also be done before handing the files.
                        foreach (string str in subDirs)
                        {
                            ct.ThrowIfCancellationRequested();
                            dirs.Push(str);
                        }
                    }
                    catch (OperationCanceledException)
                    {
                        throw new OperationCanceledException();
                    }
                }
            });

            await Task.WhenAll(diretorios);

            return new List<string>();
        }
    }
}
