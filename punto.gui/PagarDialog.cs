
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
		private int numBoleta;
		private string usuario_;
		private List<Produc> listaPago_;
		public ControladorBaseDatos a;
	

		public PagarDialog(Gtk.Window parent,string total, string usuario, List<Produc> listapago) : base ("Medios de Pago ", parent, Gtk.DialogFlags.DestroyWithParent)
		{
			this.db = new ControladorBaseDatos();
			this.pagototal=total;

			this.usuario_=usuario;
			this.listaPago_=listapago;
			this.Build ();
			

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
			frame1.Hide ();
			frame2.Show ();
			this.buttonPagoEfectivo.IsFocus=true;
			labeltotalcompra.ModifyFont(Pango.FontDescription.FromString("Arial  20"));
			labelEfectivo.ModifyFont(Pango.FontDescription.FromString("Arial  20"));
			labelTotal.ModifyFont(Pango.FontDescription.FromString("Arial  20"));
			labelVuelto.ModifyFont(Pango.FontDescription.FromString("Arial  20"));
		//	labelVuelto.Hide ();

			this.Deletable = true;
		}
		protected void OnPagoEnEfectivo (object sender, EventArgs e)
		{
			labeltotalcompra.Text=pagototal.Trim();
			frame1.Show ();
			frame2.Hide ();
			this.entryPagoEfectivo.IsFocus=true;

			//


		}


		
			[GLib.ConnectBefore ()] 
	
		protected void OnEntryPagoEfectivoKeyPressEvent (object o, KeyPressEventArgs args)
		{
		if (args.Event.Key==Gdk.Key.Return) {
				
				//labelVuelto.Show();
				vuelto = Int32.Parse (entryPagoEfectivo.Text.Trim ());
				labelvueltopago.Text = (vuelto - Int32.Parse (labeltotalcompra.Text)).ToString ();
				labelvueltopago.ModifyFont(Pango.FontDescription.FromString("Courier  20"));
				labelVuelto.ModifyFont(Pango.FontDescription.FromString("Courier  20"));
				labelvueltopago.ModifyBg(Gtk.StateType.Normal, new Gdk.Color (255, 0, 0));
			
				this.buttonPagar.IsFocus=true;
			}	
			if (args.Event.Key==Gdk.Key.F2) {
				
				labelVuelto.Show();
				vuelto = Int32.Parse (entryPagoEfectivo.Text.Trim ());
				labelvueltopago.Text = (vuelto - Int32.Parse (labeltotalcompra.Text)).ToString ();
				labelvueltopago.ModifyFont(Pango.FontDescription.FromString("Courier  20"));
				labelVuelto.ModifyFont(Pango.FontDescription.FromString("Courier  20"));

				labelvueltopago.ModifyBg(Gtk.StateType.Normal, new Gdk.Color (255, 0, 0));
				//this.buttonPagar.IsFocus=true;
				
				
			}	
		}


		protected void OnButtonPagoTarjetaClicked (object sender, EventArgs e)
		{
			PagoTarjetaDialog PagoTarjeta = new PagoTarjetaDialog(this,pagototal, listaPago_,usuario_);
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
			PagoChequeDialog PagoCheque = new PagoChequeDialog(this, pagototal, listaPago_, usuario_);
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
			numBoleta = db.ObtenerBoleta();


			Console.WriteLine("*************************************************");
			Console.WriteLine("usuario:"+usuario_);
			Console.WriteLine("boleta:"+numBoleta);
			Console.WriteLine("pago total:"+pagototal);
			int vuelto = (Int32.Parse(entryPagoEfectivo.Text.Trim())-Int32.Parse(pagototal));

			Console.WriteLine("vuelto:"+vuelto);
			Console.WriteLine("tipo pago: Pago Efectivo");
			Console.WriteLine("fecha :"+DateTime.Now);
			Console.WriteLine("*************************************************");
		
			Venta nuevaVenta = new Venta(numBoleta,
			                             DateTime.Now.ToString("yyyy-MM-dd"),
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
					for(int j=0; j<listaPago_[i].getCantidad(); j++){ 	
						db.AgregarVentaDetalleBd(numBoleta,codigoBarra);
					}

					
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Excepcion:--->"+ex);
			}
			this.buttonOk.IsFocus=true;
			buttonPagar.Sensitive = false;


		}

		protected void OnButtonPagoParcialClicked (object sender, EventArgs e)
		{
			PagoParcialDialog Pago = new PagoParcialDialog(this,pagototal, listaPago_, usuario_);
			try 
			{
				Pago.Run();
				Pago.Destroy();
				
			}
			catch (MySql.Data.MySqlClient.MySqlException ex)
			{
				Pago.Destroy();
#if DEBUG
				Console.WriteLine(ex.Message);
#endif
			}
		}


		protected void OnKeyPressEvent (object o, KeyPressEventArgs args)
		{

			if (args.Event.Key == Gdk.Key.F2) {
				labeltotalcompra.Text = pagototal.Trim ();
				frame1.Hide();
				this.entryPagoEfectivo.IsFocus = true;
				
			}
			if (args.Event.Key == Gdk.Key.F3) {
				PagoTarjetaDialog PagoTarjeta = new PagoTarjetaDialog (this, pagototal,listaPago_,usuario_);
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

				PagoChequeDialog PagoCheque = new PagoChequeDialog (this, pagototal, listaPago_, usuario_);
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


