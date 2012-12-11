using System;
using System.Collections.Generic;
using Gtk;
using punto.code;

namespace punto.gui
{

	public partial class EditarProductoDialogChangedEventArgs : EventArgs
	{

		private string nombre;
		private string precio;

		public EditarProductoDialogChangedEventArgs(string cant, string d)
		{
			nombre = cant.Trim();
			precio = d.Trim();
		}
		
		public string Nombre
		{
			get { return nombre; }
		}
		
		public string Precio
		{
			get { return precio; }
		}

	
	}

		public partial class EditarProductoDialog : Gtk.Dialog
		{
		private ControladorBaseDatos db;


			// The event. Note that by using the generic EventHandler<T> event type
			// we do not need to declare a separate delegate type.
		public event EventHandler<EditarProductoDialogChangedEventArgs> EditarProductoDialogdChanged;
			
			//Crear una especificacion

		public EditarProductoDialog (Gtk.Window parent) : base ("Agregar Especificación", parent, Gtk.DialogFlags.DestroyWithParent)
			{

				this.Build ();
				
				this.Title = "Agregar Especificación";

		}
		public EditarProductoDialog (Gtk.Window parent, string nombre, string precio) : base ("Editar Especificación", parent, Gtk.DialogFlags.DestroyWithParent)
		{
			this.Build ();
			
			this.Title = "Editar Especificación";

			if (nombre.Trim().Length == 0)
			{
				entry4.Sensitive = false;
			}
			else
			{
				entry4.Text = nombre.Trim();
			}
			if (precio.Trim().Length == 0)
			{
				entry5.Sensitive = false;
			}
			else
			{
				entry5.Text = precio.Trim();
			}
		}
		protected virtual void OnEditarProductoDialogChanged(EditarProductoDialogChangedEventArgs e)
		{
			// Make a temporary copy of the event to avoid possibility of
			// a race condition if the last subscriber unsubscribes
			// immediately after the null check and before the event is raised.
			EventHandler<EditarProductoDialogChangedEventArgs> handler = EditarProductoDialogdChanged;
			if (handler != null)
			{
				handler(this, e);
			}
		}

		protected virtual void OnEditarButtonClicked (object sender, System.EventArgs e)
		{
			string nombre = "", precio = "";

			if (entry4.Text.Trim().Length == 0)
			{
				//mostrar mensaje y terminar
				return;
			}
			else
			{
				nombre = entry4.Text.Trim();
			}
			if (entry5.Text.Trim().Length == 0)
			{
				//mostrar mensaje y terminar
				return;
			}
			else
			{
				precio = entry5.Text.Trim();
			}



			EditarProductoDialogChangedEventArgs args = new EditarProductoDialogChangedEventArgs(nombre,precio);
			this.OnEditarProductoDialogChanged(args);

			this.Destroy();	
		}
	}
}

	