using GLib;
using System.Collections.Generic;
using Gtk;
using System;
using punto.code;

namespace punto.gui
{
	public partial class EditarNumBoletaDialog : Gtk.Dialog
	{
		private string usuario_;

		public EditarNumBoletaDialog (string usuario)
		{
			this.usuario_ = usuario;
			this.Build ();
		}

		protected void OnButtonEditarNumBoletaClicked (object sender, EventArgs e)
		{
			ControladorBaseDatos db = new ControladorBaseDatos();

			try {
				Venta nuevaVenta = new Venta(Int32.Parse(entryNumBoleta.Text.Trim()),Convert.ToString(DateTime.Now), "NumBoletaNueva", "NumBoletaNueva", Int32.Parse("0"), usuario_, "false"); 
				db.AgregarVentaBd(nuevaVenta);

				entryNumBoleta.Text = "";

				Dialog dialog = new Dialog("EDITAR BOLETA", this, Gtk.DialogFlags.DestroyWithParent);
				dialog.Modal = true;
				dialog.Resizable = false;
				Gtk.Label etiqueta = new Gtk.Label();
				etiqueta.Markup = "La operación ha sido realizada con éxito";
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
				Dialog dialog = new Dialog("EDITAR BOLETA", this, Gtk.DialogFlags.DestroyWithParent);
				dialog.Modal = true;
				dialog.Resizable = false;
				Gtk.Label etiqueta = new Gtk.Label();
				etiqueta.Markup = "Ha ocurrido un error al editar boleta";
				dialog.BorderWidth = 8;
				dialog.VBox.BorderWidth = 8;
				dialog.VBox.PackStart(etiqueta, false, false, 0);
				dialog.AddButton ("Cerrar", ResponseType.Close);
				dialog.ShowAll();
				dialog.Run ();
				dialog.Destroy ();
				Console.WriteLine("error editar boleta: "+ex);
			}

		}
	}
}

