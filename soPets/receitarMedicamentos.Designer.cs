namespace soPets
{
	partial class receitarMedicamentos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(receitarMedicamentos));
			this.label2 = new System.Windows.Forms.Label();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.txtObservacoes = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.cmbVeterinario = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtMedicamentos = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 175);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(169, 17);
			this.label2.TabIndex = 92;
			this.label2.Text = "Medicamentos e dosagem";
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
			this.btnSalvar.TabIndex = 5;
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
			this.btnLimpar.TabIndex = 6;
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
			this.txtObservacoes.TabIndex = 4;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(388, 12);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(85, 17);
			this.label11.TabIndex = 91;
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
			this.label10.TabIndex = 90;
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
			this.cmbVeterinario.Location = new System.Drawing.Point(19, 110);
			this.cmbVeterinario.Name = "cmbVeterinario";
			this.cmbVeterinario.Size = new System.Drawing.Size(297, 24);
			this.cmbVeterinario.TabIndex = 2;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(16, 90);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(154, 17);
			this.label7.TabIndex = 87;
			this.label7.Text = "Veterinário responsável";
			// 
			// txtNome
			// 
			this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNome.Location = new System.Drawing.Point(19, 32);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(297, 22);
			this.txtNome.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 17);
			this.label1.TabIndex = 83;
			this.label1.Text = "Nome do pet *";
			// 
			// txtMedicamentos
			// 
			this.txtMedicamentos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtMedicamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMedicamentos.Location = new System.Drawing.Point(19, 195);
			this.txtMedicamentos.Multiline = true;
			this.txtMedicamentos.Name = "txtMedicamentos";
			this.txtMedicamentos.Size = new System.Drawing.Size(297, 252);
			this.txtMedicamentos.TabIndex = 3;
			// 
			// receitarMedicamentos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(765, 522);
			this.Controls.Add(this.txtMedicamentos);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.txtObservacoes);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.cmbVeterinario);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "receitarMedicamentos";
			this.Text = "receitarMedicamentos";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.TextBox txtObservacoes;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox cmbVeterinario;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtMedicamentos;
	}
}