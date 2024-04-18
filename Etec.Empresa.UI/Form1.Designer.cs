
namespace Etec.Empresa.UI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCPF = new System.Windows.Forms.TextBox();
            this.TxtRua = new System.Windows.Forms.TextBox();
            this.TxtDtNascimento = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.DgvClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "tela de cadastro de cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NOME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DTNASCIMENTO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "RUA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "NUMERO";
            // 
            // TxtCPF
            // 
            this.TxtCPF.Location = new System.Drawing.Point(128, 101);
            this.TxtCPF.Name = "TxtCPF";
            this.TxtCPF.Size = new System.Drawing.Size(258, 20);
            this.TxtCPF.TabIndex = 6;
            // 
            // TxtRua
            // 
            this.TxtRua.Location = new System.Drawing.Point(128, 153);
            this.TxtRua.Name = "TxtRua";
            this.TxtRua.Size = new System.Drawing.Size(258, 20);
            this.TxtRua.TabIndex = 7;
            // 
            // TxtDtNascimento
            // 
            this.TxtDtNascimento.Location = new System.Drawing.Point(128, 127);
            this.TxtDtNascimento.Name = "TxtDtNascimento";
            this.TxtDtNascimento.Size = new System.Drawing.Size(258, 20);
            this.TxtDtNascimento.TabIndex = 8;
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(128, 75);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(258, 20);
            this.TxtNome.TabIndex = 9;
            // 
            // TxtNumero
            // 
            this.TxtNumero.Location = new System.Drawing.Point(128, 179);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(258, 20);
            this.TxtNumero.TabIndex = 10;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(128, 229);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(258, 23);
            this.BtnSalvar.TabIndex = 11;
            this.BtnSalvar.Text = "SALVAR";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // DgvClientes
            // 
            this.DgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClientes.Location = new System.Drawing.Point(12, 272);
            this.DgvClientes.Name = "DgvClientes";
            this.DgvClientes.Size = new System.Drawing.Size(776, 199);
            this.DgvClientes.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 649);
            this.Controls.Add(this.DgvClientes);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.TxtDtNascimento);
            this.Controls.Add(this.TxtRua);
            this.Controls.Add(this.TxtCPF);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtCPF;
        private System.Windows.Forms.TextBox TxtRua;
        private System.Windows.Forms.TextBox TxtDtNascimento;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.DataGridView DgvClientes;
    }
}

