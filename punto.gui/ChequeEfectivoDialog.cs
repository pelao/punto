using GLib;
using System.Collections.Generic;
using Gtk;
using System;
using punto.code;
namespace punto.gui
{
	public partial class ChequeEfectivoDialog : Gtk.Dialog
	{
		private ControladorBaseDatos db;
		private int numBoleta;
		private List<Produc> listaPago_;
		private string usuario_;
		private string pagototal;

		public ChequeEfectivoDialog (Gtk.Window parent,string monto, List<Produc> listapago,string usuario)
		{
			this.Build ();
		}
	}
}

