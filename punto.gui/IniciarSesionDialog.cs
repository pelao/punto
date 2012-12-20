
using GLib;
using punto.gui;
using System.Collections.Generic;
using Gtk;
using System;
using punto.code;

namespace punto.gui
{
	public partial class IniciarSesionDialog : Gtk.Dialog
	{
		public IniciarSesionDialog ()
		{
			this.Build ();
		}
		
		
		protected void OnButtonIngresarClicked (object sender, EventArgs e)
		{
			
			ControladorBaseDatos Bd = new ControladorBaseDatos();
			
			string[] usuarioClave = new string[2];
			
			usuarioClave = Bd.ObtenerUsuarioContraseñaBd(entryUsuario.Text);
			
			if(usuarioClave[0]==entryUsuario.Text & usuarioClave[1]==entryClave.Text)
			{
				PrincipalWindow rcd = new PrincipalWindow();
				

				base.Destroy();
				rcd.Show();
			}
			else
			{
				Dialog dialog = new Dialog("Iniciar Sesion", this, Gtk.DialogFlags.DestroyWithParent);
				dialog.Modal = true;
				dialog.Resizable = false;
				Gtk.Label etiqueta = new Gtk.Label();
				etiqueta.Markup = "Usuario/Clave incorrectos";
				dialog.BorderWidth = 8;
				dialog.VBox.BorderWidth = 8;
				dialog.VBox.PackStart(etiqueta, false, false, 0);
				dialog.AddButton ("Cerrar", ResponseType.Close);
				dialog.ShowAll();
				dialog.Run ();
				dialog.Destroy ();
				
			}
		}
	
		protected void OnBotonSalirClicked (object sender, EventArgs e)
		{
			this.Destroy();
		}
	}
}


