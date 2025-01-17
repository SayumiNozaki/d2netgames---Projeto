namespace d2
{
    partial class Financeiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Financeiro));
            this.gpboxFinanceiro = new System.Windows.Forms.GroupBox();
            this.tbFinanceiro = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diainicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diafimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lucroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbFinanceiroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.d2Financeiro = new d2.d2Financeiro();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLucro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAte = new System.Windows.Forms.MaskedTextBox();
            this.txtDe = new System.Windows.Forms.MaskedTextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pnBuscar = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lbPesquisar = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.pnID = new System.Windows.Forms.Panel();
            this.lbID = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.tb_FinanceiroTableAdapter = new d2.d2FinanceiroTableAdapters.tb_FinanceiroTableAdapter();
            this.gpboxFinanceiro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbFinanceiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFinanceiroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d2Financeiro)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnBuscar.SuspendLayout();
            this.pnID.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpboxFinanceiro
            // 
            this.gpboxFinanceiro.Controls.Add(this.tbFinanceiro);
            this.gpboxFinanceiro.Controls.Add(this.panel3);
            this.gpboxFinanceiro.Controls.Add(this.groupBox1);
            this.gpboxFinanceiro.Controls.Add(this.btnVoltar);
            this.gpboxFinanceiro.Controls.Add(this.pnBuscar);
            this.gpboxFinanceiro.Controls.Add(this.pnID);
            this.gpboxFinanceiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpboxFinanceiro.Location = new System.Drawing.Point(12, 12);
            this.gpboxFinanceiro.Name = "gpboxFinanceiro";
            this.gpboxFinanceiro.Size = new System.Drawing.Size(1162, 674);
            this.gpboxFinanceiro.TabIndex = 0;
            this.gpboxFinanceiro.TabStop = false;
            this.gpboxFinanceiro.Text = "Gestão Financeira";
            // 
            // tbFinanceiro
            // 
            this.tbFinanceiro.AllowUserToDeleteRows = false;
            this.tbFinanceiro.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbFinanceiro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tbFinanceiro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbFinanceiro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.diainicioDataGridViewTextBoxColumn,
            this.diafimDataGridViewTextBoxColumn,
            this.lucroDataGridViewTextBoxColumn});
            this.tbFinanceiro.DataSource = this.tbFinanceiroBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbFinanceiro.DefaultCellStyle = dataGridViewCellStyle2;
            this.tbFinanceiro.EnableHeadersVisualStyles = false;
            this.tbFinanceiro.Location = new System.Drawing.Point(55, 201);
            this.tbFinanceiro.MultiSelect = false;
            this.tbFinanceiro.Name = "tbFinanceiro";
            this.tbFinanceiro.ReadOnly = true;
            this.tbFinanceiro.RowHeadersVisible = false;
            this.tbFinanceiro.RowHeadersWidth = 51;
            this.tbFinanceiro.RowTemplate.Height = 24;
            this.tbFinanceiro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbFinanceiro.Size = new System.Drawing.Size(657, 442);
            this.tbFinanceiro.TabIndex = 5;
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
            // diainicioDataGridViewTextBoxColumn
            // 
            this.diainicioDataGridViewTextBoxColumn.DataPropertyName = "diainicio";
            this.diainicioDataGridViewTextBoxColumn.HeaderText = "De";
            this.diainicioDataGridViewTextBoxColumn.MaxInputLength = 30;
            this.diainicioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diainicioDataGridViewTextBoxColumn.Name = "diainicioDataGridViewTextBoxColumn";
            this.diainicioDataGridViewTextBoxColumn.ReadOnly = true;
            this.diainicioDataGridViewTextBoxColumn.Width = 150;
            // 
            // diafimDataGridViewTextBoxColumn
            // 
            this.diafimDataGridViewTextBoxColumn.DataPropertyName = "diafim";
            this.diafimDataGridViewTextBoxColumn.HeaderText = "Até";
            this.diafimDataGridViewTextBoxColumn.MaxInputLength = 30;
            this.diafimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diafimDataGridViewTextBoxColumn.Name = "diafimDataGridViewTextBoxColumn";
            this.diafimDataGridViewTextBoxColumn.ReadOnly = true;
            this.diafimDataGridViewTextBoxColumn.Width = 150;
            // 
            // lucroDataGridViewTextBoxColumn
            // 
            this.lucroDataGridViewTextBoxColumn.DataPropertyName = "lucro";
            this.lucroDataGridViewTextBoxColumn.HeaderText = "Lucro";
            this.lucroDataGridViewTextBoxColumn.MaxInputLength = 10;
            this.lucroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lucroDataGridViewTextBoxColumn.Name = "lucroDataGridViewTextBoxColumn";
            this.lucroDataGridViewTextBoxColumn.ReadOnly = true;
            this.lucroDataGridViewTextBoxColumn.Width = 125;
            // 
            // tbFinanceiroBindingSource
            // 
            this.tbFinanceiroBindingSource.DataMember = "tb_Financeiro";
            this.tbFinanceiroBindingSource.DataSource = this.d2Financeiro;
            // 
            // d2Financeiro
            // 
            this.d2Financeiro.DataSetName = "d2Financeiro";
            this.d2Financeiro.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.btnLimpar);
            this.panel3.Controls.Add(this.btnDel);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Location = new System.Drawing.Point(777, 466);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(207, 177);
            this.panel3.TabIndex = 3;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLimpar.Location = new System.Drawing.Point(21, 116);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(164, 43);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            this.btnLimpar.Enter += new System.EventHandler(this.btnLimpar_Enter);
            this.btnLimpar.Leave += new System.EventHandler(this.btnLimpar_Leave);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDel.Location = new System.Drawing.Point(21, 68);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(164, 42);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "Deletar";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            this.btnDel.Enter += new System.EventHandler(this.btnDel_Enter);
            this.btnDel.Leave += new System.EventHandler(this.btnDel_Leave);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAdd.Location = new System.Drawing.Point(21, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(164, 42);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.Enter += new System.EventHandler(this.btnAdd_Enter);
            this.btnAdd.Leave += new System.EventHandler(this.btnAdd_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtLucro);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAte);
            this.groupBox1.Controls.Add(this.txtDe);
            this.groupBox1.Location = new System.Drawing.Point(736, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 262);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Relatório";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 29);
            this.label4.TabIndex = 29;
            this.label4.Text = "R$";
            // 
            // txtLucro
            // 
            this.txtLucro.Location = new System.Drawing.Point(99, 219);
            this.txtLucro.MaxLength = 50;
            this.txtLucro.Name = "txtLucro";
            this.txtLucro.ReadOnly = true;
            this.txtLucro.Size = new System.Drawing.Size(127, 30);
            this.txtLucro.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 29);
            this.label3.TabIndex = 27;
            this.label3.Text = "Lucro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 29);
            this.label2.TabIndex = 26;
            this.label2.Text = "Até";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "De";
            // 
            // txtAte
            // 
            this.txtAte.Location = new System.Drawing.Point(53, 131);
            this.txtAte.Mask = "00/00/0000 90:00:00";
            this.txtAte.Name = "txtAte";
            this.txtAte.Size = new System.Drawing.Size(208, 30);
            this.txtAte.TabIndex = 1;
            this.txtAte.ValidatingType = typeof(System.DateTime);
            this.txtAte.Enter += new System.EventHandler(this.txtAte_Enter);
            this.txtAte.Leave += new System.EventHandler(this.txtAte_Leave);
            // 
            // txtDe
            // 
            this.txtDe.Location = new System.Drawing.Point(53, 51);
            this.txtDe.Mask = "00/00/0000 90:00:00";
            this.txtDe.Name = "txtDe";
            this.txtDe.Size = new System.Drawing.Size(208, 30);
            this.txtDe.TabIndex = 0;
            this.txtDe.ValidatingType = typeof(System.DateTime);
            this.txtDe.Enter += new System.EventHandler(this.txtDe_Enter);
            this.txtDe.Leave += new System.EventHandler(this.txtDe_Leave);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnVoltar.Location = new System.Drawing.Point(1026, 29);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(130, 51);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            this.btnVoltar.Enter += new System.EventHandler(this.btnVoltar_Enter);
            this.btnVoltar.Leave += new System.EventHandler(this.btnVoltar_Leave);
            // 
            // pnBuscar
            // 
            this.pnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnBuscar.Controls.Add(this.btnBuscar);
            this.pnBuscar.Controls.Add(this.lbPesquisar);
            this.pnBuscar.Controls.Add(this.txtPesquisar);
            this.pnBuscar.Location = new System.Drawing.Point(55, 64);
            this.pnBuscar.Name = "pnBuscar";
            this.pnBuscar.Size = new System.Drawing.Size(482, 107);
            this.pnBuscar.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(358, 39);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(109, 58);
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
            this.lbPesquisar.Location = new System.Drawing.Point(10, 21);
            this.lbPesquisar.Name = "lbPesquisar";
            this.lbPesquisar.Size = new System.Drawing.Size(141, 32);
            this.lbPesquisar.TabIndex = 3;
            this.lbPesquisar.Text = "Pesquisar";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(16, 57);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(304, 30);
            this.txtPesquisar.TabIndex = 0;
            this.txtPesquisar.Enter += new System.EventHandler(this.txtPesquisar_Enter);
            this.txtPesquisar.Leave += new System.EventHandler(this.txtPesquisar_Leave);
            // 
            // pnID
            // 
            this.pnID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnID.Controls.Add(this.lbID);
            this.pnID.Controls.Add(this.txtId);
            this.pnID.Controls.Add(this.btnSelect);
            this.pnID.Location = new System.Drawing.Point(777, 85);
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
            // tb_FinanceiroTableAdapter
            // 
            this.tb_FinanceiroTableAdapter.ClearBeforeFill = true;
            // 
            // Financeiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 697);
            this.Controls.Add(this.gpboxFinanceiro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Financeiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "D2 Net Games";
            this.Load += new System.EventHandler(this.Financeiro_Load);
            this.gpboxFinanceiro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbFinanceiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFinanceiroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d2Financeiro)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnBuscar.ResumeLayout(false);
            this.pnBuscar.PerformLayout();
            this.pnID.ResumeLayout(false);
            this.pnID.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpboxFinanceiro;
        private System.Windows.Forms.Panel pnBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lbPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Panel pnID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLucro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtAte;
        private System.Windows.Forms.MaskedTextBox txtDe;
        private System.Windows.Forms.DataGridView tbFinanceiro;
        private d2Financeiro d2Financeiro;
        private System.Windows.Forms.BindingSource tbFinanceiroBindingSource;
        private d2FinanceiroTableAdapters.tb_FinanceiroTableAdapter tb_FinanceiroTableAdapter;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diainicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diafimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lucroDataGridViewTextBoxColumn;
    }
}