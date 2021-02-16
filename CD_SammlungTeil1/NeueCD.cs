using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CD_SammlungTeil1
{
	public partial class NeueCD : Form
	{
		// Eigenschaften deklarieren
		public string Album, Künstler;

		// Alternative: Eigenschaft vom Typ "CD" deklarieren
		// Hinweis: Klasse CD muss dazu auch public sein!
		// Sichtbarkeit der Eigenschaft hier kann nicht höher 
		// als die Sichtbarkeit der Klasse sein
		public CD neueCD;

		public NeueCD()
		{
			InitializeComponent();
		}

		private void btnAbbrechen_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnHinzufügen_Click(object sender, EventArgs e)
		{
			// Eigenschaften dieser Klasse mit den eingegebenen Texten beschreiben
			Album = txtAlbum.Text;
			Künstler = txtKünstler.Text;

			DialogResult = DialogResult.OK; // Rückgabewert des Formulars angeben

			Close();	// Formular schließen
		}
	}
}
