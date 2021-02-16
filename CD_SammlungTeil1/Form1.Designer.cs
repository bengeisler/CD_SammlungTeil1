
namespace CD_SammlungTeil1
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnNeueCD = new System.Windows.Forms.Button();
			this.btnSortiertAusgeben = new System.Windows.Forms.Button();
			this.btnCdsAnzeigen = new System.Windows.Forms.Button();
			this.btnEnthaltenPrüfen = new System.Windows.Forms.Button();
			this.btnHinzufügen = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnNeueCD
			// 
			this.btnNeueCD.Location = new System.Drawing.Point(402, 12);
			this.btnNeueCD.Name = "btnNeueCD";
			this.btnNeueCD.Size = new System.Drawing.Size(75, 40);
			this.btnNeueCD.TabIndex = 9;
			this.btnNeueCD.Text = "Neue CD eingeben";
			this.btnNeueCD.UseVisualStyleBackColor = true;
			this.btnNeueCD.Click += new System.EventHandler(this.btnNeueCD_Click);
			// 
			// btnSortiertAusgeben
			// 
			this.btnSortiertAusgeben.Location = new System.Drawing.Point(281, 11);
			this.btnSortiertAusgeben.Name = "btnSortiertAusgeben";
			this.btnSortiertAusgeben.Size = new System.Drawing.Size(115, 41);
			this.btnSortiertAusgeben.TabIndex = 8;
			this.btnSortiertAusgeben.Text = "Alphabetisch sortiert ausgeben";
			this.btnSortiertAusgeben.UseVisualStyleBackColor = true;
			this.btnSortiertAusgeben.Click += new System.EventHandler(this.btnSortiertAusgeben_Click);
			// 
			// btnCdsAnzeigen
			// 
			this.btnCdsAnzeigen.Location = new System.Drawing.Point(199, 12);
			this.btnCdsAnzeigen.Name = "btnCdsAnzeigen";
			this.btnCdsAnzeigen.Size = new System.Drawing.Size(75, 40);
			this.btnCdsAnzeigen.TabIndex = 7;
			this.btnCdsAnzeigen.Text = "CDs anzeigen";
			this.btnCdsAnzeigen.UseVisualStyleBackColor = true;
			this.btnCdsAnzeigen.Click += new System.EventHandler(this.btnCdsAnzeigen_Click);
			// 
			// btnEnthaltenPrüfen
			// 
			this.btnEnthaltenPrüfen.Location = new System.Drawing.Point(90, 12);
			this.btnEnthaltenPrüfen.Name = "btnEnthaltenPrüfen";
			this.btnEnthaltenPrüfen.Size = new System.Drawing.Size(102, 40);
			this.btnEnthaltenPrüfen.TabIndex = 6;
			this.btnEnthaltenPrüfen.Text = "Prüfen, ob CD enthalten ist";
			this.btnEnthaltenPrüfen.UseVisualStyleBackColor = true;
			this.btnEnthaltenPrüfen.Click += new System.EventHandler(this.btnEnthaltenPrüfen_Click);
			// 
			// btnHinzufügen
			// 
			this.btnHinzufügen.Location = new System.Drawing.Point(8, 11);
			this.btnHinzufügen.Name = "btnHinzufügen";
			this.btnHinzufügen.Size = new System.Drawing.Size(75, 41);
			this.btnHinzufügen.TabIndex = 5;
			this.btnHinzufügen.Text = "Hinzufügen";
			this.btnHinzufügen.UseVisualStyleBackColor = true;
			this.btnHinzufügen.Click += new System.EventHandler(this.btnHinzufügen_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(501, 71);
			this.Controls.Add(this.btnNeueCD);
			this.Controls.Add(this.btnSortiertAusgeben);
			this.Controls.Add(this.btnCdsAnzeigen);
			this.Controls.Add(this.btnEnthaltenPrüfen);
			this.Controls.Add(this.btnHinzufügen);
			this.Name = "Form1";
			this.Text = "CD Sammlung";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnNeueCD;
		private System.Windows.Forms.Button btnSortiertAusgeben;
		private System.Windows.Forms.Button btnCdsAnzeigen;
		private System.Windows.Forms.Button btnEnthaltenPrüfen;
		private System.Windows.Forms.Button btnHinzufügen;
	}
}

