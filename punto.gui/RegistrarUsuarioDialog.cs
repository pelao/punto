using System;
using System.Collections.Generic;
using Gtk;
using punto.code;

namespace punto.gui
{
	public partial class RegistrarUsuarioDialog : Gtk.Dialog
	{
		//	private ControladorBaseDatos db;
		public List<Usuario> tipos = new List<Usuario>();
		
		private Gtk.ListStore usuariosModel;
		
		
		public RegistrarUsuarioDialog ()
		{
			this.Build ();
			this.CargarComboboxTipoUsuario();
			
			this.CargarUsuariosModificarCombobox();

		}
		
		
		public void CargarComboboxTipoUsuario()
		{
			
			comboboxTipoUsuario.Clear();
			CellRendererText cell = new CellRendererText();
			comboboxTipoUsuario.PackStart(cell, false);
			comboboxTipoUsuario.AddAttribute(cell, "text", 0);
			
			ListStore ListaCombobox = new ListStore(typeof (string));
			
			comboboxTipoUsuario.Model = ListaCombobox;
			
			ListaCombobox.AppendValues ("SuperUsuario");
			ListaCombobox.AppendValues ("Cajero");
			ListaCombobox.AppendValues ("Empleado");
			
			
		}
		
		
		public void comboboxTipoUsuarioModUsuario()
		{
			
			comboboxTipoUsuarioMod.Clear();
			CellRendererText cell = new CellRendererText();
			comboboxTipoUsuarioMod.PackStart(cell, false);
			comboboxTipoUsuarioMod.AddAttribute(cell, "text", 0);
			
			ListStore ListaCombobox = new ListStore(typeof (string));
			
			comboboxTipoUsuarioMod.Model = ListaCombobox;
			
			ListaCombobox.AppendValues ("SuperUsuario");
			ListaCombobox.AppendValues ("Cajero");
			ListaCombobox.AppendValues ("Empleado");
			
			
		}
		
		
		protected void OnBotonAgregarClicked (object sender, EventArgs e)
		{
						
			ControladorBaseDatos db = new ControladorBaseDatos();
			
			bool existe = db.ExisteUsuarioBd(entryNombreUsuario.Text.Trim());
			
			
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
				Usuario NuevoUsuario = new Usuario(entryNombreUsuario.Text.Trim(),
				                                   entryContraseña.Text.Trim(),
				                                   entryNombre.Text.Trim(),
				                                   entryApellidos.Text.Trim(),
				                                   entryTelefono.Text.Trim(),
				                                   entryRut.Text.Trim(),
				                                   comboboxTipoUsuario.ActiveText);

				db.AgregarUsuarioBd(NuevoUsuario);


				Dialog dialog = new Dialog("USUARIO AGREGADO", this, Gtk.DialogFlags.DestroyWithParent);
				dialog.Modal = true;
				dialog.Resizable = false;
				Gtk.Label etiqueta = new Gtk.Label();
				etiqueta.Markup = "El Usuario se ha agregado correctamente";
				dialog.BorderWidth = 8;
				dialog.VBox.BorderWidth = 8;
				dialog.VBox.PackStart(etiqueta, false, false, 0);
				dialog.AddButton ("Cerrar", ResponseType.Close);
				dialog.ShowAll();		
				dialog.Run ();
				dialog.Destroy ();
			}
		}
		
		
		public void CargarUsuariosModificarCombobox()
		{
			ControladorBaseDatos db = new ControladorBaseDatos();
			
			try {
				List<Usuario> tipos = db.ObtenerUsuariosBd();
				
				comboboxUsuarioModificar.Clear();
				CellRendererText cell = new CellRendererText();
				comboboxUsuarioModificar.PackStart(cell, false);
				comboboxUsuarioModificar.AddAttribute(cell, "text", 0);
				this.usuariosModel = new Gtk.ListStore(typeof (string));
				comboboxUsuarioModificar.Model = usuariosModel;
				foreach (Usuario tp in tipos)
				{
					this.usuariosModel.AppendValues(tp.Userlogin);
					
				}
			
				if (tipos.Count != 0)
				{
					this.comboboxUsuarioModificar.Active = 0;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Excepcion:"+ex);
			}
		}
		
		protected void OnComboboxUsuarioModificarChanged (object sender, EventArgs e)
		{

			ControladorBaseDatos db = new ControladorBaseDatos();
			List<Usuario> tipos = db.ObtenerUsuariosBd();
			
			
			for (int i = 0; i < tipos.Count; i++)
			{
				Console.WriteLine("lista"+i);
				if(tipos[i].Userlogin.Equals(comboboxUsuarioModificar.ActiveText))
				{
					entryUsuarioEdit.Text = tipos[i].Userlogin;
					entryNombreEdit.Text = tipos[i].Nombre;
					entryApellidosEdit.Text = tipos[i].Apellidos;
					entryTelefonoEdit.Text = tipos[i].Telefono;
					entryRutEdit.Text = tipos[i].Rut;
					entryContraseñaEdit.Text = tipos[i].Userpass;
					
					comboboxTipoUsuarioMod.Clear();
					CellRendererText cell = new CellRendererText();
					comboboxTipoUsuarioMod.PackStart(cell, false);
					comboboxTipoUsuarioMod.AddAttribute(cell, "text", 0);
					
					ListStore ListaCombobox = new ListStore(typeof (string));
					
					comboboxTipoUsuarioMod.Model = ListaCombobox;
					
					ListaCombobox.AppendValues (tipos[i].Nivel_user);
					
					if(tipos[i].Nivel_user.Equals("Cajero"))
					{
						ListaCombobox.AppendValues ("SuperUsuario");
						ListaCombobox.AppendValues ("Empleado");
						
					}
					if((tipos[i].Nivel_user.Equals("SuperUsuario")))
					{
						ListaCombobox.AppendValues ("Cajero");
						ListaCombobox.AppendValues ("Empleado");
						
					}
					if((tipos[i].Nivel_user.Equals("Empleado")))
					{
						ListaCombobox.AppendValues ("Superusuario");
						ListaCombobox.AppendValues ("Cajero");
						
					}
				}		
			}
		}
		
		
		protected void OnBotonModificarClicked (object sender, EventArgs e)
		{
			ControladorBaseDatos db = new ControladorBaseDatos();

			try {
				string [] aux = db.ObtenerusuarioAntiguoBd(entryUsuarioEdit.Text.Trim());
				
				
				Usuario usuarioAntiguo = new Usuario(aux[0],aux[1],aux[2],aux[3],aux[4],aux[5],aux[6]);
				
				
				Usuario usuarioNuevo = new Usuario(entryUsuarioEdit.Text.Trim(),
				                                   entryContraseñaEdit.Text.Trim(),
				                                   entryNombreEdit.Text.Trim(),
				                                   entryApellidosEdit.Text.Trim(),
				                                   entryTelefonoEdit.Text.Trim(),
				                                   entryRutEdit.Text.Trim(),
				                                   comboboxTipoUsuarioMod.ActiveText);
				
				db.ActualizarUsuarioBd(usuarioAntiguo,usuarioNuevo);

				Dialog dialog = new Dialog("USUARIO ACTUALIZADO", this, Gtk.DialogFlags.DestroyWithParent);
				dialog.Modal = true;
				dialog.Resizable = false;
				Gtk.Label etiqueta = new Gtk.Label();
				etiqueta.Markup = "Actualización correcta";
				dialog.BorderWidth = 8;
				dialog.VBox.BorderWidth = 8;
				dialog.VBox.PackStart(etiqueta, false, false, 0);
				dialog.AddButton ("Cerrar", ResponseType.Close);
				dialog.ShowAll();		
				dialog.Run ();
				dialog.Destroy ();

			}
			catch (Exception ex)
			{
				Console.WriteLine("Excepcion:"+ex);
			}
		}


		
		private void ExcepcionDesconocida (GLib.UnhandledExceptionArgs e)
		{
			Dialog dialog = new Dialog("Exception", this, Gtk.DialogFlags.DestroyWithParent);
			dialog.Modal = true;
			dialog.Resizable = false;
			Gtk.Label etiqueta = new Gtk.Label();
			etiqueta.Markup = "Se ha producido un error.";
			dialog.BorderWidth = 8;
			dialog.VBox.BorderWidth = 8;
			dialog.VBox.PackStart(etiqueta, false, false, 0);
			dialog.AddButton ("Cerrar", ResponseType.Close);
			dialog.ShowAll();	
			dialog.Run ();
			dialog.Destroy ();
		}
		
		protected void OnBotonCancelarModClicked (object sender, EventArgs e)
		{
			this.Destroy();
		}

		protected void OnBotonCancelarClicked (object sender, EventArgs e)
		{
			this.Destroy();
		}

		protected void OnLabelModificarUsuarioKeyPressEvent (object o, KeyPressEventArgs args)
		{
			throw new System.NotImplementedException ();
		}
	}
}
