using System;

namespace punto.code
{
	
	
	public class Produc
	{
		private string _precio;//200
		private string _nombre;//27
		private int _cantidad;//27
		private string _codigo;//27

		//private int _precio_destino;
		
		public Produc (string nombre, string precio)
		{
			this.Precio = precio;
			this.Nombre = nombre;
			//this.CodigoDestino = codigo_destino;
		}
		public Produc (string codigo, string nombre, string precio)
		{
			this._codigo=codigo;
			this.Precio = precio;
			this.Nombre = nombre;
		
			//this.CodigoDestino = codigo_destino;
		}
		public Produc (string codigo, string nombre, string precio,int cantidad)
		{
			this._codigo=codigo;
			this.Precio = precio;
			this.Nombre = nombre;
			this._cantidad=cantidad;
			
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
		public void setCodigo(String cod){
			_codigo = cod;
		}
		
		public void setNombre(String nom){
			_nombre = nom;
		}
		
		public void setPrecio(string prec){
			_precio = prec;
		}
		
		public void setCantidad(int can){
			_cantidad = can;
		}
		
		public String getCodigo(){
			return _codigo;
		}
		
		public String getNombre(){
			return _nombre;
		}
		
		public string getPrecio(){
			return _precio;
		}
		
		public int getCantidad(){
			return _cantidad;
		}
		
	}
}
