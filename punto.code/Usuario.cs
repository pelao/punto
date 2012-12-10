using System;

namespace punto.code
{
	public partial class Usuario 
	{

		private string _userlogin;
		private string _userpass;
		private string _nombre;
		private string _apellidos;
		private string _telefono;
		private string _rut;
		private string _nivel_user;

		public Usuario (string userlogin, string userpass, string nombre, string apellidos, string telefono, string rut, string nivel_user) 
	


		{
			this.Userlogin = userlogin;
			this.Userpass = userpass; 
			this.Nombre = nombre;
			this.Apellidos = apellidos;
			this.Telefono = telefono;
			this.Rut = rut;
			this.Nivel_user = nivel_user; 


		}

		public string Userlogin
		{
			get {return this._userlogin;}
			set {
				if (value.Trim().Length <= 100)
				{
					this._userlogin = value;
				}
			}
		}

		public string Userpass
		{
			get {return this._userpass;}
			set {
				if (value.Trim().Length <= 100)
				{
					this._userpass = value;
				}
			}
		}

		public string Nombre
		{
			get {return this._nombre;}
			set {
				if (value.Trim().Length <= 100)
				{
					this._nombre = value;
				}
			}
		}

		public string Apellidos
		{
			get {return this._apellidos;}
			set {
				if (value.Trim().Length <= 100)
				{
					this._apellidos = value;
				}
			}
		}

		public string Telefono
		{
			get {return this._telefono;}
			set {
				if (value.Trim().Length <= 100)
				{
					this._telefono = value;
				}
			}
		}

		public string Rut
		{
			get {return this._rut;}
			set {
				if (value.Trim().Length <= 100)
				{
					this._rut = value;
				}
			}
		}

		public string Nivel_user
		{
			get {return this._nivel_user;}
			set {
				if (value.Trim().Length <= 100)
				{
					this._nivel_user = value;
				}
			}
		}


	}
}

