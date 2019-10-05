using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchFilesPmx
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource _cts;

        public Form1()
        {
            InitializeComponent();
        }

        private async void FindInFiles(string term)
        {
            string path = edtPathFind.Text.Trim();
            path = path.Substring(path.Length - 1) == "\\" ? path : $"{path}\\";
            string pattern = edtPatternFind.Text.Trim();
            int fileCount = 0;

            if (string.IsNullOrEmpty(pattern))
            {
                lbFilesFind.Items.Clear();
                lbLogErros.Items.Clear();
                return;
            }

            Stopwatch sw = new Stopwatch();
            sw.Start();

            _cts = new CancellationTokenSource();

            lblTempoDuracao.Text = "Processando...";
            lbFilesFind.Items.Clear();
            lbLogErros.Items.Clear();
            pbProgresso.Value = 0;
            btnCancelFind.Enabled = true;

            var progress = new Progress<string>(file =>
            {
                try
                {
                    if (file.Substring(0, 1) != "*")
                    {
                        pbProgresso.Value++;
                        fileCount++;
                        lbFilesFind.Items.Add(file);
                    }
                    else
                    {
                        lbLogErros.Items.Add(file.Substring(1, file.Length - 1));
                    }
                }
                catch (Exception e)
                {
                    lbLogErros.Items.Add(e.Message);
                }
            });

            try
            {
                var task = await FileUtil.TraverseTreeParallelForEach(path, pattern, progress, _cts.Token, term);

                pbProgresso.Value = 1000000;
                TimeSpan duration = new TimeSpan(0, sw.Elapsed.Hours, sw.Elapsed.Minutes, sw.Elapsed.Seconds, sw.Elapsed.Milliseconds);

                lblTempoDuracao.Text = $"Tempo decorrido: {duration.ToString("hh':'mm':'ss','fff")}. Total de {fileCount} item(s) encontrado(s).";
            }
            catch (ArgumentException)
            {
                lblTempoDuracao.Text = $@"Diretório {path} não encontrado!";
            }
            catch (OperationCanceledException)
            {
                pbProgresso.Value = 0;
                lbFilesFind.Items.Clear();
                lbLogErros.Items.Clear();
                lblTempoDuracao.Text = $"Operação cancelada pelo usuário";
            }
            finally
            {
                btnCancelFind.Enabled = false;
            }        
        }

        private async void Find()
        {
            string path = edtPath.Text.Trim();
            path = path.Substring(path.Length - 1) == "\\" ? path : $"{path}\\";
            string pattern = edtPattern.Text.Trim();
            int fileCount = 0;

            if (string.IsNullOrEmpty(pattern))
            {
                lbFiles.Items.Clear();
                lbLogErros.Items.Clear();
                return;
            }

            Stopwatch sw = new Stopwatch();
            sw.Start();

            _cts = new CancellationTokenSource();

            lblTempoDuracao.Text = "Processando...";
            lbFiles.Items.Clear();
            lbLogErros.Items.Clear();
            pbProgresso.Value = 0;
            btnCancel.Enabled = true;

            var progress = new Progress<string>(file =>
            {
                if (file.Substring(0, 1) != "*")
                {
                    pbProgresso.Value++;
                    fileCount++;
                    lbFiles.Items.Add(file);
                }
                else
                {
                    lbLogErros.Items.Add(file.Substring(1, file.Length - 1));
                }
            });

            try
            {
                var task = await FileUtil.TraverseTreeParallelForEach(path, pattern, progress, _cts.Token);

                pbProgresso.Value = 1000000;
                TimeSpan duration = new TimeSpan(0, sw.Elapsed.Hours, sw.Elapsed.Minutes, sw.Elapsed.Seconds, sw.Elapsed.Milliseconds);

                lblTempoDuracao.Text = $"Tempo decorrido: {duration.ToString("hh':'mm':'ss','fff")}. Total de {fileCount} item(s) encontrado(s).";
            }
            catch (ArgumentException)
            {
                lblTempoDuracao.Text = $@"Diretório {path} não encontrado!";
            }
            catch (OperationCanceledException)
            {
                pbProgresso.Value = 0;
                lbFiles.Items.Clear();
                lbLogErros.Items.Clear();
                lblTempoDuracao.Text = $"Operação cancelada pelo usuário";
            }
            finally
            {
                btnCancel.Enabled = false;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            // Encontrar os arquivos baseado na pesquisa de diretórios
            Find();
        }

        private void mnuLocal_Click(object sender, EventArgs e)
        {
            var path = lbFiles.Items[lbFiles.SelectedIndex];

            string argument = $@"/select, {path}";
            Process.Start("explorer.exe", argument);
        }

        private void btnOpenDir_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.RootFolder = Environment.SpecialFolder.MyComputer;
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    edtPath.Text = fbd.SelectedPath;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;
            _cts.Cancel();
        }

        private void abrirArquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var file = lbFiles.Items[lbFiles.SelectedIndex];

            string argument = $@"/open, {file}";
            Process.Start("explorer.exe", argument);
        }

        private void btnFindFiles_Click(object sender, EventArgs e)
        {
            // Pesquisa
            FindInFiles(edtPalavraChave.Text);
        }

        private void btnOpenDirFind_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.RootFolder = Environment.SpecialFolder.MyComputer;
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    edtPathFind.Text = fbd.SelectedPath;
            }
        }

        private void btnCancelFind_Click(object sender, EventArgs e)
        {
            btnCancelFind.Enabled = false;
            _cts.Cancel();
        }

        private void lbFilesFind_DrawItem(object sender, DrawItemEventArgs e)
        {
            string item = lbFilesFind.GetItemText(lbFilesFind.Items[e.Index]).Trim();

            try
            {
                //if the item state is selected them change the back color 
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                    e = new DrawItemEventArgs(e.Graphics,
                                              e.Font,
                                              e.Bounds,
                                              e.Index,
                                              e.State ^ DrawItemState.Selected,
                                              e.ForeColor,
                                              Color.Yellow);//Choose the color

                e.DrawBackground();

                if (item.Substring(0, 5) == "Linha")
                    e.Graphics.DrawString(lbFilesFind.Items[e.Index].ToString(), new Font("Courier New", 9), Brushes.Green, e.Bounds);
                else
                {
                    using (Brush back = new SolidBrush(lbFilesFind.BackColor))
                        e.Graphics.FillRectangle(back, e.Bounds);

                    // Draw grayed text when listbox is disabled  
                    if ((e.State & DrawItemState.Disabled) > 0)
                    {
                        e.Graphics.DrawString(lbFilesFind.Items[e.Index].ToString(), lbFilesFind.Font, SystemBrushes.GrayText, e.Bounds);
                    }
                    else
                    {
                        using (Brush fore = new SolidBrush(lbFilesFind.ForeColor))
                            e.Graphics.DrawString(lbFilesFind.Items[e.Index].ToString(), lbFilesFind.Font, fore, e.Bounds);
                    }
                }
                
                //e.Graphics.DrawString(lbFilesFind.Items[e.Index].ToString(), new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, e.Bounds);

                //if (e.State == DrawItemState.Selected)
                e.DrawFocusRectangle();
            }
            catch
            {
                return;
            }
        }
    }
}
