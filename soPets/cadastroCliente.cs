using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soPets
{
    public partial class cadastroCliente : Form
    {
        public cadastroCliente()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || mskCPF.Text == "" || mskRG.Text == "" || txtEndereco.Text == "" || cmbEstado.Text == "" || txtCidade.Text == "" || txtBairro.Text == "" || mskTelefone.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Todos os campos marcados com um * devem ser preenchidos.", "Informações insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            // Aqui deverão ser colocados os métodos para insert no banco

            else 
            {

            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            mskCPF.Text = "";
            mskRG.Text = "";
            txtEndereco.Text = "";
            cmbEstado.Text = "";
            txtCidade.Text = "";
            txtBairro.Text = "";
            mskCelular.Text = "";
            mskTelefone.Text = "";
            txtEmail.Text = "";
            txtObservacoes.Text = "";
        }
    }
}
