namespace trabalho2Pt1
{
    partial class CadastroForm
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
            this.LblNome = new System.Windows.Forms.Label();
            this.LblSalario = new System.Windows.Forms.Label();
            this.LblMatricula = new System.Windows.Forms.Label();
            this.GroupTipo = new System.Windows.Forms.GroupBox();
            this.RdAnalista = new System.Windows.Forms.RadioButton();
            this.RdProgramador = new System.Windows.Forms.RadioButton();
            this.RdSuporte = new System.Windows.Forms.RadioButton();
            this.LblAdicional = new System.Windows.Forms.Label();
            this.BtnGravar = new System.Windows.Forms.Button();
            this.txNome = new System.Windows.Forms.TextBox();
            this.txMatricula = new System.Windows.Forms.TextBox();
            this.txSalario = new System.Windows.Forms.TextBox();
            this.txAdicional = new System.Windows.Forms.TextBox();
            this.BtnRelatorio = new System.Windows.Forms.Button();
            this.GroupTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(54, 65);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(35, 13);
            this.LblNome.TabIndex = 0;
            this.LblNome.Text = "Nome";
            // 
            // LblSalario
            // 
            this.LblSalario.AutoSize = true;
            this.LblSalario.Location = new System.Drawing.Point(54, 181);
            this.LblSalario.Name = "LblSalario";
            this.LblSalario.Size = new System.Drawing.Size(66, 13);
            this.LblSalario.TabIndex = 1;
            this.LblSalario.Text = "Salario Base";
            // 
            // LblMatricula
            // 
            this.LblMatricula.AutoSize = true;
            this.LblMatricula.Location = new System.Drawing.Point(54, 121);
            this.LblMatricula.Name = "LblMatricula";
            this.LblMatricula.Size = new System.Drawing.Size(50, 13);
            this.LblMatricula.TabIndex = 2;
            this.LblMatricula.Text = "Matricula";
            // 
            // GroupTipo
            // 
            this.GroupTipo.Controls.Add(this.RdSuporte);
            this.GroupTipo.Controls.Add(this.RdProgramador);
            this.GroupTipo.Controls.Add(this.RdAnalista);
            this.GroupTipo.Location = new System.Drawing.Point(362, 65);
            this.GroupTipo.Name = "GroupTipo";
            this.GroupTipo.Size = new System.Drawing.Size(200, 234);
            this.GroupTipo.TabIndex = 3;
            this.GroupTipo.TabStop = false;
            this.GroupTipo.Text = "Tipo de Funcionário";
            // 
            // RdAnalista
            // 
            this.RdAnalista.AutoSize = true;
            this.RdAnalista.Checked = true;
            this.RdAnalista.Location = new System.Drawing.Point(21, 54);
            this.RdAnalista.Name = "RdAnalista";
            this.RdAnalista.Size = new System.Drawing.Size(62, 17);
            this.RdAnalista.TabIndex = 7;
            this.RdAnalista.TabStop = true;
            this.RdAnalista.Text = "Analista";
            this.RdAnalista.UseVisualStyleBackColor = true;
            this.RdAnalista.CheckedChanged += new System.EventHandler(this.RdAnalista_CheckedChanged);
            // 
            // RdProgramador
            // 
            this.RdProgramador.AutoSize = true;
            this.RdProgramador.Location = new System.Drawing.Point(21, 114);
            this.RdProgramador.Name = "RdProgramador";
            this.RdProgramador.Size = new System.Drawing.Size(85, 17);
            this.RdProgramador.TabIndex = 8;
            this.RdProgramador.Text = "Programador";
            this.RdProgramador.UseVisualStyleBackColor = true;
            this.RdProgramador.CheckedChanged += new System.EventHandler(this.RdProgramador_CheckedChanged);
            // 
            // RdSuporte
            // 
            this.RdSuporte.AutoSize = true;
            this.RdSuporte.Location = new System.Drawing.Point(21, 172);
            this.RdSuporte.Name = "RdSuporte";
            this.RdSuporte.Size = new System.Drawing.Size(62, 17);
            this.RdSuporte.TabIndex = 9;
            this.RdSuporte.Text = "Suporte";
            this.RdSuporte.UseVisualStyleBackColor = true;
            this.RdSuporte.CheckedChanged += new System.EventHandler(this.RdSuporte_CheckedChanged);
            // 
            // LblAdicional
            // 
            this.LblAdicional.AutoSize = true;
            this.LblAdicional.Location = new System.Drawing.Point(54, 237);
            this.LblAdicional.Name = "LblAdicional";
            this.LblAdicional.Size = new System.Drawing.Size(50, 13);
            this.LblAdicional.TabIndex = 4;
            this.LblAdicional.Text = "Adicional";
            // 
            // BtnGravar
            // 
            this.BtnGravar.Location = new System.Drawing.Point(40, 361);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(241, 23);
            this.BtnGravar.TabIndex = 5;
            this.BtnGravar.Text = "Gravar";
            this.BtnGravar.UseVisualStyleBackColor = true;
            this.BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // txNome
            // 
            this.txNome.Location = new System.Drawing.Point(57, 81);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(289, 20);
            this.txNome.TabIndex = 6;
            // 
            // txMatricula
            // 
            this.txMatricula.Location = new System.Drawing.Point(57, 137);
            this.txMatricula.Name = "txMatricula";
            this.txMatricula.Size = new System.Drawing.Size(100, 20);
            this.txMatricula.TabIndex = 7;
            // 
            // txSalario
            // 
            this.txSalario.Location = new System.Drawing.Point(57, 197);
            this.txSalario.Name = "txSalario";
            this.txSalario.Size = new System.Drawing.Size(100, 20);
            this.txSalario.TabIndex = 8;
            // 
            // txAdicional
            // 
            this.txAdicional.Location = new System.Drawing.Point(57, 253);
            this.txAdicional.Name = "txAdicional";
            this.txAdicional.Size = new System.Drawing.Size(100, 20);
            this.txAdicional.TabIndex = 9;
            // 
            // BtnRelatorio
            // 
            this.BtnRelatorio.Location = new System.Drawing.Point(311, 361);
            this.BtnRelatorio.Name = "BtnRelatorio";
            this.BtnRelatorio.Size = new System.Drawing.Size(241, 23);
            this.BtnRelatorio.TabIndex = 10;
            this.BtnRelatorio.Text = "Relatório";
            this.BtnRelatorio.UseVisualStyleBackColor = true;
            this.BtnRelatorio.Click += new System.EventHandler(this.BtnRelatorio_Click);
            // 
            // CadastroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 450);
            this.Controls.Add(this.BtnRelatorio);
            this.Controls.Add(this.txAdicional);
            this.Controls.Add(this.txSalario);
            this.Controls.Add(this.txMatricula);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.BtnGravar);
            this.Controls.Add(this.LblAdicional);
            this.Controls.Add(this.GroupTipo);
            this.Controls.Add(this.LblMatricula);
            this.Controls.Add(this.LblSalario);
            this.Controls.Add(this.LblNome);
            this.Name = "CadastroForm";
            this.Text = "Cadastro de Funcionários";
            this.GroupTipo.ResumeLayout(false);
            this.GroupTipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label LblSalario;
        private System.Windows.Forms.Label LblMatricula;
        private System.Windows.Forms.GroupBox GroupTipo;
        private System.Windows.Forms.RadioButton RdSuporte;
        private System.Windows.Forms.RadioButton RdProgramador;
        private System.Windows.Forms.RadioButton RdAnalista;
        private System.Windows.Forms.Label LblAdicional;
        private System.Windows.Forms.Button BtnGravar;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.TextBox txMatricula;
        private System.Windows.Forms.TextBox txSalario;
        private System.Windows.Forms.TextBox txAdicional;
        private System.Windows.Forms.Button BtnRelatorio;
    }
}

