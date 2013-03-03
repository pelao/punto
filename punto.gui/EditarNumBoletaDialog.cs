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
				Venta nuevaVenta = new Venta(Int32.Parse(entryNumBoleta.Text.Trim()),Convert.ToString(DateTime.Now), "NumBoletaNueva", "NumBoletaNueva", Int32.Parse("1111111111"), usuario_, "NumBoletaNueva"); 
				db.AgregarVentaBd(nuevaVenta);
			}
			catch (Exception ex)
			{
				Console.WriteLine("error editar boleta: "+ex);
			}

		}
	}
}

