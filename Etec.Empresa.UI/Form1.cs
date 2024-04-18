using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Etec.Empresa.BO;


namespace Etec.Empresa.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
        }
        List<Cliente> ListaClientes = new List<Cliente>();

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
                Cliente classCliente = new Cliente();

                classCliente.Nome = TxtNome.Text;
                classCliente.CPF = TxtCPF.Text;
            try
            {
                classCliente.DtNascimento = DateTime.Parse(TxtDtNascimento.Text);
            }
            catch
            {
                MessageBox.Show("Campo Data de nascimento inválida!");
            }
                classCliente.Rua = TxtRua.Text;
            try
            {
                classCliente.Numero = int.Parse(TxtNumero.Text);
            }
            catch
            {
                MessageBox.Show("Campo Numero inválido!");
            }

            ListaClientes.Add(classCliente);
            DgvClientes.DataSource = ListaClientes.ToList();
        }   
    }
}
