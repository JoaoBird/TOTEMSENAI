using System.Windows.Forms;

namespace teste
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelArred1 = new teste.PanelArred();
            this.label2 = new System.Windows.Forms.Label();
            this.panelArred2 = new teste.PanelArred();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelArred3 = new teste.PanelArred();
            this.panelArred4 = new teste.PanelArred();
            this.panel1.SuspendLayout();
            this.panelArred3.SuspendLayout();
            this.panelArred4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(195, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panelArred1
            // 
            this.panelArred1.BackColor = System.Drawing.Color.White;
            this.panelArred1.BackgroundImage = global::teste.Properties.Resources.lucas;
            this.panelArred1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelArred1.BorderRadius = 30;
            this.panelArred1.ForeColor = System.Drawing.Color.Black;
            this.panelArred1.Location = new System.Drawing.Point(46, 105);
            this.panelArred1.Name = "panelArred1";
            this.panelArred1.Size = new System.Drawing.Size(411, 534);
            this.panelArred1.TabIndex = 5;
            this.panelArred1.Click += new System.EventHandler(this.panelArred1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cursos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // panelArred2
            // 
            this.panelArred2.BackColor = System.Drawing.Color.White;
            this.panelArred2.BackgroundImage = global::teste.Properties.Resources._84d2a5a7_02e7_497b_bae3_04e4a9af7352;
            this.panelArred2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelArred2.BorderRadius = 30;
            this.panelArred2.ForeColor = System.Drawing.Color.Black;
            this.panelArred2.Location = new System.Drawing.Point(46, 105);
            this.panelArred2.Name = "panelArred2";
            this.panelArred2.Size = new System.Drawing.Size(411, 534);
            this.panelArred2.TabIndex = 6;
            this.panelArred2.Click += new System.EventHandler(this.panelArred2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 41);
            this.label3.TabIndex = 0;
            this.label3.Text = "Laboratórios";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            this.label3.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1904, 75);
            this.panel1.TabIndex = 4;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_close.BackgroundImage")));
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(1872, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(20, 20);
            this.btn_close.TabIndex = 2;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.button1_Click);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(264, 972);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Home";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panelArred3
            // 
            this.panelArred3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelArred3.BorderRadius = 30;
            this.panelArred3.Controls.Add(this.textBox1);
            this.panelArred3.Controls.Add(this.panelArred1);
            this.panelArred3.Controls.Add(this.label2);
            this.panelArred3.ForeColor = System.Drawing.Color.Black;
            this.panelArred3.Location = new System.Drawing.Point(359, 193);
            this.panelArred3.Name = "panelArred3";
            this.panelArred3.Size = new System.Drawing.Size(504, 678);
            this.panelArred3.TabIndex = 5;
            // 
            // panelArred4
            // 
            this.panelArred4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelArred4.BorderRadius = 30;
            this.panelArred4.Controls.Add(this.panelArred2);
            this.panelArred4.Controls.Add(this.label3);
            this.panelArred4.ForeColor = System.Drawing.Color.Black;
            this.panelArred4.Location = new System.Drawing.Point(1041, 193);
            this.panelArred4.Name = "panelArred4";
            this.panelArred4.Size = new System.Drawing.Size(504, 678);
            this.panelArred4.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1061);
            this.Controls.Add(this.panelArred4);
            this.Controls.Add(this.panelArred3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelArred3.ResumeLayout(false);
            this.panelArred3.PerformLayout();
            this.panelArred4.ResumeLayout(false);
            this.panelArred4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private Button btn_close;
        private Label label4;
        private PanelArred panelArred1;
        private PanelArred panelArred2;
        private TextBox textBox1;
        private PanelArred panelArred3;
        private PanelArred panelArred4;
    }
}

