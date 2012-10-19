using System;
using System.Configuration;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace punto.code
{
	public class basedatos
	{
		private string _server;
		private string _database;
		private string _user;
		private string _password;

		public basedatos ()
		{
			Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			//Modificar para leerlo desde un archivo xml

			this.Server = config.AppSettings.Settings["BdServer"].Value;
			this.Database = config.AppSettings.Settings["BdDatabase"].Value;
			this.User = config.AppSettings.Settings["BdUser"].Value;
			this.Password = config.AppSettings.Settings["BdPassword"].Value;

		}
		public bool AgregarProductos (producto registro)
		{
		
				
				IDbConnection dbcon = this.Conectar();
				
				IDbCommand dbcmd = dbcon.CreateCommand();
				string sql =
					"INSERT INTO productos (codigobarra,nombre,precio_venta,nombre_familia,pesable,vigente) " +
						"VALUES ("+registro.Codigobarra+",'"+registro.Nombre+"','"+registro.Precioventa+"','"+registro.Familia+"','"+registro.Pesable+"','"+registro.Vigente+"');";
		
				dbcmd.CommandText = sql;
				IDataReader reader = dbcmd.ExecuteReader();
			
				// clean up
				dbcmd.Dispose();
				dbcmd = null;
				
				this.Desconectar(dbcon);
	
			
			return false;
		}

		public bool ExisteRegistroProductos (producto registro, bool buscar_id)
		{
			IDbConnection dbcon = this.Conectar ();
			
			IDbCommand dbcmd = dbcon.CreateCommand ();
			string sql;
			if (buscar_id) {	
				sql =
					"SELECT codigobarra " +
					"FROM productos " +
					"WHERE codigobarra=" + registro.Codigobarra + ";";
				dbcmd.CommandText = sql;

			}

			IDataReader reader = dbcmd.ExecuteReader();
			bool existe = reader.Read();
			// clean up
			reader.Close();
			reader = null;
			dbcmd.Dispose();
			dbcmd = null;
			
			this.Desconectar(dbcon);
			
			return existe;
		}

		public List<familiap> ObtenerFamilias ()
		{
			IDbConnection dbcon = this.Conectar();
			
			IDbCommand dbcmd = dbcon.CreateCommand();
			string sql =
				"SELECT nombre " +
					"FROM familia_prod " +
					"ORDER BY nombre ASC";
			dbcmd.CommandText = sql;
			IDataReader reader = dbcmd.ExecuteReader();
			List<familiap> familias = new List<familiap>();
			while(reader.Read()) {
				familias.Add(new familiap( (string) reader["nombre"]));
			}
			reader.Close();
			reader = null;
			dbcmd.Dispose();
			dbcmd = null;
			
			this.Desconectar(dbcon);
			
			return familias;
		}

		public bool AgregarFamilia (familiap familia)
		{
			if (!this.ExisteFamilia(familia))
			{
				IDbConnection dbcon = this.Conectar();
				
				IDbCommand dbcmd = dbcon.CreateCommand();
				string sql =
					"INSERT INTO familia_prod (nombre)" +
						"VALUES ('"+familia.Nombre+"')";
				dbcmd.CommandText = sql;
				int res = dbcmd.ExecuteNonQuery();
				
				// clean up
				dbcmd.Dispose();
				dbcmd = null;
				
				this.Desconectar(dbcon);
				
				return true;
			}
			return false;
		}
		public bool ExisteFamilia (familiap Familia)
		{
			IDbConnection dbcon = this.Conectar();
			
			IDbCommand dbcmd = dbcon.CreateCommand();
			string sql =
				"SELECT nombre " +
					"FROM familia_prod " +
					"WHERE nombre='"+Familia.Nombre+"'";
			dbcmd.CommandText = sql;
			IDataReader reader = dbcmd.ExecuteReader();
			bool existe = reader.Read();
			// clean up
			reader.Close();
			reader = null;
			dbcmd.Dispose();
			dbcmd = null;
			
			this.Desconectar(dbcon);
			
			return existe;
		}
		public bool ConfiguracionCorrecta
		{
			get {
				bool conectado = true;
				
				try{
					IDbConnection dbcon = this.Conectar();
					if (dbcon.State != ConnectionState.Open)
					{
						//"Incorrect server name, user name or password"
						conectado = false;
					}
					this.Desconectar(dbcon);
				}
				catch(Exception e)
				{
					conectado = false;
				}
				
				return conectado;
			}
		}
		
		public void GuardarConfiguracion ()
		{	
			Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			config.AppSettings.Settings["BdServer"].Value = this.Server;
			config.AppSettings.Settings["BdDatabase"].Value = this.Database;
			config.AppSettings.Settings["BdUser"].Value = this.User;
			config.AppSettings.Settings["BdPassword"].Value = this.Password;
			config.Save(ConfigurationSaveMode.Modified);
		}
		private IDbConnection Conectar ()
		{
			string connectionString =
				"Server="+this.Server+";" +
					"Database="+this.Database+";" +
					"User ID="+this.User+";" +
					"Password="+this.Password+";" +
					"Pooling=false;" +
					"Allow Zero Datetime=true;";
			
			IDbConnection dbcon = new MySqlConnection(connectionString);
			dbcon.Open();
			return dbcon;
			
		}
		private bool Desconectar (IDbConnection dbcon)
		{
			if (dbcon == null)
			{
				return false;
			}
			
			dbcon.Close();
			dbcon = null;
			
			return true;
		}
		
		public string Server
		{
			get {return this._server;}
			set {this._server = value;}
		}
		public string Database
		{
			get {return this._database;}
			set {this._database = value;}
		}
		
		public string User
		{
			get {return this._user;}
			set {this._user = value;}
		}
		
		public string Password
		{
			get {return this._password;}
			set {this._password = value;}
		}
	}
}
