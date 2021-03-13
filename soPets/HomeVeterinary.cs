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
	public partial class HomeVeterinary : Form
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

		public HomeVeterinary()
		{
			InitializeComponent();
			Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
		}

		// Botoões minus e close

		private void btnMinus_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
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

		// Métodos de exibição dos paineis

		private void hideAllSubmenu()
		{
			pnlSubEdicao.Visible = false;
			pnlSubListagem.Visible = false;
			pnlSubExame.Visible = false;
		}

		private void hideSubmenu(Panel painelToHide)
		{
			if (painelToHide.Visible == true)
			{
				painelToHide.Visible = false;
			}
		}

		private void showSubmenu(Panel painelToShow)
		{
			if (painelToShow.Visible == true)
			{
				painelToShow.Visible = false;
			}
			else
			{
				pnlSubEdicao.Visible = false;
				pnlSubListagem.Visible = false;
				pnlSubExame.Visible = false;

				painelToShow.Visible = true;
			}
		}

		// Método para troca de cor do botão ativo

		private void activeButtonChangeColor(Button botao)
		{
			btnHome.BackColor = Color.FromArgb(29, 82, 117);
			btnEdicao.BackColor = Color.FromArgb(29, 82, 117);
			btnListagem.BackColor = Color.FromArgb(29, 82, 117);
			btnExame.BackColor = Color.FromArgb(29, 82, 117);
			btnMedicamentos.BackColor = Color.FromArgb(29, 82, 117);
			btnInfo.BackColor = Color.FromArgb(29, 82, 117);

			botao.BackColor = Color.FromArgb(52, 152, 219);
		}

		// Load

		private void HomeVeterinary_Load(object sender, EventArgs e)
		{
			hideAllSubmenu();
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

		// Botão home

		private void btnHome_Click(object sender, EventArgs e)
		{
			activeButtonChangeColor(btnHome);
			lblTitlebar.Text = "Home";

			openForm(new HomeMain());

			hideAllSubmenu();
		}

		// Botão medicamentos

		private void btnMedicamentos_Click(object sender, EventArgs e)
		{
			lblTitlebar.Text = "Indicação de medicamentos";
			activeButtonChangeColor(btnMedicamentos);

			openForm(new receitarMedicamentos());

			hideAllSubmenu();
		}

		// Abrindo submenus e chamando método que troca a cor da opção ativa

		private void btnEdicao_Click(object sender, EventArgs e)
		{
			activeButtonChangeColor(btnEdicao);
			showSubmenu(pnlSubEdicao);
		}

		private void btnListagem_Click(object sender, EventArgs e)
		{
			activeButtonChangeColor(btnListagem);
			showSubmenu(pnlSubListagem);
		}

		private void btnExame_Click(object sender, EventArgs e)
		{
			activeButtonChangeColor(btnExame);
			showSubmenu(pnlSubExame);
		}

		// Abrindo as forms operacionais e alterando o title label

		private void btnEdicaoCliente_Click(object sender, EventArgs e)
		{
			lblTitlebar.Text = "Edição de cliente(s)";
			openForm(new edicaoCliente());
		}

		private void btnEdicaoConsulta_Click(object sender, EventArgs e)
		{
			lblTitlebar.Text = "Edição de consulta(s)";
			openForm(new edicaoConsulta());
		}

		private void btnEdicaoPet_Click(object sender, EventArgs e)
		{
			lblTitlebar.Text = "Edição de pet(s)";
			openForm(new edicaoPet());
		}

		private void btnListagemClientes_Click(object sender, EventArgs e)
		{
			lblTitlebar.Text = "Listagem de cliente(s)";
			openForm(new listagemCliente());
		}

		private void btnListagemConsulta_Click(object sender, EventArgs e)
		{
			lblTitlebar.Text = "Listagem de consulta(s)";
			openForm(new listagemConsulta());
		}

		private void btnListagemPet_Click(object sender, EventArgs e)
		{
			lblTitlebar.Text = "Listagem de pet(s)";
			openForm(new listagemPet());
		}

		private void btnExameSolicitar_Click(object sender, EventArgs e)
		{
			lblTitlebar.Text = "Solicitar exame(s)";
			openForm(new solicitarExame());
		}

		private void btnExameMarcar_Click(object sender, EventArgs e)
		{
			lblTitlebar.Text = "Marcar exame(s)";
			openForm(new marcarExame());
		}

		private void btnExameResultado_Click(object sender, EventArgs e)
		{
			lblTitlebar.Text = "Verificar resultados de exame(s)";
			openForm(new resultadosExame());
		}
	}
}
