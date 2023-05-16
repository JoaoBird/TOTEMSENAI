namespace teste
{
    partial class tela_c
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_NomeMenu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.panelArred4 = new teste.PanelArred();
            this.lbl_tp_curso = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_modalidade = new System.Windows.Forms.Label();
            this.panelArred1 = new teste.PanelArred();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pic_QR = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panelArred3 = new teste.PanelArred();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.lbl_preco = new System.Windows.Forms.Label();
            this.lbl_req = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelArredondado3 = new teste.PanelArredondado();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_prof = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_aprender = new System.Windows.Forms.Label();
            this.lbl_op_trabalho = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelArred4.SuspendLayout();
            this.panelArred1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_QR)).BeginInit();
            this.panelArred3.SuspendLayout();
            this.panelArredondado3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.lbl_NomeMenu);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1904, 76);
            this.panel1.TabIndex = 9;
            // 
            // btn_back
            // 
            this.btn_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_back.BackgroundImage = global::teste.Properties.Resources.botao_de_retorno;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Location = new System.Drawing.Point(1844, 17);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(40, 40);
            this.btn_back.TabIndex = 7;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_NomeMenu
            // 
            this.lbl_NomeMenu.AutoSize = true;
            this.lbl_NomeMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NomeMenu.ForeColor = System.Drawing.Color.White;
            this.lbl_NomeMenu.Location = new System.Drawing.Point(333, 37);
            this.lbl_NomeMenu.Name = "lbl_NomeMenu";
            this.lbl_NomeMenu.Size = new System.Drawing.Size(45, 16);
            this.lbl_NomeMenu.TabIndex = 5;
            this.lbl_NomeMenu.Text = "nome";
            this.lbl_NomeMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(311, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "/";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(246, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 16);
            this.label12.TabIndex = 3;
            this.label12.Text = "Cursos";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.Click += new System.EventHandler(this.label12_Click_1);
            this.label12.MouseLeave += new System.EventHandler(this.label12_MouseLeave);
            this.label12.MouseHover += new System.EventHandler(this.label12_MouseHover);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(224, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "/";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "SENAI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 992);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1904, 49);
            this.panel2.TabIndex = 15;
            // 
            // panelArred4
            // 
            this.panelArred4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelArred4.BorderRadius = 30;
            this.panelArred4.Controls.Add(this.lbl_tp_curso);
            this.panelArred4.Controls.Add(this.lbl_nome);
            this.panelArred4.Controls.Add(this.lbl_modalidade);
            this.panelArred4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.panelArred4.Location = new System.Drawing.Point(250, 123);
            this.panelArred4.Name = "panelArred4";
            this.panelArred4.Size = new System.Drawing.Size(1045, 144);
            this.panelArred4.TabIndex = 13;
            // 
            // lbl_tp_curso
            // 
            this.lbl_tp_curso.AutoSize = true;
            this.lbl_tp_curso.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tp_curso.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tp_curso.ForeColor = System.Drawing.Color.White;
            this.lbl_tp_curso.Location = new System.Drawing.Point(559, 88);
            this.lbl_tp_curso.Name = "lbl_tp_curso";
            this.lbl_tp_curso.Size = new System.Drawing.Size(121, 24);
            this.lbl_tp_curso.TabIndex = 7;
            this.lbl_tp_curso.Text = "Tipo Curso";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nome.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.ForeColor = System.Drawing.Color.White;
            this.lbl_nome.Location = new System.Drawing.Point(24, 32);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(77, 29);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "nome";
            // 
            // lbl_modalidade
            // 
            this.lbl_modalidade.AutoSize = true;
            this.lbl_modalidade.BackColor = System.Drawing.Color.Transparent;
            this.lbl_modalidade.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_modalidade.ForeColor = System.Drawing.Color.White;
            this.lbl_modalidade.Location = new System.Drawing.Point(24, 88);
            this.lbl_modalidade.Name = "lbl_modalidade";
            this.lbl_modalidade.Size = new System.Drawing.Size(125, 24);
            this.lbl_modalidade.TabIndex = 8;
            this.lbl_modalidade.Text = "Modalidade";
            // 
            // panelArred1
            // 
            this.panelArred1.AutoSize = true;
            this.panelArred1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelArred1.BorderRadius = 30;
            this.panelArred1.Controls.Add(this.pictureBox1);
            this.panelArred1.Controls.Add(this.label8);
            this.panelArred1.Controls.Add(this.pic_QR);
            this.panelArred1.Controls.Add(this.label7);
            this.panelArred1.Controls.Add(this.label9);
            this.panelArred1.Controls.Add(this.panelArred3);
            this.panelArred1.Controls.Add(this.lbl_req);
            this.panelArred1.Controls.Add(this.label6);
            this.panelArred1.ForeColor = System.Drawing.Color.Black;
            this.panelArred1.Location = new System.Drawing.Point(1429, 123);
            this.panelArred1.Name = "panelArred1";
            this.panelArred1.Size = new System.Drawing.Size(423, 678);
            this.panelArred1.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::teste.Properties.Resources.imagem_Whatsapp_removebg_preview;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(76, 506);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 70);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(81, 467);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(261, 23);
            this.label8.TabIndex = 18;
            this.label8.Text = "Entre em contato conosco:";
            // 
            // pic_QR
            // 
            this.pic_QR.Location = new System.Drawing.Point(69, 159);
            this.pic_QR.Name = "pic_QR";
            this.pic_QR.Size = new System.Drawing.Size(285, 285);
            this.pic_QR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_QR.TabIndex = 19;
            this.pic_QR.TabStop = false;
            this.pic_QR.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(154, 526);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 30);
            this.label7.TabIndex = 1;
            this.label7.Text = "(41) 99999-8888";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(88, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(246, 24);
            this.label9.TabIndex = 20;
            this.label9.Text = "Acesse o site do SENAI";
            // 
            // panelArred3
            // 
            this.panelArred3.BackColor = System.Drawing.Color.White;
            this.panelArred3.BorderRadius = 65;
            this.panelArred3.Controls.Add(this.lbl_hora);
            this.panelArred3.Controls.Add(this.lbl_preco);
            this.panelArred3.ForeColor = System.Drawing.Color.Black;
            this.panelArred3.Location = new System.Drawing.Point(19, 18);
            this.panelArred3.Name = "panelArred3";
            this.panelArred3.Size = new System.Drawing.Size(368, 83);
            this.panelArred3.TabIndex = 19;
            // 
            // lbl_hora
            // 
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hora.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.ForeColor = System.Drawing.Color.Black;
            this.lbl_hora.Location = new System.Drawing.Point(24, 17);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(150, 22);
            this.lbl_hora.TabIndex = 6;
            this.lbl_hora.Text = "Carga horária: ";
            // 
            // lbl_preco
            // 
            this.lbl_preco.AutoSize = true;
            this.lbl_preco.BackColor = System.Drawing.Color.Transparent;
            this.lbl_preco.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_preco.ForeColor = System.Drawing.Color.Black;
            this.lbl_preco.Location = new System.Drawing.Point(24, 43);
            this.lbl_preco.Name = "lbl_preco";
            this.lbl_preco.Size = new System.Drawing.Size(106, 22);
            this.lbl_preco.TabIndex = 5;
            this.lbl_preco.Text = "Preço: R$ ";
            // 
            // lbl_req
            // 
            this.lbl_req.AutoSize = true;
            this.lbl_req.BackColor = System.Drawing.Color.Transparent;
            this.lbl_req.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_req.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_req.Location = new System.Drawing.Point(34, 626);
            this.lbl_req.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.lbl_req.MaximumSize = new System.Drawing.Size(270, 0);
            this.lbl_req.Name = "lbl_req";
            this.lbl_req.Size = new System.Drawing.Size(86, 18);
            this.lbl_req.TabIndex = 1;
            this.lbl_req.Text = "Requisitos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(34, 597);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "Requisitos:";
            // 
            // panelArredondado3
            // 
            this.panelArredondado3.AutoSize = true;
            this.panelArredondado3.BackColor = System.Drawing.Color.White;
            this.panelArredondado3.BorderRadius = 30;
            this.panelArredondado3.Controls.Add(this.label4);
            this.panelArredondado3.Controls.Add(this.lbl_prof);
            this.panelArredondado3.Controls.Add(this.label5);
            this.panelArredondado3.Controls.Add(this.label3);
            this.panelArredondado3.Controls.Add(this.lbl_aprender);
            this.panelArredondado3.Controls.Add(this.lbl_op_trabalho);
            this.panelArredondado3.ForeColor = System.Drawing.Color.Black;
            this.panelArredondado3.GradientAngle = 90F;
            this.panelArredondado3.GradientBottomColor = System.Drawing.Color.Transparent;
            this.panelArredondado3.GradientTopColor = System.Drawing.Color.Transparent;
            this.panelArredondado3.Location = new System.Drawing.Point(247, 296);
            this.panelArredondado3.Name = "panelArredondado3";
            this.panelArredondado3.Size = new System.Drawing.Size(1048, 300);
            this.panelArredondado3.TabIndex = 14;
            this.panelArredondado3.Paint += new System.Windows.Forms.PaintEventHandler(this.panelArredondado3_Paint);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(369, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "A profissão";
            // 
            // lbl_prof
            // 
            this.lbl_prof.AutoSize = true;
            this.lbl_prof.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prof.Location = new System.Drawing.Point(17, 65);
            this.lbl_prof.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lbl_prof.MaximumSize = new System.Drawing.Size(1000, 0);
            this.lbl_prof.Name = "lbl_prof";
            this.lbl_prof.Size = new System.Drawing.Size(89, 22);
            this.lbl_prof.TabIndex = 2;
            this.lbl_prof.Text = "profissao";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(437, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Oportunidades de Trabalho";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Grade Curricular: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_aprender
            // 
            this.lbl_aprender.AutoSize = true;
            this.lbl_aprender.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aprender.Location = new System.Drawing.Point(17, 193);
            this.lbl_aprender.MaximumSize = new System.Drawing.Size(1000, 0);
            this.lbl_aprender.Name = "lbl_aprender";
            this.lbl_aprender.Padding = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.lbl_aprender.Size = new System.Drawing.Size(158, 72);
            this.lbl_aprender.TabIndex = 4;
            this.lbl_aprender.Text = "Grade Curricular: ";
            // 
            // lbl_op_trabalho
            // 
            this.lbl_op_trabalho.AutoSize = true;
            this.lbl_op_trabalho.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_op_trabalho.Location = new System.Drawing.Point(17, 129);
            this.lbl_op_trabalho.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lbl_op_trabalho.MaximumSize = new System.Drawing.Size(1000, 0);
            this.lbl_op_trabalho.Name = "lbl_op_trabalho";
            this.lbl_op_trabalho.Size = new System.Drawing.Size(220, 22);
            this.lbl_op_trabalho.TabIndex = 3;
            this.lbl_op_trabalho.Text = "oportunidade de trabalho";
            this.lbl_op_trabalho.Click += new System.EventHandler(this.lbl_op_trabalho_Click);
            // 
            // tela_c
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panelArred4);
            this.Controls.Add(this.panelArred1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelArredondado3);
            this.Controls.Add(this.panel1);
            this.Name = "tela_c";
            this.Text = "tela_c";
            this.Load += new System.EventHandler(this.tela_c_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelArred4.ResumeLayout(false);
            this.panelArred4.PerformLayout();
            this.panelArred1.ResumeLayout(false);
            this.panelArred1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_QR)).EndInit();
            this.panelArred3.ResumeLayout(false);
            this.panelArred3.PerformLayout();
            this.panelArredondado3.ResumeLayout(false);
            this.panelArredondado3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_req;
        private System.Windows.Forms.Label lbl_prof;
        private System.Windows.Forms.Label lbl_op_trabalho;
        private System.Windows.Forms.Label lbl_aprender;
        private System.Windows.Forms.Label lbl_preco;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Label lbl_tp_curso;
        private System.Windows.Forms.Label lbl_modalidade;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_NomeMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private PanelArredondado panelArredondado3;
        private System.Windows.Forms.Panel panel2;
        private PanelArred panelArred1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private PanelArred panelArred3;
        private PanelArred panelArred4;
        private System.Windows.Forms.PictureBox pic_QR;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private System.Windows.Forms.Button btn_back;
    }
}