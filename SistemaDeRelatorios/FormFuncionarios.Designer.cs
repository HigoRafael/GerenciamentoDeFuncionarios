
namespace SistemaDeRelatorios
{
    partial class FormFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFuncionarios));
            this.lblFucn = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMat = new System.Windows.Forms.LinkLabel();
            this.btnBuscarMat = new System.Windows.Forms.Button();
            this.txtBuscMat = new System.Windows.Forms.TextBox();
            this.imgImagem = new System.Windows.Forms.PictureBox();
            this.dataGridViewDados = new System.Windows.Forms.DataGridView();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnBuscarFoto = new System.Windows.Forms.Button();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.linkLabel11 = new System.Windows.Forms.LinkLabel();
            this.linkLabel10 = new System.Windows.Forms.LinkLabel();
            this.linkLabel9 = new System.Windows.Forms.LinkLabel();
            this.linkLabel8 = new System.Windows.Forms.LinkLabel();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtFoto = new System.Windows.Forms.TextBox();
            this.txtNumArm = new System.Windows.Forms.TextBox();
            this.txtBloco = new System.Windows.Forms.TextBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNumCard = new System.Windows.Forms.TextBox();
            this.txtMat = new System.Windows.Forms.TextBox();
            this.txtFunc = new System.Windows.Forms.TextBox();
            this.txtSetor = new System.Windows.Forms.TextBox();
            this.txtDep = new System.Windows.Forms.TextBox();
            this.btnMini = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnCinsultaRec = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).BeginInit();
            this.panelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFucn
            // 
            this.lblFucn.AutoSize = true;
            this.lblFucn.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFucn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFucn.Location = new System.Drawing.Point(0, 0);
            this.lblFucn.Name = "lblFucn";
            this.lblFucn.Size = new System.Drawing.Size(225, 31);
            this.lblFucn.TabIndex = 0;
            this.lblFucn.Text = "FUNCIONARIOS";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnCinsultaRec);
            this.panel1.Controls.Add(this.lblMat);
            this.panel1.Controls.Add(this.btnBuscarMat);
            this.panel1.Controls.Add(this.txtBuscMat);
            this.panel1.Controls.Add(this.imgImagem);
            this.panel1.Controls.Add(this.dataGridViewDados);
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 812);
            this.panel1.TabIndex = 12;
            // 
            // lblMat
            // 
            this.lblMat.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.lblMat.AutoSize = true;
            this.lblMat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMat.ForeColor = System.Drawing.Color.DimGray;
            this.lblMat.LinkColor = System.Drawing.Color.DimGray;
            this.lblMat.Location = new System.Drawing.Point(6, 140);
            this.lblMat.Name = "lblMat";
            this.lblMat.Size = new System.Drawing.Size(89, 21);
            this.lblMat.TabIndex = 35;
            this.lblMat.TabStop = true;
            this.lblMat.Text = "Matricula:";
            // 
            // btnBuscarMat
            // 
            this.btnBuscarMat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBuscarMat.CausesValidation = false;
            this.btnBuscarMat.FlatAppearance.BorderSize = 0;
            this.btnBuscarMat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnBuscarMat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscarMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarMat.ForeColor = System.Drawing.Color.LightGray;
            this.btnBuscarMat.Location = new System.Drawing.Point(147, 164);
            this.btnBuscarMat.Name = "btnBuscarMat";
            this.btnBuscarMat.Size = new System.Drawing.Size(76, 21);
            this.btnBuscarMat.TabIndex = 34;
            this.btnBuscarMat.Text = "Buscar";
            this.btnBuscarMat.UseVisualStyleBackColor = false;
            this.btnBuscarMat.Click += new System.EventHandler(this.btnBuscarMat_Click);
            // 
            // txtBuscMat
            // 
            this.txtBuscMat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscMat.CausesValidation = false;
            this.txtBuscMat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscMat.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtBuscMat.Location = new System.Drawing.Point(10, 166);
            this.txtBuscMat.Name = "txtBuscMat";
            this.txtBuscMat.Size = new System.Drawing.Size(119, 19);
            this.txtBuscMat.TabIndex = 33;
            this.txtBuscMat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBuscMat.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscMat_KeyUp);
            // 
            // imgImagem
            // 
            this.imgImagem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgImagem.Location = new System.Drawing.Point(562, -2);
            this.imgImagem.Name = "imgImagem";
            this.imgImagem.Size = new System.Drawing.Size(224, 187);
            this.imgImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgImagem.TabIndex = 1;
            this.imgImagem.TabStop = false;
            // 
            // dataGridViewDados
            // 
            this.dataGridViewDados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewDados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDados.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewDados.Location = new System.Drawing.Point(0, 191);
            this.dataGridViewDados.Name = "dataGridViewDados";
            this.dataGridViewDados.Size = new System.Drawing.Size(786, 617);
            this.dataGridViewDados.TabIndex = 0;
            this.dataGridViewDados.SelectionChanged += new System.EventHandler(this.dataGridViewDados_SelectionChanged);
            // 
            // panelLateral
            // 
            this.panelLateral.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLateral.Controls.Add(this.btnEditar);
            this.panelLateral.Controls.Add(this.btnExcluir);
            this.panelLateral.Controls.Add(this.btnBuscarFoto);
            this.panelLateral.Controls.Add(this.buttonInserir);
            this.panelLateral.Controls.Add(this.linkLabel11);
            this.panelLateral.Controls.Add(this.linkLabel10);
            this.panelLateral.Controls.Add(this.linkLabel9);
            this.panelLateral.Controls.Add(this.linkLabel8);
            this.panelLateral.Controls.Add(this.linkLabel7);
            this.panelLateral.Controls.Add(this.linkLabel6);
            this.panelLateral.Controls.Add(this.linkLabel5);
            this.panelLateral.Controls.Add(this.linkLabel4);
            this.panelLateral.Controls.Add(this.linkLabel3);
            this.panelLateral.Controls.Add(this.linkLabel2);
            this.panelLateral.Controls.Add(this.linkLabel1);
            this.panelLateral.Controls.Add(this.txtFoto);
            this.panelLateral.Controls.Add(this.txtNumArm);
            this.panelLateral.Controls.Add(this.txtBloco);
            this.panelLateral.Controls.Add(this.txtRemark);
            this.panelLateral.Controls.Add(this.txtNome);
            this.panelLateral.Controls.Add(this.txtNumCard);
            this.panelLateral.Controls.Add(this.txtMat);
            this.panelLateral.Controls.Add(this.txtFunc);
            this.panelLateral.Controls.Add(this.txtSetor);
            this.panelLateral.Controls.Add(this.txtDep);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLateral.Location = new System.Drawing.Point(833, 31);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(405, 812);
            this.panelLateral.TabIndex = 13;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.LightGray;
            this.btnEditar.Location = new System.Drawing.Point(7, 664);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(98, 29);
            this.btnEditar.TabIndex = 34;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ForeColor = System.Drawing.Color.LightGray;
            this.btnExcluir.Location = new System.Drawing.Point(143, 664);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(98, 29);
            this.btnExcluir.TabIndex = 33;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnBuscarFoto
            // 
            this.btnBuscarFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBuscarFoto.FlatAppearance.BorderSize = 0;
            this.btnBuscarFoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnBuscarFoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarFoto.ForeColor = System.Drawing.Color.LightGray;
            this.btnBuscarFoto.Location = new System.Drawing.Point(322, 530);
            this.btnBuscarFoto.Name = "btnBuscarFoto";
            this.btnBuscarFoto.Size = new System.Drawing.Size(76, 21);
            this.btnBuscarFoto.TabIndex = 32;
            this.btnBuscarFoto.Text = "...";
            this.btnBuscarFoto.UseVisualStyleBackColor = false;
            this.btnBuscarFoto.Click += new System.EventHandler(this.btnBuscarFoto_Click);
            // 
            // buttonInserir
            // 
            this.buttonInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonInserir.FlatAppearance.BorderSize = 0;
            this.buttonInserir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonInserir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInserir.ForeColor = System.Drawing.Color.LightGray;
            this.buttonInserir.Location = new System.Drawing.Point(293, 664);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(98, 29);
            this.buttonInserir.TabIndex = 31;
            this.buttonInserir.Text = "Salvar";
            this.buttonInserir.UseVisualStyleBackColor = false;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // linkLabel11
            // 
            this.linkLabel11.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.linkLabel11.AutoSize = true;
            this.linkLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.linkLabel11.ForeColor = System.Drawing.Color.DimGray;
            this.linkLabel11.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabel11.Location = new System.Drawing.Point(115, 0);
            this.linkLabel11.Name = "linkLabel11";
            this.linkLabel11.Size = new System.Drawing.Size(166, 31);
            this.linkLabel11.TabIndex = 30;
            this.linkLabel11.TabStop = true;
            this.linkLabel11.Text = "CADASTRO";
            // 
            // linkLabel10
            // 
            this.linkLabel10.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.linkLabel10.AutoSize = true;
            this.linkLabel10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel10.ForeColor = System.Drawing.Color.DimGray;
            this.linkLabel10.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabel10.Location = new System.Drawing.Point(3, 140);
            this.linkLabel10.Name = "linkLabel10";
            this.linkLabel10.Size = new System.Drawing.Size(54, 21);
            this.linkLabel10.TabIndex = 29;
            this.linkLabel10.TabStop = true;
            this.linkLabel10.Text = "Setor:";
            // 
            // linkLabel9
            // 
            this.linkLabel9.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.linkLabel9.AutoSize = true;
            this.linkLabel9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel9.ForeColor = System.Drawing.Color.DimGray;
            this.linkLabel9.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabel9.Location = new System.Drawing.Point(3, 189);
            this.linkLabel9.Name = "linkLabel9";
            this.linkLabel9.Size = new System.Drawing.Size(73, 21);
            this.linkLabel9.TabIndex = 28;
            this.linkLabel9.TabStop = true;
            this.linkLabel9.Text = "Função:";
            // 
            // linkLabel8
            // 
            this.linkLabel8.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.linkLabel8.AutoSize = true;
            this.linkLabel8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel8.ForeColor = System.Drawing.Color.DimGray;
            this.linkLabel8.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabel8.Location = new System.Drawing.Point(3, 247);
            this.linkLabel8.Name = "linkLabel8";
            this.linkLabel8.Size = new System.Drawing.Size(89, 21);
            this.linkLabel8.TabIndex = 27;
            this.linkLabel8.TabStop = true;
            this.linkLabel8.Text = "Matricula:";
            // 
            // linkLabel7
            // 
            this.linkLabel7.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel7.ForeColor = System.Drawing.Color.DimGray;
            this.linkLabel7.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabel7.Location = new System.Drawing.Point(3, 292);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(158, 21);
            this.linkLabel7.TabIndex = 26;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "Número do Cartão";
            // 
            // linkLabel6
            // 
            this.linkLabel6.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel6.ForeColor = System.Drawing.Color.DimGray;
            this.linkLabel6.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabel6.Location = new System.Drawing.Point(3, 535);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(49, 21);
            this.linkLabel6.TabIndex = 25;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "Foto:";
            // 
            // linkLabel5
            // 
            this.linkLabel5.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel5.ForeColor = System.Drawing.Color.DimGray;
            this.linkLabel5.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabel5.Location = new System.Drawing.Point(3, 484);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(162, 21);
            this.linkLabel5.TabIndex = 24;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Número do Amário:";
            // 
            // linkLabel4
            // 
            this.linkLabel4.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel4.ForeColor = System.Drawing.Color.DimGray;
            this.linkLabel4.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabel4.Location = new System.Drawing.Point(3, 436);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(56, 21);
            this.linkLabel4.TabIndex = 23;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Bloco:";
            // 
            // linkLabel3
            // 
            this.linkLabel3.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.ForeColor = System.Drawing.Color.DimGray;
            this.linkLabel3.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabel3.Location = new System.Drawing.Point(3, 389);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(73, 21);
            this.linkLabel3.TabIndex = 22;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Remark:";
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.ForeColor = System.Drawing.Color.DimGray;
            this.linkLabel2.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabel2.Location = new System.Drawing.Point(3, 340);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(61, 21);
            this.linkLabel2.TabIndex = 21;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Nome:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.linkLabel1.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabel1.Location = new System.Drawing.Point(3, 87);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(133, 21);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Departamento:";
            // 
            // txtFoto
            // 
            this.txtFoto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFoto.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtFoto.Location = new System.Drawing.Point(172, 532);
            this.txtFoto.Name = "txtFoto";
            this.txtFoto.Size = new System.Drawing.Size(119, 19);
            this.txtFoto.TabIndex = 9;
            // 
            // txtNumArm
            // 
            this.txtNumArm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumArm.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumArm.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtNumArm.Location = new System.Drawing.Point(171, 484);
            this.txtNumArm.Name = "txtNumArm";
            this.txtNumArm.Size = new System.Drawing.Size(221, 19);
            this.txtNumArm.TabIndex = 8;
            this.txtNumArm.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNumArm_KeyUp);
            // 
            // txtBloco
            // 
            this.txtBloco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBloco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBloco.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtBloco.Location = new System.Drawing.Point(172, 433);
            this.txtBloco.Name = "txtBloco";
            this.txtBloco.Size = new System.Drawing.Size(221, 19);
            this.txtBloco.TabIndex = 7;
            this.txtBloco.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBloco_KeyUp);
            // 
            // txtRemark
            // 
            this.txtRemark.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRemark.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRemark.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtRemark.Location = new System.Drawing.Point(172, 386);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(221, 19);
            this.txtRemark.TabIndex = 6;
            this.txtRemark.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRemark_KeyUp);
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtNome.Location = new System.Drawing.Point(172, 337);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(221, 19);
            this.txtNome.TabIndex = 5;
            this.txtNome.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyUp);
            // 
            // txtNumCard
            // 
            this.txtNumCard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumCard.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumCard.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtNumCard.Location = new System.Drawing.Point(172, 289);
            this.txtNumCard.Name = "txtNumCard";
            this.txtNumCard.Size = new System.Drawing.Size(221, 19);
            this.txtNumCard.TabIndex = 4;
            this.txtNumCard.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNumCard_KeyUp);
            // 
            // txtMat
            // 
            this.txtMat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMat.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtMat.Location = new System.Drawing.Point(172, 244);
            this.txtMat.Name = "txtMat";
            this.txtMat.Size = new System.Drawing.Size(221, 19);
            this.txtMat.TabIndex = 3;
            this.txtMat.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMat_KeyUp);
            // 
            // txtFunc
            // 
            this.txtFunc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFunc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFunc.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtFunc.Location = new System.Drawing.Point(172, 186);
            this.txtFunc.Name = "txtFunc";
            this.txtFunc.Size = new System.Drawing.Size(221, 19);
            this.txtFunc.TabIndex = 2;
            this.txtFunc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFunc_KeyUp);
            // 
            // txtSetor
            // 
            this.txtSetor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSetor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSetor.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtSetor.Location = new System.Drawing.Point(172, 137);
            this.txtSetor.Name = "txtSetor";
            this.txtSetor.Size = new System.Drawing.Size(221, 19);
            this.txtSetor.TabIndex = 1;
            this.txtSetor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSetor_KeyUp);
            // 
            // txtDep
            // 
            this.txtDep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDep.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDep.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDep.Location = new System.Drawing.Point(172, 87);
            this.txtDep.Name = "txtDep";
            this.txtDep.Size = new System.Drawing.Size(221, 19);
            this.txtDep.TabIndex = 0;
            this.txtDep.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDep_KeyUp);
            // 
            // btnMini
            // 
            this.btnMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnMini.Image = ((System.Drawing.Image)(resources.GetObject("btnMini.Image")));
            this.btnMini.Location = new System.Drawing.Point(1192, 0);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(20, 20);
            this.btnMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMini.TabIndex = 11;
            this.btnMini.TabStop = false;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1218, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 10;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCinsultaRec
            // 
            this.btnCinsultaRec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCinsultaRec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCinsultaRec.BackgroundImage")));
            this.btnCinsultaRec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCinsultaRec.CausesValidation = false;
            this.btnCinsultaRec.FlatAppearance.BorderSize = 0;
            this.btnCinsultaRec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCinsultaRec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCinsultaRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCinsultaRec.ForeColor = System.Drawing.Color.LightGray;
            this.btnCinsultaRec.Location = new System.Drawing.Point(250, 151);
            this.btnCinsultaRec.Name = "btnCinsultaRec";
            this.btnCinsultaRec.Size = new System.Drawing.Size(33, 34);
            this.btnCinsultaRec.TabIndex = 36;
            this.btnCinsultaRec.UseVisualStyleBackColor = false;
            this.btnCinsultaRec.Click += new System.EventHandler(this.btnCinsultaRec_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 843);
            this.Controls.Add(this.panelLateral);
            this.Controls.Add(this.btnMini);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblFucn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFuncionarios";
            this.Text = "FormFuncionarios";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).EndInit();
            this.panelLateral.ResumeLayout(false);
            this.panelLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFucn;
        private System.Windows.Forms.PictureBox btnMini;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imgImagem;
        private System.Windows.Forms.DataGridView dataGridViewDados;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.TextBox txtDep;
        private System.Windows.Forms.TextBox txtFoto;
        private System.Windows.Forms.TextBox txtNumArm;
        private System.Windows.Forms.TextBox txtBloco;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtNumCard;
        private System.Windows.Forms.TextBox txtMat;
        private System.Windows.Forms.TextBox txtFunc;
        private System.Windows.Forms.TextBox txtSetor;
        private System.Windows.Forms.LinkLabel linkLabel10;
        private System.Windows.Forms.LinkLabel linkLabel9;
        private System.Windows.Forms.LinkLabel linkLabel8;
        private System.Windows.Forms.LinkLabel linkLabel7;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel11;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnBuscarFoto;
        private System.Windows.Forms.Button btnBuscarMat;
        private System.Windows.Forms.TextBox txtBuscMat;
        private System.Windows.Forms.LinkLabel lblMat;
        private System.Windows.Forms.Button btnCinsultaRec;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}