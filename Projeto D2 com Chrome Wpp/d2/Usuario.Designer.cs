namespace d2
{
    partial class Usuario
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario));
            this.gpboxUsuario = new System.Windows.Forms.GroupBox();
            this.tbUsuario = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dregistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.d2Usuario = new d2.d2Usuario();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.gpboxAcesso = new System.Windows.Forms.GroupBox();
            this.lbLogin = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lbSenha = new System.Windows.Forms.Label();
            this.pnBuscar = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lbPesquisar = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.gpboxSitu = new System.Windows.Forms.GroupBox();
            this.lbRegistro = new System.Windows.Forms.Label();
            this.txtDregistro = new System.Windows.Forms.MaskedTextBox();
            this.pnID = new System.Windows.Forms.Panel();
            this.lbID = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.pnCRUD = new System.Windows.Forms.Panel();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAtt = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tb_UsuarioTableAdapter = new d2.d2UsuarioTableAdapters.tb_UsuarioTableAdapter();
            this.gpboxUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d2Usuario)).BeginInit();
            this.gpboxAcesso.SuspendLayout();
            this.pnBuscar.SuspendLayout();
            this.gpboxSitu.SuspendLayout();
            this.pnID.SuspendLayout();
            this.pnCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpboxUsuario
            // 
            this.gpboxUsuario.Controls.Add(this.tbUsuario);
            this.gpboxUsuario.Controls.Add(this.btnVoltar);
            this.gpboxUsuario.Controls.Add(this.gpboxAcesso);
            this.gpboxUsuario.Controls.Add(this.pnBuscar);
            this.gpboxUsuario.Controls.Add(this.gpboxSitu);
            this.gpboxUsuario.Controls.Add(this.pnID);
            this.gpboxUsuario.Controls.Add(this.pnCRUD);
            this.gpboxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpboxUsuario.Location = new System.Drawing.Point(12, 12);
            this.gpboxUsuario.Name = "gpboxUsuario";
            this.gpboxUsuario.Size = new System.Drawing.Size(993, 660);
            this.gpboxUsuario.TabIndex = 0;
            this.gpboxUsuario.TabStop = false;
            this.gpboxUsuario.Text = "Gestão de Usuário";
            // 
            // tbUsuario
            // 
            this.tbUsuario.AllowUserToDeleteRows = false;
            this.tbUsuario.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tbUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.dregistroDataGridViewTextBoxColumn});
            this.tbUsuario.DataSource = this.tbUsuarioBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbUsuario.DefaultCellStyle = dataGridViewCellStyle2;
            this.tbUsuario.EnableHeadersVisualStyles = false;
            this.tbUsuario.Location = new System.Drawing.Point(53, 175);
            this.tbUsuario.MultiSelect = false;
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.ReadOnly = true;
            this.tbUsuario.RowHeadersVisible = false;
            this.tbUsuario.RowHeadersWidth = 51;
            this.tbUsuario.RowTemplate.Height = 24;
            this.tbUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbUsuario.Size = new System.Drawing.Size(513, 476);
            this.tbUsuario.TabIndex = 6;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 70;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuário";
            this.usuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuarioDataGridViewTextBoxColumn.Width = 150;
            // 
            // dregistroDataGridViewTextBoxColumn
            // 
            this.dregistroDataGridViewTextBoxColumn.DataPropertyName = "dregistro";
            this.dregistroDataGridViewTextBoxColumn.HeaderText = "Registro";
            this.dregistroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dregistroDataGridViewTextBoxColumn.Name = "dregistroDataGridViewTextBoxColumn";
            this.dregistroDataGridViewTextBoxColumn.ReadOnly = true;
            this.dregistroDataGridViewTextBoxColumn.Width = 150;
            // 
            // tbUsuarioBindingSource
            // 
            this.tbUsuarioBindingSource.DataMember = "tb_Usuario";
            this.tbUsuarioBindingSource.DataSource = this.d2Usuario;
            // 
            // d2Usuario
            // 
            this.d2Usuario.DataSetName = "d2Usuario";
            this.d2Usuario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(857, 29);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(130, 43);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            this.btnVoltar.Enter += new System.EventHandler(this.btnVoltar_Enter);
            this.btnVoltar.Leave += new System.EventHandler(this.btnVoltar_Leave);
            // 
            // gpboxAcesso
            // 
            this.gpboxAcesso.Controls.Add(this.lbLogin);
            this.gpboxAcesso.Controls.Add(this.txtSenha);
            this.gpboxAcesso.Controls.Add(this.txtLogin);
            this.gpboxAcesso.Controls.Add(this.lbSenha);
            this.gpboxAcesso.Location = new System.Drawing.Point(613, 295);
            this.gpboxAcesso.Name = "gpboxAcesso";
            this.gpboxAcesso.Size = new System.Drawing.Size(227, 158);
            this.gpboxAcesso.TabIndex = 3;
            this.gpboxAcesso.TabStop = false;
            this.gpboxAcesso.Text = "Acesso";
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(37, 26);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(60, 25);
            this.lbLogin.TabIndex = 11;
            this.lbLogin.Text = "Login";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(42, 115);
            this.txtSenha.MaxLength = 10;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(137, 30);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(42, 54);
            this.txtLogin.MaxLength = 10;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(137, 30);
            this.txtLogin.TabIndex = 0;
            this.txtLogin.Enter += new System.EventHandler(this.txtLogin_Enter);
            this.txtLogin.Leave += new System.EventHandler(this.txtLogin_Leave);
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Location = new System.Drawing.Point(37, 87);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(70, 25);
            this.lbSenha.TabIndex = 27;
            this.lbSenha.Text = "Senha";
            // 
            // pnBuscar
            // 
            this.pnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnBuscar.Controls.Add(this.btnBuscar);
            this.pnBuscar.Controls.Add(this.lbPesquisar);
            this.pnBuscar.Controls.Add(this.txtPesquisar);
            this.pnBuscar.Location = new System.Drawing.Point(53, 52);
            this.pnBuscar.Name = "pnBuscar";
            this.pnBuscar.Size = new System.Drawing.Size(482, 94);
            this.pnBuscar.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(358, 27);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(109, 55);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            this.btnBuscar.Enter += new System.EventHandler(this.btnBuscar_Enter);
            this.btnBuscar.Leave += new System.EventHandler(this.btnBuscar_Leave);
            // 
            // lbPesquisar
            // 
            this.lbPesquisar.AutoSize = true;
            this.lbPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPesquisar.Location = new System.Drawing.Point(10, 9);
            this.lbPesquisar.Name = "lbPesquisar";
            this.lbPesquisar.Size = new System.Drawing.Size(141, 32);
            this.lbPesquisar.TabIndex = 3;
            this.lbPesquisar.Text = "Pesquisar";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(16, 44);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(304, 30);
            this.txtPesquisar.TabIndex = 0;
            this.txtPesquisar.Enter += new System.EventHandler(this.txtPesquisar_Enter);
            this.txtPesquisar.Leave += new System.EventHandler(this.txtPesquisar_Leave);
            // 
            // gpboxSitu
            // 
            this.gpboxSitu.Controls.Add(this.lbRegistro);
            this.gpboxSitu.Controls.Add(this.txtDregistro);
            this.gpboxSitu.Location = new System.Drawing.Point(613, 161);
            this.gpboxSitu.Name = "gpboxSitu";
            this.gpboxSitu.Size = new System.Drawing.Size(227, 128);
            this.gpboxSitu.TabIndex = 2;
            this.gpboxSitu.TabStop = false;
            this.gpboxSitu.Text = "Informação";
            // 
            // lbRegistro
            // 
            this.lbRegistro.AutoSize = true;
            this.lbRegistro.Location = new System.Drawing.Point(37, 42);
            this.lbRegistro.Name = "lbRegistro";
            this.lbRegistro.Size = new System.Drawing.Size(149, 25);
            this.lbRegistro.TabIndex = 31;
            this.lbRegistro.Text = "Data de registro";
            // 
            // txtDregistro
            // 
            this.txtDregistro.Location = new System.Drawing.Point(6, 70);
            this.txtDregistro.Mask = "00/00/0000 00:00:00";
            this.txtDregistro.Name = "txtDregistro";
            this.txtDregistro.ReadOnly = true;
            this.txtDregistro.Size = new System.Drawing.Size(214, 30);
            this.txtDregistro.TabIndex = 0;
            // 
            // pnID
            // 
            this.pnID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnID.Controls.Add(this.lbID);
            this.pnID.Controls.Add(this.txtId);
            this.pnID.Controls.Add(this.btnSelect);
            this.pnID.Location = new System.Drawing.Point(613, 52);
            this.pnID.Name = "pnID";
            this.pnID.Size = new System.Drawing.Size(227, 94);
            this.pnID.TabIndex = 1;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(32, 8);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(31, 25);
            this.lbID.TabIndex = 12;
            this.lbID.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(21, 36);
            this.txtId.MaxLength = 10;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(54, 30);
            this.txtId.TabIndex = 0;
            this.txtId.Enter += new System.EventHandler(this.txtId_Enter);
            this.txtId.Leave += new System.EventHandler(this.txtId_Leave);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(90, 27);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(130, 43);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Selecionar";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            this.btnSelect.Enter += new System.EventHandler(this.btnSelect_Enter);
            this.btnSelect.Leave += new System.EventHandler(this.btnSelect_Leave);
            // 
            // pnCRUD
            // 
            this.pnCRUD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnCRUD.Controls.Add(this.btnDel);
            this.pnCRUD.Controls.Add(this.btnLimpar);
            this.pnCRUD.Controls.Add(this.btnAtt);
            this.pnCRUD.Controls.Add(this.btnAdd);
            this.pnCRUD.Location = new System.Drawing.Point(613, 459);
            this.pnCRUD.Name = "pnCRUD";
            this.pnCRUD.Size = new System.Drawing.Size(227, 192);
            this.pnCRUD.TabIndex = 4;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(21, 99);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(187, 35);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Deletar";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            this.btnDel.Enter += new System.EventHandler(this.btnDel_Enter);
            this.btnDel.Leave += new System.EventHandler(this.btnDel_Leave);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(22, 140);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(187, 35);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            this.btnLimpar.Enter += new System.EventHandler(this.btnLimpar_Enter);
            this.btnLimpar.Leave += new System.EventHandler(this.btnLimpar_Leave);
            // 
            // btnAtt
            // 
            this.btnAtt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtt.Location = new System.Drawing.Point(21, 58);
            this.btnAtt.Name = "btnAtt";
            this.btnAtt.Size = new System.Drawing.Size(187, 35);
            this.btnAtt.TabIndex = 1;
            this.btnAtt.Text = "Alterar";
            this.btnAtt.UseVisualStyleBackColor = false;
            this.btnAtt.Click += new System.EventHandler(this.btnAtt_Click);
            this.btnAtt.Enter += new System.EventHandler(this.btnAtt_Enter);
            this.btnAtt.Leave += new System.EventHandler(this.btnAtt_Leave);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(21, 17);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(187, 35);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.Enter += new System.EventHandler(this.btnAdd_Enter);
            this.btnAdd.Leave += new System.EventHandler(this.btnAdd_Leave);
            // 
            // tb_UsuarioTableAdapter
            // 
            this.tb_UsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 684);
            this.Controls.Add(this.gpboxUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "D2 Net Games";
            this.Load += new System.EventHandler(this.Usuario_Load);
            this.gpboxUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d2Usuario)).EndInit();
            this.gpboxAcesso.ResumeLayout(false);
            this.gpboxAcesso.PerformLayout();
            this.pnBuscar.ResumeLayout(false);
            this.pnBuscar.PerformLayout();
            this.gpboxSitu.ResumeLayout(false);
            this.gpboxSitu.PerformLayout();
            this.pnID.ResumeLayout(false);
            this.pnID.PerformLayout();
            this.pnCRUD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpboxUsuario;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel pnBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lbPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.GroupBox gpboxSitu;
        private System.Windows.Forms.Panel pnID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Panel pnCRUD;
        private System.Windows.Forms.Button btnAtt;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gpboxAcesso;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lbRegistro;
        private System.Windows.Forms.MaskedTextBox txtDregistro;
        private System.Windows.Forms.DataGridView tbUsuario;
        private d2Usuario d2Usuario;
        private System.Windows.Forms.BindingSource tbUsuarioBindingSource;
        private d2UsuarioTableAdapters.tb_UsuarioTableAdapter tb_UsuarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dregistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnDel;
    }
}