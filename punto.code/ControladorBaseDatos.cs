using System;
using System.Configuration;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace punto.code
{
	public class ControladorBaseDatos
	{
		private string servidor;
		private string basedatos;
		private string usuario;
		private string contraseña;

		public ControladorBaseDatos ()
		{
			/*
			Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

			this.Server = config.AppSettings.Settings["BdServer"].Value;
			this.Database = config.AppSettings.Settings["BdDatabase"].Value;
			this.User = config.AppSettings.Settings["BdUser"].Value;
			this.Password = config.AppSettings.Settings["BdPassword"].Value;
			*/

			this.Servidor = "127.0.0.1";
			this.BaseDatos = "pto";
			this.Usuario = "root";
			this.Contraseña = "root";

		}

		public string Servidor
		{
			get {return this.servidor;}
			set {this.servidor = value;}
		}
		public string BaseDatos
		{
			get {return this.basedatos;}
			set {this.basedatos = value;}
		}
		
		public string Usuario
		{
			get {return this.usuario;}
			set {this.usuario = value;}
		}
		
		public string Contraseña
		{
			get {return this.contraseña;}
			set {this.contraseña = value;}
		}


		public bool AgregarFamiliaBd (FamiliaProducto familia)
		{
			if (!this.ExisteFamiliaBd(familia))
			{
				IDbConnection dbcon = this.ConectarBd();
				
				IDbCommand dbcmd = dbcon.CreateCommand();
				
				string sql =
					"INSERT INTO familia_prod (nombre)" +
						"VALUES ('"+familia.Nombre+"')";
				
				dbcmd.CommandText = sql;
				IDataReader reader = dbcmd.ExecuteReader();

				dbcmd.Dispose();
				dbcmd = null;
				
				this.DesconectarBd(dbcon);
				
				return true;
			}
			return false;
		}
		public string[] ObtenerDatosAnularBoletaBD (string codigoB)
		{
			string[] usuario = new string[5];
			
			IDbConnection dbcon = this.ConectarBd();
			
			IDbCommand dbcmd = dbcon.CreateCommand();
			string sql =
				"SELECT fecha_venta,total,tipo_pago,usuarios_userlogin,anulada	" +
					"FROM venta " +
					"WHERE idventa='"+codigoB+"'";
			dbcmd.CommandText = sql;
			IDataReader reader = dbcmd.ExecuteReader();
			
			while(reader.Read()) {
				
				usuario[0] = (string) reader["fecha_venta"];
				usuario[1] = (string) reader["total"];
				usuario[2] = (string) reader["tipo_pago"];
				usuario[3] = (string) reader["usuarios_userlogin"];
				usuario[4] = (string) reader["anulada"];
				
				
			}
			reader.Close();
			reader = null;
			dbcmd.Dispose();
			dbcmd = null;
			
			this.DesconectarBd(dbcon);
			
			return usuario;
		}
		public bool Anularboletabd (AnularBoleta boleta)
		{
			
			IDbConnection dbcon = this.ConectarBd();
			
			IDbCommand dbcmd = dbcon.CreateCommand();
			
			string sql =
				"INSERT INTO boletaanulada (id,fecha,user_log)" +
					"VALUES ('"+boleta.IdBoleta+"','"+boleta.Fecha+"','"+boleta.Cajero+"')";
			
			dbcmd.CommandText = sql;
			IDataReader reader = dbcmd.ExecuteReader();
			
			dbcmd.Dispose();
			dbcmd = null;
			
			this.DesconectarBd(dbcon);
			
			return true;
		}		
		public bool ExistePagoChequeBoolBD (string boleta)
		{
			IDbConnection dbcon = this.ConectarBd ();
			IDbCommand dbcmd = dbcon.CreateCommand ();
			string sql;
			sql =
				"SELECT monto " +
					"FROM cheque " +
					"WHERE id_cheque_boleta='"+boleta+"'";
			dbcmd.CommandText = sql;
			IDataReader reader = dbcmd.ExecuteReader();
			bool existe = reader.Read();
			reader.Close();
			reader = null;
			dbcmd.Dispose();
			dbcmd = null;
			this.DesconectarBd(dbcon);
			
			return existe;
		}
		public string ExistePagoChequeBD (string boleta)
		{
			string[] pagocheque = new string[1];
			
			IDbConnection dbcon = this.ConectarBd();
			
			IDbCommand dbcmd = dbcon.CreateCommand();
			string sql =
				"SELECT monto " +
					"FROM cheque " +
					"WHERE id_cheque_boleta='"+boleta+"'";
			dbcmd.CommandText = sql;
			IDataReader reader = dbcmd.ExecuteReader();
			
			while(reader.Read()) {
				pagocheque[0] =  (string) reader["monto"];
			}
			reader.Close();
			reader = null;
			dbcmd.Dispose();
			dbcmd = null;
			
			this.DesconectarBd(dbcon);
			
			return pagocheque[0];
		
	}
		public bool ExistePagoTarjetaBoolBD (string boleta)
		{
			IDbConnection dbcon = this.ConectarBd ();
			IDbCommand dbcmd = dbcon.CreateCommand ();
			string sql;
			sql =
				"SELECT monto " +
					"FROM tarjeta " +
					"WHERE idventa='"+boleta+"'";
			dbcmd.CommandText = sql;
			IDataReader reader = dbcmd.ExecuteReader();
			bool existe = reader.Read();
			reader.Close();
			reader = null;
			dbcmd.Dispose();
			dbcmd = null;
			this.DesconectarBd(dbcon);
			
			return existe;
		}
		public string ExistePagoTarjetaBD (string boleta)
		{
			string[] pagoTarjeta = new string[1];
			
			IDbConnection dbcon = this.ConectarBd();
			
			IDbCommand dbcmd = dbcon.CreateCommand();
			string sql =
				"SELECT monto " +
					"FROM tarjeta " +
					"WHERE idventa='"+boleta+"'";
			dbcmd.CommandText = sql;
			IDataReader reader = dbcmd.ExecuteReader();
			
			while(reader.Read()) {
				pagoTarjeta[0] =  (string) reader["monto"];
			}
			reader.Close();
			reader = null;
			dbcmd.Dispose();
			dbcmd = null;
			
			this.DesconectarBd(dbcon);
			
			return pagoTarjeta[0];
			
		}
		public bool ActualizarCampoAnuladoBD (string codigoboleta)
		{
			
			IDbConnection dbcon = this.ConectarBd();
			string estrue = "true";
			IDbCommand dbcmd = dbcon.CreateCommand();
			string sql =
				"UPDATE venta " +
					"SET anulada='"+estrue+"'"+ 
					"WHERE idventa='"+codigoboleta+"'";
			dbcmd.CommandText = sql;
			
			int res = dbcmd.ExecuteNonQuery();
			
			dbcmd.Dispose();
			dbcmd = null;
			
			this.DesconectarBd(dbcon);
			
			return true;
		}


		public bool AgregarPagoCheque (PagoCheque registro)
		{
			IDbConnection dbcon = this.ConectarBd();
			IDbCommand dbcmd = dbcon.CreateCommand();
			string sql =
				"INSERT INTO cheque (nombreBanco,plaza,monto,id_cheque_boleta,nroserie) " +
					"VALUES ('"+registro.NombreBanco+"','"+registro.NombrePlaza+"','"+registro.Monto+"','"+registro.numBOLETA+"','"+registro.NumSerie+"');";
			
			dbcmd.CommandText = sql;
			IDataReader reader = dbcmd.ExecuteReader();
			
			
			dbcmd.Dispose();
			dbcmd = null;
			
			this.DesconectarBd(dbcon);
			
			
			return false;
		}
		public bool AgregarPagoTarjeta (PagoTarjeta registro)
		{
			
			
			IDbConnection dbcon = this.ConectarBd();
			
			IDbCommand dbcmd = dbcon.CreateCommand();
			string sql =
				"INSERT INTO tarjeta (idventa,nomTarjeta,serie, monto) " +
					"VALUES ('"+registro.numBOLETA+"','"+registro.Tarjeta+"','"+registro.Transaccion+"','"+registro.Monto+"');";
			
			dbcmd.CommandText = sql;
			IDataReader reader = dbcmd.ExecuteReader();
			
			
			dbcmd.Dispose();
			dbcmd = null;
			
			this.DesconectarBd(dbcon);
			
			
			return false;
		}
		public bool AgregarProductosBd (Producto registro)
		{
		
				
				IDbConnection dbcon = this.ConectarBd();
				
				IDbCommand dbcmd = dbcon.CreateCommand();
				string sql =
					"INSERT INTO productos (codigobarra,nombre,precio_venta,nombre_familia,pesable,vigente) " +
						"VALUES ("+registro.Codigobarra+",'"+registro.Nombre+"','"+registro.Precioventa+"','"+registro.Familia+"','"+registro.Pesable+"','"+registro.Vigente+"');";
		
				dbcmd.CommandText = sql;
				IDataReader reader = dbcmd.ExecuteReader();
			
	
				dbcmd.Dispose();
				dbcmd = null;
				
				this.DesconectarBd(dbcon);
	
			
			return false;
		}
		public bool AgregarVentaBd (Venta venta)
		{
			
			
			IDbConnection dbcon = this.ConectarBd();
			
			IDbCommand dbcmd = dbcon.CreateCommand();



			string sql =
				"INSERT INTO venta (idventa,fecha_venta,total,tipo_pago,cambio,usuarios_userlogin,anulada) " +
					"VALUES ('"+venta.Idventa+"',now(),'"+venta.Total+"','"+venta.Tipo_pago+"','"+venta.Cambio+"','"+venta.Usuarios_userlogin+"','"+venta.Anulada+"');commit;";
		
			dbcmd.CommandText = sql;
			IDataReader reader = dbcmd.ExecuteReader();
			
			
			dbcmd.Dispose();
			dbcmd = null;
			
			this.DesconectarBd(dbcon);
			
			
			return false;
		}


		public bool AgregarVentaDetalleBd (int boleta, string producto)
		{
			
			
			IDbConnection dbcon = this.ConectarBd();
			
			IDbCommand dbcmd = dbcon.CreateCommand();
			
			
			
			string sql =
				"INSERT INTO venta_detalle (idventa_detalle,idproducto) " +
					"VALUES ('"+boleta+"','"+producto+"');";
			
			dbcmd.CommandText = sql;
			IDataReader reader = dbcmd.ExecuteReader();
			
			
			dbcmd.Dispose();
			dbcmd = null;
			
			this.DesconectarBd(dbcon);
			
			
			return false;
		}

		public bool AgregarUsuarioBd (Usuario dato)
		{
			IDbConnection dbcon = this.ConectarBd();
			
			IDbCommand dbcmd = dbcon.CreateCommand();
			string sql =
			

			"INSERT INTO usuarios (userlogin,userpass,nombre,apellidos,telefono,rut,nivel_user) " +
				"VALUES ('"+dato.Userlogin+"','"+dato.Userpass+"','"+dato.Nombre+"','"+dato.Apellidos+"','"+dato.Telefono+"','"+dato.Rut+"','"+dato.Nivel_user+"');";


			dbcmd.CommandText = sql;
			IDataReader reader = dbcmd.ExecuteReader();
			dbcmd.Dispose();
			dbcmd = null;
			
			this.DesconectarBd(dbcon);
			
			
			return false;
		}

		public bool QuitarFamilia (FamiliaProducto famili)
		{
			if (this.ExisteFamiliaBd(famili))
			{
				IDbConnection dbcon = this.ConectarBd();
				
				IDbCommand dbcmd = dbcon.CreateCommand();
				string sql =
					"DELETE FROM familia_prod "+
						"WHERE nombre='"+famili.Nombre+"';";
				dbcmd.CommandText = sql;
				int res = dbcmd.ExecuteNonQuery();
				
				// clean up
				dbcmd.Dispose();
				dbcmd = null;
				
				this.DesconectarBd(dbcon);
				
				return true;
			}
			return false;
		}
		public bool ActualizarFamilia (FamiliaProducto familia_vieja, FamiliaProducto familia_nueva)
		{
			if ( this.ExisteFamiliaBd(familia_vieja) && 
			    (!this.ExisteFamiliaBd(familia_nueva) || (this.ExisteFamiliaBd(familia_nueva) && familia_vieja.Nombre==familia_nueva.Nombre)))
			{
				IDbConnection dbcon = this.ConectarBd();
				
				IDbCommand dbcmd = dbcon.CreateCommand();
				string sql =
					"UPDATE familia_prod " +
						"SET nombre='"+familia_nueva.Nombre+"' " +
						"WHERE nombre='"+familia_vieja.Nombre+"' ";
				dbcmd.CommandText = sql;
				
				int res = dbcmd.ExecuteNonQuery();
				
				dbcmd.Dispose();
				dbcmd = null;
				
				this.DesconectarBd(dbcon);
				
				return true;
			}
			return false;
		}
		public bool ActualizarUsuarioBd (Usuario usuarioAntiguo, Usuario usuarioNuevo)
		{
			
			IDbConnection dbcon = this.ConectarBd();
			
			IDbCommand dbcmd = dbcon.CreateCommand();
			string sql =
				"UPDATE usuarios " +
					"SET userlogin='"+usuarioNuevo.Userlogin+"'," + "userpass='"+usuarioNuevo.Userpass+"'," + "nombre='"+usuarioNuevo.Nombre+"'," + "apellidos='"+usuarioNuevo.Apellidos+"'," + "telefono='"+usuarioNuevo.Telefono+"'," + "rut='"+usuarioNuevo.Rut+"'," + "nivel_user='"+usuarioNuevo.Nivel_user+"'"+ 
					"WHERE userlogin='"+usuarioAntiguo.Userlogin+"'";
			dbcmd.CommandText = sql;
			
			int res = dbcmd.ExecuteNonQuery();
			
			dbcmd.Dispose();
			dbcmd = null;
			
			this.DesconectarBd(dbcon);
			
			return true;
		}

		public List<ModificarProducto> ObtenerProductosBd ()
		{
			IDbConnection dbcon = this.ConectarBd();
			
			IDbCommand dbcmd = dbcon.CreateCommand();
			string sql =
				"SELECT nombre,precio_venta,nombre_familia,vigente " +
					"FROM productos "+
					"ORDER BY nombre ASC";
			dbcmd.CommandText = sql;
			IDataReader reader = dbcmd.ExecuteReader();
			List<ModificarProducto> product = new List<ModificarProducto>();
			while(reader.Read()) {
				product.Add(new ModificarProducto( ((string) reader["nombre"]),((string) reader["precio_venta"]),((string) reader["nombre_familia"]),((string) reader["vigente"])));
			}
			reader.Close();
			reader = null;
			dbcmd.Dispose();
			dbcmd = null;
			
			this.DesconectarBd(dbcon);
			
			return product;
		}
		public bool ExisteNombreRegistroProductosBd (string nombre)
		{
			IDbConnection dbcon = this.ConectarBd ();
			
			IDbCommand dbcmd = dbcon.CreateCommand ();
			string sql;
			sql =
				"SELECT nombre " +
					"FROM productos " +
					"WHERE nombre='"+ nombre + "';";
			dbcmd.CommandText = sql;
			
			
			
			IDataReader reader = dbcmd.ExecuteReader();
			bool existe = reader.Read();
			
			reader.Close();
			reader = null;
			dbcmd.Dispose();
			dbcmd = null;
			
			this.DesconectarBd(dbcon);
			
			return existe;
		}
		public bool ExisteRegistroProductosBd (string codigob)
		{
			IDbConnection dbcon = this.ConectarBd ();
			
			IDbCommand dbcmd = dbcon.CreateCommand ();
			string sql;
				sql =
					"SELECT codigobarra " +
					"FROM productos " +
					"WHERE codigobarra='"+ codigob + "';";
				dbcmd.CommandText = sql;



			IDataReader reader = dbcmd.ExecuteReader();
			bool existe = reader.Read();
	
			reader.Close();
			reader = null;
			dbcmd.Dispose();
			dbcmd = null;
			
			this.DesconectarBd(dbcon);
			
			return existe;
		}

		public bool ExisteUsuarioBd (string usuario)
		{
			IDbConnection dbcon = this.ConectarBd ();
			
			IDbCommand dbcmd = dbcon.CreateCommand ();
			string sql;
			sql =
				"SELECT userlogin " +
					"FROM usuarios " +
					"WHERE userlogin='"+ usuario + "';";
			dbcmd.CommandText = sql;
			
			
			
			IDataReader reader = dbcmd.ExecuteReader();
			bool existe = reader.Read();
			
			reader.Close();
			reader = null;
			dbcmd.Dispose();
			dbcmd = null;
			
			this.DesconectarBd(dbcon);
			
			return existe;
		}

		public List<string> ObtenerFechaBd ()
		{

			IDbConnection dbcon = this.ConectarBd();
			
			IDbCommand dbcmd = dbcon.CreateCommand();
			string sql =
				"SELECT fecha_venta " +
					"FROM venta ORDER BY fecha_venta  ASC";

			dbcmd.CommandText = sql;
			IDataReader reader = dbcmd.ExecuteReader();
			List<string> fecha = new List<string>();
			while(reader.Read()) {
				fecha.Add((string)(reader["fecha_venta"]));
			}
			reader.Close();
			reader = null;
			dbcmd.Dispose();
			dbcmd = null;
			
			this.DesconectarBd(dbcon);
			
			return fecha;
		}

		public void ordenarFecha ()
		{
	

			IDbConnection dbcon = this.ConectarBd();

			
			IDbCommand dbcmd = dbcon.CreateCommand();
			string sql =
				"SELECT fecha_venta " +
					"FROM venta " +
					"ORDER BY fecha_venta ASC";
			
			
			dbcmd.CommandText = sql;
			IDataReader reader = dbcmd.ExecuteReader();
			reader.Close();
			reader = null;
			dbcmd.Dispose();
			dbcmd = null;
			
			this.DesconectarBd(dbcon);

		}

		public List<Venta> ObtenerIntervaloFechasBd (string fechaInicial, string fechaFinal)
		{

			IDbConnection dbcon = this.ConectarBd();
		//	string formato = "yyyy-MM-dd hh:mm:ss";

			IDbCommand dbcmd = dbcon.CreateCommand();
			string sql =
				"SELECT * " +
					"FROM venta " +
					"WHERE fecha_venta BETWEEN '"+ fechaInicial + "' and  '"+ fechaFinal + "'";


			dbcmd.CommandText = sql;
			IDataReader reader = dbcmd.ExecuteReader();
			List<Venta> intervaloFecha = new List<Venta>();  
			//List<string> intervaloFecha = new List<string>();  
			while(reader.Read()) {
				intervaloFecha.Add( new Venta((int) reader["idventa"], (string) reader["fecha_venta"],(string) reader["total"], (string) reader["tipo_pago"], (int) reader["cambio"], (string) reader["usuarios_userlogin"], (string) reader["anulada"]));
			//	intervaloFecha.Add((string) reader["fecha_venta"] ,(string) reader["total"], (string) reader["tipo_pago"]);

			}
			reader.Close();
			reader = null;
			dbcmd.Dispose();
			dbcmd = null;
			
			this.DesconectarBd(dbcon);
			
			return intervaloFecha;
		}


		public Produc ObtenerProductosVenta (string codigoB)
		{
			
			IDbConnection dbcon = this.ConectarBd();
			
			IDbCommand dbcmd = dbcon.CreateCommand();
			string sql =
				"SELECT codigobarra	,nombre,precio_venta " +
					"FROM productos " +
					"WHERE codigobarra='"+codigoB+"'"+
					"ORDER BY nombre ASC";;
			dbcmd.CommandText = sql;
			IDataReader reader = dbcmd.ExecuteReader();
		    Produc producto = null;
			while(reader.Read()) {
				producto = new Produc((string) reader["codigobarra"], (string) reader["nombre"],(string) reader["precio_venta"]);
			}
			reader.Close();
			reader = null;
			dbcmd.Dispose();
			dbcmd = null;
			
			this.DesconectarBd(dbcon);
			
			return producto;
		}

	/*	public List<Producto> ObtenerProductosBd (int codigoB)
		{
			IDbConnection dbcon = this.ConectarBd();
			
			IDbCommand dbcmd = dbcon.CreateCommand();
			string sql =
				"SELECT codigobarra,nombre,precio_venta,nombre_familia,pesable,vigente " +
					"FROM productos " +
					"WHERE codigobarra='"+codigoB+"'";
			dbcmd.CommandText = sql;
			IDataReader reader = dbcmd.ExecuteReader();
			List<Producto> product = new List<Producto>();
			while(reader.Read()) {
				product.Add(new Producto( ((int) reader["codigobarra"]),((string) reader["nombre"]),((int) reader["precio_venta"]),((string) reader["nombre_familia"]),((bool) reader["pesable"]),((bool) reader["vigente"])));
			}
			reader.Close();
			reader = null;
			dbcmd.Dispose();
			dbcmd = null;
			
			this.DesconectarBd(dbcon);
			
			return product;
		}
  */   
		public bool ActualizarProductoBd (string NombreA,string NombreV,string PrecioV,string FamiliaA)
		{
						
			IDbConnection dbcon = this.ConectarBd();
				
				IDbCommand dbcmd = dbcon.CreateCommand();
				string sql =
				"UPDATE productos " +
					"SET nombre='"+NombreV+"', "+"precio_venta='"+PrecioV+"',"+"nombre_familia='"+FamiliaA+"'" +
					"WHERE nombre='"+NombreA+"'";
			dbcmd.CommandText = sql;

			int res = dbcmd.ExecuteNonQuery();

				dbcmd.Dispose();
				dbcmd = null;
				
				this.DesconectarBd(dbcon);
				
			return true;
		}
		public int ObtenerBoleta ()
		{
			int boleta=0;
			
			IDbConnection dbcon = this.ConectarBd();
			
			IDbCommand dbcmd = dbcon.CreateCommand();

			string sql =
				"SELECT max(idventa) " +
					"FROM venta";
			dbcmd.CommandText = sql;
			IDataReader reader = dbcmd.ExecuteReader();
			
			while(reader.Read()) {
				boleta =   (int)reader["max(idventa)"]+1;

			}
			reader.Close();
			reader = null;
			dbcmd.Dispose();
			dbcmd = null;
			
			this.DesconectarBd(dbcon);
			
			return boleta;
		}


		public string ObtenerCodigoBarraBd (string nombreProducto)
		{
			string[] codigoBarra = new string[1];
			
			IDbConnection dbcon = this.ConectarBd();
			
			IDbCommand dbcmd = dbcon.CreateCommand();
			string sql =
				"SELECT codigobarra " +
					"FROM productos " +
					"WHERE nombre='"+nombreProducto+"'";
			dbcmd.CommandText = sql;
			IDataReader reader = dbcmd.ExecuteReader();
			
			while(reader.Read()) {
				codigoBarra[0] =  (string) reader["codigobarra"];
				

			}
			reader.Close();
			reader = null;
			dbcmd.Dispose();
			dbcmd = null;
			
			this.DesconectarBd(dbcon);
			
			return codigoBarra[0];
		}

		public string ObtenerNivelUsuarioBd (string nombreUsuario)
		{
			string[] nivelUsuario = new string[1];
			
			IDbConnection dbcon = this.ConectarBd();
			
			IDbCommand dbcmd = dbcon.CreateCommand();
			string sql =
				"SELECT nivel_user " +
					"FROM usuarios " +
					"WHERE userlogin='"+nombreUsuario+"'";
			dbcmd.CommandText = sql;
			IDataReader reader = dbcmd.ExecuteReader();
			
			while(reader.Read()) {
				nivelUsuario[0] =  (string) reader["nivel_user"];
				
				
			}
			reader.Close();
			reader = null;
			dbcmd.Dispose();
			dbcmd = null;
			
			this.DesconectarBd(dbcon);
			
			return nivelUsuario[0];
		}

		public string[] ObtenerusuarioAntiguoBd (string userlogin)
		{

			string[] usuario = new string[7];
			
			IDbConnection dbcon = this.ConectarBd();
			
			IDbCommand dbcmd = dbcon.CreateCommand();
			string sql =
				"SELECT userlogin,userpass,nombre,apellidos,telefono,rut,nivel_user " +
					"FROM usuarios " +
					"WHERE userlogin='"+userlogin+"'";
			dbcmd.CommandText = sql;
			IDataReader reader = dbcmd.ExecuteReader();
			
			while(reader.Read()) {
				
				usuario[0] = (string) reader["userlogin"];
				usuario[1] = (string) reader["userpass"];
				usuario[2] = (string) reader["nombre"];
				usuario[3] = (string) reader["apellidos"];
				usuario[4] = (string) reader["telefono"];
				usuario[5] = (string) reader["rut"];
				usuario[6] = (string) reader["nivel_user"];
				
			
				
			}
			reader.Close();
			reader = null;
			dbcmd.Dispose();
			dbcmd = null;
			
			this.DesconectarBd(dbcon);
			
			return usuario;
		}

		public List<Usuario> ObtenerUsuariosBd ()
		{
			
			IDbConnection dbcon = this.ConectarBd();
			
			IDbCommand dbcmd = dbcon.CreateCommand();
			string sql =
				"SELECT userlogin,userpass,nombre,apellidos,telefono,rut,nivel_user " +
					"FROM usuarios " +
					"ORDER BY userlogin ASC";
			dbcmd.CommandText = sql;
			IDataReader reader = dbcmd.ExecuteReader();
			List<Usuario> usuarios = new List<Usuario>();
			
			while(reader.Read()) {
				
				usuarios.Add(new Usuario( (string) reader["userlogin"], 
				                         (string) reader["userpass"],
				                         (string) reader["nombre"],
				                         (string) reader["apellidos"],
				                         (string) reader["telefono"],
				                         (string) reader["rut"],
				                         (string) reader["nivel_user"]));
			}
			
			reader.Close();
			reader = null;
			dbcmd.Dispose();
			dbcmd = null;
			
			this.DesconectarBd(dbcon);
			
			return usuarios;
		}

		public string ObtenerPrecioProductosBd (string codigoB)
		{
			string[] precio = new string[1];

			IDbConnection dbcon = this.ConectarBd();
			
			IDbCommand dbcmd = dbcon.CreateCommand();
			string sql =
				"SELECT precio_venta " +
					"FROM productos " +
					"WHERE codigobarra='"+codigoB+"'";
			dbcmd.CommandText = sql;
			IDataReader reader = dbcmd.ExecuteReader();
		
			while(reader.Read()) {
				precio[0] =  (string) reader["precio_venta"];

				//bool vig = reader["vigente"];
			}
			reader.Close();
			reader = null;
			dbcmd.Dispose();
			dbcmd = null;
			
			this.DesconectarBd(dbcon);
			
			return precio[0];
		}

		public string[] ObtenerUsuarioContraseñaBd (string usuario) 
		{
			string[] usuarioContraseña = new string[2];
			
			IDbConnection dbcon = this.ConectarBd();
			
			IDbCommand dbcmd = dbcon.CreateCommand();
			
			string sql =
				"SELECT userlogin, userpass " +
					"FROM usuarios "+
					"WHERE userlogin='"+usuario+"'";;
			
			dbcmd.CommandText = sql;
			IDataReader reader = dbcmd.ExecuteReader();
			
			while(reader.Read()) {
				usuarioContraseña[0] = (string) reader["userlogin"];
				usuarioContraseña[1] = (string) reader["userpass"];
				
			}
			reader.Close();
			reader = null;
			dbcmd.Dispose();
			dbcmd = null;
			
			this.DesconectarBd(dbcon);
			return usuarioContraseña;
		}

		public List<FamiliaProducto> ObtenerFamiliasBd ()
		{
			IDbConnection dbcon = this.ConectarBd();
			
			IDbCommand dbcmd = dbcon.CreateCommand();
			string sql =
				"SELECT nombre " +
					"FROM familia_prod " +
					"ORDER BY nombre ASC";
			dbcmd.CommandText = sql;
			IDataReader reader = dbcmd.ExecuteReader();
			List<FamiliaProducto> familias = new List<FamiliaProducto>();
			while(reader.Read()) {
				familias.Add(new FamiliaProducto( (string) reader["nombre"]));
			}
			reader.Close();
			reader = null;
			dbcmd.Dispose();
			dbcmd = null;
			
			this.DesconectarBd(dbcon);
			
			return familias;
		}


		public bool ExisteFamiliaBd (FamiliaProducto Familia)
		{
			IDbConnection dbcon = this.ConectarBd();
			
			IDbCommand dbcmd = dbcon.CreateCommand();
			string sql =
				"SELECT nombre " +
					"FROM familia_prod " +
					"WHERE nombre='"+Familia.Nombre+"'";
			dbcmd.CommandText = sql;
			IDataReader reader = dbcmd.ExecuteReader();
			bool existe = reader.Read();

			reader.Close();
			reader = null;
			dbcmd.Dispose();
			dbcmd = null;
			
			this.DesconectarBd(dbcon);
			
			return existe;
		}
		public bool ConfiguracionCorrectaBd
		{
			get {
				bool conectado = true;
				
				try{
					IDbConnection dbcon = this.ConectarBd();
					if (dbcon.State != ConnectionState.Open)
					{
						//nombre servidor, usuario o contraseña incorrecta
						conectado = false;
					}
					this.DesconectarBd(dbcon);
				}
				catch(Exception e)
				{
					conectado = false;
				}
				
				return conectado;
			}
		}
		public int ObtenerPrecioVenta ()
		{
			int valor=0;
			IDbConnection dbcon = this.ConectarBd();
			
			IDbCommand dbcmd = dbcon.CreateCommand();
			string sql =
				"SELECT total " +
					"FROM venta " +
					"order by idventa DESC limit 1";
			dbcmd.CommandText = sql;
			IDataReader reader = dbcmd.ExecuteReader();
			
			while(reader.Read()) {
				valor =   (int)reader["total"];
				
			}
			reader.Close();
			reader = null;
			dbcmd.Dispose();
			dbcmd = null;
			
			this.DesconectarBd(dbcon);
			
			return valor;
		}

/*		public void GuardarConfiguracionBd ()
		{	
			Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			config.AppSettings.Settings["BdServer"].Value = this.Server;
			config.AppSettings.Settings["BdDatabase"].Value = this.Database;
			config.AppSettings.Settings["BdUser"].Value = this.User;
			config.AppSettings.Settings["BdPassword"].Value = this.Password;
			config.Save(ConfigurationSaveMode.Modified);
		}
*/
		private IDbConnection ConectarBd ()
		{
			string connectionString =
				"Server="+this.Servidor+";" +
					"Database="+this.BaseDatos+";" +
					"User ID="+this.Usuario+";" +
					"Password="+this.Contraseña+";" +
					"Pooling=false;" +
					"Allow Zero Datetime=true;";
			
			IDbConnection dbcon = new MySqlConnection(connectionString);
			dbcon.Open();
			return dbcon;
			
		}
		private bool DesconectarBd (IDbConnection dbcon)
		{
			if (dbcon == null)
			{
				return false;
			}
			
			dbcon.Close();
			dbcon = null;
			
			return true;
		}
		
	
	}
}
