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
	public partial class edicaoFuncionario : Form
	{
		public edicaoFuncionario()
		{
			InitializeComponent();
		}

		private void btnLimpar_Click(object sender, EventArgs e)
		{
			mskCPF.Text = "";
			mskCelular.Text = "";
			mskRG.Text = "";
			mskTelefone.Text = "";
			txtBairro.Text = "";
			txtCidade.Text = "";
			txtEmail.Text = "";
			txtEndereco.Text = "";
			txtNome.Text = "";
			txtObservacoes.Text = "";
			mskCRMV.Text = "";
			mskNumeroCTPS.Text = "";
			mskPIS.Text = "";
			mskSerie.Text = "";
		}
	}
}
