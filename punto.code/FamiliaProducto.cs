using System;

namespace punto.code
{
	
	
	public class FamiliaProducto
		{

		private string _nombre;

			
		public FamiliaProducto ( string nombre)
			{
				this.Nombre = nombre;

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
