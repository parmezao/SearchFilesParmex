namespace SearchFilesPmx
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mnuOpenFile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.abrirLocalDoArquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirArquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLocal = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTempoDuracao = new System.Windows.Forms.Label();
            this.pbProgresso = new System.Windows.Forms.ProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.edtPattern = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnOpenDir = new System.Windows.Forms.Button();
            this.edtPath = new System.Windows.Forms.TextBox();
            this.lbFiles = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbLogErros = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbFilesFind = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.edtPalavraChave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelFind = new System.Windows.Forms.Button();
            this.edtPatternFind = new System.Windows.Forms.TextBox();
            this.btnFindFiles = new System.Windows.Forms.Button();
            this.btnOpenDirFind = new System.Windows.Forms.Button();
            this.edtPathFind = new System.Windows.Forms.TextBox();
            this.mnuOpenFile.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuOpenFile
            // 
            this.mnuOpenFile.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuOpenFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirLocalDoArquivoToolStripMenuItem,
            this.abrirArquivoToolStripMenuItem});
            this.mnuOpenFile.Name = "mnuOpenFile";
            this.mnuOpenFile.Size = new System.Drawing.Size(229, 52);
            // 
            // abrirLocalDoArquivoToolStripMenuItem
            // 
            this.abrirLocalDoArquivoToolStripMenuItem.Name = "abrirLocalDoArquivoToolStripMenuItem";
            this.abrirLocalDoArquivoToolStripMenuItem.Size = new System.Drawing.Size(228, 24);
            this.abrirLocalDoArquivoToolStripMenuItem.Text = "Abrir Local do Arquivo";
            this.abrirLocalDoArquivoToolStripMenuItem.Click += new System.EventHandler(this.mnuLocal_Click);
            // 
            // abrirArquivoToolStripMenuItem
            // 
            this.abrirArquivoToolStripMenuItem.Name = "abrirArquivoToolStripMenuItem";
            this.abrirArquivoToolStripMenuItem.Size = new System.Drawing.Size(228, 24);
            this.abrirArquivoToolStripMenuItem.Text = "Abrir Arquivo";
            this.abrirArquivoToolStripMenuItem.Click += new System.EventHandler(this.abrirArquivoToolStripMenuItem_Click);
            // 
            // mnuLocal
            // 
            this.mnuLocal.Name = "mnuLocal";
            this.mnuLocal.Size = new System.Drawing.Size(188, 22);
            this.mnuLocal.Text = "Abrir local do arquivo";
            this.mnuLocal.Click += new System.EventHandler(this.mnuLocal_Click);
            // 
            // lblTempoDuracao
            // 
            this.lblTempoDuracao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTempoDuracao.AutoSize = true;
            this.lblTempoDuracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempoDuracao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTempoDuracao.Location = new System.Drawing.Point(13, 513);
            this.lblTempoDuracao.Name = "lblTempoDuracao";
            this.lblTempoDuracao.Size = new System.Drawing.Size(0, 17);
            this.lblTempoDuracao.TabIndex = 2;
            // 
            // pbProgresso
            // 
            this.pbProgresso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbProgresso.Location = new System.Drawing.Point(12, 481);
            this.pbProgresso.Maximum = 1000000;
            this.pbProgresso.Name = "pbProgresso";
            this.pbProgresso.Size = new System.Drawing.Size(1003, 23);
            this.pbProgresso.Step = 100;
            this.pbProgresso.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1007, 467);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.lbFiles);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(999, 438);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Arquivos";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.edtPattern);
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.btnOpenDir);
            this.panel1.Controls.Add(this.edtPath);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 50);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(770, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tipo Arquivo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Diretório";
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Image = global::SearchFilesPmx.Properties.Resources.if_cancel_1034311;
            this.btnCancel.Location = new System.Drawing.Point(963, 22);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(29, 22);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // edtPattern
            // 
            this.edtPattern.Location = new System.Drawing.Point(773, 23);
            this.edtPattern.Name = "edtPattern";
            this.edtPattern.Size = new System.Drawing.Size(160, 23);
            this.edtPattern.TabIndex = 2;
            // 
            // btnFind
            // 
            this.btnFind.Image = global::SearchFilesPmx.Properties.Resources.if_Find01_928435;
            this.btnFind.Location = new System.Drawing.Point(934, 22);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(29, 22);
            this.btnFind.TabIndex = 3;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnOpenDir
            // 
            this.btnOpenDir.Image = global::SearchFilesPmx.Properties.Resources.if_ic_folder_open_48px_3523751;
            this.btnOpenDir.Location = new System.Drawing.Point(739, 22);
            this.btnOpenDir.Name = "btnOpenDir";
            this.btnOpenDir.Size = new System.Drawing.Size(28, 22);
            this.btnOpenDir.TabIndex = 1;
            this.btnOpenDir.UseVisualStyleBackColor = true;
            this.btnOpenDir.Click += new System.EventHandler(this.btnOpenDir_Click);
            // 
            // edtPath
            // 
            this.edtPath.Location = new System.Drawing.Point(6, 23);
            this.edtPath.Name = "edtPath";
            this.edtPath.Size = new System.Drawing.Size(732, 23);
            this.edtPath.TabIndex = 0;
            this.edtPath.Text = "C:\\";
            // 
            // lbFiles
            // 
            this.lbFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFiles.BackColor = System.Drawing.SystemColors.Info;
            this.lbFiles.ContextMenuStrip = this.mnuOpenFile;
            this.lbFiles.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiles.FormattingEnabled = true;
            this.lbFiles.HorizontalScrollbar = true;
            this.lbFiles.ItemHeight = 16;
            this.lbFiles.Location = new System.Drawing.Point(0, 54);
            this.lbFiles.Name = "lbFiles";
            this.lbFiles.Size = new System.Drawing.Size(998, 372);
            this.lbFiles.TabIndex = 2;
            this.lbFiles.DoubleClick += new System.EventHandler(this.abrirArquivoToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbLogErros);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(999, 438);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Log de Erros";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbLogErros
            // 
            this.lbLogErros.BackColor = System.Drawing.SystemColors.Info;
            this.lbLogErros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbLogErros.FormattingEnabled = true;
            this.lbLogErros.ItemHeight = 16;
            this.lbLogErros.Location = new System.Drawing.Point(0, 0);
            this.lbLogErros.Name = "lbLogErros";
            this.lbLogErros.Size = new System.Drawing.Size(996, 436);
            this.lbLogErros.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lbFilesFind);
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(999, 438);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Localizar em Arquivos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lbFilesFind
            // 
            this.lbFilesFind.BackColor = System.Drawing.SystemColors.Info;
            this.lbFilesFind.ContextMenuStrip = this.mnuOpenFile;
            this.lbFilesFind.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbFilesFind.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilesFind.FormattingEnabled = true;
            this.lbFilesFind.HorizontalScrollbar = true;
            this.lbFilesFind.ItemHeight = 15;
            this.lbFilesFind.Location = new System.Drawing.Point(0, 55);
            this.lbFilesFind.Name = "lbFilesFind";
            this.lbFilesFind.Size = new System.Drawing.Size(998, 379);
            this.lbFilesFind.TabIndex = 10;
            this.lbFilesFind.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbFilesFind_DrawItem);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.listBox2);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.edtPalavraChave);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnCancelFind);
            this.panel2.Controls.Add(this.edtPatternFind);
            this.panel2.Controls.Add(this.btnFindFiles);
            this.panel2.Controls.Add(this.btnOpenDirFind);
            this.panel2.Controls.Add(this.edtPathFind);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(998, 50);
            this.panel2.TabIndex = 9;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.SystemColors.Info;
            this.listBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.HorizontalScrollbar = true;
            this.listBox2.Location = new System.Drawing.Point(-1, 51);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(996, 394);
            this.listBox2.TabIndex = 10;
            this.listBox2.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbFilesFind_DrawItem);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Info;
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(19, 55);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(996, 394);
            this.listBox1.TabIndex = 10;
            this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbFilesFind_DrawItem);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(564, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Palavra Chave";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(770, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Filtros";
            // 
            // edtPalavraChave
            // 
            this.edtPalavraChave.Location = new System.Drawing.Point(567, 23);
            this.edtPalavraChave.Name = "edtPalavraChave";
            this.edtPalavraChave.Size = new System.Drawing.Size(200, 23);
            this.edtPalavraChave.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Diretório";
            // 
            // btnCancelFind
            // 
            this.btnCancelFind.Enabled = false;
            this.btnCancelFind.Image = global::SearchFilesPmx.Properties.Resources.if_cancel_1034311;
            this.btnCancelFind.Location = new System.Drawing.Point(963, 22);
            this.btnCancelFind.Name = "btnCancelFind";
            this.btnCancelFind.Size = new System.Drawing.Size(29, 22);
            this.btnCancelFind.TabIndex = 4;
            this.btnCancelFind.UseVisualStyleBackColor = true;
            this.btnCancelFind.Click += new System.EventHandler(this.btnCancelFind_Click);
            // 
            // edtPatternFind
            // 
            this.edtPatternFind.Location = new System.Drawing.Point(773, 23);
            this.edtPatternFind.Name = "edtPatternFind";
            this.edtPatternFind.Size = new System.Drawing.Size(160, 23);
            this.edtPatternFind.TabIndex = 2;
            // 
            // btnFindFiles
            // 
            this.btnFindFiles.Image = global::SearchFilesPmx.Properties.Resources.if_Find01_928435;
            this.btnFindFiles.Location = new System.Drawing.Point(934, 22);
            this.btnFindFiles.Name = "btnFindFiles";
            this.btnFindFiles.Size = new System.Drawing.Size(29, 22);
            this.btnFindFiles.TabIndex = 3;
            this.btnFindFiles.UseVisualStyleBackColor = true;
            this.btnFindFiles.Click += new System.EventHandler(this.btnFindFiles_Click);
            // 
            // btnOpenDirFind
            // 
            this.btnOpenDirFind.Image = global::SearchFilesPmx.Properties.Resources.if_ic_folder_open_48px_3523751;
            this.btnOpenDirFind.Location = new System.Drawing.Point(533, 22);
            this.btnOpenDirFind.Name = "btnOpenDirFind";
            this.btnOpenDirFind.Size = new System.Drawing.Size(28, 22);
            this.btnOpenDirFind.TabIndex = 7;
            this.btnOpenDirFind.UseVisualStyleBackColor = true;
            this.btnOpenDirFind.Click += new System.EventHandler(this.btnOpenDirFind_Click);
            // 
            // edtPathFind
            // 
            this.edtPathFind.Location = new System.Drawing.Point(6, 23);
            this.edtPathFind.Name = "edtPathFind";
            this.edtPathFind.Size = new System.Drawing.Size(527, 23);
            this.edtPathFind.TabIndex = 0;
            this.edtPathFind.Text = "C:\\";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 542);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pbProgresso);
            this.Controls.Add(this.lblTempoDuracao);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Search Files Parmex";
            this.mnuOpenFile.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTempoDuracao;
        private System.Windows.Forms.ContextMenuStrip mnuOpenFile;
        private System.Windows.Forms.ToolStripMenuItem mnuLocal;
        private System.Windows.Forms.ProgressBar pbProgresso;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox lbFiles;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lbLogErros;
        private System.Windows.Forms.ToolStripMenuItem abrirLocalDoArquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirArquivoToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox edtPattern;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnOpenDir;
        private System.Windows.Forms.TextBox edtPath;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbFilesFind;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancelFind;
        private System.Windows.Forms.TextBox edtPatternFind;
        private System.Windows.Forms.Button btnFindFiles;
        private System.Windows.Forms.Button btnOpenDirFind;
        private System.Windows.Forms.TextBox edtPathFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edtPalavraChave;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label6;
    }
}

