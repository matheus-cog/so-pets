using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace soPets
{
    public partial class Form1 : Form
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

        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        // Variáveis para habilitar o mover do form

        int mov;
        int movX;
        int movY;

        // Botões close e minus

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Métodos para habilitar o mover do form

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

        // Verificação de usuário e direcionamento para form Home

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "admin" && txtSenha.Text == "admin")
            {
                MessageBox.Show("Bem-vindo(a) ao Pet's, admin.","Pet's software");
                Home form = new Home();
                form.Show();
                this.Hide();
            }

            else if (txtLogin.Text == "user" && txtSenha.Text == "user")
            {
                MessageBox.Show("Bem-vindo(a) ao Pet's, usuário.", "Pet's software");
                HomeUser formUser = new HomeUser();
                formUser.Show();
                this.Hide();
            }

            else if (txtLogin.Text == "veterinario" && txtSenha.Text == "veterinario")
            {
                MessageBox.Show("Bem-vindo(a) ao Pet's, veterinário.", "Pet's software");
                HomeVeterinary formVeterinary = new HomeVeterinary();
                formVeterinary.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Usuário e senha inválidos, gentileza contactar o administrador.", "Falha de login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
