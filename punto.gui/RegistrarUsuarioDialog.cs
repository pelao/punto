using System;
using System.Collections.Generic;
using Gtk;
using punto.code;

namespace punto.gui
{
	public partial class RegistrarUsuarioDialog : Gtk.Dialog
	{
		private ControladorBaseDatos db;

		public RegistrarUsuarioDialog ()
		{
			this.Build ();
			this.CargarComboboxTipoUsuario();
		}


		public void CargarComboboxTipoUsuario()
		{

			comboboxTipoUsuario.Clear();
			CellRendererText cell = new CellRendererText();
			comboboxTipoUsuario.PackStart(cell, false);
			comboboxTipoUsuario.AddAttribute(cell, "text", 0);
			ListStore store = new ListStore(typeof (string));
			comboboxTipoUsuario.Model = store;
			
			store.AppendValues ("SuperUsuario");
			store.AppendValues ("Cajero");
			store.AppendValues ("Empleado");


		}


		protected void OnBotonAgregarClicked (object sender, EventArgs e)
		{
			Console.WriteLine(entryNombreUsuario.Text.Trim());
			Console.WriteLine(entryNombre.Text.Trim());
			Console.WriteLine(entryApellidos.Text.Trim());
			Console.WriteLine(entryTelefono.Text.Trim());
			Console.WriteLine(entryRut.Text.Trim());
			Console.WriteLine(entryContraseña.Text.Trim());
			Console.WriteLine(comboboxTipoUsuario.ActiveText);


			bool existe = this.db.ExisteUsuarioBd(entryNombreUsuario.Text.Trim());

			
			if (existe)	{
				Dialog dialog = new Dialog("USUARIO YA EXISTE", this, Gtk.DialogFlags.DestroyWithParent);
				dialog.Modal = true;
				dialog.Resizable = false;
				Gtk.Label etiqueta = new Gtk.Label();
				etiqueta.Markup = "El Usuario que intenta agregar ya existe en la Base de Datos";
				dialog.BorderWidth = 8;
				dialog.VBox.BorderWidth = 8;
				dialog.VBox.PackStart(etiqueta, false, false, 0);
				dialog.AddButton ("Cerrar", ResponseType.Close);
				dialog.ShowAll();		
				dialog.Run ();
				dialog.Destroy ();
			}
			else
			{
			Usuario NuevoUsuario = new Usuario(entryNombreUsuario.Text.Trim(),entryContraseña.Text.Trim(),
				                              entryNombre.Text.Trim(),entryApellidos.Text.Trim(),
				                              entryTelefono.Text.Trim(),entryRut.Text.Trim(),
				                              comboboxTipoUsuario.ActiveText);
	//			this.db.AgregarUsuarioBd(NuevoUsuario);

				
				Dialog dialog = new Dialog("USUARIO INGRESADO", this, Gtk.DialogFlags.DestroyWithParent);
				dialog.Modal = true;
				dialog.Resizable = false;
				Gtk.Label etiqueta = new Gtk.Label();
				etiqueta.Markup = "El Usuario ha sido ingresado a la Base de Datos";
				dialog.BorderWidth = 8;
				dialog.VBox.BorderWidth = 8;
				dialog.VBox.PackStart(etiqueta, false, false, 0);
				dialog.AddButton ("Cerrar", ResponseType.Close);
				dialog.ShowAll();
				dialog.Run ();
				dialog.Destroy ();
				
			}
			
			
		}
	}
}

