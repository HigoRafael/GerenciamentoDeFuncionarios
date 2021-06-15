namespace SistemaDeRelatorios
{
    partial class FormularioPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPrincipal));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.buttonAcessar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelTitulo = new System.Windows.Forms.Panel();
            this.btnMini = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnDeslisa = new System.Windows.Forms.PictureBox();
            this.PanelPrincpal = new System.Windows.Forms.Panel();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeslisa)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MenuVertical.Controls.Add(this.buttonAcessar);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(84, 925);
            this.MenuVertical.TabIndex = 0;
            // 
            // buttonAcessar
            // 
            this.buttonAcessar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonAcessar.FlatAppearance.BorderSize = 0;
            this.buttonAcessar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonAcessar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAcessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAcessar.ForeColor = System.Drawing.Color.LightGray;
            this.buttonAcessar.Image = ((System.Drawing.Image)(resources.GetObject("buttonAcessar.Image")));
            this.buttonAcessar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAcessar.Location = new System.Drawing.Point(0, 209);
            this.buttonAcessar.Name = "buttonAcessar";
            this.buttonAcessar.Size = new System.Drawing.Size(282, 40);
            this.buttonAcessar.TabIndex = 4;
            this.buttonAcessar.Text = "FUNCIONÁRIOS";
            this.buttonAcessar.UseVisualStyleBackColor = false;
            this.buttonAcessar.Click += new System.EventHandler(this.buttonAcessar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaDeRelatorios.Properties.Resources.d8ee0a0b9c7f64e7286b0c939306449a;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PanelTitulo
            // 
            this.PanelTitulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelTitulo.Controls.Add(this.btnMini);
            this.PanelTitulo.Controls.Add(this.btnClose);
            this.PanelTitulo.Controls.Add(this.btnDeslisa);
            this.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitulo.Location = new System.Drawing.Point(84, 0);
            this.PanelTitulo.Name = "PanelTitulo";
            this.PanelTitulo.Size = new System.Drawing.Size(1312, 66);
            this.PanelTitulo.TabIndex = 1;
            // 
            // btnMini
            // 
            this.btnMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnMini.Image = ((System.Drawing.Image)(resources.GetObject("btnMini.Image")));
            this.btnMini.Location = new System.Drawing.Point(1263, 3);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(20, 20);
            this.btnMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMini.TabIndex = 9;
            this.btnMini.TabStop = false;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1289, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 8;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDeslisa
            // 
            this.btnDeslisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeslisa.Image = ((System.Drawing.Image)(resources.GetObject("btnDeslisa.Image")));
            this.btnDeslisa.Location = new System.Drawing.Point(6, 12);
            this.btnDeslisa.Name = "btnDeslisa";
            this.btnDeslisa.Size = new System.Drawing.Size(35, 35);
            this.btnDeslisa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDeslisa.TabIndex = 0;
            this.btnDeslisa.TabStop = false;
            this.btnDeslisa.Click += new System.EventHandler(this.btnDeslisa_Click);
            // 
            // PanelPrincpal
            // 
            this.PanelPrincpal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincpal.Location = new System.Drawing.Point(84, 66);
            this.PanelPrincpal.Name = "PanelPrincpal";
            this.PanelPrincpal.Size = new System.Drawing.Size(1312, 859);
            this.PanelPrincpal.TabIndex = 2;
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 925);
            this.Controls.Add(this.PanelPrincpal);
            this.Controls.Add(this.PanelTitulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FormularioPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioPrincipal";
            this.MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeslisa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel PanelTitulo;
        private System.Windows.Forms.Panel PanelPrincpal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnDeslisa;
        private System.Windows.Forms.PictureBox btnMini;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Button buttonAcessar;
    }
}