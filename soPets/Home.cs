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
    public partial class Home : Form
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

        public Home()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));            
        }

        // Variáveis e métodos para movimentação do form

        int mov;
        int movX;
        int movY;

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
            pnlSubCadastro.Visible = false;
            pnlSubEdicao.Visible = false;
            pnlSubRemocao.Visible = false;
            pnlSubListagem.Visible = false;
            pnlSubExame.Visible = false;
        }

        private void showSubmenu(Panel painelToShow) 
        {
            if (painelToShow.Visible == true)
            {
                painelToShow.Visible = false;
            }
            else 
            {
                pnlSubCadastro.Visible = false;
                pnlSubEdicao.Visible = false;
                pnlSubRemocao.Visible = false;
                pnlSubListagem.Visible = false;
                pnlSubExame.Visible = false;

                painelToShow.Visible = true;
            }
        }

        // Método para troca de cor do botão ativo

        private void activeButtonChangeColor(Button botao)
        {
            btnHome.BackColor = Color.FromArgb(29, 82, 117);
            btnCadastro.BackColor = Color.FromArgb(29, 82, 117);
            btnEdicao.BackColor = Color.FromArgb(29, 82, 117);
            btnRemocao.BackColor = Color.FromArgb(29, 82, 117);
            btnListagem.BackColor = Color.FromArgb(29, 82, 117);
            btnExame.BackColor = Color.FromArgb(29, 82, 117);
            btnMedicamentos.BackColor = Color.FromArgb(29, 82, 117);
            btnInfo.BackColor = Color.FromArgb(29, 82, 117);

            botao.BackColor = Color.FromArgb(52, 152, 219);
        }

        // Botões de minus e close

        private void button22_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Botão home
        private void btnHome_Click(object sender, EventArgs e)
        {
            activeButtonChangeColor(btnHome);
            lblTitlebar.Text = "Home";

            openForm(new HomeMain());

            hideAllSubmenu();
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

        // Botão medicamentos

        private void btnMedicamentos_Click(object sender, EventArgs e)
        {
            lblTitlebar.Text = "Indicação de medicamentos";
            activeButtonChangeColor(btnMedicamentos);

            openForm(new receitarMedicamentos());

            hideAllSubmenu();
        }

        // Load

        private void Home_Load(object sender, EventArgs e)
        {
            hideAllSubmenu();
            openForm(new HomeMain());
        }

        // Exibição ou hide dos sub menus e troca de cor do botão referente a operação ativa

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            activeButtonChangeColor(btnCadastro);           
            showSubmenu(pnlSubCadastro);
        }

        private void btnEdicao_Click(object sender, EventArgs e)
        {
            activeButtonChangeColor(btnEdicao);
            showSubmenu(pnlSubEdicao);
        }

        private void btnRemocao_Click(object sender, EventArgs e)
        {
            activeButtonChangeColor(btnRemocao);
            showSubmenu(pnlSubRemocao);
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

        private void button6_Click(object sender, EventArgs e)
        {            
            lblTitlebar.Text = "Cadastro de cliente";
            openForm(new cadastroCliente());
        }

        private void btnCadastroConsulta_Click(object sender, EventArgs e)
        {
            lblTitlebar.Text = "Cadastro de consulta(s)";
            openForm(new cadastroConsulta());
        }

        private void btnCadastroFuncionario_Click(object sender, EventArgs e)
        {
            lblTitlebar.Text = "Cadastro de funcionário(s)";
            openForm(new cadastroFuncionario());
        }

        private void btnCadastroPet_Click(object sender, EventArgs e)
        {
            lblTitlebar.Text = "Cadastro de pet(s)";
            openForm(new cadastroPet());
        }

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

        private void btnEdicaoFuncionario_Click(object sender, EventArgs e)
        {
            lblTitlebar.Text = "Edição de funcionário(s)";
            openForm(new edicaoFuncionario());
        }

        private void btnEdicaoPet_Click(object sender, EventArgs e)
        {
            lblTitlebar.Text = "Edição de pet(s)";
            openForm(new edicaoPet());
        }

        private void btnRemocaoCliente_Click(object sender, EventArgs e)
        {
            lblTitlebar.Text = "Remoção de cliente(s)";
            openForm(new remocaoCliente());
        }

        private void btnRemocaoConsulta_Click(object sender, EventArgs e)
        {
            lblTitlebar.Text = "Remoção de consulta(s)";
            openForm(new remocaoConsulta());
        }

        private void btnRemocaoFuncionario_Click(object sender, EventArgs e)
        {
            lblTitlebar.Text = "Remoção de funcionário(s)";
            openForm(new remocaoFuncionario());
        }

        private void btnRemocaoPet_Click(object sender, EventArgs e)
        {
            lblTitlebar.Text = "Remoção de pet(s)";
            openForm(new remocaoPet());
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

        private void btnListagemFuncionario_Click(object sender, EventArgs e)
        {
            lblTitlebar.Text = "Listagem de funcionário(s)";
            openForm(new listagemFuncionario());
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