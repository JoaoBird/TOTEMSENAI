namespace teste
{
    partial class Edc_lab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edc_lab));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_adm = new System.Windows.Forms.Label();
            this.lbl_cadastrar = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.box_nome = new System.Windows.Forms.TextBox();
            this.box_desc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelArred1 = new teste.PanelArred();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_voltar_img = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_def_primaria = new System.Windows.Forms.Button();
            this.btn_proximo_img = new System.Windows.Forms.Button();
            this.btn_adc_img = new System.Windows.Forms.Button();
            this.panelArred2 = new teste.PanelArred();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.btn_prev_vid = new System.Windows.Forms.Button();
            this.excluir_video = new System.Windows.Forms.Button();
            this.btn_proximo_vid = new System.Windows.Forms.Button();
            this.btn_adc_vid = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelArred1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelArred2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1904, 74);
            this.panel1.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.lbl_adm);
            this.panel2.Controls.Add(this.lbl_cadastrar);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1904, 74);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(367, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "/";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = global::teste.Properties.Resources.botao_de_retorno;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1842, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_adm
            // 
            this.lbl_adm.AutoSize = true;
            this.lbl_adm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adm.ForeColor = System.Drawing.Color.White;
            this.lbl_adm.Location = new System.Drawing.Point(252, 37);
            this.lbl_adm.Name = "lbl_adm";
            this.lbl_adm.Size = new System.Drawing.Size(103, 16);
            this.lbl_adm.TabIndex = 3;
            this.lbl_adm.Text = "Administrador";
            this.lbl_adm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_adm.Click += new System.EventHandler(this.lbl_adm_Click);
            this.lbl_adm.MouseLeave += new System.EventHandler(this.lbl_adm_MouseLeave);
            this.lbl_adm.MouseHover += new System.EventHandler(this.lbl_adm_MouseHover);
            // 
            // lbl_cadastrar
            // 
            this.lbl_cadastrar.AutoSize = true;
            this.lbl_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cadastrar.ForeColor = System.Drawing.Color.White;
            this.lbl_cadastrar.Location = new System.Drawing.Point(391, 37);
            this.lbl_cadastrar.Name = "lbl_cadastrar";
            this.lbl_cadastrar.Size = new System.Drawing.Size(132, 16);
            this.lbl_cadastrar.TabIndex = 8;
            this.lbl_cadastrar.Text = "Editar Laboratorio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(168, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Home";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            this.label10.MouseLeave += new System.EventHandler(this.label10_MouseLeave);
            this.label10.MouseHover += new System.EventHandler(this.label10_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 42);
            this.label2.TabIndex = 0;
            this.label2.Text = "SENAI";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(228, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Nome do laboratorio";
            // 
            // box_nome
            // 
            this.box_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_nome.Location = new System.Drawing.Point(280, 97);
            this.box_nome.Name = "box_nome";
            this.box_nome.Size = new System.Drawing.Size(596, 26);
            this.box_nome.TabIndex = 33;
            // 
            // box_desc
            // 
            this.box_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_desc.Location = new System.Drawing.Point(280, 159);
            this.box_desc.Multiline = true;
            this.box_desc.Name = "box_desc";
            this.box_desc.Size = new System.Drawing.Size(596, 366);
            this.box_desc.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Descrição";
            // 
            // btn_enviar
            // 
            this.btn_enviar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_enviar.FlatAppearance.BorderSize = 0;
            this.btn_enviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_enviar.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enviar.ForeColor = System.Drawing.Color.White;
            this.btn_enviar.Location = new System.Drawing.Point(758, 963);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(118, 42);
            this.btn_enviar.TabIndex = 38;
            this.btn_enviar.Text = "Atualizar";
            this.btn_enviar.UseVisualStyleBackColor = false;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(354, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 31);
            this.label5.TabIndex = 50;
            this.label5.Text = "0/0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(354, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 31);
            this.label6.TabIndex = 51;
            this.label6.Text = "0/0";
            // 
            // panelArred1
            // 
            this.panelArred1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelArred1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelArred1.BorderRadius = 30;
            this.panelArred1.Controls.Add(this.label5);
            this.panelArred1.Controls.Add(this.pictureBox1);
            this.panelArred1.Controls.Add(this.btn_voltar_img);
            this.panelArred1.Controls.Add(this.button2);
            this.panelArred1.Controls.Add(this.btn_def_primaria);
            this.panelArred1.Controls.Add(this.btn_proximo_img);
            this.panelArred1.Controls.Add(this.btn_adc_img);
            this.panelArred1.ForeColor = System.Drawing.Color.Black;
            this.panelArred1.Location = new System.Drawing.Point(1147, 80);
            this.panelArred1.Name = "panelArred1";
            this.panelArred1.Size = new System.Drawing.Size(745, 448);
            this.panelArred1.TabIndex = 52;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(45, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(652, 361);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // btn_voltar_img
            // 
            this.btn_voltar_img.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_voltar_img.FlatAppearance.BorderSize = 0;
            this.btn_voltar_img.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar_img.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar_img.Image = ((System.Drawing.Image)(resources.GetObject("btn_voltar_img.Image")));
            this.btn_voltar_img.Location = new System.Drawing.Point(3, 151);
            this.btn_voltar_img.Name = "btn_voltar_img";
            this.btn_voltar_img.Size = new System.Drawing.Size(39, 51);
            this.btn_voltar_img.TabIndex = 45;
            this.btn_voltar_img.UseVisualStyleBackColor = false;
            this.btn_voltar_img.Click += new System.EventHandler(this.btn_voltar_img_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(493, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 61);
            this.button2.TabIndex = 42;
            this.button2.Text = "Remover imagem";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btn_excluir_img_Click);
            // 
            // btn_def_primaria
            // 
            this.btn_def_primaria.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_def_primaria.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_def_primaria.FlatAppearance.BorderSize = 2;
            this.btn_def_primaria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_def_primaria.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_def_primaria.ForeColor = System.Drawing.Color.White;
            this.btn_def_primaria.Location = new System.Drawing.Point(272, 384);
            this.btn_def_primaria.Name = "btn_def_primaria";
            this.btn_def_primaria.Size = new System.Drawing.Size(204, 61);
            this.btn_def_primaria.TabIndex = 49;
            this.btn_def_primaria.Text = "Definir imagem primaria";
            this.btn_def_primaria.UseVisualStyleBackColor = false;
            this.btn_def_primaria.Click += new System.EventHandler(this.btn_def_primaria_Click);
            // 
            // btn_proximo_img
            // 
            this.btn_proximo_img.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_proximo_img.FlatAppearance.BorderSize = 0;
            this.btn_proximo_img.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_proximo_img.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_proximo_img.Image = ((System.Drawing.Image)(resources.GetObject("btn_proximo_img.Image")));
            this.btn_proximo_img.Location = new System.Drawing.Point(703, 151);
            this.btn_proximo_img.Name = "btn_proximo_img";
            this.btn_proximo_img.Size = new System.Drawing.Size(39, 51);
            this.btn_proximo_img.TabIndex = 46;
            this.btn_proximo_img.UseVisualStyleBackColor = false;
            this.btn_proximo_img.Click += new System.EventHandler(this.btn_proximo_img_Click);
            // 
            // btn_adc_img
            // 
            this.btn_adc_img.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_adc_img.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_adc_img.FlatAppearance.BorderSize = 2;
            this.btn_adc_img.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_adc_img.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adc_img.ForeColor = System.Drawing.Color.White;
            this.btn_adc_img.Location = new System.Drawing.Point(45, 384);
            this.btn_adc_img.Name = "btn_adc_img";
            this.btn_adc_img.Size = new System.Drawing.Size(204, 61);
            this.btn_adc_img.TabIndex = 40;
            this.btn_adc_img.Text = "Adicionar imagem";
            this.btn_adc_img.UseVisualStyleBackColor = false;
            this.btn_adc_img.Click += new System.EventHandler(this.btn_adc_img_Click);
            // 
            // panelArred2
            // 
            this.panelArred2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelArred2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelArred2.BorderRadius = 30;
            this.panelArred2.Controls.Add(this.label6);
            this.panelArred2.Controls.Add(this.player);
            this.panelArred2.Controls.Add(this.btn_prev_vid);
            this.panelArred2.Controls.Add(this.excluir_video);
            this.panelArred2.Controls.Add(this.btn_proximo_vid);
            this.panelArred2.Controls.Add(this.btn_adc_vid);
            this.panelArred2.ForeColor = System.Drawing.Color.Black;
            this.panelArred2.Location = new System.Drawing.Point(1147, 548);
            this.panelArred2.Name = "panelArred2";
            this.panelArred2.Size = new System.Drawing.Size(745, 464);
            this.panelArred2.TabIndex = 53;
            this.panelArred2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelArred2_Paint);
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(48, 28);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(649, 360);
            this.player.TabIndex = 44;
            // 
            // btn_prev_vid
            // 
            this.btn_prev_vid.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_prev_vid.FlatAppearance.BorderSize = 0;
            this.btn_prev_vid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prev_vid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prev_vid.Image = ((System.Drawing.Image)(resources.GetObject("btn_prev_vid.Image")));
            this.btn_prev_vid.Location = new System.Drawing.Point(5, 181);
            this.btn_prev_vid.Name = "btn_prev_vid";
            this.btn_prev_vid.Size = new System.Drawing.Size(37, 51);
            this.btn_prev_vid.TabIndex = 47;
            this.btn_prev_vid.UseVisualStyleBackColor = false;
            this.btn_prev_vid.Click += new System.EventHandler(this.btn_prev_vid_Click);
            // 
            // excluir_video
            // 
            this.excluir_video.BackColor = System.Drawing.Color.RoyalBlue;
            this.excluir_video.FlatAppearance.BorderSize = 0;
            this.excluir_video.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.excluir_video.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluir_video.ForeColor = System.Drawing.Color.White;
            this.excluir_video.Location = new System.Drawing.Point(430, 394);
            this.excluir_video.Name = "excluir_video";
            this.excluir_video.Size = new System.Drawing.Size(267, 63);
            this.excluir_video.TabIndex = 41;
            this.excluir_video.Text = "Remover video";
            this.excluir_video.UseVisualStyleBackColor = false;
            this.excluir_video.Click += new System.EventHandler(this.excluir_video_Click);
            // 
            // btn_proximo_vid
            // 
            this.btn_proximo_vid.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_proximo_vid.FlatAppearance.BorderSize = 0;
            this.btn_proximo_vid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_proximo_vid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_proximo_vid.Image = ((System.Drawing.Image)(resources.GetObject("btn_proximo_vid.Image")));
            this.btn_proximo_vid.Location = new System.Drawing.Point(705, 181);
            this.btn_proximo_vid.Name = "btn_proximo_vid";
            this.btn_proximo_vid.Size = new System.Drawing.Size(37, 51);
            this.btn_proximo_vid.TabIndex = 48;
            this.btn_proximo_vid.UseVisualStyleBackColor = false;
            this.btn_proximo_vid.Click += new System.EventHandler(this.btn_proximo_vid_Click);
            // 
            // btn_adc_vid
            // 
            this.btn_adc_vid.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_adc_vid.FlatAppearance.BorderSize = 0;
            this.btn_adc_vid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_adc_vid.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adc_vid.ForeColor = System.Drawing.Color.White;
            this.btn_adc_vid.Location = new System.Drawing.Point(48, 394);
            this.btn_adc_vid.Name = "btn_adc_vid";
            this.btn_adc_vid.Size = new System.Drawing.Size(267, 63);
            this.btn_adc_vid.TabIndex = 39;
            this.btn_adc_vid.Text = "Adicionar video";
            this.btn_adc_vid.UseVisualStyleBackColor = false;
            this.btn_adc_vid.Click += new System.EventHandler(this.btn_adc_vid_Click);
            // 
            // Edc_lab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1010);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.box_desc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.box_nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelArred1);
            this.Controls.Add(this.panelArred2);
            this.Name = "Edc_lab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edc_lab";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Edc_lab_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelArred1.ResumeLayout(false);
            this.panelArred1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelArred2.ResumeLayout(false);
            this.panelArred2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_adm;
        private System.Windows.Forms.Label lbl_cadastrar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox box_nome;
        private System.Windows.Forms.TextBox box_desc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.Button btn_adc_vid;
        private System.Windows.Forms.Button btn_adc_img;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button excluir_video;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_proximo_img;
        private System.Windows.Forms.Button btn_voltar_img;
        private System.Windows.Forms.Button btn_proximo_vid;
        private System.Windows.Forms.Button btn_prev_vid;
        private System.Windows.Forms.Button btn_def_primaria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private PanelArred panelArred1;
        private PanelArred panelArred2;
    }
}