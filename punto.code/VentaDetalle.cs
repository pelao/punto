using System;

namespace punto.code
{
	public class DetalleVenta
	{
		private int var_codigoVenta;
		private int var_cantidad;
		private int var_precio_venta;
		private DateTime var_fecha;

		public DetalleVenta(int codigoVenta ,int cantidad, int precio_venta ,DateTime fecha)
		{
			this.CODIGOVENTA=codigoVenta;
			this.CANTIDAD=cantidad;
			this.PRECIOVENTA=precio_venta;
			this.FECHA=fecha;
		}
		public DateTime FECHA
		{
			get {return this.var_fecha;}
			set {this.var_fecha = value;}
		}
		public int CODIGOVENTA
		{
			get { return var_codigoVenta; }
			set { var_codigoVenta = value; }
		}
		public int PRECIOVENTA
		{
			get { return var_precio_venta; }
			set { var_precio_venta = value; }
		}
		public int CANTIDAD
		{
			get { return var_cantidad; }
			set { var_cantidad = value; }
		}
	}
}

