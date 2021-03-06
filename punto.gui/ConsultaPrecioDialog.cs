using System;
using punto.code;

namespace punto.gui
{
	public partial class ConsultaPrecioDialog : Gtk.Dialog
	{
		private ControladorBaseDatos db;

		public ConsultaPrecioDialog ()
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
			labelPrecioConsulta.ModifyFont(Pango.FontDescription.FromString("Courier bold 32"));
			labelPrecio.ModifyFont(Pango.FontDescription.FromString("Courier bold 32"));
			labelConsulta.ModifyFont(Pango.FontDescription.FromString("Courier bold 32"));
		}




		protected void OnEntryCodigoDeBarraTextInserted (object o, Gtk.TextInsertedArgs args)
		{
			string precio = this.db.ObtenerPrecioProductosBd(entryCodigoDeBarra.Text.Trim());
			entryCodigoDeBarra.DeleteText(0, entryCodigoDeBarra.Text.Length);

			labelPrecioConsulta.Text=precio;
		
		}
	}
}

