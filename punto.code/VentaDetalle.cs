using System;

namespace punto.code
{
	public class VentaDetalle
	{
		private string  _nombre;
		private int _precio;

		public VentaDetalle ( string nombre, int precio)
		{
			this.Nombre = nombre;
			this.Precio = precio;
		}

		public string Nombre
		{
			get {return this._nombre;}
			set {
				if (value.Trim().Length <= 27)
				{
					this._nombre = value.Trim();
				}
			}
		}

		public int Precio
		{
			get {return this._precio;}
			set {
				if (value >= 0)
				{
					this._precio = value;
				}
			}
		}
	}
}

