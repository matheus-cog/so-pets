using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soPets
{
	public partial class HomeUser : Form
	{
		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
		private static extern IntPtr CreateRoundRectRgn
		(
			int nLeftRect,     // x-coordinate of upper-left corner
			int nTopRect,      // y-coordinate of upper-left corner
			int nRightRect,    // x-coordinate of lower-right corner
			int nBottomRect,   // y-coordinate of lower-right corner
			int nWidthEllipse, // height of ellipse
			int nHeightEllipse // width of ellipse
		);

		public HomeUser()
		{
			InitializeComponent();
			Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
		}

		// Variáveis e métodos para habilitar a movimentação do form

		int mov, movX, movY;

		private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
		{
			mov = 1;
			movX = e.X;
			movY = e.Y;
		}

		private void pnlTitleBar_MouseMove(object sender, MouseEventArgs e)
		{
			if (mov == 1)
			{
				this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
			}
		}

		private void pnlTitleBar_MouseUp(object sender, MouseEventArgs e)
		{
			mov = 0;
		}

		// Método e variável para abrir a form no panel

		Form activeForm;

		private void openForm(Form form)
		{
			if (activeForm != null)
			{
				activeForm.Close();
			}
			activeForm = form;
			form.TopLevel = false;
			form.FormBorderStyle = FormBorderStyle.None;
			form.Dock = DockStyle.Fill;
			pnlHome.Controls.Add(form);
			pnlHome.Tag = form;
			pnlHome.BringToFront();
			pnlHome.Show();
			form.Show();
		}

		// Método para troca de cor do botão ativo

		private void activeButtonChangeColor(Button botao)
		{
			btnHome.BackColor = Color.FromArgb(29, 82, 117);
			btnResultadosExame.BackColor = Color.FromArgb(29, 82, 117);
			btnInfo.BackColor = Color.FromArgb(29, 82, 117);

			botao.BackColor = Color.FromArgb(52, 152, 219);
		}

		// Botão exit

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Botão minus

		private void btnMinus_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		// Botão home

		private void btnHome_Click(object sender, EventArgs e)
		{
			activeButtonChangeColor(btnHome);

			openForm(new HomeMain());

			lblTitlebar.Text = "Home";
		}

		// Botão resultados de exame

		private void btnExame_Click(object sender, EventArgs e)
		{
			activeButtonChangeColor(btnResultadosExame);
			lblTitlebar.Text = "Verificação do resultado de exame(s)";

			openForm(new resultadosExame());
		}

		private void HomeUser_Load(object sender, EventArgs e)
		{
			openForm(new HomeMain());
		}

		// Botão info

		private void btnInfo_Click(object sender, EventArgs e)
		{
			activeButtonChangeColor(btnInfo);
			MessageBox.Show("  Software desenvolvido por: \n\n   - Matheus Campos \n   - Pedro Palmer \n   - Gabryel Alves \n   - Rafael Mourão ", "Informações adicionais", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		// Botão sair

		private void btnSair_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Você realmente deseja fazer o logoff?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Form1 loginform = new Form1();
				loginform.Show();
				this.Hide();
			}
		}
	}
}
