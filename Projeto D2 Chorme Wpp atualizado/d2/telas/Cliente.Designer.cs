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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.gpboxCliente = new System.Windows.Forms.GroupBox();
            this.tbCliente = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbClienteBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.d2Cliente = new d2.d2Cliente();
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
            this.tbClienteBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.d2Clienteatt = new d2.d2Clienteatt();
            this.tbClienteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tbClienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.tb_ClienteTableAdapter = new d2.d2ClienteattTableAdapters.tb_ClienteTableAdapter();
            this.tb_ClienteTableAdapter1 = new d2.d2ClienteTableAdapters.tb_ClienteTableAdapter();
            this.gpboxCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d2Cliente)).BeginInit();
            this.pnBuscar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnID.SuspendLayout();
            this.pnCRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d2Clienteatt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource)).BeginInit();
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
            this.gpboxCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpboxCliente.Name = "gpboxCliente";
            this.gpboxCliente.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpboxCliente.Size = new System.Drawing.Size(1083, 574);
            this.gpboxCliente.TabIndex = 0;
            this.gpboxCliente.TabStop = false;
            this.gpboxCliente.Text = "Gestão de Cliente";
            // 
            // tbCliente
            // 
            this.tbCliente.AllowUserToAddRows = false;
            this.tbCliente.AllowUserToDeleteRows = false;
            this.tbCliente.AutoGenerateColumns = false;
            this.tbCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tbCliente.DataSource = this.tbClienteBindingSource4;
            this.tbCliente.EnableHeadersVisualStyles = false;
            this.tbCliente.Location = new System.Drawing.Point(23, 171);
            this.tbCliente.Margin = new System.Windows.Forms.Padding(4);
            this.tbCliente.MultiSelect = false;
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.ReadOnly = true;
            this.tbCliente.RowHeadersVisible = false;
            this.tbCliente.RowHeadersWidth = 51;
            this.tbCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbCliente.Size = new System.Drawing.Size(589, 373);
            this.tbCliente.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 10;
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.MaxInputLength = 80;
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 230;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "telefone";
            this.dataGridViewTextBoxColumn3.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn3.MaxInputLength = 15;
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 130;
            // 
            // tbClienteBindingSource4
            // 
            this.tbClienteBindingSource4.DataMember = "tb_Cliente";
            this.tbClienteBindingSource4.DataSource = this.d2Cliente;
            // 
            // d2Cliente
            // 
            this.d2Cliente.DataSetName = "d2Cliente";
            this.d2Cliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnBuscar
            // 
            this.pnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnBuscar.Controls.Add(this.btnBuscar);
            this.pnBuscar.Controls.Add(this.lbPesquisar);
            this.pnBuscar.Controls.Add(this.txtPesquisar);
            this.pnBuscar.Location = new System.Drawing.Point(23, 52);
            this.pnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnBuscar.Name = "pnBuscar";
            this.pnBuscar.Size = new System.Drawing.Size(483, 98);
            this.pnBuscar.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(356, 32);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(109, 43);
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
            this.lbPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPesquisar.Location = new System.Drawing.Point(9, 7);
            this.lbPesquisar.Name = "lbPesquisar";
            this.lbPesquisar.Size = new System.Drawing.Size(121, 29);
            this.lbPesquisar.TabIndex = 3;
            this.lbPesquisar.Text = "Pesquisar";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(13, 46);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(304, 30);
            this.txtPesquisar.TabIndex = 0;
            this.txtPesquisar.Enter += new System.EventHandler(this.txtPesquisar_Enter);
            this.txtPesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisar_KeyDown);
            this.txtPesquisar.Leave += new System.EventHandler(this.txtPesquisar_Leave);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(947, 28);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(131, 43);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            this.btnVoltar.Enter += new System.EventHandler(this.btnVoltar_Enter);
            this.btnVoltar.Leave += new System.EventHandler(this.btnVoltar_Leave);
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
            this.groupBox1.Location = new System.Drawing.Point(619, 153);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(227, 391);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // lbTel2
            // 
            this.lbTel2.AutoSize = true;
            this.lbTel2.Location = new System.Drawing.Point(11, 290);
            this.lbTel2.Name = "lbTel2";
            this.lbTel2.Size = new System.Drawing.Size(105, 25);
            this.lbTel2.TabIndex = 11;
            this.lbTel2.Text = "Telefone 2";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(16, 78);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(185, 30);
            this.txtNome.TabIndex = 0;
            this.txtNome.Enter += new System.EventHandler(this.txtNome_Enter);
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // txtCPF
            // 
            this.txtCPF.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCPF.Location = new System.Drawing.Point(16, 158);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(185, 30);
            this.txtCPF.TabIndex = 1;
            this.txtCPF.Enter += new System.EventHandler(this.txtCPF_Enter);
            this.txtCPF.Leave += new System.EventHandler(this.txtCPF_Leave);
            // 
            // lbTel1
            // 
            this.lbTel1.AutoSize = true;
            this.lbTel1.Location = new System.Drawing.Point(11, 210);
            this.lbTel1.Name = "lbTel1";
            this.lbTel1.Size = new System.Drawing.Size(105, 25);
            this.lbTel1.TabIndex = 10;
            this.lbTel1.Text = "Telefone 1";
            // 
            // txtTel1
            // 
            this.txtTel1.AllowPromptAsInput = false;
            this.txtTel1.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtTel1.Location = new System.Drawing.Point(16, 239);
            this.txtTel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTel1.Mask = "(00) 00000-0000";
            this.txtTel1.Name = "txtTel1";
            this.txtTel1.Size = new System.Drawing.Size(185, 30);
            this.txtTel1.TabIndex = 2;
            this.txtTel1.Enter += new System.EventHandler(this.txtTel1_Enter);
            this.txtTel1.Leave += new System.EventHandler(this.txtTel1_Leave);
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
            this.txtTel2.AllowPromptAsInput = false;
            this.txtTel2.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtTel2.Location = new System.Drawing.Point(16, 319);
            this.txtTel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTel2.Mask = "(00) 00000-0000";
            this.txtTel2.Name = "txtTel2";
            this.txtTel2.Size = new System.Drawing.Size(185, 30);
            this.txtTel2.TabIndex = 3;
            this.txtTel2.Enter += new System.EventHandler(this.txtTel2_Enter);
            this.txtTel2.Leave += new System.EventHandler(this.txtTel2_Leave);
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
            this.pnID.Location = new System.Drawing.Point(619, 52);
            this.pnID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnID.Name = "pnID";
            this.pnID.Size = new System.Drawing.Size(227, 94);
            this.pnID.TabIndex = 1;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(32, 7);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(31, 25);
            this.lbID.TabIndex = 12;
            this.lbID.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(21, 36);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(55, 30);
            this.txtId.TabIndex = 0;
            this.txtId.Enter += new System.EventHandler(this.txtId_Enter);
            this.txtId.Leave += new System.EventHandler(this.txtId_Leave);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(91, 27);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(131, 43);
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
            this.pnCRUD.Controls.Add(this.btnLimpar);
            this.pnCRUD.Controls.Add(this.btnAtt);
            this.pnCRUD.Controls.Add(this.btnAdd);
            this.pnCRUD.Location = new System.Drawing.Point(851, 366);
            this.pnCRUD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnCRUD.Name = "pnCRUD";
            this.pnCRUD.Size = new System.Drawing.Size(227, 178);
            this.pnCRUD.TabIndex = 3;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(37, 114);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(164, 43);
            this.btnLimpar.TabIndex = 2;
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
            this.btnAtt.Location = new System.Drawing.Point(37, 66);
            this.btnAtt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAtt.Name = "btnAtt";
            this.btnAtt.Size = new System.Drawing.Size(164, 43);
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
            this.btnAdd.Location = new System.Drawing.Point(37, 17);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(164, 43);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.Enter += new System.EventHandler(this.btnAdd_Enter);
            this.btnAdd.Leave += new System.EventHandler(this.btnAdd_Leave);
            // 
            // tbClienteBindingSource3
            // 
            this.tbClienteBindingSource3.DataMember = "tb_Cliente";
            this.tbClienteBindingSource3.DataSource = this.d2Clienteatt;
            // 
            // d2Clienteatt
            // 
            this.d2Clienteatt.DataSetName = "d2Clienteatt";
            this.d2Clienteatt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbClienteBindingSource2
            // 
            this.tbClienteBindingSource2.DataMember = "tb_Cliente";
            // 
            // tbClienteBindingSource1
            // 
            this.tbClienteBindingSource1.DataMember = "tb_Cliente";
            // 
            // tbClienteBindingSource
            // 
            this.tbClienteBindingSource.DataMember = "tb_Cliente";
            // 
            // tb_ClienteTableAdapter
            // 
            this.tb_ClienteTableAdapter.ClearBeforeFill = true;
            // 
            // tb_ClienteTableAdapter1
            // 
            this.tb_ClienteTableAdapter1.ClearBeforeFill = true;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 601);
            this.Controls.Add(this.gpboxCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "D2 Net Games";
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.gpboxCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d2Cliente)).EndInit();
            this.pnBuscar.ResumeLayout(false);
            this.pnBuscar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnID.ResumeLayout(false);
            this.pnID.PerformLayout();
            this.pnCRUD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d2Clienteatt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource tbClienteBindingSource1;

        private System.Windows.Forms.BindingSource tbClienteBindingSource2;

        private System.Windows.Forms.DataGridView tbCliente;
        private d2Clienteatt d2Clienteatt;
        private System.Windows.Forms.BindingSource tbClienteBindingSource3;
        private d2ClienteattTableAdapters.tb_ClienteTableAdapter tb_ClienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private d2Cliente d2Cliente;
        private System.Windows.Forms.BindingSource tbClienteBindingSource4;
        private d2ClienteTableAdapters.tb_ClienteTableAdapter tb_ClienteTableAdapter1;
    }
}