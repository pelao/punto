

using System;

namespace punto.code
{
	
	
	public class ListaVenta
	{
		private string _precio;//200
		private string _nombre;//27
		//private int _precio_destino;
		private string _serie;//27
		
		public ListaVenta (string serie,string nombre, string precio)
		{			
			this.Serie =serie ;
			
			this.Precio = precio;
			this.Nombre = nombre;
			//this.CodigoDestino = codigo_destino;
		}
		public string Serie
		{
			get {return this._serie;}
			set {this._serie = value;}
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
		
		
	}
}
