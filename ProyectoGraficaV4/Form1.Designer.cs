namespace ProyectoGraficaV4
{
    partial class Form1
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejeDeCoordenadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traslacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escalacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Stop = new System.Windows.Forms.Button();
            this.Play = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.saveFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openFileToolStripMenuItem.Text = "Open File..";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveFileToolStripMenuItem.Text = "Save File..";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejeDeCoordenadasToolStripMenuItem,
            this.traslacionToolStripMenuItem,
            this.rotacionToolStripMenuItem,
            this.escalacionToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // ejeDeCoordenadasToolStripMenuItem
            // 
            this.ejeDeCoordenadasToolStripMenuItem.Name = "ejeDeCoordenadasToolStripMenuItem";
            this.ejeDeCoordenadasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ejeDeCoordenadasToolStripMenuItem.Text = "Eje De Coordenadas";
            this.ejeDeCoordenadasToolStripMenuItem.Click += new System.EventHandler(this.ejeDeCoordenadasToolStripMenuItem_Click);
            // 
            // traslacionToolStripMenuItem
            // 
            this.traslacionToolStripMenuItem.Name = "traslacionToolStripMenuItem";
            this.traslacionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.traslacionToolStripMenuItem.Text = "Traslacion";
            this.traslacionToolStripMenuItem.Click += new System.EventHandler(this.traslacionToolStripMenuItem_Click);
            // 
            // rotacionToolStripMenuItem
            // 
            this.rotacionToolStripMenuItem.Name = "rotacionToolStripMenuItem";
            this.rotacionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rotacionToolStripMenuItem.Text = "Rotacion";
            this.rotacionToolStripMenuItem.Click += new System.EventHandler(this.rotacionToolStripMenuItem_Click);
            // 
            // escalacionToolStripMenuItem
            // 
            this.escalacionToolStripMenuItem.Name = "escalacionToolStripMenuItem";
            this.escalacionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.escalacionToolStripMenuItem.Text = "Escalacion";
            this.escalacionToolStripMenuItem.Click += new System.EventHandler(this.escalacionToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.Stop);
            this.panel1.Controls.Add(this.Play);
            this.panel1.Controls.Add(this.Pause);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 49);
            this.panel1.TabIndex = 1;
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(303, 0);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(108, 33);
            this.Stop.TabIndex = 4;
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(12, 0);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(144, 33);
            this.Play.TabIndex = 2;
            this.Play.Text = "Iniciar";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Pause
            // 
            this.Pause.Location = new System.Drawing.Point(162, 0);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(124, 33);
            this.Pause.TabIndex = 3;
            this.Pause.Text = "pausa";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(-59, 137);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(282, 95);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(-37, 255);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(256, 95);
            this.listBox2.TabIndex = 3;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(-49, 356);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(273, 95);
            this.listBox3.TabIndex = 4;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejeDeCoordenadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traslacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escalacionToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
    }
}

