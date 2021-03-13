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
	public partial class remocaoFuncionario : Form
	{
		public remocaoFuncionario()
		{
			InitializeComponent();
		}

		private void btnLimpar_Click(object sender, EventArgs e)
		{
			mskCPF.Text = "";
		}
	}
}
