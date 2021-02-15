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
	public partial class Form1 : Form
	{
		private List<CD> meineSammlung = new List<CD>();
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// Alternativ:
			//meineSammlung = new List<CD>();
		}

		private void btnHinzufügen_Click(object sender, EventArgs e)
		{
			// Objekte erstellen und der Liste hinzufügen
			meineSammlung.Add(new CD("A Night At The Opera", "Queen"));
			meineSammlung.Add(new CD("A Day At The Races", "Queen"));
			meineSammlung.Add(new CD("Smash", "The Offspring"));
			meineSammlung.Add(new CD("Best Of", "Earth, Wind And Fire"));
			meineSammlung.Add(new CD("21", "Adele"));

			MessageBox.Show("Die Sammlung enthält: " + meineSammlung.Count + " CDs");
		}

		private void btnCdsAnzeigen_Click(object sender, EventArgs e)
		{
			foreach (var cd in meineSammlung)
			{
				Console.WriteLine(cd);
			}
		}

		private void btnEnthaltenPrüfen_Click(object sender, EventArgs e)
		{
			// Mit Contains() prüfen, ob CD enthalten ist
			MessageBox.Show(meineSammlung.Contains(new CD(
					"Best Of", "Earth, Wind And Fire")).ToString());
			
			//if (meineSammlung.Contains(new CD("Best Of", "Earth, Wind And Fire"))) 
			//	MessageBox.Show("CD ist enthalten");
		}
	}
}
