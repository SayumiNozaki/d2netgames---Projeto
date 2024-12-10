namespace d2
{
    partial class Cliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gpboxCliente = new System.Windows.Forms.GroupBox();
            this.tbCliente = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbClienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.d2Cliente1 = new d2.d2Cliente();
            this.pnBuscar = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lbPesquisar = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTel2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.lbTel1 = new System.Windows.Forms.Label();
            this.txtTel1 = new System.Windows.Forms.MaskedTextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtTel2 = new System.Windows.Forms.MaskedTextBox();
            this.lbCPF = new System.Windows.Forms.Label();
            this.pnID = new System.Windows.Forms.Panel();
            this.lbID = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.pnCRUD = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAtt = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.d2Cliente = new d2.d2Cliente();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.tb_ClienteTableAdapter = new d2.d2ClienteTableAdapters.tb_ClienteTableAdapter();
            this.gpboxCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d2Cliente1)).BeginInit();
            this.pnBuscar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnID.SuspendLayout();
            this.pnCRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d2Cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // gpboxCliente
            // 
            this.gpboxCliente.Controls.Add(this.tbCliente);
            this.gpboxCliente.Controls.Add(this.pnBuscar);
            this.gpboxCliente.Controls.Add(this.btnVoltar);
            this.gpboxCliente.Controls.Add(this.groupBox1);
            this.gpboxCliente.Controls.Add(this.pnID);
            this.gpboxCliente.Controls.Add(this.pnCRUD);
            this.gpboxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpboxCliente.Location = new System.Drawing.Point(12, 12);
            this.gpboxCliente.Name = "gpboxCliente";
            this.gpboxCliente.Size = new System.Drawing.Size(1245, 746);
            this.gpboxCliente.TabIndex = 0;
            this.gpboxCliente.TabStop = false;
            this.gpboxCliente.Text = "Gestão de Cliente";
            // 
            // tbCliente
            // 
            this.tbCliente.AllowUserToDeleteRows = false;
            this.tbCliente.AutoGenerateColumns = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tbCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn});
            this.tbCliente.DataSource = this.tbClienteBindingSource1;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbCliente.DefaultCellStyle = dataGridViewCellStyle4;
            this.tbCliente.EnableHeadersVisualStyles = false;
            this.tbCliente.Location = new System.Drawing.Point(57, 172);
            this.tbCliente.MultiSelect = false;
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.ReadOnly = true;
            this.tbCliente.RowHeadersVisible = false;
            this.tbCliente.RowHeadersWidth = 51;
            this.tbCliente.RowTemplate.Height = 24;
            this.tbCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbCliente.Size = new System.Drawing.Size(652, 521);
            this.tbCliente.TabIndex = 21;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.MaxInputLength = 10;
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MaxInputLength = 30;
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 130;
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cpfDataGridViewTextBoxColumn.MaxInputLength = 14;
            this.cpfDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            this.cpfDataGridViewTextBoxColumn.ReadOnly = true;
            this.cpfDataGridViewTextBoxColumn.Width = 150;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.MaxInputLength = 15;
            this.telefoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // tbClienteBindingSource1
            // 
            this.tbClienteBindingSource1.DataMember = "tb_Cliente";
            this.tbClienteBindingSource1.DataSource = this.d2Cliente1;
            // 
            // d2Cliente1
            // 
            this.d2Cliente1.DataSetName = "d2Cliente";
            this.d2Cliente1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnBuscar
            // 
            this.pnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnBuscar.Controls.Add(this.btnBuscar);
            this.pnBuscar.Controls.Add(this.lbPesquisar);
            this.pnBuscar.Controls.Add(this.txtPesquisar);
            this.pnBuscar.Location = new System.Drawing.Point(57, 52);
            this.pnBuscar.Name = "pnBuscar";
            this.pnBuscar.Size = new System.Drawing.Size(482, 98);
            this.pnBuscar.TabIndex = 20;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBuscar.Location = new System.Drawing.Point(356, 32);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(109, 43);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lbPesquisar
            // 
            this.lbPesquisar.AutoSize = true;
            this.lbPesquisar.Location = new System.Drawing.Point(9, 17);
            this.lbPesquisar.Name = "lbPesquisar";
            this.lbPesquisar.Size = new System.Drawing.Size(99, 25);
            this.lbPesquisar.TabIndex = 3;
            this.lbPesquisar.Text = "Pesquisar";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(14, 45);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(304, 30);
            this.txtPesquisar.TabIndex = 2;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnVoltar.Location = new System.Drawing.Point(1109, 29);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(130, 43);
            this.btnVoltar.TabIndex = 16;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbTel2);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.txtCPF);
            this.groupBox1.Controls.Add(this.lbTel1);
            this.groupBox1.Controls.Add(this.txtTel1);
            this.groupBox1.Controls.Add(this.lbNome);
            this.groupBox1.Controls.Add(this.txtTel2);
            this.groupBox1.Controls.Add(this.lbCPF);
            this.groupBox1.Location = new System.Drawing.Point(805, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 392);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // lbTel2
            // 
            this.lbTel2.AutoSize = true;
            this.lbTel2.Location = new System.Drawing.Point(11, 291);
            this.lbTel2.Name = "lbTel2";
            this.lbTel2.Size = new System.Drawing.Size(105, 25);
            this.lbTel2.TabIndex = 11;
            this.lbTel2.Text = "Telefone 2";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(16, 77);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(185, 30);
            this.txtNome.TabIndex = 5;
            // 
            // txtCPF
            // 
            this.txtCPF.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCPF.Location = new System.Drawing.Point(16, 158);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(185, 30);
            this.txtCPF.TabIndex = 6;
            // 
            // lbTel1
            // 
            this.lbTel1.AutoSize = true;
            this.lbTel1.Location = new System.Drawing.Point(11, 211);
            this.lbTel1.Name = "lbTel1";
            this.lbTel1.Size = new System.Drawing.Size(105, 25);
            this.lbTel1.TabIndex = 10;
            this.lbTel1.Text = "Telefone 1";
            // 
            // txtTel1
            // 
            this.txtTel1.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtTel1.Location = new System.Drawing.Point(16, 239);
            this.txtTel1.Mask = "(00) 00000-0000";
            this.txtTel1.Name = "txtTel1";
            this.txtTel1.Size = new System.Drawing.Size(185, 30);
            this.txtTel1.TabIndex = 7;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(11, 49);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(64, 25);
            this.lbNome.TabIndex = 9;
            this.lbNome.Text = "Nome";
            // 
            // txtTel2
            // 
            this.txtTel2.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtTel2.Location = new System.Drawing.Point(16, 319);
            this.txtTel2.Mask = "(00) 00000-0000";
            this.txtTel2.Name = "txtTel2";
            this.txtTel2.Size = new System.Drawing.Size(185, 30);
            this.txtTel2.TabIndex = 8;
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Location = new System.Drawing.Point(11, 130);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(52, 25);
            this.lbCPF.TabIndex = 9;
            this.lbCPF.Text = "CPF";
            // 
            // pnID
            // 
            this.pnID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnID.Controls.Add(this.lbID);
            this.pnID.Controls.Add(this.txtId);
            this.pnID.Controls.Add(this.btnSelect);
            this.pnID.Location = new System.Drawing.Point(805, 52);
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
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(54, 30);
            this.txtId.TabIndex = 12;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSelect.Location = new System.Drawing.Point(90, 27);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(130, 43);
            this.btnSelect.TabIndex = 12;
            this.btnSelect.Text = "Selecionar";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // pnCRUD
            // 
            this.pnCRUD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnCRUD.Controls.Add(this.btnLimpar);
            this.pnCRUD.Controls.Add(this.btnAtt);
            this.pnCRUD.Controls.Add(this.btnAdd);
            this.pnCRUD.Location = new System.Drawing.Point(729, 561);
            this.pnCRUD.Name = "pnCRUD";
            this.pnCRUD.Size = new System.Drawing.Size(414, 132);
            this.pnCRUD.TabIndex = 0;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLimpar.Location = new System.Drawing.Point(216, 75);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(164, 43);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAtt
            // 
            this.btnAtt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAtt.Location = new System.Drawing.Point(37, 75);
            this.btnAtt.Name = "btnAtt";
            this.btnAtt.Size = new System.Drawing.Size(164, 43);
            this.btnAtt.TabIndex = 14;
            this.btnAtt.Text = "Alterar";
            this.btnAtt.UseVisualStyleBackColor = false;
            this.btnAtt.Click += new System.EventHandler(this.btnAtt_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAdd.Location = new System.Drawing.Point(37, 17);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(164, 43);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbClienteBindingSource
            // 
            this.tbClienteBindingSource.DataMember = "tb_Cliente";
            this.tbClienteBindingSource.DataSource = this.d2Cliente;
            // 
            // d2Cliente
            // 
            this.d2Cliente.DataSetName = "d2Cliente";
            this.d2Cliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_ClienteTableAdapter
            // 
            this.tb_ClienteTableAdapter.ClearBeforeFill = true;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 770);
            this.Controls.Add(this.gpboxCliente);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.gpboxCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d2Cliente1)).EndInit();
            this.pnBuscar.ResumeLayout(false);
            this.pnBuscar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnID.ResumeLayout(false);
            this.pnID.PerformLayout();
            this.pnCRUD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d2Cliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpboxCliente;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lbPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Panel pnID;
        private System.Windows.Forms.Panel pnCRUD;
        private System.Windows.Forms.Label lbTel2;
        private System.Windows.Forms.Label lbTel1;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.MaskedTextBox txtTel2;
        private System.Windows.Forms.MaskedTextBox txtTel1;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnAtt;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnBuscar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.BindingSource tbClienteBindingSource;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridView tbCliente;
        private d2Cliente d2Cliente1;
        private System.Windows.Forms.BindingSource tbClienteBindingSource1;
        private d2Cliente d2Cliente;
        private d2ClienteTableAdapters.tb_ClienteTableAdapter tb_ClienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
    }
}