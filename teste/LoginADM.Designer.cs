﻿namespace teste
{
    partial class LoginADM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginADM));
            this.btn_entrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.btn_ALT = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelArred1 = new teste.PanelArred();
            this.btn_n_vis = new System.Windows.Forms.Button();
            this.btn_vis = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.box_senha = new System.Windows.Forms.TextBox();
            this.lbl_login = new System.Windows.Forms.Label();
            this.box_login = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelArred1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_entrar
            // 
            this.btn_entrar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_entrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_entrar.FlatAppearance.BorderSize = 10;
            this.btn_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrar.ForeColor = System.Drawing.Color.White;
            this.btn_entrar.Location = new System.Drawing.Point(200, 380);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(92, 38);
            this.btn_entrar.TabIndex = 4;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = false;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 76);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_back);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(478, 76);
            this.panel2.TabIndex = 10;
            // 
            // btn_back
            // 
            this.btn_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_back.BackgroundImage = global::teste.Properties.Resources.botao_de_retorno;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Location = new System.Drawing.Point(419, 17);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(40, 40);
            this.btn_back.TabIndex = 4;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
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
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(246, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 16);
            this.label12.TabIndex = 3;
            this.label12.Text = "Login";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.label10.Location = new System.Drawing.Point(166, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Home";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            this.label10.MouseEnter += new System.EventHandler(this.label10_MouseEnter);
            this.label10.MouseLeave += new System.EventHandler(this.label10_MouseLeave);
            // 
            // btn_enviar
            // 
            this.btn_enviar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_enviar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_enviar.FlatAppearance.BorderSize = 10;
            this.btn_enviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enviar.ForeColor = System.Drawing.Color.White;
            this.btn_enviar.Location = new System.Drawing.Point(200, 380);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(92, 38);
            this.btn_enviar.TabIndex = 7;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = false;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // btn_ALT
            // 
            this.btn_ALT.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_ALT.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_ALT.FlatAppearance.BorderSize = 10;
            this.btn_ALT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ALT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ALT.ForeColor = System.Drawing.Color.White;
            this.btn_ALT.Location = new System.Drawing.Point(200, 380);
            this.btn_ALT.Name = "btn_ALT";
            this.btn_ALT.Size = new System.Drawing.Size(92, 38);
            this.btn_ALT.TabIndex = 8;
            this.btn_ALT.Text = "Alterar";
            this.btn_ALT.UseVisualStyleBackColor = false;
            this.btn_ALT.Visible = false;
            this.btn_ALT.Click += new System.EventHandler(this.btn_ALT_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 10;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(147, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 38);
            this.button1.TabIndex = 9;
            this.button1.Text = "Enviar codigo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelArred1
            // 
            this.panelArred1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelArred1.BorderRadius = 30;
            this.panelArred1.Controls.Add(this.btn_n_vis);
            this.panelArred1.Controls.Add(this.btn_vis);
            this.panelArred1.Controls.Add(this.label3);
            this.panelArred1.Controls.Add(this.label2);
            this.panelArred1.Controls.Add(this.lbl_senha);
            this.panelArred1.Controls.Add(this.box_senha);
            this.panelArred1.Controls.Add(this.lbl_login);
            this.panelArred1.Controls.Add(this.box_login);
            this.panelArred1.ForeColor = System.Drawing.Color.Black;
            this.panelArred1.Location = new System.Drawing.Point(64, 120);
            this.panelArred1.Name = "panelArred1";
            this.panelArred1.Size = new System.Drawing.Size(365, 241);
            this.panelArred1.TabIndex = 6;
            // 
            // btn_n_vis
            // 
            this.btn_n_vis.BackColor = System.Drawing.Color.White;
            this.btn_n_vis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_n_vis.Location = new System.Drawing.Point(279, 148);
            this.btn_n_vis.Name = "btn_n_vis";
            this.btn_n_vis.Size = new System.Drawing.Size(29, 26);
            this.btn_n_vis.TabIndex = 10;
            this.btn_n_vis.Text = "●";
            this.btn_n_vis.UseVisualStyleBackColor = false;
            this.btn_n_vis.Click += new System.EventHandler(this.btn_n_vis_Click);
            // 
            // btn_vis
            // 
            this.btn_vis.BackColor = System.Drawing.Color.White;
            this.btn_vis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_vis.Location = new System.Drawing.Point(279, 148);
            this.btn_vis.Name = "btn_vis";
            this.btn_vis.Size = new System.Drawing.Size(29, 26);
            this.btn_vis.TabIndex = 6;
            this.btn_vis.Text = "○";
            this.btn_vis.UseVisualStyleBackColor = false;
            this.btn_vis.Click += new System.EventHandler(this.btn_vis_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(79, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Insira o codigo enviado";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(79, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Esqueci minha senha";
            this.label2.DoubleClick += new System.EventHandler(this.label2_DoubleClick);
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senha.ForeColor = System.Drawing.Color.White;
            this.lbl_senha.Location = new System.Drawing.Point(34, 154);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(61, 20);
            this.lbl_senha.TabIndex = 1;
            this.lbl_senha.Text = "Senha";
            // 
            // box_senha
            // 
            this.box_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_senha.Location = new System.Drawing.Point(137, 148);
            this.box_senha.Name = "box_senha";
            this.box_senha.PasswordChar = '●';
            this.box_senha.Size = new System.Drawing.Size(171, 26);
            this.box_senha.TabIndex = 3;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.ForeColor = System.Drawing.Color.White;
            this.lbl_login.Location = new System.Drawing.Point(34, 68);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(53, 20);
            this.lbl_login.TabIndex = 0;
            this.lbl_login.Text = "Login";
            // 
            // box_login
            // 
            this.box_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_login.Location = new System.Drawing.Point(137, 62);
            this.box_login.Name = "box_login";
            this.box_login.Size = new System.Drawing.Size(171, 26);
            this.box_login.TabIndex = 2;
            // 
            // LoginADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 514);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_ALT);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.panelArred1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_entrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginADM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginADM";
            this.Load += new System.EventHandler(this.LoginADM_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelArred1.ResumeLayout(false);
            this.panelArred1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.TextBox box_login;
        private System.Windows.Forms.TextBox box_senha;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private PanelArred panelArred1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ALT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_vis;
        private System.Windows.Forms.Button btn_n_vis;
    }
}