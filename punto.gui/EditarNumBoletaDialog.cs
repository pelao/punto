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
		ControladorBaseDatos db = new ControladorBaseDatos ();
		int numBoleta =0;

		public EditarNumBoletaDialog (string usuario)
		{
			this.usuario_ = usuario;
			this.Build ();
			numBoleta = this.db.ObtenerBoleta () - 1;

			Dialog dialog = new Dialog ("EDITAR BOLETA", this, Gtk.DialogFlags.DestroyWithParent);
			dialog.Modal = true;
			dialog.Resizable = false;
			Gtk.Label etiqueta = new Gtk.Label ();
			etiqueta.Markup = "Número de boleta actual: "+numBoleta.ToString();
			dialog.BorderWidth = 8;
			dialog.VBox.BorderWidth = 8;
			dialog.VBox.PackStart (etiqueta, false, false, 0);
			dialog.AddButton ("Cerrar", ResponseType.Close);
			dialog.ShowAll ();
			dialog.Run ();
			dialog.Destroy ();


		}

		protected void OnButtonEditarNumBoletaClicked (object sender, EventArgs e)
		{

			 numBoleta = this.db.ObtenerBoleta ();

		

			if (Int32.Parse (entryNumBoleta.Text.Trim ()) > numBoleta) {
			
				try {
					Venta nuevaVenta = new Venta (Int32.Parse (entryNumBoleta.Text.Trim ()), DateTime.Now.ToString ("yyyy-MM-dd"), "0", "inicioBoletaNueva", Int32.Parse ("0"), usuario_, "false"); 
					db.AgregarVentaBd (nuevaVenta);

					entryNumBoleta.Text = "";

					Dialog dialog = new Dialog ("EDITAR BOLETA", this, Gtk.DialogFlags.DestroyWithParent);
					dialog.Modal = true;
					dialog.Resizable = false;
					Gtk.Label etiqueta = new Gtk.Label ();
					etiqueta.Markup = "La operación ha sido realizada con éxito";
					dialog.BorderWidth = 8;
					dialog.VBox.BorderWidth = 8;
					dialog.VBox.PackStart (etiqueta, false, false, 0);
					dialog.AddButton ("Cerrar", ResponseType.Close);
					dialog.ShowAll ();
					dialog.Run ();
					dialog.Destroy ();


				} catch (Exception ex) {
					Dialog dialog = new Dialog ("EDITAR BOLETA", this, Gtk.DialogFlags.DestroyWithParent);
					dialog.Modal = true;
					dialog.Resizable = false;
					Gtk.Label etiqueta = new Gtk.Label ();
					etiqueta.Markup = "Ha ocurrido un error al editar boleta";
					dialog.BorderWidth = 8;
					dialog.VBox.BorderWidth = 8;
					dialog.VBox.PackStart (etiqueta, false, false, 0);
					dialog.AddButton ("Cerrar", ResponseType.Close);
					dialog.ShowAll ();
					dialog.Run ();
					dialog.Destroy ();
					Console.WriteLine ("error editar boleta: " + ex);
				}

			} else {

			

				Dialog dialog = new Dialog ("EDITAR BOLETA", this, Gtk.DialogFlags.DestroyWithParent);
				dialog.Modal = true;
				dialog.Resizable = false;
				Gtk.Label etiqueta = new Gtk.Label ();
				etiqueta.Markup = "La boleta ingresada es menor a la del sistema";
				dialog.BorderWidth = 8;
				dialog.VBox.BorderWidth = 8;
				dialog.VBox.PackStart (etiqueta, false, false, 0);
				dialog.AddButton ("Cerrar", ResponseType.Close);
				dialog.ShowAll ();
				dialog.Run ();
				dialog.Destroy ();
			
			}
		}
	}
}

