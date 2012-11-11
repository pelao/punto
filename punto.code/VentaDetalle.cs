using System;

namespace punto.code
{
	public class DetalleVenta
	{
		private int var_codigoVenta;
		private int var_codigoProducto;
		private decimal var_cantidad;
		
		public DetalleVenta(int codigoVenta ,int codigoProducto ,decimal cantidad)
		{
			this.CODIGOVENTA=codigoVenta;
			this.CODIGOPRODUCTO=codigoProducto;
			this.CANTIDAD=cantidad;
		}
		public int CODIGOVENTA
		{
			get { return var_codigoVenta; }
			set { var_codigoVenta = value; }
		}
		public int CODIGOPRODUCTO
		{
			get { return var_codigoProducto; }
			set { var_codigoProducto = value; }
		}
		public decimal CANTIDAD
		{
			get { return var_cantidad; }
			set { var_cantidad = value; }
		}
	}
}

