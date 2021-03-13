namespace soPets
{
	partial class cadastroConsulta
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastroConsulta));
			this.btnSalvar = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.txtObservacoes = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.mskCPF = new System.Windows.Forms.MaskedTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbVeterinario = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.mskDia = new System.Windows.Forms.MaskedTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.mskHorario = new System.Windows.Forms.MaskedTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtPrognosticos = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
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
			this.btnSalvar.TabIndex = 43;
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
			this.btnLimpar.TabIndex = 44;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = false;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
			// 
			// txtObservacoes
			// 
			this.txtObservacoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtObservacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtObservacoes.Location = new System.Drawing.Point(391, 32);
			this.txtObservacoes.Multiline = true;
			this.txtObservacoes.Name = "txtObservacoes";
			this.txtObservacoes.Size = new System.Drawing.Size(337, 299);
			this.txtObservacoes.TabIndex = 41;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(388, 12);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(85, 17);
			this.label11.TabIndex = 48;
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
			this.label10.TabIndex = 47;
			// 
			// mskCPF
			// 
			this.mskCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.mskCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.mskCPF.Location = new System.Drawing.Point(19, 100);
			this.mskCPF.Mask = "000.000.000-00";
			this.mskCPF.Name = "mskCPF";
			this.mskCPF.Size = new System.Drawing.Size(100, 15);
			this.mskCPF.TabIndex = 28;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 17);
			this.label2.TabIndex = 27;
			this.label2.Text = "CPF *";
			// 
			// txtNome
			// 
			this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNome.Location = new System.Drawing.Point(19, 32);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(311, 22);
			this.txtNome.TabIndex = 26;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 17);
			this.label1.TabIndex = 25;
			this.label1.Text = "Nome";
			// 
			// cmbVeterinario
			// 
			this.cmbVeterinario.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmbVeterinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.cmbVeterinario.FormattingEnabled = true;
			this.cmbVeterinario.Items.AddRange(new object[] {
            "Minas Gerais (MG)",
            "Acre (AC)",
            "Alagoas (AL)",
            "Amapá (AP)",
            "Amazonas (AM)",
            "Bahia (BA)",
            "Ceará (CE)",
            "Distrito Federal (DF)",
            "Espírito Santo (ES)",
            "Goiás (GO)",
            "Maranhão (MA)",
            "Mato Grosso (MT)",
            "Mato Grosso do Sul (MS)",
            "Pará (PA)",
            "Paraíba (PB)",
            "Paraná (PR)",
            "Pernambuco (PE)",
            "Piauí (PI)",
            "Rio de Janeiro (RJ)",
            "Rio Grande do Norte (RN)",
            "Rio Grande do Sul (RS)",
            "Rondônia (RO)",
            "Roraima (RR)",
            "Santa Catarina (SC)",
            "São Paulo (SP)",
            "Sergipe (SE)",
            "Tocantins (TO)"});
			this.cmbVeterinario.Location = new System.Drawing.Point(19, 173);
			this.cmbVeterinario.Name = "cmbVeterinario";
			this.cmbVeterinario.Size = new System.Drawing.Size(311, 24);
			this.cmbVeterinario.TabIndex = 56;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(16, 153);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(164, 17);
			this.label3.TabIndex = 57;
			this.label3.Text = "Veterinário responsável *";
			// 
			// mskDia
			// 
			this.mskDia.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.mskDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.mskDia.Location = new System.Drawing.Point(19, 267);
			this.mskDia.Mask = "00/00/0000";
			this.mskDia.Name = "mskDia";
			this.mskDia.Size = new System.Drawing.Size(100, 15);
			this.mskDia.TabIndex = 60;
			this.mskDia.ValidatingType = typeof(System.DateTime);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(16, 247);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 17);
			this.label4.TabIndex = 61;
			this.label4.Text = "Dia * ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(182, 247);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(65, 17);
			this.label5.TabIndex = 62;
			this.label5.Text = "Horário *";
			// 
			// mskHorario
			// 
			this.mskHorario.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.mskHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.mskHorario.Location = new System.Drawing.Point(185, 267);
			this.mskHorario.Mask = "90:00";
			this.mskHorario.Name = "mskHorario";
			this.mskHorario.Size = new System.Drawing.Size(100, 15);
			this.mskHorario.TabIndex = 63;
			this.mskHorario.ValidatingType = typeof(System.DateTime);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(16, 333);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(155, 17);
			this.label6.TabIndex = 64;
			this.label6.Text = "Prognósticos (opcional)";
			// 
			// txtPrognosticos
			// 
			this.txtPrognosticos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPrognosticos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrognosticos.Location = new System.Drawing.Point(19, 353);
			this.txtPrognosticos.Multiline = true;
			this.txtPrognosticos.Name = "txtPrognosticos";
			this.txtPrognosticos.Size = new System.Drawing.Size(311, 124);
			this.txtPrognosticos.TabIndex = 65;
			// 
			// cadastroConsulta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(765, 522);
			this.Controls.Add(this.txtPrognosticos);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.mskHorario);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.mskDia);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cmbVeterinario);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.txtObservacoes);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.mskCPF);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "cadastroConsulta";
			this.Text = "cadastroConsulta";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.TextBox txtObservacoes;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.MaskedTextBox mskCPF;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbVeterinario;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.MaskedTextBox mskDia;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.MaskedTextBox mskHorario;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtPrognosticos;
	}
}