namespace trabalho2Pt1
{
    partial class FrmRelatorioFolha
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
            this.txTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridFolha = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalarioBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adicional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridFolha)).BeginInit();
            this.SuspendLayout();
            // 
            // txTotal
            // 
            this.txTotal.Location = new System.Drawing.Point(119, 431);
            this.txTotal.Name = "txTotal";
            this.txTotal.Size = new System.Drawing.Size(195, 20);
            this.txTotal.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total da Folha";
            // 
            // gridFolha
            // 
            this.gridFolha.AllowUserToAddRows = false;
            this.gridFolha.AllowUserToDeleteRows = false;
            this.gridFolha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFolha.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Matricula,
            this.SalarioBase,
            this.Adicional,
            this.Total,
            this.tipoFuncionario});
            this.gridFolha.Location = new System.Drawing.Point(12, 66);
            this.gridFolha.Name = "gridFolha";
            this.gridFolha.ReadOnly = true;
            this.gridFolha.Size = new System.Drawing.Size(633, 343);
            this.gridFolha.TabIndex = 3;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Matricula
            // 
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.Name = "Matricula";
            this.Matricula.ReadOnly = true;
            // 
            // SalarioBase
            // 
            this.SalarioBase.HeaderText = "Salario Base";
            this.SalarioBase.Name = "SalarioBase";
            this.SalarioBase.ReadOnly = true;
            // 
            // Adicional
            // 
            this.Adicional.HeaderText = "Adicional";
            this.Adicional.Name = "Adicional";
            this.Adicional.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // tipoFuncionario
            // 
            this.tipoFuncionario.HeaderText = "Tipo de Funcionário";
            this.tipoFuncionario.Name = "tipoFuncionario";
            this.tipoFuncionario.ReadOnly = true;
            // 
            // FrmRelatorioFolha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 474);
            this.Controls.Add(this.gridFolha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txTotal);
            this.Name = "FrmRelatorioFolha";
            this.Text = "Folha de Pagamento";
            this.Load += new System.EventHandler(this.FrmRelatorioFolha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridFolha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridFolha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalarioBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adicional;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoFuncionario;
    }
}