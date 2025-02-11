namespace d2
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
            this.gpboxLogin = new System.Windows.Forms.GroupBox();
            this.lbSenha = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.gpboxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpboxLogin
            // 
            this.gpboxLogin.Controls.Add(this.lbSenha);
            this.gpboxLogin.Controls.Add(this.lbLogin);
            this.gpboxLogin.Controls.Add(this.btnAjuda);
            this.gpboxLogin.Controls.Add(this.btnEntrar);
            this.gpboxLogin.Controls.Add(this.txtSenha);
            this.gpboxLogin.Controls.Add(this.txtLogin);
            this.gpboxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpboxLogin.Location = new System.Drawing.Point(165, 52);
            this.gpboxLogin.Name = "gpboxLogin";
            this.gpboxLogin.Size = new System.Drawing.Size(451, 386);
            this.gpboxLogin.TabIndex = 0;
            this.gpboxLogin.TabStop = false;
            this.gpboxLogin.Text = "Acessar conta";
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Location = new System.Drawing.Point(186, 142);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(70, 25);
            this.lbSenha.TabIndex = 5;
            this.lbSenha.Text = "Senha";
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(186, 65);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(60, 25);
            this.lbLogin.TabIndex = 4;
            this.lbLogin.Text = "Login";
            // 
            // btnAjuda
            // 
            this.btnAjuda.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAjuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjuda.Location = new System.Drawing.Point(145, 295);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(147, 52);
            this.btnAjuda.TabIndex = 3;
            this.btnAjuda.Text = "Ajuda";
            this.btnAjuda.UseVisualStyleBackColor = false;
            this.btnAjuda.Click += new System.EventHandler(this.btnAjuda_Click);
            this.btnAjuda.Enter += new System.EventHandler(this.btnAjuda_Enter);
            this.btnAjuda.Leave += new System.EventHandler(this.btnAjuda_Leave);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Location = new System.Drawing.Point(132, 239);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(176, 51);
            this.btnEntrar.TabIndex = 2;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            this.btnEntrar.Enter += new System.EventHandler(this.btnEntrar_Enter);
            this.btnEntrar.Leave += new System.EventHandler(this.btnEntrar_Leave);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(132, 170);
            this.txtSenha.MaxLength = 10;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(176, 30);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
            this.txtSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSenha_KeyDown);
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(132, 93);
            this.txtLogin.MaxLength = 10;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(176, 30);
            this.txtLogin.TabIndex = 0;
            this.txtLogin.Enter += new System.EventHandler(this.txtLogin_Enter);
            this.txtLogin.Leave += new System.EventHandler(this.txtLogin_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.gpboxLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "D2 Net Games";
            this.gpboxLogin.ResumeLayout(false);
            this.gpboxLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpboxLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.Button btnEntrar;
    }
}

