using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_SammlungTeil1
{
	class CD : IEquatable<CD>
	{
		// Eigenschaften 
		private readonly string titel;
		private readonly string künstler;

		// Konstruktor
		public CD(string t, string k)
		{
			titel = t;
			künstler = k;
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
