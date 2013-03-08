using GLib;
using System.Collections.Generic;
using Gtk;
using System;
using punto.code;

namespace punto.gui
{
	public partial class PagoParcialDialog : Gtk.Dialog
	{
		private ControladorBaseDatos db;
		private int numBoleta;
		private List<Produc> listaPago_;
		private string usuario_;
		private string pagototal;

		public PagoParcialDialog (Gtk.Window parent,string monto, List<Produc> listapago,string usuario)
		{
			this.listaPago_ = listapago;
			this.usuario_ = usuario;
			this.pagototal = monto;
			this.Build ();
		}

		protected void OnButtonChequeEfectivoClicked (object sender, EventArgs e)
		{
			ChequeEfectivoDialog PagoCheque = new ChequeEfectivoDialog(this,pagototal, listaPago_, usuario_);
			try 
			{
				PagoCheque.Run();

				PagoCheque.Destroy();
				
			}
			catch (MySql.Data.MySqlClient.MySqlException ex)
			{
				PagoCheque.Destroy();
#if DEBUG

				Console.WriteLine(ex.Message);
#endif
			}

		}

		
		protected void OnButtonTarjetaEfectivoClicked (object sender, EventArgs e)
		{
			TarjetaEfectivoDialog PagoTarjeta = new TarjetaEfectivoDialog(this,pagototal, listaPago_, usuario_);
			try 
			{
				PagoTarjeta.Run();
			
				PagoTarjeta.Destroy();
				
			}
			catch (MySql.Data.MySqlClient.MySqlException ex)
			{
				PagoTarjeta.Destroy();
#if DEBUG
				
				Console.WriteLine(ex.Message);
#endif
			}

		}
	}
}

