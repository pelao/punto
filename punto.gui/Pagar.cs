

using System;
using System.Collections.Generic;
using Gtk;
using punto.code;

namespace punto.gui
{
	public partial class Pagar : Gtk.Dialog
	{
		private ControladorBaseDatos db;
		
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
			alignment3.Hide ();
			hbox3.Show();


		}
	}
}

