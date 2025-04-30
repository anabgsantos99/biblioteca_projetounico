
namespace casdatrodefuncionaria
{
    partial class frmPerguntadeSeguranca
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
            this.txtResposta = new System.Windows.Forms.TextBox();
            this.btnRedefinirSenha = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.LinkLabel();
            this.pbPergunta = new System.Windows.Forms.PictureBox();
            this.lblPerguntadeSeguranca = new System.Windows.Forms.Label();
            this.txtDigiteSeuEmail = new System.Windows.Forms.TextBox();
            this.comboBoxPerguntaSeguranca = new System.Windows.Forms.ComboBox();
            this.panelFundo = new System.Windows.Forms.Panel();
            this.pbResposta = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPergunta)).BeginInit();
            this.panelFundo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResposta)).BeginInit();
            this.SuspendLayout();
            // 
            // txtResposta
            // 
            this.txtResposta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtResposta.BackColor = System.Drawing.Color.White;
            this.txtResposta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResposta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtResposta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(141)))));
            this.txtResposta.Location = new System.Drawing.Point(606, 520);
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.Size = new System.Drawing.Size(393, 19);
            this.txtResposta.TabIndex = 2;
            this.txtResposta.Text = "Resposta";
            this.txtResposta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtResposta.Click += new System.EventHandler(this.txtResposta_Click);
            // 
            // btnRedefinirSenha
            // 
            this.btnRedefinirSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRedefinirSenha.BackColor = System.Drawing.Color.Transparent;
            this.btnRedefinirSenha.FlatAppearance.BorderSize = 0;
            this.btnRedefinirSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedefinirSenha.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.btnRedefinirSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.btnRedefinirSenha.Location = new System.Drawing.Point(689, 641);
            this.btnRedefinirSenha.Name = "btnRedefinirSenha";
            this.btnRedefinirSenha.Size = new System.Drawing.Size(226, 40);
            this.btnRedefinirSenha.TabIndex = 6;
            this.btnRedefinirSenha.Text = "Redefinir Senha";
            this.btnRedefinirSenha.UseVisualStyleBackColor = false;
            this.btnRedefinirSenha.Click += new System.EventHandler(this.btnRedefinirSenha_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(141)))));
            this.lblLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.LinkColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(779, 709);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(47, 18);
            this.lblLogin.TabIndex = 11;
            this.lblLogin.TabStop = true;
            this.lblLogin.Text = "Login";
            this.lblLogin.VisitedLinkColor = System.Drawing.Color.White;
            this.lblLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLogin_LinkClicked);
            // 
            // pbPergunta
            // 
            this.pbPergunta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbPergunta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPergunta.Image = global::casdatrodefuncionaria.Properties.Resources.icone_pergunta;
            this.pbPergunta.Location = new System.Drawing.Point(606, 438);
            this.pbPergunta.Name = "pbPergunta";
            this.pbPergunta.Size = new System.Drawing.Size(41, 37);
            this.pbPergunta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPergunta.TabIndex = 12;
            this.pbPergunta.TabStop = false;
            // 
            // lblPerguntadeSeguranca
            // 
            this.lblPerguntadeSeguranca.AutoSize = true;
            this.lblPerguntadeSeguranca.BackColor = System.Drawing.Color.Transparent;
            this.lblPerguntadeSeguranca.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lblPerguntadeSeguranca.ForeColor = System.Drawing.Color.White;
            this.lblPerguntadeSeguranca.Location = new System.Drawing.Point(618, 289);
            this.lblPerguntadeSeguranca.Name = "lblPerguntadeSeguranca";
            this.lblPerguntadeSeguranca.Size = new System.Drawing.Size(369, 37);
            this.lblPerguntadeSeguranca.TabIndex = 14;
            this.lblPerguntadeSeguranca.Text = "Pergunta de segurança";
            // 
            // txtDigiteSeuEmail
            // 
            this.txtDigiteSeuEmail.BackColor = System.Drawing.Color.White;
            this.txtDigiteSeuEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDigiteSeuEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtDigiteSeuEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(141)))));
            this.txtDigiteSeuEmail.Location = new System.Drawing.Point(593, 395);
            this.txtDigiteSeuEmail.Name = "txtDigiteSeuEmail";
            this.txtDigiteSeuEmail.Size = new System.Drawing.Size(417, 19);
            this.txtDigiteSeuEmail.TabIndex = 0;
            this.txtDigiteSeuEmail.Text = "Digite seu e-mail";
            this.txtDigiteSeuEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDigiteSeuEmail.Click += new System.EventHandler(this.txtDigiteSeuEmail_Click);
            // 
            // comboBoxPerguntaSeguranca
            // 
            this.comboBoxPerguntaSeguranca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxPerguntaSeguranca.BackColor = System.Drawing.Color.White;
            this.comboBoxPerguntaSeguranca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPerguntaSeguranca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPerguntaSeguranca.Font = new System.Drawing.Font("Arial", 12F);
            this.comboBoxPerguntaSeguranca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(141)))));
            this.comboBoxPerguntaSeguranca.FormattingEnabled = true;
            this.comboBoxPerguntaSeguranca.Items.AddRange(new object[] {
            "Sua comida favorita?",
            "Nome do seu primeiro animal de estimação?",
            "Seu emprego dos sonhos?",
            "Nome da cidade em que você nasceu?",
            "Nome do seu melhor amigo na infância?"});
            this.comboBoxPerguntaSeguranca.Location = new System.Drawing.Point(653, 443);
            this.comboBoxPerguntaSeguranca.Name = "comboBoxPerguntaSeguranca";
            this.comboBoxPerguntaSeguranca.Size = new System.Drawing.Size(346, 26);
            this.comboBoxPerguntaSeguranca.TabIndex = 1;
            // 
            // panelFundo
            // 
            this.panelFundo.BackgroundImage = global::casdatrodefuncionaria.Properties.Resources.Tela_de_Login__3_;
            this.panelFundo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelFundo.Controls.Add(this.pbResposta);
            this.panelFundo.Controls.Add(this.txtDigiteSeuEmail);
            this.panelFundo.Controls.Add(this.comboBoxPerguntaSeguranca);
            this.panelFundo.Controls.Add(this.txtResposta);
            this.panelFundo.Controls.Add(this.btnRedefinirSenha);
            this.panelFundo.Controls.Add(this.lblPerguntadeSeguranca);
            this.panelFundo.Controls.Add(this.pbPergunta);
            this.panelFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFundo.Location = new System.Drawing.Point(0, 0);
            this.panelFundo.Name = "panelFundo";
            this.panelFundo.Size = new System.Drawing.Size(1604, 861);
            this.panelFundo.TabIndex = 17;
            // 
            // pbResposta
            // 
            this.pbResposta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbResposta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbResposta.Image = global::casdatrodefuncionaria.Properties.Resources.icone_pergunta;
            this.pbResposta.Location = new System.Drawing.Point(606, 510);
            this.pbResposta.Name = "pbResposta";
            this.pbResposta.Size = new System.Drawing.Size(41, 37);
            this.pbResposta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbResposta.TabIndex = 17;
            this.pbResposta.TabStop = false;
            // 
            // frmPerguntadeSeguranca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1604, 861);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.panelFundo);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "frmPerguntadeSeguranca";
            this.Text = "Redefinir Senha";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbPergunta)).EndInit();
            this.panelFundo.ResumeLayout(false);
            this.panelFundo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResposta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtResposta;
        private System.Windows.Forms.Button btnRedefinirSenha;
        private System.Windows.Forms.LinkLabel lblLogin;
        private System.Windows.Forms.PictureBox pbPergunta;
        private System.Windows.Forms.Label lblPerguntadeSeguranca;
        private System.Windows.Forms.TextBox txtDigiteSeuEmail;
        private System.Windows.Forms.ComboBox comboBoxPerguntaSeguranca;
        private System.Windows.Forms.Panel panelFundo;
        private System.Windows.Forms.PictureBox pbResposta;
    }
}