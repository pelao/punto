using System;

namespace punto.code
{
	public class AnularBoleta
	{

		private string fecha;//200
		private string total;//27
		private string tipodepago;//27
		private string cajero;//27
		private string anular;//27
		private string idboleta;

		//private int _precio_destino;
		
		public AnularBoleta (string fecha, string total, string tipodepago, string cajero,string anular)
		{
			this.Fecha = fecha;
			this.Total = total;
			this.Tipopago = tipodepago;
			this.Cajero = cajero;
			this.Anular = anular;

			//this.CodigoDestino = codigo_destino;
		}
		public AnularBoleta (string idboleta, string fecha, string cajero)
		{
			this.IdBoleta = idboleta;
			this.Fecha = fecha;
			this.Cajero = cajero;

			
			//this.CodigoDestino = codigo_destino;
		}
		
		public string IdBoleta
		{
			get {return this.idboleta;}
			set {this.idboleta = value;}
		}
		public string Fecha
		{
			get {return this.fecha;}
			set {this.fecha = value;}
		}
		
		public string Total
		{
			get {return this.total;}
			set {this.total = value;}
		}
		public string Tipopago
		{
			get {return this.tipodepago;}
			set {this.tipodepago = value;}
		}
		public string Anular
		{
			get {return this.anular;}
			set {this.anular = value;}
		}
		public string Cajero
		{
			get {return this.cajero;}
			set {
				if (value.Trim().Length <= 27)
				{
					this.cajero = value.Trim();
				}
			}
		}
		
		public String getTotal(){
			return total;
		}
		
		public String getFecha(){
			return fecha;
		}
		
		public string getCajero(){
			return cajero;
		}
		public string getTipopago(){
			return tipodepago;
		}
		public string getAnular(){
			return anular;
		}

	
		
		//		public int CodigoDestino
		//		{
		//			get {return this._precio_destino;}
		//			set {
		//				if (value >= 0)
		//				{
		//					this._precio_destino = value;
		//				}
		//			}
		//		}
	}
}
