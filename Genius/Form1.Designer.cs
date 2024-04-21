namespace Genius
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.R = new System.Windows.Forms.PictureBox();
            this.G = new System.Windows.Forms.PictureBox();
            this.B = new System.Windows.Forms.PictureBox();
            this.Y = new System.Windows.Forms.PictureBox();
            this.TxtPontos = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configs_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // R
            // 
            this.R.BackColor = System.Drawing.Color.DarkRed;
            this.R.Location = new System.Drawing.Point(49, 42);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(126, 118);
            this.R.TabIndex = 0;
            this.R.TabStop = false;
            this.R.Click += new System.EventHandler(this.Clique);
            // 
            // G
            // 
            this.G.BackColor = System.Drawing.Color.DarkGreen;
            this.G.Location = new System.Drawing.Point(181, 42);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(126, 118);
            this.G.TabIndex = 1;
            this.G.TabStop = false;
            this.G.Click += new System.EventHandler(this.Clique);
            // 
            // B
            // 
            this.B.BackColor = System.Drawing.Color.MidnightBlue;
            this.B.Location = new System.Drawing.Point(49, 166);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(126, 118);
            this.B.TabIndex = 2;
            this.B.TabStop = false;
            this.B.Click += new System.EventHandler(this.Clique);
            // 
            // Y
            // 
            this.Y.BackColor = System.Drawing.Color.Gold;
            this.Y.Location = new System.Drawing.Point(181, 166);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(126, 118);
            this.Y.TabIndex = 3;
            this.Y.TabStop = false;
            this.Y.Click += new System.EventHandler(this.Clique);
            // 
            // TxtPontos
            // 
            this.TxtPontos.AutoSize = true;
            this.TxtPontos.BackColor = System.Drawing.Color.Transparent;
            this.TxtPontos.Font = new System.Drawing.Font("SansSerif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtPontos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtPontos.Location = new System.Drawing.Point(146, 287);
            this.TxtPontos.Name = "TxtPontos";
            this.TxtPontos.Size = new System.Drawing.Size(77, 23);
            this.TxtPontos.TabIndex = 4;
            this.TxtPontos.Text = "Pontos";
            this.TxtPontos.Click += new System.EventHandler(this.Clique);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configs_menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(359, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configs_menu
            // 
            this.configs_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarToolStripMenuItem,
            this.sairToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.configs_menu.Name = "configs_menu";
            this.configs_menu.Size = new System.Drawing.Size(96, 20);
            this.configs_menu.Text = "Configurações";
            this.configs_menu.Click += new System.EventHandler(this.Menu);
            // 
            // iniciarToolStripMenuItem
            // 
            this.iniciarToolStripMenuItem.Name = "iniciarToolStripMenuItem";
            this.iniciarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iniciarToolStripMenuItem.Text = "Iniciar";
            this.iniciarToolStripMenuItem.Click += new System.EventHandler(this.Menu);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.Menu);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.Menu);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(359, 352);
            this.ControlBox = false;
            this.Controls.Add(this.TxtPontos);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.B);
            this.Controls.Add(this.G);
            this.Controls.Add(this.R);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genius";
            ((System.ComponentModel.ISupportInitialize)(this.R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox R;
        private PictureBox G;
        private PictureBox B;
        private PictureBox Y;
        private Label TxtPontos;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem configs_menu;
        private ToolStripMenuItem iniciarToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
    }
}