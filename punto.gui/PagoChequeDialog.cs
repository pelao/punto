using GLib;
using System.Collections.Generic;
using Gtk;
using System;
using punto.code;

namespace punto.gui
{
	public partial class PagoChequeDialog : Gtk.Dialog
	{		private ControladorBaseDatos db;
		
		public PagoChequeDialog (Gtk.Window parent,string monto) : base ("Pago Con Cheque", parent, Gtk.DialogFlags.DestroyWithParent)
			
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
			
			PagoCheque pago = new PagoCheque(comboboxBanco.ActiveText.Trim(),comboboxPlaza.ActiveText.Trim(),entryNroSerie.Text.Trim(),entryMonto.Text.Trim(),DateTime.Now);
			Console.WriteLine(comboboxBanco.ActiveText.Trim());
			Console.WriteLine(comboboxPlaza.ActiveText.Trim());
			Console.WriteLine(entryNroSerie.Text.Trim());
			Console.WriteLine(entryMonto.Text.Trim());

			this.db.AgregarPagoCheque(pago);		
		}
	}
}

