

using System;
using System.Collections.Generic;
using Gtk;
using punto.code;


namespace punto.gui
{



	public partial class Pagar : Gtk.Dialog
	{
		private ControladorBaseDatos db;
		private int num;
		private int vuelto;
		private VenderProductosDialog treviewventa;
		private string pagototal;

			public Pagar(Gtk.Window parent,string total,string boleta) : base ("Pagar", parent, Gtk.DialogFlags.DestroyWithParent)
		{
			this.pagototal=total;
			
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
				//mostrar dialog configuracion
				basedatosdialog bdd = new basedatosdialog(this);
				bdd.Run();
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
			Console.WriteLine(this.db.ObtenerPrecioVenta());
			alignment3.Hide ();
			hbox3.Show();
			this.entryPagoEfectivo.IsFocus=true;
		
		}



		/*

		protected void OnEntryPagoEfectivoTextInserted (object o, TextInsertedArgs args)
		{

				vuelto = Int32.Parse (entryPagoEfectivo.Text.Trim ());
				label10.Text = (vuelto - Int32.Parse (label5.Text)).ToString ();
				Console.WriteLine (vuelto);
				Console.WriteLine (label10.Text);

		}*/

		/*

		protected void OnEntryPagoEfectivoTextDeleted (object o, TextDeletedArgs args)
		{
			vuelto=Int32.Parse( entryPagoEfectivo.Text.Trim ());
			label10.Text=(vuelto-Int32.Parse( label5.Text)).ToString();
			Console.WriteLine(vuelto);
			Console.WriteLine(label10.Text);
		}*/

		
		[GLib.ConnectBefore ()] 

		protected void OnEntryPagoEfectivoKeyPressEvent (object o, KeyPressEventArgs args)
		{
			if (args.Event.Key==Gdk.Key.Return) {
				
				labelVuelto.Show();
				vuelto = Int32.Parse (entryPagoEfectivo.Text.Trim ());
				labelvueltopago.Text = (vuelto - Int32.Parse (labeltotalcompra.Text)).ToString ();
				labelVuelto.ModifyFont(Pango.FontDescription.FromString("Courier bold 32"));
				labelvueltopago.ModifyFont(Pango.FontDescription.FromString("Courier bold 32"));
				labelvueltopago.ModifyBg(Gtk.StateType.Normal, new Gdk.Color (255, 0, 0));
				this.buttonOk.IsFocus=true;


			}	
		}

		protected void OnButtonOkClicked (object sender, EventArgs e)
		{

			}

		}
	}


