using System;

namespace punto.code
{
	public class ModificarProducto
	{
		private string _precio;//200
		private string _nombre;//27
		private string _familia;//27
		private string _vigente;//27

		//private int _precio_destino;
		
		public ModificarProducto (string nombre, string precio, string familia, string vigente)
		{
			this.Precio = precio;
			this.Nombre = nombre;
			this.Familia = familia;
			this.Vigente = vigente;

			//this.CodigoDestino = codigo_destino;
		}
		
		public string Precio
		{
			get {return this._precio;}
			set {this._precio = value;}
		}
		
		public string Familia
		{
			get {return this._familia;}
			set {this._familia = value;}
		}
		public string Vigente
		{
			get {return this._vigente;}
			set {this._vigente = value;}
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
