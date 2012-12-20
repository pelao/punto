using System;

namespace punto.code
{
	public class PagoTarjeta
	{
		private string var_tarjeta;
		private string var_transaccion;
		private string var_monto;
		private DateTime var_fecha;


		public PagoTarjeta(string tarjetaNom ,string transaccionNum, string monto, DateTime fecha)
		{
			this.Tarjeta=tarjetaNom;
			this.Transaccion=transaccionNum;
			this.Monto=monto;
			this.FECHA=fecha;
		}
		public DateTime FECHA
		{
			get {return this.var_fecha;}
			set {this.var_fecha = value;}
		}

		public string Tarjeta
		{
			get {return this.var_tarjeta;}
			set {
				if (value.Trim().Length <=20)
				{
					this.var_tarjeta = value;
				}
			}
		}

		public string Transaccion
		{
			get {return this.var_transaccion;}
			set {
				if (value.Trim().Length <=20)
				{
					this.var_transaccion = value;
				}
			}
		}
		public string Monto
		{
			get {return this.var_monto;}
			set {
				if (value.Trim().Length <=20)
				{
					this.var_monto = value;
				}
			}
		}
	}
}
