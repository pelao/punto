
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
		private int numBoleta;
		private List<Produc> listaPago_;
		private string usuario_;
		private string pagototal;
		public PagoTarjetaDialog (Gtk.Window parent,string monto, List<Produc> listapago,string usuario) : base ("Pago Con Tarjeta", parent, Gtk.DialogFlags.DestroyWithParent)
		{
			this.listaPago_ = listapago;
			this.usuario_ = usuario;
			this.pagototal = monto;
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
			numBoleta = db.ObtenerBoleta();

			PagoTarjeta pago = new PagoTarjeta(numBoleta,comboboxentryTipoTarjeta.ActiveText.Trim(),entryNroTransaccion.Text.Trim(),entryMonto.Text.Trim());

			Venta nuevaVenta = new Venta(numBoleta, Convert.ToString(DateTime.Now), pagototal, "Tarjeta", Int32.Parse("0"), usuario_, "false"); 
			db.AgregarVentaBd(nuevaVenta);
			try {
				for(int i=0; i<listaPago_.Count;i++)
				{   
					Console.WriteLine("ANTES DE codigo barra");
					
					string codigoBarra = db.ObtenerCodigoBarraBd((listaPago_[i].getNombre().Trim()));
					
					Console.WriteLine(codigoBarra);
					for(int j=0; j<listaPago_[i].getCantidad(); j++){ 	
						db.AgregarVentaDetalleBd(numBoleta,codigoBarra);
					}
					
					
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Excepcion:--->"+ex);
			}

			Console.WriteLine(comboboxentryTipoTarjeta.ActiveText.Trim());
			Console.WriteLine(entryNroTransaccion.Text.Trim());
			Console.WriteLine(entryMonto.Text.Trim());
			this.db.AgregarPagoTarjeta(pago);

		}
	}
}

