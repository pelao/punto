

using System;

namespace punto.code
{
	public class PagoCheque
	{
		private string var_banco;
		private string var_plaza;
		private string var_serie;
		private string var_monto;
		private DateTime var_fecha;

		public PagoCheque(string nomBanco ,string nombPlaza, string numSerie, string monto, DateTime fecha)
		{
			this.NombreBanco=nomBanco;
			this.NombrePlaza=nombPlaza;
			this.NumSerie=numSerie;
			this.Monto=monto;
			this.FECHA=fecha;

		}
		public DateTime FECHA
		{
			get {return this.var_fecha;}
			set {this.var_fecha = value;}
		}
		public string NombreBanco
		{
			get {return this.var_banco;}
			set {
				if (value.Trim().Length <=20)
				{
					this.var_banco = value;
				}
			}
		}
		
		public string NombrePlaza
		{
			get {return this.var_plaza;}
			set {
				if (value.Trim().Length <=20)
				{
					this.var_plaza = value;
				}
			}
		}
		public string NumSerie
		{
			get {return this.var_serie;}
			set {
				if (value.Trim().Length <=20)
				{
					this.var_serie = value;
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
