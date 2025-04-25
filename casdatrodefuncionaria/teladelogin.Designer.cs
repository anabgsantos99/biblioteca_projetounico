
namespace teladelogin
{
    partial class frmTeladeLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCriarConta = new System.Windows.Forms.LinkLabel();
            this.pbSenha = new System.Windows.Forms.PictureBox();
            this.lblBoasvindas = new System.Windows.Forms.Label();
            this.pbUsuario = new System.Windows.Forms.PictureBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblEsqueciasenha = new System.Windows.Forms.LinkLabel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.rbLembreme = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::casdatrodefuncionaria.Properties.Resources.Tela_de_Login__2_;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblCriarConta);
            this.panel1.Controls.Add(this.pbSenha);
            this.panel1.Controls.Add(this.lblBoasvindas);
            this.panel1.Controls.Add(this.pbUsuario);
            this.panel1.Controls.Add(this.lblLogin);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.lblEsqueciasenha);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtSenha);
            this.panel1.Controls.Add(this.rbLembreme);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1604, 861);
            this.panel1.TabIndex = 0;
            // 
            // lblCriarConta
            // 
            this.lblCriarConta.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.lblCriarConta.AutoSize = true;
            this.lblCriarConta.BackColor = System.Drawing.Color.Transparent;
            this.lblCriarConta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriarConta.LinkColor = System.Drawing.Color.White;
            this.lblCriarConta.Location = new System.Drawing.Point(446, 726);
            this.lblCriarConta.Name = "lblCriarConta";
            this.lblCriarConta.Size = new System.Drawing.Size(89, 18);
            this.lblCriarConta.TabIndex = 10;
            this.lblCriarConta.TabStop = true;
            this.lblCriarConta.Text = "Criar Conta";
            this.lblCriarConta.VisitedLinkColor = System.Drawing.Color.White;
            this.lblCriarConta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCriarConta_LinkClicked);
            // 
            // pbSenha
            // 
            this.pbSenha.BackColor = System.Drawing.Color.White;
            this.pbSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSenha.Image = global::casdatrodefuncionaria.Properties.Resources.icone_cadeado;
            this.pbSenha.Location = new System.Drawing.Point(295, 507);
            this.pbSenha.Name = "pbSenha";
            this.pbSenha.Size = new System.Drawing.Size(45, 39);
            this.pbSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSenha.TabIndex = 9;
            this.pbSenha.TabStop = false;
            // 
            // lblBoasvindas
            // 
            this.lblBoasvindas.AutoSize = true;
            this.lblBoasvindas.BackColor = System.Drawing.Color.Transparent;
            this.lblBoasvindas.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoasvindas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(141)))));
            this.lblBoasvindas.Location = new System.Drawing.Point(978, 285);
            this.lblBoasvindas.Name = "lblBoasvindas";
            this.lblBoasvindas.Size = new System.Drawing.Size(314, 55);
            this.lblBoasvindas.TabIndex = 1;
            this.lblBoasvindas.Text = "Boas-vindas!";
            // 
            // pbUsuario
            // 
            this.pbUsuario.BackColor = System.Drawing.Color.White;
            this.pbUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbUsuario.Image = global::casdatrodefuncionaria.Properties.Resources.icone_usuario;
            this.pbUsuario.Location = new System.Drawing.Point(295, 413);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(45, 39);
            this.pbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUsuario.TabIndex = 8;
            this.pbUsuario.TabStop = false;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(436, 294);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(104, 37);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.btnLogin.Location = new System.Drawing.Point(375, 642);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(226, 40);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblEsqueciasenha
            // 
            this.lblEsqueciasenha.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.lblEsqueciasenha.AutoSize = true;
            this.lblEsqueciasenha.BackColor = System.Drawing.Color.Transparent;
            this.lblEsqueciasenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsqueciasenha.LinkColor = System.Drawing.Color.White;
            this.lblEsqueciasenha.Location = new System.Drawing.Point(568, 573);
            this.lblEsqueciasenha.Name = "lblEsqueciasenha";
            this.lblEsqueciasenha.Size = new System.Drawing.Size(124, 18);
            this.lblEsqueciasenha.TabIndex = 6;
            this.lblEsqueciasenha.TabStop = true;
            this.lblEsqueciasenha.Text = "Esqueci a senha";
            this.lblEsqueciasenha.VisitedLinkColor = System.Drawing.Color.White;
            this.lblEsqueciasenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblEsqueciasenha_LinkClicked);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Arial", 16F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(141)))));
            this.txtEmail.Location = new System.Drawing.Point(283, 418);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(409, 25);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Text = "E-mail";
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmail.Click += new System.EventHandler(this.txtEmail_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Arial", 16F);
            this.txtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(141)))));
            this.txtSenha.Location = new System.Drawing.Point(283, 512);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(409, 25);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.Text = "Senha";
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSenha.Click += new System.EventHandler(this.txtSenha_Click);
            // 
            // rbLembreme
            // 
            this.rbLembreme.AutoSize = true;
            this.rbLembreme.BackColor = System.Drawing.Color.Transparent;
            this.rbLembreme.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLembreme.ForeColor = System.Drawing.Color.White;
            this.rbLembreme.Location = new System.Drawing.Point(306, 569);
            this.rbLembreme.Name = "rbLembreme";
            this.rbLembreme.Size = new System.Drawing.Size(107, 22);
            this.rbLembreme.TabIndex = 3;
            this.rbLembreme.TabStop = true;
            this.rbLembreme.Text = "Lembre-me";
            this.rbLembreme.UseVisualStyleBackColor = false;
            this.rbLembreme.CheckedChanged += new System.EventHandler(this.rbLembreme_CheckedChanged);
            // 
            // frmTeladeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 861);
            this.Controls.Add(this.panel1);
            this.Name = "frmTeladeLogin";
            this.Text = "Tela de Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBoasvindas;
        private System.Windows.Forms.PictureBox pbSenha;
        private System.Windows.Forms.PictureBox pbUsuario;
        private System.Windows.Forms.LinkLabel lblEsqueciasenha;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.RadioButton rbLembreme;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.LinkLabel lblCriarConta;
    }
}

