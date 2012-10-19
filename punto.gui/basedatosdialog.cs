using System;
using System.Collections.Generic;
using Gtk;


using punto.code;

namespace punto.gui
{
	
	public partial class basedatosdialog : Gtk.Dialog
	{
		private basedatos db;
		private bool era_correcta = true;
		
		public basedatosdialog (Gtk.Window parent) : base ("Configuración de Conexión a Base de Datos", parent, Gtk.DialogFlags.DestroyWithParent)
		{
			this.db = new basedatos();
			this.Build ();
			this.entry1.Text = this.db.Server;
			this.entry2.Text = this.db.Database;
			this.entry3.Text = this.db.User;
			this.entry4.Text = this.db.Password;
			
			try {
				this.era_correcta = this.db.ConfiguracionCorrecta;
			}
			catch (Exception ex)
			{
				this.era_correcta = false;
			}
			
			GLib.ExceptionManager.UnhandledException += ExcepcionDesconocida;
			this.Deletable = true;
		}

		
		private void ExcepcionDesconocida (GLib.UnhandledExceptionArgs e)
		{
#if DEBUG
			Console.WriteLine(e.ToString());
#endif
			Dialog dialog = new Dialog("Ha ocurrido un error", this, Gtk.DialogFlags.DestroyWithParent);
			dialog.Modal = true;
			dialog.Resizable = false;
			Gtk.Label etiqueta = new Gtk.Label();
			etiqueta.Markup = "Ha ocurrido un error en la comunicación con el servidor de base de datos.";
			dialog.BorderWidth = 8;
			dialog.VBox.BorderWidth = 8;
			dialog.VBox.PackStart(etiqueta, false, false, 0);
			dialog.AddButton ("Cerrar", ResponseType.Close);
			dialog.ShowAll();
			dialog.Run ();
			dialog.Destroy ();
			
			this.Destroy();
		}
		
		protected virtual void OnProbarConexionClicked (object sender, System.EventArgs e)
		{
			this.db.Server = this.entry1.Text;
			this.db.Database = this.entry2.Text;
			this.db.User = this.entry3.Text;
			this.db.Password = this.entry4.Text;
			
			bool correcta = false;
			
			try {
				correcta = this.db.ConfiguracionCorrecta;
			}
			catch (Exception ex)
			{
				correcta = false;
			}
			
			if (correcta)
			{
				this.label5.Text = "Conexión realizada exitosamente";
			}
			else
			{
				this.label5.Text = "Falló la prueba de la conexión";
			}
		}
		
		protected virtual void OnGuardarClicked (object sender, System.EventArgs e)
		{
			this.db.Server = this.entry1.Text;
			this.db.Database = this.entry2.Text;
			this.db.User = this.entry3.Text;
			this.db.Password = this.entry4.Text;
			
			this.db.GuardarConfiguracion();
			this.Destroy();
		}
		public void Destroy ()
		{
#if DEBUG
			Console.WriteLine("Destroy");
#endif
			GLib.ExceptionManager.UnhandledException -= ExcepcionDesconocida;
			//EdicionDialogChangedEventArgs args = new EdicionDialogChangedEventArgs(this.cambiado);
			//this.OnEdicionDialogChanged(args);
			base.Destroy();
		}


		
	
		protected virtual void OnCancelarClicked (object sender, System.EventArgs e)
		{
			if (!this.era_correcta)
			{
				this.ParentWindow.Dispose();
			}
		}

	
	}
}

