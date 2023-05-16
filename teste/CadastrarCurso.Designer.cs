namespace teste
{
    partial class CadastrarCurso
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
            this.lbl_cadastrar = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_requisitos = new System.Windows.Forms.Label();
            this.lbl_profissao = new System.Windows.Forms.Label();
            this.lbl_op_trabalho = new System.Windows.Forms.Label();
            this.lbl_aprender = new System.Windows.Forms.Label();
            this.lbl_preco = new System.Windows.Forms.Label();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.lbl_tipo_curso = new System.Windows.Forms.Label();
            this.lbl_modalidade = new System.Windows.Forms.Label();
            this.box_tp = new System.Windows.Forms.ComboBox();
            this.box_modalidade = new System.Windows.Forms.ComboBox();
            this.box_nome = new System.Windows.Forms.TextBox();
            this.box_requisitos = new System.Windows.Forms.TextBox();
            this.box_preco = new System.Windows.Forms.TextBox();
            this.box_carga_horaria = new System.Windows.Forms.TextBox();
            this.box_profissao = new System.Windows.Forms.TextBox();
            this.box_op = new System.Windows.Forms.TextBox();
            this.box_oq_aprender = new System.Windows.Forms.TextBox();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.lbl_url = new System.Windows.Forms.Label();
            this.box_url = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 74);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_cadastrar
            // 
            this.lbl_cadastrar.AutoSize = true;
            this.lbl_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cadastrar.ForeColor = System.Drawing.Color.White;
            this.lbl_cadastrar.Location = new System.Drawing.Point(391, 37);
            this.lbl_cadastrar.Name = "lbl_cadastrar";
            this.lbl_cadastrar.Size = new System.Drawing.Size(119, 16);
            this.lbl_cadastrar.TabIndex = 8;
            this.lbl_cadastrar.Text = "Cadastrar Curso";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(106, 108);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(80, 13);
            this.lbl_nome.TabIndex = 9;
            this.lbl_nome.Text = "Nome do Curso";
            // 
            // lbl_requisitos
            // 
            this.lbl_requisitos.AutoSize = true;
            this.lbl_requisitos.Location = new System.Drawing.Point(106, 175);
            this.lbl_requisitos.Name = "lbl_requisitos";
            this.lbl_requisitos.Size = new System.Drawing.Size(56, 13);
            this.lbl_requisitos.TabIndex = 10;
            this.lbl_requisitos.Text = "Requisitos";
            // 
            // lbl_profissao
            // 
            this.lbl_profissao.AutoSize = true;
            this.lbl_profissao.Location = new System.Drawing.Point(107, 332);
            this.lbl_profissao.Name = "lbl_profissao";
            this.lbl_profissao.Size = new System.Drawing.Size(50, 13);
            this.lbl_profissao.TabIndex = 11;
            this.lbl_profissao.Text = "Profissao";
            // 
            // lbl_op_trabalho
            // 
            this.lbl_op_trabalho.AutoSize = true;
            this.lbl_op_trabalho.Location = new System.Drawing.Point(556, 101);
            this.lbl_op_trabalho.Name = "lbl_op_trabalho";
            this.lbl_op_trabalho.Size = new System.Drawing.Size(136, 13);
            this.lbl_op_trabalho.TabIndex = 12;
            this.lbl_op_trabalho.Text = "Oportunidades de Trabalho";
            // 
            // lbl_aprender
            // 
            this.lbl_aprender.AutoSize = true;
            this.lbl_aprender.Location = new System.Drawing.Point(594, 329);
            this.lbl_aprender.Name = "lbl_aprender";
            this.lbl_aprender.Size = new System.Drawing.Size(98, 13);
            this.lbl_aprender.TabIndex = 13;
            this.lbl_aprender.Text = "O que vai aprender";
            // 
            // lbl_preco
            // 
            this.lbl_preco.AutoSize = true;
            this.lbl_preco.Location = new System.Drawing.Point(107, 531);
            this.lbl_preco.Name = "lbl_preco";
            this.lbl_preco.Size = new System.Drawing.Size(35, 13);
            this.lbl_preco.TabIndex = 14;
            this.lbl_preco.Text = "Preço";
            // 
            // lbl_hora
            // 
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.Location = new System.Drawing.Point(106, 586);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(72, 13);
            this.lbl_hora.TabIndex = 15;
            this.lbl_hora.Text = "Carga Horaria";
            // 
            // lbl_tipo_curso
            // 
            this.lbl_tipo_curso.AutoSize = true;
            this.lbl_tipo_curso.Location = new System.Drawing.Point(594, 531);
            this.lbl_tipo_curso.Name = "lbl_tipo_curso";
            this.lbl_tipo_curso.Size = new System.Drawing.Size(72, 13);
            this.lbl_tipo_curso.TabIndex = 16;
            this.lbl_tipo_curso.Text = "Tipo do curso";
            // 
            // lbl_modalidade
            // 
            this.lbl_modalidade.AutoSize = true;
            this.lbl_modalidade.Location = new System.Drawing.Point(594, 586);
            this.lbl_modalidade.Name = "lbl_modalidade";
            this.lbl_modalidade.Size = new System.Drawing.Size(62, 13);
            this.lbl_modalidade.TabIndex = 17;
            this.lbl_modalidade.Text = "Modalidade";
            // 
            // box_tp
            // 
            this.box_tp.FormattingEnabled = true;
            this.box_tp.Location = new System.Drawing.Point(721, 523);
            this.box_tp.Name = "box_tp";
            this.box_tp.Size = new System.Drawing.Size(198, 21);
            this.box_tp.TabIndex = 18;
            // 
            // box_modalidade
            // 
            this.box_modalidade.FormattingEnabled = true;
            this.box_modalidade.Location = new System.Drawing.Point(721, 583);
            this.box_modalidade.Name = "box_modalidade";
            this.box_modalidade.Size = new System.Drawing.Size(198, 21);
            this.box_modalidade.TabIndex = 19;
            // 
            // box_nome
            // 
            this.box_nome.Location = new System.Drawing.Point(227, 101);
            this.box_nome.Name = "box_nome";
            this.box_nome.Size = new System.Drawing.Size(236, 20);
            this.box_nome.TabIndex = 20;
            // 
            // box_requisitos
            // 
            this.box_requisitos.Location = new System.Drawing.Point(227, 168);
            this.box_requisitos.Multiline = true;
            this.box_requisitos.Name = "box_requisitos";
            this.box_requisitos.Size = new System.Drawing.Size(236, 110);
            this.box_requisitos.TabIndex = 21;
            // 
            // box_preco
            // 
            this.box_preco.Location = new System.Drawing.Point(227, 524);
            this.box_preco.Name = "box_preco";
            this.box_preco.Size = new System.Drawing.Size(198, 20);
            this.box_preco.TabIndex = 22;
            // 
            // box_carga_horaria
            // 
            this.box_carga_horaria.Location = new System.Drawing.Point(227, 579);
            this.box_carga_horaria.Name = "box_carga_horaria";
            this.box_carga_horaria.Size = new System.Drawing.Size(198, 20);
            this.box_carga_horaria.TabIndex = 23;
            // 
            // box_profissao
            // 
            this.box_profissao.Location = new System.Drawing.Point(227, 329);
            this.box_profissao.Multiline = true;
            this.box_profissao.Name = "box_profissao";
            this.box_profissao.Size = new System.Drawing.Size(236, 142);
            this.box_profissao.TabIndex = 24;
            // 
            // box_op
            // 
            this.box_op.Location = new System.Drawing.Point(721, 101);
            this.box_op.Multiline = true;
            this.box_op.Name = "box_op";
            this.box_op.Size = new System.Drawing.Size(258, 142);
            this.box_op.TabIndex = 25;
            // 
            // box_oq_aprender
            // 
            this.box_oq_aprender.Location = new System.Drawing.Point(721, 329);
            this.box_oq_aprender.Multiline = true;
            this.box_oq_aprender.Name = "box_oq_aprender";
            this.box_oq_aprender.Size = new System.Drawing.Size(258, 142);
            this.box_oq_aprender.TabIndex = 26;
            // 
            // btn_enviar
            // 
            this.btn_enviar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_enviar.FlatAppearance.BorderSize = 0;
            this.btn_enviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_enviar.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enviar.ForeColor = System.Drawing.Color.White;
            this.btn_enviar.Location = new System.Drawing.Point(503, 634);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(89, 35);
            this.btn_enviar.TabIndex = 27;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = false;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // lbl_url
            // 
            this.lbl_url.AutoSize = true;
            this.lbl_url.Location = new System.Drawing.Point(107, 634);
            this.lbl_url.Name = "lbl_url";
            this.lbl_url.Size = new System.Drawing.Size(74, 13);
            this.lbl_url.TabIndex = 28;
            this.lbl_url.Text = "URL do Curso";
            // 
            // box_url
            // 
            this.box_url.Location = new System.Drawing.Point(227, 627);
            this.box_url.Name = "box_url";
            this.box_url.Size = new System.Drawing.Size(198, 20);
            this.box_url.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.lbl_cadastrar);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1064, 74);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = global::teste.Properties.Resources.botao_de_retorno;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1007, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(252, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 16);
            this.label12.TabIndex = 3;
            this.label12.Text = "Administrador";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            this.label12.MouseEnter += new System.EventHandler(this.label12_MouseEnter);
            this.label12.MouseLeave += new System.EventHandler(this.label12_MouseLeave);
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
            this.label10.MouseEnter += new System.EventHandler(this.label10_MouseEnter);
            this.label10.MouseLeave += new System.EventHandler(this.label10_MouseLeave);
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            // CadastrarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.box_url);
            this.Controls.Add(this.lbl_url);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.box_oq_aprender);
            this.Controls.Add(this.box_op);
            this.Controls.Add(this.box_profissao);
            this.Controls.Add(this.box_carga_horaria);
            this.Controls.Add(this.box_preco);
            this.Controls.Add(this.box_requisitos);
            this.Controls.Add(this.box_nome);
            this.Controls.Add(this.box_modalidade);
            this.Controls.Add(this.box_tp);
            this.Controls.Add(this.lbl_modalidade);
            this.Controls.Add(this.lbl_tipo_curso);
            this.Controls.Add(this.lbl_hora);
            this.Controls.Add(this.lbl_preco);
            this.Controls.Add(this.lbl_aprender);
            this.Controls.Add(this.lbl_op_trabalho);
            this.Controls.Add(this.lbl_profissao);
            this.Controls.Add(this.lbl_requisitos);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.panel1);
            this.Name = "CadastrarCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastrarCurso";
            this.Load += new System.EventHandler(this.CadastrarCurso_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_cadastrar;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_requisitos;
        private System.Windows.Forms.Label lbl_profissao;
        private System.Windows.Forms.Label lbl_op_trabalho;
        private System.Windows.Forms.Label lbl_aprender;
        private System.Windows.Forms.Label lbl_preco;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Label lbl_tipo_curso;
        private System.Windows.Forms.Label lbl_modalidade;
        private System.Windows.Forms.ComboBox box_tp;
        private System.Windows.Forms.ComboBox box_modalidade;
        private System.Windows.Forms.TextBox box_nome;
        private System.Windows.Forms.TextBox box_requisitos;
        private System.Windows.Forms.TextBox box_preco;
        private System.Windows.Forms.TextBox box_carga_horaria;
        private System.Windows.Forms.TextBox box_profissao;
        private System.Windows.Forms.TextBox box_op;
        private System.Windows.Forms.TextBox box_oq_aprender;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.Label lbl_url;
        private System.Windows.Forms.TextBox box_url;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
    }
}