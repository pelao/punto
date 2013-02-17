
using GLib;
using System.Collections.Generic;
using Gtk;
using System;
using punto.code;

namespace punto.gui
{
	public partial class PagoTarjetaDialog : Gtk.Dialog
	{		
		private ControladorBaseDatos db;

		public PagoTarjetaDialog (Gtk.Window parent,string monto) : base ("Pago Con Tarjeta", parent, Gtk.DialogFlags.DestroyWithParent)
		{

			this.Build ();
			this.db = new ControladorBaseDatos();
		
			bool correcta = false;
			
			try {
				correcta = this.db.ConfiguracionCorrectaBd;
			}
			catch (Exception ex)
			{
				correcta = false;
			}
			if (!correcta)
			{

				this.db = null;
				this.db = new ControladorBaseDatos();
				
				correcta = false;
				
				try {
					correcta = this.db.ConfiguracionCorrectaBd;
				}
				catch (Exception ex)
				{
					correcta = false;
				}
			}

			comboboxentryTipoTarjeta.AppendText("RedCompra");
			comboboxentryTipoTarjeta.AppendText("Visa");
			comboboxentryTipoTarjeta.AppendText("Mastercard");
			entryMonto.Text=monto;
		}

		protected void OnButtonOkClicked (object sender, EventArgs e)
		{
			this.db = new ControladorBaseDatos();

			PagoTarjeta pago = new PagoTarjeta(comboboxentryTipoTarjeta.ActiveText.Trim(),entryNroTransaccion.Text.Trim(),entryMonto.Text.Trim(),DateTime.Now);
			Console.WriteLine(comboboxentryTipoTarjeta.ActiveText.Trim());
			Console.WriteLine(entryNroTransaccion.Text.Trim());
			Console.WriteLine(entryMonto.Text.Trim());
			this.db.AgregarPagoTarjeta(pago);

		}
	}
}

