using System;

namespace punto.gui
{
	public partial class InicioSesionWindow : Gtk.Window
	{
		public InicioSesionWindow () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
	}
}

