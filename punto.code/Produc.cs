using System;

namespace punto.code

{
	public class Produc
	{
		private string var_Nombre;
		private int var_precio;
		
		public Produc(string codigoNombre  ,int precio)
		{
			this.NOMBRES=codigoNombre;
			this.PRECIO=precio;
		}

		public string NOMBRES
		{
			get { return var_Nombre; }
			set { var_Nombre = value; }
		}

		public int PRECIO
		{
			get {return this.var_precio;}
			set {
				if (value >= 0)
				{
					this.var_precio= value;
				}
			}
		}
	}
}

