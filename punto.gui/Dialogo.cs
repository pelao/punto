using System;

namespace punto.gui
{
	public partial class Dialog : Gtk.Window
	{
		public Dialog () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
	}
}

