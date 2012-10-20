using System;

namespace punto.code
{
	
	
	public class FamiliaProducto
		{

		private string _nombre;//27
			//private int _codigo_destino;
			
		public FamiliaProducto ( string nombre)
			{
				this.Nombre = nombre;
				//this.CodigoDestino = codigo_destino;
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
			//			get {return this._codigo_destino;}
			//			set {
			//				if (value >= 0)
			//				{
			//					this._codigo_destino = value;
			//				}
			//			}
			//		}
		}
	}
