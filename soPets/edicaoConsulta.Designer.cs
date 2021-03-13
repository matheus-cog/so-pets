namespace soPets
{
	partial class edicaoConsulta
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(edicaoConsulta));
			this.txtPrognosticos = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.mskCRMV = new System.Windows.Forms.MaskedTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cmbVeterinario = new System.Windows.Forms.ComboBox();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.txtObservacoes = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.mskCPF = new System.Windows.Forms.MaskedTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSearch = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtPrognosticos
			// 
			this.txtPrognosticos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPrognosticos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrognosticos.Location = new System.Drawing.Point(19, 353);
			this.txtPrognosticos.Multiline = true;
			this.txtPrognosticos.Name = "txtPrognosticos";
			this.txtPrognosticos.Size = new System.Drawing.Size(311, 124);
			this.txtPrognosticos.TabIndex = 82;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(16, 333);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(155, 17);
			this.label6.TabIndex = 81;
			this.label6.Text = "Prognósticos (opcional)";
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.maskedTextBox1.Location = new System.Drawing.Point(185, 267);
			this.maskedTextBox1.Mask = "90:00";
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(100, 15);
			this.maskedTextBox1.TabIndex = 80;
			this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(182, 247);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(65, 17);
			this.label5.TabIndex = 79;
			this.label5.Text = "Horário *";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(16, 247);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 17);
			this.label4.TabIndex = 78;
			this.label4.Text = "Dia * ";
			// 
			// mskCRMV
			// 
			this.mskCRMV.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.mskCRMV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.mskCRMV.Location = new System.Drawing.Point(19, 267);
			this.mskCRMV.Mask = "00/00/0000";
			this.mskCRMV.Name = "mskCRMV";
			this.mskCRMV.Size = new System.Drawing.Size(100, 15);
			this.mskCRMV.TabIndex = 77;
			this.mskCRMV.ValidatingType = typeof(System.DateTime);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(16, 153);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(164, 17);
			this.label3.TabIndex = 76;
			this.label3.Text = "Veterinário responsável *";
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
			this.cmbVeterinario.TabIndex = 75;
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
			this.btnSalvar.TabIndex = 71;
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
			this.btnLimpar.TabIndex = 72;
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
			this.txtObservacoes.TabIndex = 70;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(388, 12);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(85, 17);
			this.label11.TabIndex = 74;
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
			this.label10.TabIndex = 73;
			// 
			// mskCPF
			// 
			this.mskCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.mskCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.mskCPF.Location = new System.Drawing.Point(19, 32);
			this.mskCPF.Mask = "000.000.000-00";
			this.mskCPF.Name = "mskCPF";
			this.mskCPF.Size = new System.Drawing.Size(100, 15);
			this.mskCPF.TabIndex = 69;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 17);
			this.label2.TabIndex = 68;
			this.label2.Text = "CPF *";
			// 
			// txtNome
			// 
			this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNome.Location = new System.Drawing.Point(19, 96);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(311, 22);
			this.txtNome.TabIndex = 67;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 76);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 17);
			this.label1.TabIndex = 66;
			this.label1.Text = "Nome";
			// 
			// btnSearch
			// 
			this.btnSearch.BackgroundImage = global::soPets.Properties.Resources.baseline_search_black_18dp;
			this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnSearch.FlatAppearance.BorderSize = 0;
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearch.Location = new System.Drawing.Point(125, 24);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(26, 23);
			this.btnSearch.TabIndex = 83;
			this.btnSearch.UseVisualStyleBackColor = true;
			// 
			// edicaoConsulta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(765, 522);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtPrognosticos);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.maskedTextBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.mskCRMV);
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
			this.Name = "edicaoConsulta";
			this.Text = "edicaoConsulta";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtPrognosticos;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.MaskedTextBox maskedTextBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.MaskedTextBox mskCRMV;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbVeterinario;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.TextBox txtObservacoes;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.MaskedTextBox mskCPF;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSearch;
	}
}