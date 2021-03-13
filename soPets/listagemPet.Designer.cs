namespace soPets
{
	partial class listagemPet
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listagemPet));
			this.dgvPet = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvPet)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvPet
			// 
			this.dgvPet.AllowUserToAddRows = false;
			this.dgvPet.AllowUserToDeleteRows = false;
			this.dgvPet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPet.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvPet.Location = new System.Drawing.Point(0, 0);
			this.dgvPet.Name = "dgvPet";
			this.dgvPet.ReadOnly = true;
			this.dgvPet.Size = new System.Drawing.Size(765, 522);
			this.dgvPet.TabIndex = 0;
			// 
			// listagemPet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(765, 522);
			this.Controls.Add(this.dgvPet);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "listagemPet";
			this.Text = "listagemPet";
			((System.ComponentModel.ISupportInitialize)(this.dgvPet)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvPet;
	}
}