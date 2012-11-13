using System;

namespace punto.code
{
	
	
	public class Produc
	{
		private string _precio;//200
		private string _nombre;//27
		//private int _precio_destino;
		
		public Produc (string nombre, string precio)
		{
			this.Precio = precio;
			this.Nombre = nombre;
			//this.CodigoDestino = codigo_destino;
		}
		
		public string Precio
		{
			get {return this._precio;}
			set {this._precio = value;}
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
