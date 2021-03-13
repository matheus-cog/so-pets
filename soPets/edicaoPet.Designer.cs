namespace soPets
{
	partial class edicaoPet
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(edicaoPet));
			this.rdbNao = new System.Windows.Forms.RadioButton();
			this.rdbSim = new System.Windows.Forms.RadioButton();
			this.mskDataNascimentoPet = new System.Windows.Forms.MaskedTextBox();
			this.cmbTipo = new System.Windows.Forms.ComboBox();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.txtObservacoes = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txtCidade = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtBairro = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtEndereco = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSearch = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// rdbNao
			// 
			this.rdbNao.AutoSize = true;
			this.rdbNao.Location = new System.Drawing.Point(67, 402);
			this.rdbNao.Name = "rdbNao";
			this.rdbNao.Size = new System.Drawing.Size(45, 17);
			this.rdbNao.TabIndex = 73;
			this.rdbNao.TabStop = true;
			this.rdbNao.Text = "Não";
			this.rdbNao.UseVisualStyleBackColor = true;
			// 
			// rdbSim
			// 
			this.rdbSim.AutoSize = true;
			this.rdbSim.Location = new System.Drawing.Point(19, 402);
			this.rdbSim.Name = "rdbSim";
			this.rdbSim.Size = new System.Drawing.Size(42, 17);
			this.rdbSim.TabIndex = 72;
			this.rdbSim.TabStop = true;
			this.rdbSim.Text = "Sim";
			this.rdbSim.UseVisualStyleBackColor = true;
			// 
			// mskDataNascimentoPet
			// 
			this.mskDataNascimentoPet.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.mskDataNascimentoPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.mskDataNascimentoPet.Location = new System.Drawing.Point(19, 245);
			this.mskDataNascimentoPet.Mask = "00/00/0000";
			this.mskDataNascimentoPet.Name = "mskDataNascimentoPet";
			this.mskDataNascimentoPet.Size = new System.Drawing.Size(100, 15);
			this.mskDataNascimentoPet.TabIndex = 71;
			this.mskDataNascimentoPet.ValidatingType = typeof(System.DateTime);
			// 
			// cmbTipo
			// 
			this.cmbTipo.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.cmbTipo.FormattingEnabled = true;
			this.cmbTipo.Items.AddRange(new object[] {
            "Cachorro",
            "Gato",
            "Aquático",
            "Aves",
            "Roedor",
            "Réptil",
            "Equino",
            "Outros"});
			this.cmbTipo.Location = new System.Drawing.Point(19, 96);
			this.cmbTipo.Name = "cmbTipo";
			this.cmbTipo.Size = new System.Drawing.Size(132, 24);
			this.cmbTipo.TabIndex = 70;
			// 
			// btnSalvar
			// 
			this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(150)))), ((int)(((byte)(165)))));
			this.btnSalvar.FlatAppearance.BorderSize = 0;
			this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalvar.ForeColor = System.Drawing.Color.White;
			this.btnSalvar.Location = new System.Drawing.Point(592, 488);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(75, 23);
			this.btnSalvar.TabIndex = 65;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = false;
			// 
			// btnLimpar
			// 
			this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(150)))), ((int)(((byte)(165)))));
			this.btnLimpar.FlatAppearance.BorderSize = 0;
			this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLimpar.ForeColor = System.Drawing.Color.White;
			this.btnLimpar.Location = new System.Drawing.Point(673, 488);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(75, 23);
			this.btnLimpar.TabIndex = 66;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = false;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(16, 382);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(62, 17);
			this.label12.TabIndex = 69;
			this.label12.Text = "Castrado";
			// 
			// txtObservacoes
			// 
			this.txtObservacoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtObservacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtObservacoes.Location = new System.Drawing.Point(391, 32);
			this.txtObservacoes.Multiline = true;
			this.txtObservacoes.Name = "txtObservacoes";
			this.txtObservacoes.Size = new System.Drawing.Size(337, 299);
			this.txtObservacoes.TabIndex = 63;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(388, 12);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(85, 17);
			this.label11.TabIndex = 68;
			this.label11.Text = "Observações";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 304F);
			this.label10.Location = new System.Drawing.Point(353, 30);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(2, 461);
			this.label10.TabIndex = 67;
			// 
			// txtCidade
			// 
			this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCidade.Location = new System.Drawing.Point(178, 170);
			this.txtCidade.Name = "txtCidade";
			this.txtCidade.Size = new System.Drawing.Size(138, 22);
			this.txtCidade.TabIndex = 59;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(16, 225);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(131, 17);
			this.label7.TabIndex = 64;
			this.label7.Text = "Data de nascimento";
			// 
			// txtBairro
			// 
			this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBairro.Location = new System.Drawing.Point(19, 317);
			this.txtBairro.Name = "txtBairro";
			this.txtBairro.Size = new System.Drawing.Size(297, 22);
			this.txtBairro.TabIndex = 60;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(16, 297);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(36, 17);
			this.label6.TabIndex = 62;
			this.label6.Text = "Raça";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(175, 150);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(90, 17);
			this.label5.TabIndex = 61;
			this.label5.Text = "Tag (se tiver)";
			// 
			// txtEndereco
			// 
			this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEndereco.Location = new System.Drawing.Point(19, 170);
			this.txtEndereco.Name = "txtEndereco";
			this.txtEndereco.Size = new System.Drawing.Size(132, 22);
			this.txtEndereco.TabIndex = 57;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(16, 150);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(128, 17);
			this.label4.TabIndex = 58;
			this.label4.Text = "Microchip (se tiver)";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 17);
			this.label2.TabIndex = 56;
			this.label2.Text = "Tipo";
			// 
			// txtNome
			// 
			this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNome.Location = new System.Drawing.Point(19, 32);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(246, 22);
			this.txtNome.TabIndex = 55;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 17);
			this.label1.TabIndex = 54;
			this.label1.Text = "Nome do pet *";
			// 
			// btnSearch
			// 
			this.btnSearch.BackgroundImage = global::soPets.Properties.Resources.baseline_search_black_18dp;
			this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnSearch.FlatAppearance.BorderSize = 0;
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearch.Location = new System.Drawing.Point(271, 31);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(26, 23);
			this.btnSearch.TabIndex = 74;
			this.btnSearch.UseVisualStyleBackColor = true;
			// 
			// edicaoPet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(765, 522);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.rdbNao);
			this.Controls.Add(this.rdbSim);
			this.Controls.Add(this.mskDataNascimentoPet);
			this.Controls.Add(this.cmbTipo);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.txtObservacoes);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtCidade);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtBairro);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtEndereco);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "edicaoPet";
			this.Text = "edicaoPet";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton rdbNao;
		private System.Windows.Forms.RadioButton rdbSim;
		private System.Windows.Forms.MaskedTextBox mskDataNascimentoPet;
		private System.Windows.Forms.ComboBox cmbTipo;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtObservacoes;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtCidade;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtBairro;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtEndereco;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSearch;
	}
}