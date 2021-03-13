namespace soPets
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
			this.pnlTitleBar = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblTitlebar = new System.Windows.Forms.Label();
			this.btnMinus = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.pnlNavigation = new System.Windows.Forms.Panel();
			this.btnInfo = new System.Windows.Forms.Button();
			this.btnMedicamentos = new System.Windows.Forms.Button();
			this.pnlSubExame = new System.Windows.Forms.Panel();
			this.btnExameResultado = new System.Windows.Forms.Button();
			this.btnExameMarcar = new System.Windows.Forms.Button();
			this.btnExameSolicitar = new System.Windows.Forms.Button();
			this.btnExame = new System.Windows.Forms.Button();
			this.pnlSubListagem = new System.Windows.Forms.Panel();
			this.btnListagemPet = new System.Windows.Forms.Button();
			this.btnListagemFuncionario = new System.Windows.Forms.Button();
			this.btnListagemConsulta = new System.Windows.Forms.Button();
			this.btnListagemClientes = new System.Windows.Forms.Button();
			this.btnListagem = new System.Windows.Forms.Button();
			this.pnlSubRemocao = new System.Windows.Forms.Panel();
			this.btnRemocaoPet = new System.Windows.Forms.Button();
			this.btnRemocaoFuncionario = new System.Windows.Forms.Button();
			this.btnRemocaoConsulta = new System.Windows.Forms.Button();
			this.btnRemocaoCliente = new System.Windows.Forms.Button();
			this.btnRemocao = new System.Windows.Forms.Button();
			this.pnlSubEdicao = new System.Windows.Forms.Panel();
			this.btnEdicaoPet = new System.Windows.Forms.Button();
			this.btnEdicaoFuncionario = new System.Windows.Forms.Button();
			this.btnEdicaoConsulta = new System.Windows.Forms.Button();
			this.btnEdicaoCliente = new System.Windows.Forms.Button();
			this.btnEdicao = new System.Windows.Forms.Button();
			this.pnlSubCadastro = new System.Windows.Forms.Panel();
			this.btnCadastroPet = new System.Windows.Forms.Button();
			this.btnCadastroFuncionario = new System.Windows.Forms.Button();
			this.btnCadastroConsulta = new System.Windows.Forms.Button();
			this.btnCadastroCliente = new System.Windows.Forms.Button();
			this.btnCadastro = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnHome = new System.Windows.Forms.Button();
			this.btnSair = new System.Windows.Forms.Button();
			this.pnlHome = new System.Windows.Forms.Panel();
			this.pnlTitleBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.pnlNavigation.SuspendLayout();
			this.pnlSubExame.SuspendLayout();
			this.pnlSubListagem.SuspendLayout();
			this.pnlSubRemocao.SuspendLayout();
			this.pnlSubEdicao.SuspendLayout();
			this.pnlSubCadastro.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlTitleBar
			// 
			this.pnlTitleBar.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.pnlTitleBar.Controls.Add(this.pictureBox1);
			this.pnlTitleBar.Controls.Add(this.lblTitlebar);
			this.pnlTitleBar.Controls.Add(this.btnMinus);
			this.pnlTitleBar.Controls.Add(this.btnExit);
			this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTitleBar.Location = new System.Drawing.Point(237, 0);
			this.pnlTitleBar.Name = "pnlTitleBar";
			this.pnlTitleBar.Size = new System.Drawing.Size(765, 43);
			this.pnlTitleBar.TabIndex = 1;
			this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
			this.pnlTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseMove);
			this.pnlTitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseUp);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::soPets.Properties.Resources.logo_transparent_cropped;
			this.pictureBox1.Location = new System.Drawing.Point(6, 6);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(33, 31);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// lblTitlebar
			// 
			this.lblTitlebar.AutoSize = true;
			this.lblTitlebar.Font = new System.Drawing.Font("Microsoft YaHei", 10.25F, System.Drawing.FontStyle.Bold);
			this.lblTitlebar.Location = new System.Drawing.Point(45, 12);
			this.lblTitlebar.Name = "lblTitlebar";
			this.lblTitlebar.Size = new System.Drawing.Size(52, 19);
			this.lblTitlebar.TabIndex = 5;
			this.lblTitlebar.Text = "Home";
			// 
			// btnMinus
			// 
			this.btnMinus.BackgroundImage = global::soPets.Properties.Resources.iconMinus__black_;
			this.btnMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnMinus.FlatAppearance.BorderSize = 0;
			this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMinus.Location = new System.Drawing.Point(703, 9);
			this.btnMinus.Name = "btnMinus";
			this.btnMinus.Size = new System.Drawing.Size(22, 22);
			this.btnMinus.TabIndex = 4;
			this.btnMinus.UseVisualStyleBackColor = true;
			this.btnMinus.Click += new System.EventHandler(this.button23_Click);
			// 
			// btnExit
			// 
			this.btnExit.BackgroundImage = global::soPets.Properties.Resources.iconClose__black_;
			this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnExit.FlatAppearance.BorderSize = 0;
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.Location = new System.Drawing.Point(731, 9);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(22, 22);
			this.btnExit.TabIndex = 3;
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.button22_Click);
			// 
			// pnlNavigation
			// 
			this.pnlNavigation.AutoScroll = true;
			this.pnlNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(82)))), ((int)(((byte)(117)))));
			this.pnlNavigation.Controls.Add(this.btnInfo);
			this.pnlNavigation.Controls.Add(this.btnMedicamentos);
			this.pnlNavigation.Controls.Add(this.pnlSubExame);
			this.pnlNavigation.Controls.Add(this.btnExame);
			this.pnlNavigation.Controls.Add(this.pnlSubListagem);
			this.pnlNavigation.Controls.Add(this.btnListagem);
			this.pnlNavigation.Controls.Add(this.pnlSubRemocao);
			this.pnlNavigation.Controls.Add(this.btnRemocao);
			this.pnlNavigation.Controls.Add(this.pnlSubEdicao);
			this.pnlNavigation.Controls.Add(this.btnEdicao);
			this.pnlNavigation.Controls.Add(this.pnlSubCadastro);
			this.pnlNavigation.Controls.Add(this.btnCadastro);
			this.pnlNavigation.Controls.Add(this.panel2);
			this.pnlNavigation.Controls.Add(this.btnSair);
			this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlNavigation.Location = new System.Drawing.Point(0, 0);
			this.pnlNavigation.Name = "pnlNavigation";
			this.pnlNavigation.Size = new System.Drawing.Size(237, 565);
			this.pnlNavigation.TabIndex = 0;
			// 
			// btnInfo
			// 
			this.btnInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnInfo.FlatAppearance.BorderSize = 0;
			this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInfo.Font = new System.Drawing.Font("Corbel", 9F);
			this.btnInfo.ForeColor = System.Drawing.Color.White;
			this.btnInfo.Image = global::soPets.Properties.Resources.baseline_info_white_18dp;
			this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnInfo.Location = new System.Drawing.Point(0, 1021);
			this.btnInfo.Name = "btnInfo";
			this.btnInfo.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
			this.btnInfo.Size = new System.Drawing.Size(220, 42);
			this.btnInfo.TabIndex = 27;
			this.btnInfo.Text = "Info";
			this.btnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnInfo.UseVisualStyleBackColor = true;
			this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
			// 
			// btnMedicamentos
			// 
			this.btnMedicamentos.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnMedicamentos.FlatAppearance.BorderSize = 0;
			this.btnMedicamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMedicamentos.Font = new System.Drawing.Font("Corbel", 9F);
			this.btnMedicamentos.ForeColor = System.Drawing.Color.White;
			this.btnMedicamentos.Image = global::soPets.Properties.Resources.icon_medicine;
			this.btnMedicamentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnMedicamentos.Location = new System.Drawing.Point(0, 979);
			this.btnMedicamentos.Name = "btnMedicamentos";
			this.btnMedicamentos.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
			this.btnMedicamentos.Size = new System.Drawing.Size(220, 42);
			this.btnMedicamentos.TabIndex = 33;
			this.btnMedicamentos.Text = "Receitar medicamentos";
			this.btnMedicamentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnMedicamentos.UseVisualStyleBackColor = true;
			this.btnMedicamentos.Click += new System.EventHandler(this.btnMedicamentos_Click);
			// 
			// pnlSubExame
			// 
			this.pnlSubExame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
			this.pnlSubExame.Controls.Add(this.btnExameResultado);
			this.pnlSubExame.Controls.Add(this.btnExameMarcar);
			this.pnlSubExame.Controls.Add(this.btnExameSolicitar);
			this.pnlSubExame.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlSubExame.Location = new System.Drawing.Point(0, 865);
			this.pnlSubExame.Name = "pnlSubExame";
			this.pnlSubExame.Size = new System.Drawing.Size(220, 114);
			this.pnlSubExame.TabIndex = 32;
			// 
			// btnExameResultado
			// 
			this.btnExameResultado.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnExameResultado.FlatAppearance.BorderSize = 0;
			this.btnExameResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExameResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.btnExameResultado.ForeColor = System.Drawing.Color.White;
			this.btnExameResultado.Location = new System.Drawing.Point(0, 76);
			this.btnExameResultado.Name = "btnExameResultado";
			this.btnExameResultado.Padding = new System.Windows.Forms.Padding(37, 0, 0, 0);
			this.btnExameResultado.Size = new System.Drawing.Size(220, 38);
			this.btnExameResultado.TabIndex = 2;
			this.btnExameResultado.Text = "Ver resultados";
			this.btnExameResultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExameResultado.UseVisualStyleBackColor = true;
			this.btnExameResultado.Click += new System.EventHandler(this.btnExameResultado_Click);
			// 
			// btnExameMarcar
			// 
			this.btnExameMarcar.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnExameMarcar.FlatAppearance.BorderSize = 0;
			this.btnExameMarcar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExameMarcar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.btnExameMarcar.ForeColor = System.Drawing.Color.White;
			this.btnExameMarcar.Location = new System.Drawing.Point(0, 38);
			this.btnExameMarcar.Name = "btnExameMarcar";
			this.btnExameMarcar.Padding = new System.Windows.Forms.Padding(37, 0, 0, 0);
			this.btnExameMarcar.Size = new System.Drawing.Size(220, 38);
			this.btnExameMarcar.TabIndex = 1;
			this.btnExameMarcar.Text = "Marcar";
			this.btnExameMarcar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExameMarcar.UseVisualStyleBackColor = true;
			this.btnExameMarcar.Click += new System.EventHandler(this.btnExameMarcar_Click);
			// 
			// btnExameSolicitar
			// 
			this.btnExameSolicitar.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnExameSolicitar.FlatAppearance.BorderSize = 0;
			this.btnExameSolicitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExameSolicitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.btnExameSolicitar.ForeColor = System.Drawing.Color.White;
			this.btnExameSolicitar.Location = new System.Drawing.Point(0, 0);
			this.btnExameSolicitar.Name = "btnExameSolicitar";
			this.btnExameSolicitar.Padding = new System.Windows.Forms.Padding(37, 0, 0, 0);
			this.btnExameSolicitar.Size = new System.Drawing.Size(220, 38);
			this.btnExameSolicitar.TabIndex = 0;
			this.btnExameSolicitar.Text = "Solicitar";
			this.btnExameSolicitar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExameSolicitar.UseVisualStyleBackColor = true;
			this.btnExameSolicitar.Click += new System.EventHandler(this.btnExameSolicitar_Click);
			// 
			// btnExame
			// 
			this.btnExame.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnExame.FlatAppearance.BorderSize = 0;
			this.btnExame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExame.Font = new System.Drawing.Font("Corbel", 9F);
			this.btnExame.ForeColor = System.Drawing.Color.White;
			this.btnExame.Image = global::soPets.Properties.Resources.baseline_description_white_18dp;
			this.btnExame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExame.Location = new System.Drawing.Point(0, 823);
			this.btnExame.Name = "btnExame";
			this.btnExame.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
			this.btnExame.Size = new System.Drawing.Size(220, 42);
			this.btnExame.TabIndex = 31;
			this.btnExame.Text = "Exame";
			this.btnExame.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnExame.UseVisualStyleBackColor = true;
			this.btnExame.Click += new System.EventHandler(this.btnExame_Click);
			// 
			// pnlSubListagem
			// 
			this.pnlSubListagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
			this.pnlSubListagem.Controls.Add(this.btnListagemPet);
			this.pnlSubListagem.Controls.Add(this.btnListagemFuncionario);
			this.pnlSubListagem.Controls.Add(this.btnListagemConsulta);
			this.pnlSubListagem.Controls.Add(this.btnListagemClientes);
			this.pnlSubListagem.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlSubListagem.Location = new System.Drawing.Point(0, 671);
			this.pnlSubListagem.Name = "pnlSubListagem";
			this.pnlSubListagem.Size = new System.Drawing.Size(220, 152);
			this.pnlSubListagem.TabIndex = 30;
			// 
			// btnListagemPet
			// 
			this.btnListagemPet.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnListagemPet.FlatAppearance.BorderSize = 0;
			this.btnListagemPet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnListagemPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.btnListagemPet.ForeColor = System.Drawing.Color.White;
			this.btnListagemPet.Location = new System.Drawing.Point(0, 114);
			this.btnListagemPet.Name = "btnListagemPet";
			this.btnListagemPet.Padding = new System.Windows.Forms.Padding(37, 0, 0, 0);
			this.btnListagemPet.Size = new System.Drawing.Size(220, 38);
			this.btnListagemPet.TabIndex = 3;
			this.btnListagemPet.Text = "Pet";
			this.btnListagemPet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnListagemPet.UseVisualStyleBackColor = true;
			this.btnListagemPet.Click += new System.EventHandler(this.btnListagemPet_Click);
			// 
			// btnListagemFuncionario
			// 
			this.btnListagemFuncionario.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnListagemFuncionario.FlatAppearance.BorderSize = 0;
			this.btnListagemFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnListagemFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.btnListagemFuncionario.ForeColor = System.Drawing.Color.White;
			this.btnListagemFuncionario.Location = new System.Drawing.Point(0, 76);
			this.btnListagemFuncionario.Name = "btnListagemFuncionario";
			this.btnListagemFuncionario.Padding = new System.Windows.Forms.Padding(37, 0, 0, 0);
			this.btnListagemFuncionario.Size = new System.Drawing.Size(220, 38);
			this.btnListagemFuncionario.TabIndex = 2;
			this.btnListagemFuncionario.Text = "Funcionário";
			this.btnListagemFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnListagemFuncionario.UseVisualStyleBackColor = true;
			this.btnListagemFuncionario.Click += new System.EventHandler(this.btnListagemFuncionario_Click);
			// 
			// btnListagemConsulta
			// 
			this.btnListagemConsulta.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnListagemConsulta.FlatAppearance.BorderSize = 0;
			this.btnListagemConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnListagemConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.btnListagemConsulta.ForeColor = System.Drawing.Color.White;
			this.btnListagemConsulta.Location = new System.Drawing.Point(0, 38);
			this.btnListagemConsulta.Name = "btnListagemConsulta";
			this.btnListagemConsulta.Padding = new System.Windows.Forms.Padding(37, 0, 0, 0);
			this.btnListagemConsulta.Size = new System.Drawing.Size(220, 38);
			this.btnListagemConsulta.TabIndex = 1;
			this.btnListagemConsulta.Text = "Consulta";
			this.btnListagemConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnListagemConsulta.UseVisualStyleBackColor = true;
			this.btnListagemConsulta.Click += new System.EventHandler(this.btnListagemConsulta_Click);
			// 
			// btnListagemClientes
			// 
			this.btnListagemClientes.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnListagemClientes.FlatAppearance.BorderSize = 0;
			this.btnListagemClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnListagemClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.btnListagemClientes.ForeColor = System.Drawing.Color.White;
			this.btnListagemClientes.Location = new System.Drawing.Point(0, 0);
			this.btnListagemClientes.Name = "btnListagemClientes";
			this.btnListagemClientes.Padding = new System.Windows.Forms.Padding(37, 0, 0, 0);
			this.btnListagemClientes.Size = new System.Drawing.Size(220, 38);
			this.btnListagemClientes.TabIndex = 0;
			this.btnListagemClientes.Text = "Clientes";
			this.btnListagemClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnListagemClientes.UseVisualStyleBackColor = true;
			this.btnListagemClientes.Click += new System.EventHandler(this.btnListagemClientes_Click);
			// 
			// btnListagem
			// 
			this.btnListagem.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnListagem.FlatAppearance.BorderSize = 0;
			this.btnListagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnListagem.Font = new System.Drawing.Font("Corbel", 9F);
			this.btnListagem.ForeColor = System.Drawing.Color.White;
			this.btnListagem.Image = ((System.Drawing.Image)(resources.GetObject("btnListagem.Image")));
			this.btnListagem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnListagem.Location = new System.Drawing.Point(0, 629);
			this.btnListagem.Name = "btnListagem";
			this.btnListagem.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
			this.btnListagem.Size = new System.Drawing.Size(220, 42);
			this.btnListagem.TabIndex = 26;
			this.btnListagem.Text = "Listagem";
			this.btnListagem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnListagem.UseVisualStyleBackColor = true;
			this.btnListagem.Click += new System.EventHandler(this.btnListagem_Click);
			// 
			// pnlSubRemocao
			// 
			this.pnlSubRemocao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
			this.pnlSubRemocao.Controls.Add(this.btnRemocaoPet);
			this.pnlSubRemocao.Controls.Add(this.btnRemocaoFuncionario);
			this.pnlSubRemocao.Controls.Add(this.btnRemocaoConsulta);
			this.pnlSubRemocao.Controls.Add(this.btnRemocaoCliente);
			this.pnlSubRemocao.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlSubRemocao.Location = new System.Drawing.Point(0, 477);
			this.pnlSubRemocao.Name = "pnlSubRemocao";
			this.pnlSubRemocao.Size = new System.Drawing.Size(220, 152);
			this.pnlSubRemocao.TabIndex = 29;
			// 
			// btnRemocaoPet
			// 
			this.btnRemocaoPet.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnRemocaoPet.FlatAppearance.BorderSize = 0;
			this.btnRemocaoPet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRemocaoPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.btnRemocaoPet.ForeColor = System.Drawing.Color.White;
			this.btnRemocaoPet.Location = new System.Drawing.Point(0, 114);
			this.btnRemocaoPet.Name = "btnRemocaoPet";
			this.btnRemocaoPet.Padding = new System.Windows.Forms.Padding(37, 0, 0, 0);
			this.btnRemocaoPet.Size = new System.Drawing.Size(220, 38);
			this.btnRemocaoPet.TabIndex = 3;
			this.btnRemocaoPet.Text = "Pet";
			this.btnRemocaoPet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRemocaoPet.UseVisualStyleBackColor = true;
			this.btnRemocaoPet.Click += new System.EventHandler(this.btnRemocaoPet_Click);
			// 
			// btnRemocaoFuncionario
			// 
			this.btnRemocaoFuncionario.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnRemocaoFuncionario.FlatAppearance.BorderSize = 0;
			this.btnRemocaoFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRemocaoFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.btnRemocaoFuncionario.ForeColor = System.Drawing.Color.White;
			this.btnRemocaoFuncionario.Location = new System.Drawing.Point(0, 76);
			this.btnRemocaoFuncionario.Name = "btnRemocaoFuncionario";
			this.btnRemocaoFuncionario.Padding = new System.Windows.Forms.Padding(37, 0, 0, 0);
			this.btnRemocaoFuncionario.Size = new System.Drawing.Size(220, 38);
			this.btnRemocaoFuncionario.TabIndex = 2;
			this.btnRemocaoFuncionario.Text = "Funcionário";
			this.btnRemocaoFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRemocaoFuncionario.UseVisualStyleBackColor = true;
			this.btnRemocaoFuncionario.Click += new System.EventHandler(this.btnRemocaoFuncionario_Click);
			// 
			// btnRemocaoConsulta
			// 
			this.btnRemocaoConsulta.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnRemocaoConsulta.FlatAppearance.BorderSize = 0;
			this.btnRemocaoConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRemocaoConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.btnRemocaoConsulta.ForeColor = System.Drawing.Color.White;
			this.btnRemocaoConsulta.Location = new System.Drawing.Point(0, 38);
			this.btnRemocaoConsulta.Name = "btnRemocaoConsulta";
			this.btnRemocaoConsulta.Padding = new System.Windows.Forms.Padding(37, 0, 0, 0);
			this.btnRemocaoConsulta.Size = new System.Drawing.Size(220, 38);
			this.btnRemocaoConsulta.TabIndex = 1;
			this.btnRemocaoConsulta.Text = "Consulta";
			this.btnRemocaoConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRemocaoConsulta.UseVisualStyleBackColor = true;
			this.btnRemocaoConsulta.Click += new System.EventHandler(this.btnRemocaoConsulta_Click);
			// 
			// btnRemocaoCliente
			// 
			this.btnRemocaoCliente.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnRemocaoCliente.FlatAppearance.BorderSize = 0;
			this.btnRemocaoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRemocaoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.btnRemocaoCliente.ForeColor = System.Drawing.Color.White;
			this.btnRemocaoCliente.Location = new System.Drawing.Point(0, 0);
			this.btnRemocaoCliente.Name = "btnRemocaoCliente";
			this.btnRemocaoCliente.Padding = new System.Windows.Forms.Padding(37, 0, 0, 0);
			this.btnRemocaoCliente.Size = new System.Drawing.Size(220, 38);
			this.btnRemocaoCliente.TabIndex = 0;
			this.btnRemocaoCliente.Text = "Clientes";
			this.btnRemocaoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRemocaoCliente.UseVisualStyleBackColor = true;
			this.btnRemocaoCliente.Click += new System.EventHandler(this.btnRemocaoCliente_Click);
			// 
			// btnRemocao
			// 
			this.btnRemocao.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnRemocao.FlatAppearance.BorderSize = 0;
			this.btnRemocao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRemocao.Font = new System.Drawing.Font("Corbel", 9F);
			this.btnRemocao.ForeColor = System.Drawing.Color.White;
			this.btnRemocao.Image = global::soPets.Properties.Resources.baseline_delete_white_18dp;
			this.btnRemocao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRemocao.Location = new System.Drawing.Point(0, 435);
			this.btnRemocao.Name = "btnRemocao";
			this.btnRemocao.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
			this.btnRemocao.Size = new System.Drawing.Size(220, 42);
			this.btnRemocao.TabIndex = 25;
			this.btnRemocao.Text = "Remoção";
			this.btnRemocao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRemocao.UseVisualStyleBackColor = true;
			this.btnRemocao.Click += new System.EventHandler(this.btnRemocao_Click);
			// 
			// pnlSubEdicao
			// 
			this.pnlSubEdicao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
			this.pnlSubEdicao.Controls.Add(this.btnEdicaoPet);
			this.pnlSubEdicao.Controls.Add(this.btnEdicaoFuncionario);
			this.pnlSubEdicao.Controls.Add(this.btnEdicaoConsulta);
			this.pnlSubEdicao.Controls.Add(this.btnEdicaoCliente);
			this.pnlSubEdicao.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlSubEdicao.Location = new System.Drawing.Point(0, 283);
			this.pnlSubEdicao.Name = "pnlSubEdicao";
			this.pnlSubEdicao.Size = new System.Drawing.Size(220, 152);
			this.pnlSubEdicao.TabIndex = 28;
			// 
			// btnEdicaoPet
			// 
			this.btnEdicaoPet.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnEdicaoPet.FlatAppearance.BorderSize = 0;
			this.btnEdicaoPet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEdicaoPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.btnEdicaoPet.ForeColor = System.Drawing.Color.White;
			this.btnEdicaoPet.Location = new System.Drawing.Point(0, 114);
			this.btnEdicaoPet.Name = "btnEdicaoPet";
			this.btnEdicaoPet.Padding = new System.Windows.Forms.Padding(37, 0, 0, 0);
			this.btnEdicaoPet.Size = new System.Drawing.Size(220, 38);
			this.btnEdicaoPet.TabIndex = 3;
			this.btnEdicaoPet.Text = "Pet";
			this.btnEdicaoPet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEdicaoPet.UseVisualStyleBackColor = true;
			this.btnEdicaoPet.Click += new System.EventHandler(this.btnEdicaoPet_Click);
			// 
			// btnEdicaoFuncionario
			// 
			this.btnEdicaoFuncionario.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnEdicaoFuncionario.FlatAppearance.BorderSize = 0;
			this.btnEdicaoFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEdicaoFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.btnEdicaoFuncionario.ForeColor = System.Drawing.Color.White;
			this.btnEdicaoFuncionario.Location = new System.Drawing.Point(0, 76);
			this.btnEdicaoFuncionario.Name = "btnEdicaoFuncionario";
			this.btnEdicaoFuncionario.Padding = new System.Windows.Forms.Padding(37, 0, 0, 0);
			this.btnEdicaoFuncionario.Size = new System.Drawing.Size(220, 38);
			this.btnEdicaoFuncionario.TabIndex = 2;
			this.btnEdicaoFuncionario.Text = "Funcionário";
			this.btnEdicaoFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEdicaoFuncionario.UseVisualStyleBackColor = true;
			this.btnEdicaoFuncionario.Click += new System.EventHandler(this.btnEdicaoFuncionario_Click);
			// 
			// btnEdicaoConsulta
			// 
			this.btnEdicaoConsulta.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnEdicaoConsulta.FlatAppearance.BorderSize = 0;
			this.btnEdicaoConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEdicaoConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.btnEdicaoConsulta.ForeColor = System.Drawing.Color.White;
			this.btnEdicaoConsulta.Location = new System.Drawing.Point(0, 38);
			this.btnEdicaoConsulta.Name = "btnEdicaoConsulta";
			this.btnEdicaoConsulta.Padding = new System.Windows.Forms.Padding(37, 0, 0, 0);
			this.btnEdicaoConsulta.Size = new System.Drawing.Size(220, 38);
			this.btnEdicaoConsulta.TabIndex = 1;
			this.btnEdicaoConsulta.Text = "Consulta";
			this.btnEdicaoConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEdicaoConsulta.UseVisualStyleBackColor = true;
			this.btnEdicaoConsulta.Click += new System.EventHandler(this.btnEdicaoConsulta_Click);
			// 
			// btnEdicaoCliente
			// 
			this.btnEdicaoCliente.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnEdicaoCliente.FlatAppearance.BorderSize = 0;
			this.btnEdicaoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEdicaoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.btnEdicaoCliente.ForeColor = System.Drawing.Color.White;
			this.btnEdicaoCliente.Location = new System.Drawing.Point(0, 0);
			this.btnEdicaoCliente.Name = "btnEdicaoCliente";
			this.btnEdicaoCliente.Padding = new System.Windows.Forms.Padding(37, 0, 0, 0);
			this.btnEdicaoCliente.Size = new System.Drawing.Size(220, 38);
			this.btnEdicaoCliente.TabIndex = 0;
			this.btnEdicaoCliente.Text = "Clientes";
			this.btnEdicaoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEdicaoCliente.UseVisualStyleBackColor = true;
			this.btnEdicaoCliente.Click += new System.EventHandler(this.btnEdicaoCliente_Click);
			// 
			// btnEdicao
			// 
			this.btnEdicao.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnEdicao.FlatAppearance.BorderSize = 0;
			this.btnEdicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEdicao.Font = new System.Drawing.Font("Corbel", 9F);
			this.btnEdicao.ForeColor = System.Drawing.Color.White;
			this.btnEdicao.Image = ((System.Drawing.Image)(resources.GetObject("btnEdicao.Image")));
			this.btnEdicao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEdicao.Location = new System.Drawing.Point(0, 241);
			this.btnEdicao.Name = "btnEdicao";
			this.btnEdicao.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
			this.btnEdicao.Size = new System.Drawing.Size(220, 42);
			this.btnEdicao.TabIndex = 24;
			this.btnEdicao.Text = "Edição";
			this.btnEdicao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEdicao.UseVisualStyleBackColor = true;
			this.btnEdicao.Click += new System.EventHandler(this.btnEdicao_Click);
			// 
			// pnlSubCadastro
			// 
			this.pnlSubCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
			this.pnlSubCadastro.Controls.Add(this.btnCadastroPet);
			this.pnlSubCadastro.Controls.Add(this.btnCadastroFuncionario);
			this.pnlSubCadastro.Controls.Add(this.btnCadastroConsulta);
			this.pnlSubCadastro.Controls.Add(this.btnCadastroCliente);
			this.pnlSubCadastro.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlSubCadastro.Location = new System.Drawing.Point(0, 89);
			this.pnlSubCadastro.Name = "pnlSubCadastro";
			this.pnlSubCadastro.Size = new System.Drawing.Size(220, 152);
			this.pnlSubCadastro.TabIndex = 23;
			// 
			// btnCadastroPet
			// 
			this.btnCadastroPet.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnCadastroPet.FlatAppearance.BorderSize = 0;
			this.btnCadastroPet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCadastroPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.btnCadastroPet.ForeColor = System.Drawing.Color.White;
			this.btnCadastroPet.Location = new System.Drawing.Point(0, 114);
			this.btnCadastroPet.Name = "btnCadastroPet";
			this.btnCadastroPet.Padding = new System.Windows.Forms.Padding(37, 0, 0, 0);
			this.btnCadastroPet.Size = new System.Drawing.Size(220, 38);
			this.btnCadastroPet.TabIndex = 3;
			this.btnCadastroPet.Text = "Pet";
			this.btnCadastroPet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCadastroPet.UseVisualStyleBackColor = true;
			this.btnCadastroPet.Click += new System.EventHandler(this.btnCadastroPet_Click);
			// 
			// btnCadastroFuncionario
			// 
			this.btnCadastroFuncionario.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnCadastroFuncionario.FlatAppearance.BorderSize = 0;
			this.btnCadastroFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCadastroFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.btnCadastroFuncionario.ForeColor = System.Drawing.Color.White;
			this.btnCadastroFuncionario.Location = new System.Drawing.Point(0, 76);
			this.btnCadastroFuncionario.Name = "btnCadastroFuncionario";
			this.btnCadastroFuncionario.Padding = new System.Windows.Forms.Padding(37, 0, 0, 0);
			this.btnCadastroFuncionario.Size = new System.Drawing.Size(220, 38);
			this.btnCadastroFuncionario.TabIndex = 2;
			this.btnCadastroFuncionario.Text = "Funcionário";
			this.btnCadastroFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCadastroFuncionario.UseVisualStyleBackColor = true;
			this.btnCadastroFuncionario.Click += new System.EventHandler(this.btnCadastroFuncionario_Click);
			// 
			// btnCadastroConsulta
			// 
			this.btnCadastroConsulta.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnCadastroConsulta.FlatAppearance.BorderSize = 0;
			this.btnCadastroConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCadastroConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.btnCadastroConsulta.ForeColor = System.Drawing.Color.White;
			this.btnCadastroConsulta.Location = new System.Drawing.Point(0, 38);
			this.btnCadastroConsulta.Name = "btnCadastroConsulta";
			this.btnCadastroConsulta.Padding = new System.Windows.Forms.Padding(37, 0, 0, 0);
			this.btnCadastroConsulta.Size = new System.Drawing.Size(220, 38);
			this.btnCadastroConsulta.TabIndex = 1;
			this.btnCadastroConsulta.Text = "Consulta";
			this.btnCadastroConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCadastroConsulta.UseVisualStyleBackColor = true;
			this.btnCadastroConsulta.Click += new System.EventHandler(this.btnCadastroConsulta_Click);
			// 
			// btnCadastroCliente
			// 
			this.btnCadastroCliente.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnCadastroCliente.FlatAppearance.BorderSize = 0;
			this.btnCadastroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCadastroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.btnCadastroCliente.ForeColor = System.Drawing.Color.White;
			this.btnCadastroCliente.Location = new System.Drawing.Point(0, 0);
			this.btnCadastroCliente.Name = "btnCadastroCliente";
			this.btnCadastroCliente.Padding = new System.Windows.Forms.Padding(37, 0, 0, 0);
			this.btnCadastroCliente.Size = new System.Drawing.Size(220, 38);
			this.btnCadastroCliente.TabIndex = 0;
			this.btnCadastroCliente.Text = "Clientes";
			this.btnCadastroCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCadastroCliente.UseVisualStyleBackColor = true;
			this.btnCadastroCliente.Click += new System.EventHandler(this.button6_Click);
			// 
			// btnCadastro
			// 
			this.btnCadastro.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnCadastro.FlatAppearance.BorderSize = 0;
			this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCadastro.Font = new System.Drawing.Font("Corbel", 9F);
			this.btnCadastro.ForeColor = System.Drawing.Color.White;
			this.btnCadastro.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastro.Image")));
			this.btnCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCadastro.Location = new System.Drawing.Point(0, 43);
			this.btnCadastro.Name = "btnCadastro";
			this.btnCadastro.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
			this.btnCadastro.Size = new System.Drawing.Size(220, 46);
			this.btnCadastro.TabIndex = 22;
			this.btnCadastro.Text = "Cadastro";
			this.btnCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCadastro.UseVisualStyleBackColor = true;
			this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnHome);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(220, 43);
			this.panel2.TabIndex = 0;
			// 
			// btnHome
			// 
			this.btnHome.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnHome.FlatAppearance.BorderSize = 0;
			this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHome.Font = new System.Drawing.Font("Corbel", 9F);
			this.btnHome.ForeColor = System.Drawing.Color.White;
			this.btnHome.Image = global::soPets.Properties.Resources.baseline_home_white_18dp;
			this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnHome.Location = new System.Drawing.Point(0, 0);
			this.btnHome.Name = "btnHome";
			this.btnHome.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
			this.btnHome.Size = new System.Drawing.Size(220, 43);
			this.btnHome.TabIndex = 0;
			this.btnHome.Text = "Home";
			this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnHome.UseVisualStyleBackColor = true;
			this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
			// 
			// btnSair
			// 
			this.btnSair.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnSair.FlatAppearance.BorderSize = 0;
			this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSair.Font = new System.Drawing.Font("Corbel", 9F);
			this.btnSair.ForeColor = System.Drawing.Color.White;
			this.btnSair.Image = global::soPets.Properties.Resources.baseline_exit_to_app_white_18dp;
			this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSair.Location = new System.Drawing.Point(0, 1063);
			this.btnSair.Name = "btnSair";
			this.btnSair.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
			this.btnSair.Size = new System.Drawing.Size(220, 42);
			this.btnSair.TabIndex = 34;
			this.btnSair.Text = "Sair";
			this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSair.UseVisualStyleBackColor = true;
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// pnlHome
			// 
			this.pnlHome.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlHome.Location = new System.Drawing.Point(237, 43);
			this.pnlHome.Name = "pnlHome";
			this.pnlHome.Size = new System.Drawing.Size(765, 522);
			this.pnlHome.TabIndex = 2;
			// 
			// Home
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(1002, 565);
			this.Controls.Add(this.pnlHome);
			this.Controls.Add(this.pnlTitleBar);
			this.Controls.Add(this.pnlNavigation);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Home";
			this.Opacity = 0.99D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Home do secretário(a)";
			this.Load += new System.EventHandler(this.Home_Load);
			this.pnlTitleBar.ResumeLayout(false);
			this.pnlTitleBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.pnlNavigation.ResumeLayout(false);
			this.pnlSubExame.ResumeLayout(false);
			this.pnlSubListagem.ResumeLayout(false);
			this.pnlSubRemocao.ResumeLayout(false);
			this.pnlSubEdicao.ResumeLayout(false);
			this.pnlSubCadastro.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnInfo;
		private System.Windows.Forms.Panel pnlSubListagem;
		private System.Windows.Forms.Button btnListagemPet;
		private System.Windows.Forms.Button btnListagemFuncionario;
		private System.Windows.Forms.Button btnListagemConsulta;
		private System.Windows.Forms.Button btnListagemClientes;
		private System.Windows.Forms.Button btnListagem;
		private System.Windows.Forms.Panel pnlSubRemocao;
		private System.Windows.Forms.Button btnRemocaoPet;
		private System.Windows.Forms.Button btnRemocaoFuncionario;
		private System.Windows.Forms.Button btnRemocaoConsulta;
		private System.Windows.Forms.Button btnRemocaoCliente;
		private System.Windows.Forms.Button btnRemocao;
		private System.Windows.Forms.Panel pnlSubEdicao;
		private System.Windows.Forms.Button btnEdicaoPet;
		private System.Windows.Forms.Button btnEdicaoFuncionario;
		private System.Windows.Forms.Button btnEdicaoConsulta;
		private System.Windows.Forms.Button btnEdicaoCliente;
		private System.Windows.Forms.Button btnEdicao;
		private System.Windows.Forms.Panel pnlSubCadastro;
		private System.Windows.Forms.Button btnCadastroPet;
		private System.Windows.Forms.Button btnCadastroFuncionario;
		private System.Windows.Forms.Button btnCadastroConsulta;
		private System.Windows.Forms.Button btnCadastroCliente;
		private System.Windows.Forms.Button btnCadastro;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblTitlebar;
		private System.Windows.Forms.Panel pnlHome;
		private System.Windows.Forms.Button btnExame;
		private System.Windows.Forms.Panel pnlSubExame;
		private System.Windows.Forms.Button btnExameMarcar;
		private System.Windows.Forms.Button btnExameSolicitar;
		private System.Windows.Forms.Button btnExameResultado;
		private System.Windows.Forms.Button btnMedicamentos;
		private System.Windows.Forms.Button btnSair;
	}
}