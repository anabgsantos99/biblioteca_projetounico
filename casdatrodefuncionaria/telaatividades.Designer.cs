namespace telaatividades
{
    partial class frmTeladeAtividade
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
            this.panelTopo_TeladeAtividades = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnTelaCadastrodeAtividades = new System.Windows.Forms.Button();
            this.lblBibliotecaSenac = new System.Windows.Forms.Label();
            this.lstAtividades = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAlterarStatus = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.panelTopo_TeladeAtividades.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopo_TeladeAtividades
            // 
            this.panelTopo_TeladeAtividades.BackColor = System.Drawing.Color.White;
            this.panelTopo_TeladeAtividades.Controls.Add(this.btnSair);
            this.panelTopo_TeladeAtividades.Controls.Add(this.btnTelaCadastrodeAtividades);
            this.panelTopo_TeladeAtividades.Controls.Add(this.lblBibliotecaSenac);
            this.panelTopo_TeladeAtividades.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopo_TeladeAtividades.Location = new System.Drawing.Point(0, 0);
            this.panelTopo_TeladeAtividades.Name = "panelTopo_TeladeAtividades";
            this.panelTopo_TeladeAtividades.Size = new System.Drawing.Size(1604, 37);
            this.panelTopo_TeladeAtividades.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Image = global::casdatrodefuncionaria.Properties.Resources.logout_24dp_F7941D_FILL0_wght400_GRAD0_opsz24;
            this.btnSair.Location = new System.Drawing.Point(1560, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(41, 31);
            this.btnSair.TabIndex = 5;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnTelaCadastrodeAtividades
            // 
            this.btnTelaCadastrodeAtividades.BackColor = System.Drawing.Color.White;
            this.btnTelaCadastrodeAtividades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTelaCadastrodeAtividades.ForeColor = System.Drawing.Color.White;
            this.btnTelaCadastrodeAtividades.Image = global::casdatrodefuncionaria.Properties.Resources.add_task_24dp_F7941D_FILL0_wght400_GRAD0_opsz48;
            this.btnTelaCadastrodeAtividades.Location = new System.Drawing.Point(3, 3);
            this.btnTelaCadastrodeAtividades.Name = "btnTelaCadastrodeAtividades";
            this.btnTelaCadastrodeAtividades.Size = new System.Drawing.Size(41, 31);
            this.btnTelaCadastrodeAtividades.TabIndex = 4;
            this.btnTelaCadastrodeAtividades.UseVisualStyleBackColor = false;
            this.btnTelaCadastrodeAtividades.Click += new System.EventHandler(this.btnTelaCadastrodeAtividades_Click);
            // 
            // lblBibliotecaSenac
            // 
            this.lblBibliotecaSenac.AutoSize = true;
            this.lblBibliotecaSenac.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBibliotecaSenac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(141)))));
            this.lblBibliotecaSenac.Location = new System.Drawing.Point(1291, 9);
            this.lblBibliotecaSenac.Name = "lblBibliotecaSenac";
            this.lblBibliotecaSenac.Size = new System.Drawing.Size(263, 18);
            this.lblBibliotecaSenac.TabIndex = 1;
            this.lblBibliotecaSenac.Text = "BIBLIOTECA SENAC LARGO TREZE";
            // 
            // lstAtividades
            // 
            this.lstAtividades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(193)))), ((int)(((byte)(128)))));
            this.lstAtividades.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAtividades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(141)))));
            this.lstAtividades.HideSelection = false;
            this.lstAtividades.LabelEdit = true;
            this.lstAtividades.Location = new System.Drawing.Point(58, 195);
            this.lstAtividades.Name = "lstAtividades";
            this.lstAtividades.Size = new System.Drawing.Size(1487, 512);
            this.lstAtividades.TabIndex = 2;
            this.lstAtividades.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 40);
            this.label1.TabIndex = 14;
            this.label1.Text = "Atividades";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(193)))), ((int)(((byte)(128)))));
            this.txtBuscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(58, 151);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(180, 26);
            this.txtBuscar.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(54, 739);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(413, 40);
            this.label3.TabIndex = 18;
            this.label3.Text = "Selecione linha e aperte botão ao lado para: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(677, 740);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 40);
            this.label2.TabIndex = 19;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAlterarStatus
            // 
            this.btnAlterarStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(141)))));
            this.btnAlterarStatus.FlatAppearance.BorderSize = 0;
            this.btnAlterarStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarStatus.ForeColor = System.Drawing.Color.White;
            this.btnAlterarStatus.Image = global::casdatrodefuncionaria.Properties.Resources.switch_camera;
            this.btnAlterarStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarStatus.Location = new System.Drawing.Point(1398, 740);
            this.btnAlterarStatus.Name = "btnAlterarStatus";
            this.btnAlterarStatus.Size = new System.Drawing.Size(146, 38);
            this.btnAlterarStatus.TabIndex = 27;
            this.btnAlterarStatus.Text = "Alterar Status";
            this.btnAlterarStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAlterarStatus.UseVisualStyleBackColor = false;
            this.btnAlterarStatus.Click += new System.EventHandler(this.btnAlterarStatus_Click_1);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(141)))));
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Image = global::casdatrodefuncionaria.Properties.Resources.delete_forever_24dp_FFFFFF_FILL0_wght400_GRAD0_opsz48;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExcluir.Location = new System.Drawing.Point(1016, 740);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(146, 38);
            this.btnExcluir.TabIndex = 26;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(141)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Image = global::casdatrodefuncionaria.Properties.Resources.edit_note_24dp_FFFFFF_FILL0_wght400_GRAD0_opsz48;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(634, 740);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(146, 38);
            this.btnEditar.TabIndex = 25;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(193)))), ((int)(((byte)(128)))));
            this.btnPesquisar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(193)))), ((int)(((byte)(128)))));
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(141)))));
            this.btnPesquisar.Image = global::casdatrodefuncionaria.Properties.Resources.search_24dp_004A8D_FILL0_wght400_GRAD0_opsz48;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.Location = new System.Drawing.Point(260, 151);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(180, 26);
            this.btnPesquisar.TabIndex = 16;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // frmTeladeAtividade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(1604, 861);
            this.Controls.Add(this.btnAlterarStatus);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstAtividades);
            this.Controls.Add(this.panelTopo_TeladeAtividades);
            this.MaximizeBox = false;
            this.Name = "frmTeladeAtividade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atividades";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTeladeAtividade_FormClosed);
            this.panelTopo_TeladeAtividades.ResumeLayout(false);
            this.panelTopo_TeladeAtividades.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTopo_TeladeAtividades;
        private System.Windows.Forms.Label lblBibliotecaSenac;
        private System.Windows.Forms.ListView lstAtividades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterarStatus;
        private System.Windows.Forms.Button btnTelaCadastrodeAtividades;
        private System.Windows.Forms.Button btnSair;
    }
}

