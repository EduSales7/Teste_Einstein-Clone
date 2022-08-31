
namespace tela_inicial_testeEinsten
{
    partial class FrmTelaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTelaPrincipal));
            this.pnlInicial = new System.Windows.Forms.Panel();
            this.lblDescricao3 = new System.Windows.Forms.Label();
            this.lblDescricao2 = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlNiveis = new System.Windows.Forms.Panel();
            this.btnFacil = new System.Windows.Forms.Button();
            this.lblNiveis = new System.Windows.Forms.Label();
            this.pnlInicial.SuspendLayout();
            this.pnlNiveis.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInicial
            // 
            this.pnlInicial.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlInicial.Controls.Add(this.lblDescricao3);
            this.pnlInicial.Controls.Add(this.lblDescricao2);
            this.pnlInicial.Controls.Add(this.lblDescricao);
            this.pnlInicial.Controls.Add(this.lblTitulo);
            this.pnlInicial.Location = new System.Drawing.Point(12, 17);
            this.pnlInicial.Name = "pnlInicial";
            this.pnlInicial.Size = new System.Drawing.Size(1130, 305);
            this.pnlInicial.TabIndex = 0;
            // 
            // lblDescricao3
            // 
            this.lblDescricao3.AutoSize = true;
            this.lblDescricao3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescricao3.ForeColor = System.Drawing.Color.Indigo;
            this.lblDescricao3.Location = new System.Drawing.Point(23, 236);
            this.lblDescricao3.Name = "lblDescricao3";
            this.lblDescricao3.Size = new System.Drawing.Size(831, 37);
            this.lblDescricao3.TabIndex = 3;
            this.lblDescricao3.Text = "Será que você faz parte desse seleto grupo que consegue resolvê-lo?";
            // 
            // lblDescricao2
            // 
            this.lblDescricao2.AutoSize = true;
            this.lblDescricao2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescricao2.ForeColor = System.Drawing.Color.Indigo;
            this.lblDescricao2.Location = new System.Drawing.Point(23, 169);
            this.lblDescricao2.Name = "lblDescricao2";
            this.lblDescricao2.Size = new System.Drawing.Size(682, 37);
            this.lblDescricao2.TabIndex = 2;
            this.lblDescricao2.Text = "98% da população mundial não era capaz de resolvê-lo.";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescricao.ForeColor = System.Drawing.Color.Indigo;
            this.lblDescricao.Location = new System.Drawing.Point(23, 120);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(1067, 37);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "Albert Einstein criou este teste de QI (raciocínio lógico) no século passado e af" +
    "irmou que ";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.Indigo;
            this.lblTitulo.Location = new System.Drawing.Point(23, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(418, 67);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Teste de Einstein";
            // 
            // pnlNiveis
            // 
            this.pnlNiveis.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlNiveis.Controls.Add(this.btnFacil);
            this.pnlNiveis.Controls.Add(this.lblNiveis);
            this.pnlNiveis.Location = new System.Drawing.Point(12, 347);
            this.pnlNiveis.Name = "pnlNiveis";
            this.pnlNiveis.Size = new System.Drawing.Size(1128, 312);
            this.pnlNiveis.TabIndex = 1;
            // 
            // btnFacil
            // 
            this.btnFacil.BackColor = System.Drawing.Color.Indigo;
            this.btnFacil.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFacil.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFacil.Location = new System.Drawing.Point(412, 91);
            this.btnFacil.Name = "btnFacil";
            this.btnFacil.Size = new System.Drawing.Size(293, 141);
            this.btnFacil.TabIndex = 1;
            this.btnFacil.Text = "Iniciar Jogo";
            this.btnFacil.UseVisualStyleBackColor = false;
            this.btnFacil.Click += new System.EventHandler(this.btnFacil_Click);
            // 
            // lblNiveis
            // 
            this.lblNiveis.AutoSize = true;
            this.lblNiveis.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNiveis.ForeColor = System.Drawing.Color.Indigo;
            this.lblNiveis.Location = new System.Drawing.Point(491, 28);
            this.lblNiveis.Name = "lblNiveis";
            this.lblNiveis.Size = new System.Drawing.Size(152, 32);
            this.lblNiveis.TabIndex = 0;
            this.lblNiveis.Text = "Iniciar jogo:";
            // 
            // FrmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1152, 801);
            this.Controls.Add(this.pnlNiveis);
            this.Controls.Add(this.pnlInicial);
            this.Name = "FrmTelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste de Einstein";
            this.Load += new System.EventHandler(this.FrmTelaPrincipal_Load);
            this.pnlInicial.ResumeLayout(false);
            this.pnlInicial.PerformLayout();
            this.pnlNiveis.ResumeLayout(false);
            this.pnlNiveis.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInicial;
        private System.Windows.Forms.Label lblDescricao3;
        private System.Windows.Forms.Label lblDescricao2;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlNiveis;
        private System.Windows.Forms.Button btnFacil;
        private System.Windows.Forms.Label lblNiveis;
    }
}

