using System;

namespace punto.code
{
	public class Venta
	{
		private int  idventa_;
		private DateTime fecha_venta_;
		private string total_;
		private string tipo_pago_;
		private int cambio_;
		private string usuarios_userlogin_;
		private string anulada_;


		public Venta(int codigoVenta,DateTime fecha, string total, string tipo_pago, int cambio, string usuarios_userlogin, string anulada)
		{
			this.Idventa = codigoVenta;
			this.Var_fecha = fecha;
			this.Total = total;
			this.Tipo_pago = tipo_pago;
			this.Cambio = cambio;
			this.Usuarios_userlogin = usuarios_userlogin;
			this.Anulada = anulada;
		}

		public int Idventa
		{
			get { return idventa_; }
			set { idventa_ = value; }
		}

		public DateTime Var_fecha
		{
			get {return this.fecha_venta_;}
			set {this.fecha_venta_ = value;}
		}

		public string Total
		{
			get {return this.total_;}
			set {
				if (value.Trim().Length <= 100)
				{
					this.total_ = value;
				}
			}
		}
		public string Tipo_pago
		{
			get {return this.tipo_pago_;}
			set {
				if (value.Trim().Length <= 100)
				{
					this.tipo_pago_ = value;
				}
			}
		}
		public int Cambio
		{
			get { return cambio_; }
			set { cambio_ = value; }
	

		}

		public string Usuarios_userlogin
		{
			get {return this.usuarios_userlogin_;}
			set {
				if (value.Trim().Length <= 100)
				{
				this.usuarios_userlogin_ = value;
				}
			}
		}
		public string Anulada
		{
			get {return this.anulada_;}
			set {
				if (value.Trim().Length <= 100)
				{
					this.anulada_ = value;
				}
		    }
	    }
   }

}
