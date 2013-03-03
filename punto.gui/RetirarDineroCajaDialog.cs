using GLib;
using System.Collections.Generic;
using Gtk;
using System;
using punto.code;

namespace punto.gui
{
	public partial class RetirarDineroCajaDialog : Gtk.Dialog
	{
		private string usuario_;

		public RetirarDineroCajaDialog (string usuario)
		{
			this.usuario_ = usuario;
			this.Build ();
		}

		protected void OnButtonRetirarDineroClicked (object sender, EventArgs e)
		{
			ControladorBaseDatos baseDatos = new ControladorBaseDatos();
			try {
				
				int boleta = baseDatos.ObtenerBoleta();
				Venta nVenta = new Venta(boleta,
				                         Convert.ToString(DateTime.Now), 
				                         entryRetirarDinero.Text.Trim(), 
				                         "SalidaDineroCaja", 
				                         Int32.Parse("0"), 
				                         usuario_, 
				                         "false"); 
				baseDatos.AgregarVentaBd(nVenta);
			
				entryRetirarDinero.Text = "";

				Dialog dialog = new Dialog("RETIRAR MONTO DINERO", this, Gtk.DialogFlags.DestroyWithParent);
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
				Dialog dialog = new Dialog("RETIRAR MONTO DINERO", this, Gtk.DialogFlags.DestroyWithParent);
				dialog.Modal = true;
				dialog.Resizable = false;
				Gtk.Label etiqueta = new Gtk.Label();
				etiqueta.Markup = "Ha ocurrido un error al ingresar monto dinero";
				dialog.BorderWidth = 8;
				dialog.VBox.BorderWidth = 8;
				dialog.VBox.PackStart(etiqueta, false, false, 0);
				dialog.AddButton ("Cerrar", ResponseType.Close);
				dialog.ShowAll();
				dialog.Run ();
				dialog.Destroy ();
				Console.WriteLine("error ingresar monto: "+ex);
			}		
		}
	}
}

