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
	public partial class edicaoConsulta : Form
	{
		public edicaoConsulta()
		{
			InitializeComponent();
		}

		private void btnLimpar_Click(object sender, EventArgs e)
		{
			mskCPF.Text = "";
			txtNome.Text = "";
			txtObservacoes.Text = "";
			txtPrognosticos.Text = "";
			mskCRMV.Text = "";
		}
	}
}
