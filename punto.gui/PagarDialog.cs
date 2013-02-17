
using System;
using System.Collections.Generic;
using Gtk;
using punto.code;


namespace punto.gui
{
	public partial class PagarDialog : Gtk.Dialog
	{
		private ControladorBaseDatos db;
		private int num;
		private int vuelto;
		private VenderProductosDialog treviewventa;
		private string pagototal;
		private string numBoleta;
		private string usuario_;
		private List<Produc> listaPago_;
	

		public PagarDialog(Gtk.Window parent,string total,string boleta, string usuario, List<Produc> listapago) : base ("Pagar", parent, Gtk.DialogFlags.DestroyWithParent)
		{
			this.pagototal=total;
			this.numBoleta=boleta;
			this.usuario_=usuario;
			this.listaPago_=listapago;
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
				
				if(!correcta)
				{
					Application.Quit();
				}
			}
			alignment3.Show();
			hbox3.Hide();
			this.buttonPagoEfectivo.IsFocus=true;
			labeltotalcompra.ModifyFont(Pango.FontDescription.FromString("Courier bold 32"));
			labelTotal.ModifyFont(Pango.FontDescription.FromString("Courier bold 32"));
			labelVuelto.Hide ();

			this.Deletable = true;
		}
		protected void OnPagoEnEfectivo (object sender, EventArgs e)
		{
			labeltotalcompra.Text=pagototal.Trim();
			alignment3.Hide ();
			hbox3.Show();
			this.entryPagoEfectivo.IsFocus=true;
		
		}


		
		/*	[GLib.ConnectBefore ()] 

		protected void OnEntryPagoEfectivoKeyPressEvent (object o, KeyPressEventArgs args)
		{
		if (args.Event.Key==Gdk.Key.Return) {
				
				labelVuelto.Show();
				vuelto = Int32.Parse (entryPagoEfectivo.Text.Trim ());
				labelvueltopago.Text = (vuelto - Int32.Parse (labeltotalcompra.Text)).ToString ();
				labelVuelto.ModifyFont(Pango.FontDescription.FromString("Courier bold 32"));
				labelvueltopago.ModifyFont(Pango.FontDescription.FromString("Courier bold 32"));
				labelvueltopago.ModifyBg(Gtk.StateType.Normal, new Gdk.Color (255, 0, 0));
			
				this.buttonPagar.IsFocus=true;
			}	
			if (args.Event.Key==Gdk.Key.F2) {
				
				labelVuelto.Show();
				vuelto = Int32.Parse (entryPagoEfectivo.Text.Trim ());
				labelvueltopago.Text = (vuelto - Int32.Parse (labeltotalcompra.Text)).ToString ();
				labelVuelto.ModifyFont(Pango.FontDescription.FromString("Courier bold 32"));
				labelvueltopago.ModifyFont(Pango.FontDescription.FromString("Courier bold 32"));
				labelvueltopago.ModifyBg(Gtk.StateType.Normal, new Gdk.Color (255, 0, 0));
				this.buttonPagar.IsFocus=true;
				
				
			}	
		}*/


		protected void OnButtonPagoTarjetaClicked (object sender, EventArgs e)
		{
			PagoTarjetaDialog PagoTarjeta = new PagoTarjetaDialog(this,pagototal);
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
			this.buttonOk.IsFocus=true;

		}

		protected void OnButtonPagoChequeClicked (object sender, EventArgs e)
		{
			PagoChequeDialog PagoCheque = new PagoChequeDialog(this, pagototal);
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
			this.buttonOk.IsFocus=true;

		}

		protected void OnButtonPagarClicked (object sender, EventArgs e)
		{
			ControladorBaseDatos db = new ControladorBaseDatos();



			Console.WriteLine("*************************************************");
			Console.WriteLine("usuario:"+usuario_);
			Console.WriteLine("boleta:"+numBoleta);
			Console.WriteLine("pago total:"+pagototal);
			int vuelto = (Int32.Parse(entryPagoEfectivo.Text.Trim())-Int32.Parse(pagototal));

			Console.WriteLine("vuelto:"+vuelto);
			Console.WriteLine("tipo pago: Pago Efectivo");
			Console.WriteLine("fecha :"+DateTime.Now);
			Console.WriteLine("*************************************************");
		
			Venta nuevaVenta = new Venta(Int32.Parse(numBoleta),
			                             DateTime.Now,
			                             pagototal,
			                             "efectivo",
			                             vuelto,
			                             usuario_,
			                             "false"); 
			db.AgregarVentaBd(nuevaVenta);
			try {
				for(int i=0; i<listaPago_.Count;i++)
				{   
					Console.WriteLine("ANTES DE codigo barra");

					string codigoBarra = db.ObtenerCodigoBarraBd((listaPago_[i].getNombre().Trim()));
										
					Console.WriteLine(codigoBarra);
										
					db.AgregarVentaDetalleBd(Int32.Parse(numBoleta),codigoBarra);
					
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Excepcion:--->"+ex);
			}

			this.buttonOk.IsFocus=true;

		}


		protected void OnKeyPressEvent (object o, KeyPressEventArgs args)
		{

			if (args.Event.Key == Gdk.Key.F2) {
				labeltotalcompra.Text = pagototal.Trim ();
				alignment3.Hide ();
				hbox3.Show ();
				this.entryPagoEfectivo.IsFocus = true;
				
			}
			if (args.Event.Key == Gdk.Key.F3) {
				PagoTarjetaDialog PagoTarjeta = new PagoTarjetaDialog (this, pagototal);
				try {
					PagoTarjeta.Run ();
					PagoTarjeta.Destroy ();	
					
				} catch (MySql.Data.MySqlClient.MySqlException ex) {
					PagoTarjeta.Destroy ();
#if DEBUG


					Console.WriteLine (ex.Message);
#endif
				}
				this.buttonOk.IsFocus = true;
				;
				
			}
			if (args.Event.Key == Gdk.Key.F4) {

				PagoChequeDialog PagoCheque = new PagoChequeDialog (this, pagototal);
				try {
					PagoCheque.Run ();
					PagoCheque.Destroy ();
				
				} catch (MySql.Data.MySqlClient.MySqlException ex) {
					PagoCheque.Destroy ();

#if DEBUG
					Console.WriteLine (ex.Message);
#endif
				}
				this.buttonOk.IsFocus = true;
			}
		}
	}

}


