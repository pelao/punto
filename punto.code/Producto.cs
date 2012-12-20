using System;

namespace punto.code
{
	public class Producto
	{
		private string _codigobarra;
		private string _nombre;
		private int _precioventa;
		private bool _pesable;
		private bool _vigente;
		private string _familia;

	
		public Producto (string codigobarra, string nombre, int precioventa, string familia,bool pesable,bool vigente)
		{
			this.Codigobarra = codigobarra;
			this.Nombre = nombre;
			this.Precioventa = precioventa;
			this.Pesable= pesable;
			this.Vigente = vigente;
			this.Familia = familia;

		}
		public string Codigobarra
		{
			get {return this._codigobarra;}
			set {
				if (value.Trim().Length <=20)
				{
					this._codigobarra = value;
				}
			}
		}
		
		public int Precioventa
		{
			get {return this._precioventa;}
			set {
				if (value >= 0)
				{
					this._precioventa = value;
				}
			}
		}


		
		public string Familia
		{
			get {return this._familia;}
			set {
				if (value.Trim().Length <= 100)
				{
					this._familia = value;
				}
			}
		}
		public string Nombre
		{
			get {return this._nombre;}
			set {
				if (value.Trim().Length <= 100)
				{
					this._nombre = value;
				}
			}
		}
		

		
		public bool Vigente
		{
			get {return this._vigente;}
			set {
				this._vigente = value;
			}
		}
		
		public bool Pesable
		{
			get {return this._pesable;}
			set {this._pesable = value;}
		}

	}
}
