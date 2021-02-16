using System;
using System.Collections.Generic;

namespace CD_SammlungTeil1
{
	public class CD : IEquatable<CD>, IComparable<CD>
	{
		// Eigenschaften 
		private readonly string titel;
		private readonly string künstler;

		// Konstruktor
		public CD(string t, string k)
		{
			// Ausnahme wird in der Klasse ausgelöst, aber nicht aufgefangen
			// => Ausnahme wird automatisch in nächsthöhere Ebene weiter"geworfen"
			if (t == "" || k == "") throw new ArgumentException("Bitte Titel und Künstler eingeben");

			titel = t;
			künstler = k;
		}

		public int CompareTo(CD other)
		{
			return titel.CompareTo(other.titel);
		}

		public override bool Equals(object obj)
		{
			return Equals(obj as CD);
		}

		public bool Equals(CD other)
		{
			return other != null &&
						 titel == other.titel &&
						 künstler == other.künstler;
		}

		public override int GetHashCode()
		{
			int hashCode = 1478916941;
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(titel);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(künstler);
			return hashCode;
		}

		// ToString() überschreiben
		public override string ToString()
		{
			return titel + " - " + künstler;
		}
	}
}
