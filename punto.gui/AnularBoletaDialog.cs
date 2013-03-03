using GLib;
using System.Collections.Generic;
using Gtk;
using System;
using punto.code;

namespace punto.gui
{
	public partial class AnularBoletaDialog : Gtk.Dialog
	{
		private ControladorBaseDatos db;
		
		public AnularBoletaDialog ()
		{
			this.Build ();
			this.db = new ControladorBaseDatos ();
			bool correcta = false;
			
			try 
			{
				correcta = this.db.ConfiguracionCorrectaBd;
			} 
			catch (Exception ex) 
			{
				correcta = false;
			}
			if (!correcta) {
				
				
				this.db = null;
				this.db = new ControladorBaseDatos ();
				
				correcta = false;
				
				try 
				{
					correcta = this.db.ConfiguracionCorrectaBd;
				} 
				catch (Exception ex) 
				{
					correcta = false;
				}
				
			}
		}
		
		
		
		
		
		protected void OnButton724Clicked (object sender, EventArgs e)
		{
			frame1.Show ();
			string [] aux = this.db.ObtenerDatosAnularBoletaBD(entry1.Text.Trim());
			
			label8.Text = aux [1];
			label9.Text = aux [0];
			label10.Text = aux [2];
			label11.Text = aux [3];
			
			
		}
		
		protected void OnButton551Clicked (object sender, EventArgs e)
		{	
			try {
				Console.WriteLine (entry1.Text.Trim());
				this.db.Anularboletabd(new AnularBoleta(entry1.Text.Trim(),label9.Text,label11.Text));
				MessageDialog md = new MessageDialog (null, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "Boleta anulada correctamente");
				md.Run ();
				md.Destroy();
				this.db.ActualizarCampoAnuladoBD(entry1.Text.Trim());
				
				entry1.Text = "";
				label8.Text = "";
				label9.Text = "";
				label10.Text = "";
				label11.Text = "";
				frame1.Hide ();
			}
			catch{
				MessageDialog md = new MessageDialog (null, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "Boleta ya esta anulada");
				md.Run ();
				md.Destroy();
				entry1.Text = "";
				label8.Text = "";
				label9.Text = "";
				label10.Text = "";
				label11.Text = "";
				frame1.Hide ();
				
			}
		}
		
		protected void OnButton19Clicked (object sender, EventArgs e)
		{
			entry1.Text = "";
			label8.Text = "";
			label9.Text = "";
			label10.Text = "";
			label11.Text = "";
		}
	}
}

