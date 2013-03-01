using System;

namespace punto.code
{
	public class PagoTarjeta
	{
		private string var_tarjeta;
		private string var_transaccion;
		private string var_monto;
		private int var_boleta;


		public PagoTarjeta(int numBoleta,string tarjetaNom ,string serie, string monto)
		{
			this.Tarjeta=tarjetaNom;
			this.Transaccion=serie;
			this.Monto=monto;
			this.numBOLETA=numBoleta;
		}
		public int numBOLETA
		{
			get {return this.var_boleta;}
			set {
				if (value >= 0)
				{
					this.var_boleta = value;
				}
			}
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
