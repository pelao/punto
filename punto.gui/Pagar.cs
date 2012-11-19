

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
		
		public Pagar(Gtk.Window parent) : base ("Pagar", parent, Gtk.DialogFlags.DestroyWithParent)
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
			
			this.Deletable = true;
		}
		
		protected void OnButton1392Clicked (object sender, EventArgs e)
		{
			label5.Text=this.db.ObtenerPrecioVenta().ToString();
			Console.WriteLine(this.db.ObtenerPrecioVenta());
			alignment3.Hide ();
			hbox3.Show();
			
			
		}
		
		
		
		protected void OnEntry7KeyPressEvent (object o, KeyPressEventArgs args)
		{
			if (args.Event.Key == Gdk.Key.Return) {
				
				
				vuelto = Int32.Parse (entry7.Text.Trim ());
				label10.Text = (Int32.Parse (label5.Text) - vuelto).ToString ();
				Console.WriteLine (vuelto);
				Console.WriteLine (label10.Text);
			}
		}
		
		
		protected void OnButton424Clicked (object sender, EventArgs e)
		{
			vuelto=Int32.Parse( entry7.Text.Trim ());
			label10.Text=(vuelto-Int32.Parse( label5.Text)).ToString();
			Console.WriteLine(vuelto);
			Console.WriteLine(label10.Text);	
		}
		
		protected void OnEntry7TextInserted (object o, TextInsertedArgs args)
		{
			vuelto=Int32.Parse( entry7.Text.Trim ());
			label10.Text=(vuelto-Int32.Parse( label5.Text)).ToString();
			Console.WriteLine(vuelto);
			Console.WriteLine(label10.Text);
		}
		
		protected void OnEntry7TextDeleted (object o, TextDeletedArgs args)
		{
			vuelto=Int32.Parse( entry7.Text.Trim ());
			label10.Text=(vuelto-Int32.Parse( label5.Text)).ToString();
			Console.WriteLine(vuelto);
			Console.WriteLine(label10.Text);
		}
		
		
		
		
		
		protected void OnDialog1VBoxKeyPressEvent (object o, KeyPressEventArgs args)
		{
			label5.Text=this.db.ObtenerPrecioVenta().ToString();
			Console.WriteLine(this.db.ObtenerPrecioVenta());
			alignment3.Hide ();
			hbox3.Show();
			vuelto = Int32.Parse (entry7.Text.Trim ());
			label10.Text = (vuelto-Int32.Parse (label5.Text)).ToString ();
			Console.WriteLine (vuelto);
			Console.WriteLine (label10.Text);
		}
	}
}

