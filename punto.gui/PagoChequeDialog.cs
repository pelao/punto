using GLib;
using System.Collections.Generic;
using Gtk;
using System;
using punto.code;

namespace punto.gui
{
	public partial class PagoChequeDialog : Gtk.Dialog
	{	private ControladorBaseDatos db;
		private int numBoleta;
		private List<Produc> listaPago_;
		private string usuario_;
		private string pagototal;
		
		public PagoChequeDialog (Gtk.Window parent,string monto, List<Produc> listapago,string usuario) : base ("Pago Con Cheque", parent, Gtk.DialogFlags.DestroyWithParent)
			
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
			
			comboboxBanco.AppendText("Santander");
			comboboxBanco.AppendText("Chile");
			comboboxBanco.AppendText("BCI");

			comboboxPlaza.AppendText("Valdivia");
			comboboxPlaza.AppendText("Santiago");
			comboboxPlaza.AppendText("Rancagua");
			comboboxPlaza.AppendText("Talca");
			comboboxPlaza.AppendText("Chillan");
			comboboxPlaza.AppendText("Concepcion");
			comboboxPlaza.AppendText("Osorno");
			comboboxPlaza.AppendText("Puerto Montt");

			entryMonto.Text=monto;
			
			
			
		}
		
		protected void OnButtonOkClicked (object sender, EventArgs e)
		{
			this.db = new ControladorBaseDatos();
			numBoleta = db.ObtenerBoleta();
			PagoCheque pago = new PagoCheque(comboboxBanco.ActiveText.Trim(),comboboxPlaza.ActiveText.Trim(),entryMonto.Text.Trim(),numBoleta,entryNroSerie.Text.Trim());

			Venta nuevaVenta = new Venta(numBoleta, DateTime.Now, pagototal, "cheque", Int32.Parse("0"), usuario_, "false"); 
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

			Console.WriteLine(comboboxBanco.ActiveText.Trim());
			Console.WriteLine(comboboxPlaza.ActiveText.Trim());
			Console.WriteLine(entryNroSerie.Text.Trim());
			Console.WriteLine(entryMonto.Text.Trim());

			this.db.AgregarPagoCheque(pago);		
		}
	}
}

