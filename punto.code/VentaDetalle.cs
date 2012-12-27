using System;

namespace punto.code
{
	public class VentaDetalle
	{
		private int var_numBoleta;
		private string var_nombreProducto;


		public VentaDetalle(int boleta ,string nombreProducto)
		{
			this.NumBoleta=boleta;
			this.NombreProducto =nombreProducto;
	
		}

		public int NumBoleta
		{
			get { return var_numBoleta; }
			set { var_numBoleta = value; }
		}
		public string NombreProducto
		{
			get {return this.var_nombreProducto;}
			set {
				if (value.Trim().Length <= 100)
				{
					this.var_nombreProducto = value;
				}
			}
		}

	}
}

