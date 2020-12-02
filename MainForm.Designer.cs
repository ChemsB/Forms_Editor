namespace pt2b_ChemsBezetout
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ediciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.colorYFuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.practicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.New = new System.Windows.Forms.ToolStripButton();
            this.Open = new System.Windows.Forms.ToolStripButton();
            this.Copy = new System.Windows.Forms.ToolStripButton();
            this.Cut = new System.Windows.Forms.ToolStripButton();
            this.Paste = new System.Windows.Forms.ToolStripButton();
            this.Exit = new System.Windows.Forms.ToolStripButton();
            this.EditorControl = new System.Windows.Forms.TabControl();
            this.Editar = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Mostrar = new System.Windows.Forms.TabPage();
            this.ShowFiles = new System.Windows.Forms.Button();
            this.rutas = new System.Windows.Forms.ListBox();
            this.Configurar = new System.Windows.Forms.TabPage();
            this.Options = new System.Windows.Forms.GroupBox();
            this.Font = new System.Windows.Forms.RadioButton();
            this.TextColor = new System.Windows.Forms.RadioButton();
            this.ShowMenu = new System.Windows.Forms.CheckBox();
            this.Extension = new System.Windows.Forms.TabPage();
            this.OpenFiles = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.userControl11 = new ControlCalculator.UserControl1();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.EditorControl.SuspendLayout();
            this.Editar.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.Mostrar.SuspendLayout();
            this.Configurar.SuspendLayout();
            this.Options.SuspendLayout();
            this.Extension.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ediciónToolStripMenuItem,
            this.practicaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(945, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoToolStripMenuItem.Image")));
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripMenuItem.Image")));
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.ShowFiles_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("guardarToolStripMenuItem.Image")));
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ediciónToolStripMenuItem
            // 
            this.ediciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seleccionarTodoToolStripMenuItem,
            this.toolStripSeparator2,
            this.cortarToolStripMenuItem,
            this.copiarToolStripMenuItem,
            this.pegarToolStripMenuItem,
            this.toolStripSeparator1,
            this.colorYFuenteToolStripMenuItem,
            this.fuenteToolStripMenuItem});
            this.ediciónToolStripMenuItem.Name = "ediciónToolStripMenuItem";
            this.ediciónToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ediciónToolStripMenuItem.Text = "&Edición";
            // 
            // seleccionarTodoToolStripMenuItem
            // 
            this.seleccionarTodoToolStripMenuItem.Name = "seleccionarTodoToolStripMenuItem";
            this.seleccionarTodoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.seleccionarTodoToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.seleccionarTodoToolStripMenuItem.Text = "Seleccionar Todo";
            this.seleccionarTodoToolStripMenuItem.Click += new System.EventHandler(this.seleccionarTodoToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(204, 6);
            // 
            // cortarToolStripMenuItem
            // 
            this.cortarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cortarToolStripMenuItem.Image")));
            this.cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
            this.cortarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cortarToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.cortarToolStripMenuItem.Text = "Cortar";
            this.cortarToolStripMenuItem.Click += new System.EventHandler(this.Cut_Click);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copiarToolStripMenuItem.Image")));
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.Copy_Click);
            // 
            // pegarToolStripMenuItem
            // 
            this.pegarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pegarToolStripMenuItem.Image")));
            this.pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            this.pegarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pegarToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.pegarToolStripMenuItem.Text = "Pegar";
            this.pegarToolStripMenuItem.Click += new System.EventHandler(this.Paste_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(204, 6);
            // 
            // colorYFuenteToolStripMenuItem
            // 
            this.colorYFuenteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("colorYFuenteToolStripMenuItem.Image")));
            this.colorYFuenteToolStripMenuItem.Name = "colorYFuenteToolStripMenuItem";
            this.colorYFuenteToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.colorYFuenteToolStripMenuItem.Text = "Color";
            this.colorYFuenteToolStripMenuItem.Click += new System.EventHandler(this.ColorToolStripMenuItem_Click);
            // 
            // fuenteToolStripMenuItem
            // 
            this.fuenteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fuenteToolStripMenuItem.Image")));
            this.fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            this.fuenteToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.fuenteToolStripMenuItem.Text = "Fuente";
            this.fuenteToolStripMenuItem.Click += new System.EventHandler(this.FontToolStripMenuItem_Click);
            // 
            // practicaToolStripMenuItem
            // 
            this.practicaToolStripMenuItem.Name = "practicaToolStripMenuItem";
            this.practicaToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.practicaToolStripMenuItem.Text = "&Practica";
            this.practicaToolStripMenuItem.Click += new System.EventHandler(this.PracticaToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New,
            this.Open,
            this.Copy,
            this.Cut,
            this.Paste,
            this.Exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(945, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // New
            // 
            this.New.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.New.Image = ((System.Drawing.Image)(resources.GetObject("New.Image")));
            this.New.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(23, 22);
            this.New.Text = "toolStripButton1";
            this.New.ToolTipText = "New File";
            this.New.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // Open
            // 
            this.Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Open.Image = ((System.Drawing.Image)(resources.GetObject("Open.Image")));
            this.Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(23, 22);
            this.Open.Text = "Open File";
            this.Open.ToolTipText = "Open File";
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Copy
            // 
            this.Copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Copy.Image = ((System.Drawing.Image)(resources.GetObject("Copy.Image")));
            this.Copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(23, 22);
            this.Copy.Text = "toolStripButton3";
            this.Copy.ToolTipText = "Copy";
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Cut
            // 
            this.Cut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Cut.Image = ((System.Drawing.Image)(resources.GetObject("Cut.Image")));
            this.Cut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Cut.Name = "Cut";
            this.Cut.Size = new System.Drawing.Size(23, 22);
            this.Cut.Text = "toolStripButton4";
            this.Cut.ToolTipText = "Cut";
            this.Cut.Click += new System.EventHandler(this.Cut_Click);
            // 
            // Paste
            // 
            this.Paste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Paste.Image = ((System.Drawing.Image)(resources.GetObject("Paste.Image")));
            this.Paste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(23, 22);
            this.Paste.Text = "toolStripButton5";
            this.Paste.ToolTipText = "Paste";
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // Exit
            // 
            this.Exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Exit.Name = "Exit";
            this.Exit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Exit.Size = new System.Drawing.Size(23, 22);
            this.Exit.Text = "toolStripButton6";
            this.Exit.ToolTipText = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // EditorControl
            // 
            this.EditorControl.Controls.Add(this.Editar);
            this.EditorControl.Controls.Add(this.Mostrar);
            this.EditorControl.Controls.Add(this.Configurar);
            this.EditorControl.Controls.Add(this.Extension);
            this.EditorControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditorControl.Location = new System.Drawing.Point(0, 49);
            this.EditorControl.Name = "EditorControl";
            this.EditorControl.SelectedIndex = 0;
            this.EditorControl.Size = new System.Drawing.Size(945, 508);
            this.EditorControl.TabIndex = 2;
            // 
            // Editar
            // 
            this.Editar.Controls.Add(this.richTextBox1);
            this.Editar.Location = new System.Drawing.Point(4, 22);
            this.Editar.Name = "Editar";
            this.Editar.Padding = new System.Windows.Forms.Padding(3);
            this.Editar.Size = new System.Drawing.Size(937, 482);
            this.Editar.TabIndex = 0;
            this.Editar.Text = "Editor";
            this.Editar.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(931, 476);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 48);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.FontToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.ColorToolStripMenuItem_Click);
            // 
            // Mostrar
            // 
            this.Mostrar.Controls.Add(this.ShowFiles);
            this.Mostrar.Controls.Add(this.rutas);
            this.Mostrar.Location = new System.Drawing.Point(4, 22);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Padding = new System.Windows.Forms.Padding(3);
            this.Mostrar.Size = new System.Drawing.Size(937, 482);
            this.Mostrar.TabIndex = 1;
            this.Mostrar.Text = "Mostrar";
            this.Mostrar.UseVisualStyleBackColor = true;
            // 
            // ShowFiles
            // 
            this.ShowFiles.Location = new System.Drawing.Point(34, 267);
            this.ShowFiles.Name = "ShowFiles";
            this.ShowFiles.Size = new System.Drawing.Size(103, 35);
            this.ShowFiles.TabIndex = 1;
            this.ShowFiles.Text = "Mostrar";
            this.ShowFiles.UseVisualStyleBackColor = true;
            this.ShowFiles.Click += new System.EventHandler(this.ShowFiles_Click);
            // 
            // rutas
            // 
            this.rutas.Dock = System.Windows.Forms.DockStyle.Top;
            this.rutas.FormattingEnabled = true;
            this.rutas.Location = new System.Drawing.Point(3, 3);
            this.rutas.Name = "rutas";
            this.rutas.Size = new System.Drawing.Size(931, 238);
            this.rutas.TabIndex = 0;
            this.rutas.DoubleClick += new System.EventHandler(this.Rutas_DoubleClick);
            // 
            // Configurar
            // 
            this.Configurar.Controls.Add(this.Options);
            this.Configurar.Controls.Add(this.ShowMenu);
            this.Configurar.Location = new System.Drawing.Point(4, 22);
            this.Configurar.Name = "Configurar";
            this.Configurar.Padding = new System.Windows.Forms.Padding(3);
            this.Configurar.Size = new System.Drawing.Size(937, 482);
            this.Configurar.TabIndex = 2;
            this.Configurar.Text = "Configurar";
            this.Configurar.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.Options.Controls.Add(this.Font);
            this.Options.Controls.Add(this.TextColor);
            this.Options.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Options.Location = new System.Drawing.Point(182, 121);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(356, 212);
            this.Options.TabIndex = 1;
            this.Options.TabStop = false;
            this.Options.Text = "Opciones";
            // 
            // Font
            // 
            this.Font.AutoSize = true;
            this.Font.Location = new System.Drawing.Point(64, 55);
            this.Font.Name = "Font";
            this.Font.Size = new System.Drawing.Size(78, 24);
            this.Font.TabIndex = 1;
            this.Font.TabStop = true;
            this.Font.Text = "Fuente";
            this.Font.UseVisualStyleBackColor = true;
            // 
            // TextColor
            // 
            this.TextColor.AutoSize = true;
            this.TextColor.Location = new System.Drawing.Point(64, 118);
            this.TextColor.Name = "TextColor";
            this.TextColor.Size = new System.Drawing.Size(131, 24);
            this.TextColor.TabIndex = 0;
            this.TextColor.TabStop = true;
            this.TextColor.Text = "Color de texto";
            this.TextColor.UseVisualStyleBackColor = true;
            // 
            // ShowMenu
            // 
            this.ShowMenu.AutoSize = true;
            this.ShowMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ShowMenu.Location = new System.Drawing.Point(182, 63);
            this.ShowMenu.Name = "ShowMenu";
            this.ShowMenu.Size = new System.Drawing.Size(239, 24);
            this.ShowMenu.TabIndex = 0;
            this.ShowMenu.Text = "Habilitar el menu Contextual";
            this.ShowMenu.UseVisualStyleBackColor = true;
            this.ShowMenu.CheckedChanged += new System.EventHandler(this.ShowMenu_CheckedChanged);
            // 
            // Extension
            // 
            this.Extension.Controls.Add(this.userControl11);
            this.Extension.Location = new System.Drawing.Point(4, 22);
            this.Extension.Name = "Extension";
            this.Extension.Padding = new System.Windows.Forms.Padding(3);
            this.Extension.Size = new System.Drawing.Size(937, 482);
            this.Extension.TabIndex = 3;
            this.Extension.Text = "Extensión";
            this.Extension.UseVisualStyleBackColor = true;
            // 
            // OpenFiles
            // 
            this.OpenFiles.FileName = "OpenFiles";
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(8, 18);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(455, 380);
            this.userControl11.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 557);
            this.Controls.Add(this.EditorControl);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Editor Personal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.EditorControl.ResumeLayout(false);
            this.Editar.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.Mostrar.ResumeLayout(false);
            this.Configurar.ResumeLayout(false);
            this.Configurar.PerformLayout();
            this.Options.ResumeLayout(false);
            this.Options.PerformLayout();
            this.Extension.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ediciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seleccionarTodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorYFuenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem practicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem fuenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton New;
        private System.Windows.Forms.ToolStripButton Open;
        private System.Windows.Forms.ToolStripButton Copy;
        private System.Windows.Forms.ToolStripButton Cut;
        private System.Windows.Forms.ToolStripButton Paste;
        private System.Windows.Forms.ToolStripButton Exit;
        private System.Windows.Forms.TabControl EditorControl;
        private System.Windows.Forms.TabPage Editar;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabPage Mostrar;
        private System.Windows.Forms.TabPage Configurar;
        private System.Windows.Forms.TabPage Extension;
        private System.Windows.Forms.Button ShowFiles;
        private System.Windows.Forms.GroupBox Options;
        private System.Windows.Forms.RadioButton Font;
        private System.Windows.Forms.RadioButton TextColor;
        private System.Windows.Forms.CheckBox ShowMenu;
        private System.Windows.Forms.OpenFileDialog OpenFiles;
        private System.Windows.Forms.ListBox rutas;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private ControlCalculator.UserControl1 userControl11;
    }
}

