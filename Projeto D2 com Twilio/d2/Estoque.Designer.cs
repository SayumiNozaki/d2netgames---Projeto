namespace d2
{
    partial class Estoque
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
            this.gpboxEstoque = new System.Windows.Forms.GroupBox();
            this.tbEstoque = new System.Windows.Forms.DataGridView();
            this.tbEstoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.d2Estoque = new d2.d2Estoque();
            this.gpboxRetirado = new System.Windows.Forms.GroupBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lbValor = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.lbCPF = new System.Windows.Forms.Label();
            this.lbNome2 = new System.Windows.Forms.Label();
            this.txtNomeRetirada = new System.Windows.Forms.TextBox();
            this.lbRetirada = new System.Windows.Forms.Label();
            this.txtDretirada = new System.Windows.Forms.MaskedTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnWpp2 = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnWpp1 = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAtt = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gpboxSituacao = new System.Windows.Forms.GroupBox();
            this.radioEstoque = new System.Windows.Forms.RadioButton();
            this.radioRetirado = new System.Windows.Forms.RadioButton();
            this.gpboxPacote = new System.Windows.Forms.GroupBox();
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.lbRegistro = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbLoja = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCliente = new System.Windows.Forms.Button();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtDregistro = new System.Windows.Forms.MaskedTextBox();
            this.txtLoja = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gpboxFiltro = new System.Windows.Forms.GroupBox();
            this.checkRetirado = new System.Windows.Forms.CheckBox();
            this.checkEstoque = new System.Windows.Forms.CheckBox();
            this.lbPesquisar = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tb_EstoqueTableAdapter = new d2.d2EstoqueTableAdapters.tb_EstoqueTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lojaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpboxEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEstoqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d2Estoque)).BeginInit();
            this.gpboxRetirado.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gpboxSituacao.SuspendLayout();
            this.gpboxPacote.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gpboxFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpboxEstoque
            // 
            this.gpboxEstoque.Controls.Add(this.tbEstoque);
            this.gpboxEstoque.Controls.Add(this.gpboxRetirado);
            this.gpboxEstoque.Controls.Add(this.panel3);
            this.gpboxEstoque.Controls.Add(this.gpboxSituacao);
            this.gpboxEstoque.Controls.Add(this.gpboxPacote);
            this.gpboxEstoque.Controls.Add(this.panel2);
            this.gpboxEstoque.Controls.Add(this.btnVoltar);
            this.gpboxEstoque.Controls.Add(this.panel1);
            this.gpboxEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpboxEstoque.Location = new System.Drawing.Point(12, 12);
            this.gpboxEstoque.Name = "gpboxEstoque";
            this.gpboxEstoque.Size = new System.Drawing.Size(1512, 746);
            this.gpboxEstoque.TabIndex = 0;
            this.gpboxEstoque.TabStop = false;
            this.gpboxEstoque.Text = "Gestão do Estoque";
            // 
            // tbEstoque
            // 
            this.tbEstoque.AllowUserToDeleteRows = false;
            this.tbEstoque.AllowUserToResizeColumns = false;
            this.tbEstoque.AllowUserToResizeRows = false;
            this.tbEstoque.AutoGenerateColumns = false;
            this.tbEstoque.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbEstoque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tbEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeclienteDataGridViewTextBoxColumn,
            this.lojaDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.situacaoDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn});
            this.tbEstoque.DataSource = this.tbEstoqueBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbEstoque.DefaultCellStyle = dataGridViewCellStyle2;
            this.tbEstoque.EnableHeadersVisualStyles = false;
            this.tbEstoque.Location = new System.Drawing.Point(26, 262);
            this.tbEstoque.MultiSelect = false;
            this.tbEstoque.Name = "tbEstoque";
            this.tbEstoque.ReadOnly = true;
            this.tbEstoque.RowHeadersVisible = false;
            this.tbEstoque.RowHeadersWidth = 51;
            this.tbEstoque.RowTemplate.Height = 24;
            this.tbEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbEstoque.Size = new System.Drawing.Size(957, 458);
            this.tbEstoque.TabIndex = 11;
            // 
            // tbEstoqueBindingSource
            // 
            this.tbEstoqueBindingSource.DataMember = "tb_Estoque";
            this.tbEstoqueBindingSource.DataSource = this.d2Estoque;
            // 
            // d2Estoque
            // 
            this.d2Estoque.DataSetName = "d2Estoque";
            this.d2Estoque.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gpboxRetirado
            // 
            this.gpboxRetirado.Controls.Add(this.txtValor);
            this.gpboxRetirado.Controls.Add(this.lbValor);
            this.gpboxRetirado.Controls.Add(this.txtCPF);
            this.gpboxRetirado.Controls.Add(this.lbCPF);
            this.gpboxRetirado.Controls.Add(this.lbNome2);
            this.gpboxRetirado.Controls.Add(this.txtNomeRetirada);
            this.gpboxRetirado.Controls.Add(this.lbRetirada);
            this.gpboxRetirado.Controls.Add(this.txtDretirada);
            this.gpboxRetirado.Location = new System.Drawing.Point(1268, 262);
            this.gpboxRetirado.Name = "gpboxRetirado";
            this.gpboxRetirado.Size = new System.Drawing.Size(213, 292);
            this.gpboxRetirado.TabIndex = 4;
            this.gpboxRetirado.TabStop = false;
            this.gpboxRetirado.Text = "Retirado por";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(26, 185);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(158, 30);
            this.txtValor.TabIndex = 2;
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Location = new System.Drawing.Point(21, 157);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(58, 25);
            this.lbValor.TabIndex = 15;
            this.lbValor.Text = "Valor";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(26, 124);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(158, 30);
            this.txtCPF.TabIndex = 1;
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Location = new System.Drawing.Point(21, 96);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(52, 25);
            this.lbCPF.TabIndex = 14;
            this.lbCPF.Text = "CPF";
            // 
            // lbNome2
            // 
            this.lbNome2.AutoSize = true;
            this.lbNome2.Location = new System.Drawing.Point(21, 35);
            this.lbNome2.Name = "lbNome2";
            this.lbNome2.Size = new System.Drawing.Size(64, 25);
            this.lbNome2.TabIndex = 12;
            this.lbNome2.Text = "Nome";
            // 
            // txtNomeRetirada
            // 
            this.txtNomeRetirada.Location = new System.Drawing.Point(26, 63);
            this.txtNomeRetirada.Name = "txtNomeRetirada";
            this.txtNomeRetirada.Size = new System.Drawing.Size(158, 30);
            this.txtNomeRetirada.TabIndex = 0;
            // 
            // lbRetirada
            // 
            this.lbRetirada.AutoSize = true;
            this.lbRetirada.Location = new System.Drawing.Point(21, 218);
            this.lbRetirada.Name = "lbRetirada";
            this.lbRetirada.Size = new System.Drawing.Size(150, 25);
            this.lbRetirada.TabIndex = 10;
            this.lbRetirada.Text = "Data de retirada";
            // 
            // txtDretirada
            // 
            this.txtDretirada.Location = new System.Drawing.Point(26, 246);
            this.txtDretirada.Mask = "00/00/0000 90:00:000";
            this.txtDretirada.Name = "txtDretirada";
            this.txtDretirada.ReadOnly = true;
            this.txtDretirada.Size = new System.Drawing.Size(161, 30);
            this.txtDretirada.TabIndex = 3;
            this.txtDretirada.ValidatingType = typeof(System.DateTime);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.btnWpp2);
            this.panel3.Controls.Add(this.btnLimpar);
            this.panel3.Controls.Add(this.btnWpp1);
            this.panel3.Controls.Add(this.btnDel);
            this.panel3.Controls.Add(this.btnAtt);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Location = new System.Drawing.Point(1000, 560);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(481, 161);
            this.panel3.TabIndex = 5;
            // 
            // btnWpp2
            // 
            this.btnWpp2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnWpp2.Location = new System.Drawing.Point(265, 57);
            this.btnWpp2.Name = "btnWpp2";
            this.btnWpp2.Size = new System.Drawing.Size(187, 45);
            this.btnWpp2.TabIndex = 5;
            this.btnWpp2.Text = "What\'s App 2";
            this.btnWpp2.UseVisualStyleBackColor = false;
            this.btnWpp2.Click += new System.EventHandler(this.btnWpp2_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLimpar.Location = new System.Drawing.Point(265, 108);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(187, 43);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnWpp1
            // 
            this.btnWpp1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnWpp1.Location = new System.Drawing.Point(265, 6);
            this.btnWpp1.Name = "btnWpp1";
            this.btnWpp1.Size = new System.Drawing.Size(187, 45);
            this.btnWpp1.TabIndex = 3;
            this.btnWpp1.Text = "What\'s App";
            this.btnWpp1.UseVisualStyleBackColor = false;
            this.btnWpp1.Click += new System.EventHandler(this.btnWpp1_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDel.Location = new System.Drawing.Point(38, 108);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(187, 45);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Deletar";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAtt
            // 
            this.btnAtt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAtt.Location = new System.Drawing.Point(38, 57);
            this.btnAtt.Name = "btnAtt";
            this.btnAtt.Size = new System.Drawing.Size(187, 45);
            this.btnAtt.TabIndex = 1;
            this.btnAtt.Text = "Alterar";
            this.btnAtt.UseVisualStyleBackColor = false;
            this.btnAtt.Click += new System.EventHandler(this.btnAtt_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAdd.Location = new System.Drawing.Point(38, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(187, 45);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gpboxSituacao
            // 
            this.gpboxSituacao.Controls.Add(this.radioEstoque);
            this.gpboxSituacao.Controls.Add(this.radioRetirado);
            this.gpboxSituacao.Location = new System.Drawing.Point(1268, 157);
            this.gpboxSituacao.Name = "gpboxSituacao";
            this.gpboxSituacao.Size = new System.Drawing.Size(213, 103);
            this.gpboxSituacao.TabIndex = 3;
            this.gpboxSituacao.TabStop = false;
            this.gpboxSituacao.Text = "Situação";
            // 
            // radioEstoque
            // 
            this.radioEstoque.AutoSize = true;
            this.radioEstoque.Location = new System.Drawing.Point(39, 27);
            this.radioEstoque.Name = "radioEstoque";
            this.radioEstoque.Size = new System.Drawing.Size(105, 29);
            this.radioEstoque.TabIndex = 0;
            this.radioEstoque.TabStop = true;
            this.radioEstoque.Text = "Estoque";
            this.radioEstoque.UseVisualStyleBackColor = true;
            // 
            // radioRetirado
            // 
            this.radioRetirado.AutoSize = true;
            this.radioRetirado.Location = new System.Drawing.Point(39, 59);
            this.radioRetirado.Name = "radioRetirado";
            this.radioRetirado.Size = new System.Drawing.Size(105, 29);
            this.radioRetirado.TabIndex = 1;
            this.radioRetirado.TabStop = true;
            this.radioRetirado.Text = "Retirado";
            this.radioRetirado.UseVisualStyleBackColor = true;
            // 
            // gpboxPacote
            // 
            this.gpboxPacote.Controls.Add(this.lbQuantidade);
            this.gpboxPacote.Controls.Add(this.lbRegistro);
            this.gpboxPacote.Controls.Add(this.txtQuantidade);
            this.gpboxPacote.Controls.Add(this.lbNome);
            this.gpboxPacote.Controls.Add(this.lbLoja);
            this.gpboxPacote.Controls.Add(this.txtNomeCliente);
            this.gpboxPacote.Controls.Add(this.label2);
            this.gpboxPacote.Controls.Add(this.btnCliente);
            this.gpboxPacote.Controls.Add(this.txtIdCliente);
            this.gpboxPacote.Controls.Add(this.txtDregistro);
            this.gpboxPacote.Controls.Add(this.txtLoja);
            this.gpboxPacote.Location = new System.Drawing.Point(1000, 157);
            this.gpboxPacote.Name = "gpboxPacote";
            this.gpboxPacote.Size = new System.Drawing.Size(262, 397);
            this.gpboxPacote.TabIndex = 2;
            this.gpboxPacote.TabStop = false;
            this.gpboxPacote.Text = "Pacote";
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Location = new System.Drawing.Point(20, 259);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(114, 25);
            this.lbQuantidade.TabIndex = 12;
            this.lbQuantidade.Text = "Quantidade";
            // 
            // lbRegistro
            // 
            this.lbRegistro.AutoSize = true;
            this.lbRegistro.Location = new System.Drawing.Point(20, 323);
            this.lbRegistro.Name = "lbRegistro";
            this.lbRegistro.Size = new System.Drawing.Size(149, 25);
            this.lbRegistro.TabIndex = 8;
            this.lbRegistro.Text = "Data de registro";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(25, 287);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(198, 30);
            this.txtQuantidade.TabIndex = 4;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(17, 133);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(152, 25);
            this.lbNome.TabIndex = 7;
            this.lbNome.Text = "Nome do cliente";
            // 
            // lbLoja
            // 
            this.lbLoja.AutoSize = true;
            this.lbLoja.Location = new System.Drawing.Point(20, 194);
            this.lbLoja.Name = "lbLoja";
            this.lbLoja.Size = new System.Drawing.Size(49, 25);
            this.lbLoja.TabIndex = 6;
            this.lbLoja.Text = "Loja";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(22, 161);
            this.txtNomeCliente.MaxLength = 50;
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.ReadOnly = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(198, 30);
            this.txtNomeCliente.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID Cliente";
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCliente.Location = new System.Drawing.Point(122, 52);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(113, 41);
            this.btnCliente.TabIndex = 1;
            this.btnCliente.Text = "Buscar";
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(27, 63);
            this.txtIdCliente.MaxLength = 10;
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(69, 30);
            this.txtIdCliente.TabIndex = 0;
            // 
            // txtDregistro
            // 
            this.txtDregistro.Location = new System.Drawing.Point(27, 351);
            this.txtDregistro.Mask = "00/00/0000 90:00:000";
            this.txtDregistro.Name = "txtDregistro";
            this.txtDregistro.ReadOnly = true;
            this.txtDregistro.Size = new System.Drawing.Size(198, 30);
            this.txtDregistro.TabIndex = 5;
            this.txtDregistro.ValidatingType = typeof(System.DateTime);
            // 
            // txtLoja
            // 
            this.txtLoja.Location = new System.Drawing.Point(25, 222);
            this.txtLoja.Name = "txtLoja";
            this.txtLoja.Size = new System.Drawing.Size(198, 30);
            this.txtLoja.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnSelect);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtId);
            this.panel2.Location = new System.Drawing.Point(1000, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 100);
            this.panel2.TabIndex = 1;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSelect.Location = new System.Drawing.Point(122, 31);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(124, 47);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Selecionar";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(21, 40);
            this.txtId.MaxLength = 10;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(76, 30);
            this.txtId.TabIndex = 0;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnVoltar.Location = new System.Drawing.Point(1373, 29);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(133, 51);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.gpboxFiltro);
            this.panel1.Controls.Add(this.lbPesquisar);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.txtPesquisar);
            this.panel1.Location = new System.Drawing.Point(26, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 188);
            this.panel1.TabIndex = 0;
            // 
            // gpboxFiltro
            // 
            this.gpboxFiltro.Controls.Add(this.checkRetirado);
            this.gpboxFiltro.Controls.Add(this.checkEstoque);
            this.gpboxFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpboxFiltro.Location = new System.Drawing.Point(272, 12);
            this.gpboxFiltro.Name = "gpboxFiltro";
            this.gpboxFiltro.Size = new System.Drawing.Size(350, 72);
            this.gpboxFiltro.TabIndex = 3;
            this.gpboxFiltro.TabStop = false;
            this.gpboxFiltro.Text = "Filtro";
            // 
            // checkRetirado
            // 
            this.checkRetirado.AutoSize = true;
            this.checkRetirado.Location = new System.Drawing.Point(188, 29);
            this.checkRetirado.Name = "checkRetirado";
            this.checkRetirado.Size = new System.Drawing.Size(144, 36);
            this.checkRetirado.TabIndex = 1;
            this.checkRetirado.Text = "Retirado";
            this.checkRetirado.UseVisualStyleBackColor = true;
            this.checkRetirado.CheckedChanged += new System.EventHandler(this.checkRetirado_CheckedChanged);
            // 
            // checkEstoque
            // 
            this.checkEstoque.AutoSize = true;
            this.checkEstoque.Location = new System.Drawing.Point(27, 29);
            this.checkEstoque.Name = "checkEstoque";
            this.checkEstoque.Size = new System.Drawing.Size(141, 36);
            this.checkEstoque.TabIndex = 0;
            this.checkEstoque.Text = "Estoque";
            this.checkEstoque.UseVisualStyleBackColor = true;
            this.checkEstoque.CheckedChanged += new System.EventHandler(this.checkEstoque_CheckedChanged);
            // 
            // lbPesquisar
            // 
            this.lbPesquisar.AutoSize = true;
            this.lbPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPesquisar.Location = new System.Drawing.Point(19, 91);
            this.lbPesquisar.Name = "lbPesquisar";
            this.lbPesquisar.Size = new System.Drawing.Size(148, 36);
            this.lbPesquisar.TabIndex = 2;
            this.lbPesquisar.Text = "Pesquisar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(507, 106);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(115, 65);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(25, 130);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(460, 30);
            this.txtPesquisar.TabIndex = 0;
            // 
            // tb_EstoqueTableAdapter
            // 
            this.tb_EstoqueTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // nomeclienteDataGridViewTextBoxColumn
            // 
            this.nomeclienteDataGridViewTextBoxColumn.DataPropertyName = "nomecliente";
            this.nomeclienteDataGridViewTextBoxColumn.HeaderText = "Nome cliente";
            this.nomeclienteDataGridViewTextBoxColumn.MaxInputLength = 80;
            this.nomeclienteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeclienteDataGridViewTextBoxColumn.Name = "nomeclienteDataGridViewTextBoxColumn";
            this.nomeclienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeclienteDataGridViewTextBoxColumn.Width = 200;
            // 
            // lojaDataGridViewTextBoxColumn
            // 
            this.lojaDataGridViewTextBoxColumn.DataPropertyName = "loja";
            this.lojaDataGridViewTextBoxColumn.HeaderText = "Loja";
            this.lojaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lojaDataGridViewTextBoxColumn.Name = "lojaDataGridViewTextBoxColumn";
            this.lojaDataGridViewTextBoxColumn.ReadOnly = true;
            this.lojaDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.MaxInputLength = 10;
            this.quantidadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantidadeDataGridViewTextBoxColumn.Width = 114;
            // 
            // situacaoDataGridViewTextBoxColumn
            // 
            this.situacaoDataGridViewTextBoxColumn.DataPropertyName = "situacao";
            this.situacaoDataGridViewTextBoxColumn.HeaderText = "Situação";
            this.situacaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.situacaoDataGridViewTextBoxColumn.Name = "situacaoDataGridViewTextBoxColumn";
            this.situacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.situacaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.MaxInputLength = 10;
            this.valorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorDataGridViewTextBoxColumn.Width = 80;
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1536, 766);
            this.Controls.Add(this.gpboxEstoque);
            this.MaximizeBox = false;
            this.Name = "Estoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.Estoque_Load);
            this.gpboxEstoque.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEstoqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d2Estoque)).EndInit();
            this.gpboxRetirado.ResumeLayout(false);
            this.gpboxRetirado.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.gpboxSituacao.ResumeLayout(false);
            this.gpboxSituacao.PerformLayout();
            this.gpboxPacote.ResumeLayout(false);
            this.gpboxPacote.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpboxFiltro.ResumeLayout(false);
            this.gpboxFiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpboxEstoque;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lbPesquisar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.GroupBox gpboxFiltro;
        private System.Windows.Forms.CheckBox checkRetirado;
        private System.Windows.Forms.CheckBox checkEstoque;
        private System.Windows.Forms.GroupBox gpboxPacote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.MaskedTextBox txtDregistro;
        private System.Windows.Forms.TextBox txtLoja;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioRetirado;
        private System.Windows.Forms.RadioButton radioEstoque;
        private System.Windows.Forms.Label lbRegistro;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbLoja;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.GroupBox gpboxSituacao;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAtt;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbRetirada;
        private System.Windows.Forms.MaskedTextBox txtDretirada;
        private System.Windows.Forms.GroupBox gpboxRetirado;
        private System.Windows.Forms.Label lbNome2;
        private System.Windows.Forms.TextBox txtNomeRetirada;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.Label lbQuantidade;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.DataGridView tbEstoque;
        private d2Estoque d2Estoque;
        private System.Windows.Forms.BindingSource tbEstoqueBindingSource;
        private d2EstoqueTableAdapters.tb_EstoqueTableAdapter tb_EstoqueTableAdapter;
        private System.Windows.Forms.Button btnWpp1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnWpp2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lojaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
    }
}