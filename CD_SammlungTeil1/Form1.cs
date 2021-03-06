﻿using System;
using System.Collections.Generic;
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
			try
			{
				// Objekte erstellen und der Liste hinzufügen
				meineSammlung.Add(new CD("A Night At The Opera", "Queen"));
				meineSammlung.Add(new CD("A Day At The Races", "Queen"));
				meineSammlung.Add(new CD("Smash", "The Offspring"));
				meineSammlung.Add(new CD("Best Of", "Earth, Wind And Fire"));
				meineSammlung.Add(new CD("21", "Adele"));
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

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

		private void btnSortiertAusgeben_Click(object sender, EventArgs e)
		{
			// Sort() => Liste sortieren
			meineSammlung.Sort();   // Aufsteigende Sortierung
			meineSammlung.Reverse(); // Absteigende Sortierung (vorher muss Sort() ausgeführt werden)

			// Alle Elemente der Liste in der Konsole ausgeben
			foreach (var cd in meineSammlung)
			{
				Console.WriteLine(cd);
			}
		}

		private void btnNeueCD_Click(object sender, EventArgs e)
		{
			var neueForm = new NeueCD();  // Objekt von der neuen Form wird erstellt

			// 2. Form anzeigen und Rückgabe auswerten
			var rückgabeAusNeueCD = neueForm.ShowDialog();

			if (rückgabeAusNeueCD == DialogResult.OK)
			{
				// Der CD-Liste wird ein neues OBjekt hinzugefügt
				// Die Eigenschaften des neuen Objekts werden im Konstruktor angegeben
				// Die Daten dafür kommen aus den Eigenschaften des neuen Formulars (NeueCD)
				// Wichtig: Es muss auf das konkrete Objekt von diesem neuen Formular zugegriffen werden:
				// => neueForm
				try
				{
					meineSammlung.Add(new CD(neueForm.Album, neueForm.Künstler));
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}
	}
}
