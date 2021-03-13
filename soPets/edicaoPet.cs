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
	public partial class edicaoPet : Form
	{
		public edicaoPet()
		{
			InitializeComponent();
		}

		private void btnLimpar_Click(object sender, EventArgs e)
		{
			mskDataNascimentoPet.Text = "";
			txtBairro.Text = "";
			txtCidade.Text = "";
			txtEndereco.Text = "";
			txtNome.Text = "";
			txtObservacoes.Text = "";
		}
	}
}
