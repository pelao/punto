using System;
using System.Collections.Generic;
using Gtk;
using punto.code;

namespace punto.gui
{
	
	public partial class EditarProductoDialogChangedEventArgs : EventArgs
	{
		
		private string nombre;
		private string precio;
		private string familia;
		
		public EditarProductoDialogChangedEventArgs(string cant, string d,string fam)
		{
			nombre = cant.Trim();
			precio = d.Trim();
			familia = fam.Trim();
		}
		
		public string Nombre
		{
			get { return nombre; }
		}
		
		public string Precio
		{
			get { return precio; }
		}
		public string Familia
		{
			get { return familia; }
		}
		
		
	}
	
	public partial class EditarProductoDialog : Gtk.Dialog
	{
		private ControladorBaseDatos db;
		public List<FamiliaProducto> fam= new List<FamiliaProducto>();
		
		private Gtk.ListStore ventamodel;
		
		public event EventHandler<EditarProductoDialogChangedEventArgs> EditarProductoDialogdChanged;
		
		
		public EditarProductoDialog (Gtk.Window parent, string nombre, string precio,string familia) : base ("Editar producto", parent, Gtk.DialogFlags.DestroyWithParent)
		{
			this.Build ();
			this.db = new ControladorBaseDatos();
			this.comboboxFamilia.Hide ();

			if (nombre.Trim().Length == 0)
			{
				entryNombre.Sensitive = false;
			}
			else
			{
				entryNombre.Text = nombre.Trim();
			}
			if (precio.Trim().Length == 0)
			{
				entryPrecio.Sensitive = false;
			}
			else
			{
				entryPrecio.Text = precio.Trim();
			}
			if (familia.Trim().Length == 0)
			{
				entryFamilia.Sensitive = false;
			}
			else
			{
				entryFamilia.Text = familia.Trim();
			}
		}
		protected void OnButtonCancelClicked (object sender, EventArgs e)
		{
			this.Hide();
			this.Dispose();
		}
		
		protected void OnCambiarfamilabuttonClicked (object sender, EventArgs e)
		{			
			this.entryFamilia.Hide();
			this.comboboxFamilia.Show();
			this.CargarTiposFamiliaComboboxa();
		}

		protected virtual void OnEditarProductoDialogChanged(EditarProductoDialogChangedEventArgs e)
		{

			EventHandler<EditarProductoDialogChangedEventArgs> handler = EditarProductoDialogdChanged;
			if (handler != null)
			{
				handler(this, e);
			}
		}
		
		protected virtual void OnEditarButtonClicked (object sender, System.EventArgs e)
		{

		}
		public void CargarTiposFamiliaComboboxa ()
		{
			
			List<FamiliaProducto> tipos = this.db.ObtenerFamiliasBd ();
			comboboxFamilia.Clear();
			CellRendererText cell = new CellRendererText ();
			comboboxFamilia.PackStart (cell, false);
			comboboxFamilia.AddAttribute (cell, "text", 0);
			this.ventamodel = new Gtk.ListStore (typeof(string));
			comboboxFamilia.Model = ventamodel;
			foreach (FamiliaProducto tp in tipos) {
				this.ventamodel.AppendValues (tp.Nombre);
				
			}
			vigentecheckbutton.Active = true;
			
			if (tipos.Count != 0) {
				this.comboboxFamilia.Active = 0;
			}
		}
		protected void OnButtonOkClicked (object sender, EventArgs e)
		{
			string nombre = "", precio = "",familia="";
			
			if (entryNombre.Text.Trim().Length == 0)
			{
			
				return;
			}
			else
			{
				nombre = entryNombre.Text.Trim();
			}
			if (entryPrecio.Text.Trim().Length == 0)
			{
	
				return;
			}
			else
			{
				precio = entryPrecio.Text.Trim();
			}
			if (entryFamilia.Text.Trim().Length == 0)
			{
	
				return;
			}
			else
			{
				familia = comboboxFamilia.ActiveText;
			}

			EditarProductoDialogChangedEventArgs args = new EditarProductoDialogChangedEventArgs(nombre,precio,familia);
			this.OnEditarProductoDialogChanged(args);

			this.Destroy();			
		}
	}
}

