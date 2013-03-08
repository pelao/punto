using GLib;
using System.Collections.Generic;
using Gtk;
using System;
using punto.code;


namespace punto.gui
{
	public partial class TarjetaEfectivoDialog : Gtk.Dialog
	{
		private ControladorBaseDatos db;
		private int numBoleta;
		private List<Produc> listaPago_;
		private string usuario_;
		private string pagototal;

		public TarjetaEfectivoDialog(Gtk.Window parent,string monto, List<Produc> listapago,string usuario)
		{
			this.listaPago_ = listapago;
			this.usuario_ = usuario;
			this.pagototal = monto;
			this.Build ();
			this.db = new ControladorBaseDatos();
			labeltotalcompra1.Text = monto;
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

		protected void OnButtonPagarClicked (object sender, EventArgs e)
		{
			ControladorBaseDatos BD = new ControladorBaseDatos();
			numBoleta = BD.ObtenerBoleta();
			
			PagoTarjeta pago = new PagoTarjeta(numBoleta,comboboxentryTipoTarjeta.ActiveText.Trim(),entryNroTransaccion.Text.Trim(),entryMonto.Text.Trim());
			
			Venta nuevaVenta = new Venta(numBoleta, DateTime.Now.ToString("yyyy-MM-dd"), entryPagoEfectivo.Text.Trim(), "TarjetaEfectivo", Int32.Parse("0"), usuario_, "false"); 
			BD.AgregarVentaBd(nuevaVenta);
			try {
				for(int i=0; i<listaPago_.Count;i++)
				{   
					Console.WriteLine("ANTES DE codigo barra");
					
					string codigoBarra = BD.ObtenerCodigoBarraBd((listaPago_[i].getNombre().Trim()));
					
					Console.WriteLine(codigoBarra);
					for(int j=0; j<listaPago_[i].getCantidad(); j++){ 	
						BD.AgregarVentaDetalleBd(numBoleta,codigoBarra);
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
			BD.AgregarPagoTarjeta(pago);
		}
	}
}

