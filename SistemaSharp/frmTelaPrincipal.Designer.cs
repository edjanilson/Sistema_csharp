namespace SistemaSharp
{
    partial class frmTelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabuadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adiçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subtraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médiaEscolarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizadorDeImagensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplicaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divisãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabuadaToolStripMenuItem,
            this.médiaEscolarToolStripMenuItem,
            this.visualizadorDeImagensToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(676, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabuadaToolStripMenuItem
            // 
            this.tabuadaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adiçãoToolStripMenuItem,
            this.subtraçãoToolStripMenuItem,
            this.multiplicaçãoToolStripMenuItem,
            this.divisãoToolStripMenuItem});
            this.tabuadaToolStripMenuItem.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabuadaToolStripMenuItem.Name = "tabuadaToolStripMenuItem";
            this.tabuadaToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.tabuadaToolStripMenuItem.Text = "Tabuada";
            // 
            // adiçãoToolStripMenuItem
            // 
            this.adiçãoToolStripMenuItem.Name = "adiçãoToolStripMenuItem";
            this.adiçãoToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.adiçãoToolStripMenuItem.Text = "Adição";
            this.adiçãoToolStripMenuItem.Click += new System.EventHandler(this.adiçãoToolStripMenuItem_Click);
            // 
            // subtraçãoToolStripMenuItem
            // 
            this.subtraçãoToolStripMenuItem.Name = "subtraçãoToolStripMenuItem";
            this.subtraçãoToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.subtraçãoToolStripMenuItem.Text = "Subtração";
            this.subtraçãoToolStripMenuItem.Click += new System.EventHandler(this.subtraçãoToolStripMenuItem_Click);
            // 
            // médiaEscolarToolStripMenuItem
            // 
            this.médiaEscolarToolStripMenuItem.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.médiaEscolarToolStripMenuItem.Name = "médiaEscolarToolStripMenuItem";
            this.médiaEscolarToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.médiaEscolarToolStripMenuItem.Text = "Média Escolar";
            this.médiaEscolarToolStripMenuItem.Click += new System.EventHandler(this.médiaEscolarToolStripMenuItem_Click);
            // 
            // visualizadorDeImagensToolStripMenuItem
            // 
            this.visualizadorDeImagensToolStripMenuItem.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualizadorDeImagensToolStripMenuItem.Name = "visualizadorDeImagensToolStripMenuItem";
            this.visualizadorDeImagensToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.visualizadorDeImagensToolStripMenuItem.Text = "Visualizador de imagens";
            this.visualizadorDeImagensToolStripMenuItem.Click += new System.EventHandler(this.visualizadorDeImagensToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // multiplicaçãoToolStripMenuItem
            // 
            this.multiplicaçãoToolStripMenuItem.Name = "multiplicaçãoToolStripMenuItem";
            this.multiplicaçãoToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.multiplicaçãoToolStripMenuItem.Text = "Multiplicação";
            this.multiplicaçãoToolStripMenuItem.Click += new System.EventHandler(this.multiplicaçãoToolStripMenuItem_Click);
            // 
            // divisãoToolStripMenuItem
            // 
            this.divisãoToolStripMenuItem.Name = "divisãoToolStripMenuItem";
            this.divisãoToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.divisãoToolStripMenuItem.Text = "Divisão";
            this.divisãoToolStripMenuItem.Click += new System.EventHandler(this.divisãoToolStripMenuItem_Click);
            // 
            // frmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(676, 421);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tabuadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adiçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subtraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médiaEscolarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizadorDeImagensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiplicaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divisãoToolStripMenuItem;
    }
}