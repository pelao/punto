using System;
using System.Collections.Generic;
using Gtk;
using punto.code;

namespace punto.gui
{

	public  class EditarProductoDialogChangedEventArgs : EventArgs
	{

		private string nombre;
		private string precio;
		private string familia;
		private string vigente;


		public EditarProductoDialogChangedEventArgs(string cant, string d,string fam,string vig)
		{
			nombre = cant.Trim();
			precio = d.Trim();
			familia=fam.Trim();
			vigente=vig.Trim();
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
		public string Vigente
		{
			get { return vigente; }
		}


	
	}

		public partial class EditarProductoDialog : Gtk.Dialog
		{
		public List<FamiliaProducto> fam= new List<FamiliaProducto>();

		private Gtk.ListStore ventamodel;

		private bool checkbox=false;
		
		private bool checkbox2=true;
		private ControladorBaseDatos db;


			// The event. Note that by using the generic EventHandler<T> event type
			// we do not need to declare a separate delegate type.
		public event EventHandler<EditarProductoDialogChangedEventArgs> EditarProductoDialogdChanged;
			
			//Crear una especificacion


		public EditarProductoDialog (Gtk.Window parent, string nombre, string precio,string familia,string vigente) : base ("Editar Especificación", parent, Gtk.DialogFlags.DestroyWithParent)
		{
			this.Build ();
			this.Title = "Editar Especificación";
			this.db = new ControladorBaseDatos();
			this.combobox2.Hide ();

			if (nombre.Trim().Length == 0)
			{
				entry4.Sensitive = false;
			}
			else
			{
				entry4.Text = nombre.Trim();
			}
			if (precio.Trim().Length == 0)
			{
				entry5.Sensitive = false;
			}
			else
			{
				entry5.Text = precio.Trim();
			}
			if (familia.Trim().Length == 0)
			{
				entry2.Sensitive = false;
			}
			else
			{
				entry2.Text = familia.Trim();
			}
			Console.WriteLine(vigente);



			if (vigente=="True")

			{
				vigentecheckbutton.Active=true;
				checkbox=true;

			
			}
			else
			{
				checkbox=false;

			}



		}

		protected virtual void OnEditarProductoDialogChanged(EditarProductoDialogChangedEventArgs e)
		{
			// Make a temporary copy of the event to avoid possibility of
			// a race condition if the last subscriber unsubscribes
			// immediately after the null check and before the event is raised.
			EventHandler<EditarProductoDialogChangedEventArgs> handler = EditarProductoDialogdChanged;
			if (handler != null)
			{
				handler(this, e);
			}
		}
		public void CargarTiposFamiliaComboboxa()
		{

			List<FamiliaProducto> tipos = this.db.ObtenerFamiliasBd();
			combobox2.Clear();
			CellRendererText cell = new CellRendererText();
			combobox2.PackStart(cell, false);
			combobox2.AddAttribute(cell, "text", 0);
			this.ventamodel = new Gtk.ListStore(typeof (string));
			combobox2.Model = ventamodel;
			foreach (FamiliaProducto tp in tipos)
			{
				this.ventamodel.AppendValues(tp.Nombre);
				
			}
			vigentecheckbutton.Active=true;

			if (tipos.Count != 0)
			{
				this.combobox2.Active = 0;
			}
		}

		protected virtual void OnEditarButtonClicked (object sender, System.EventArgs e)
		{

		}

		protected void OnButtonCancelClicked (object sender, EventArgs e)
		{
			this.Hide();
			this.Dispose();
		}

		protected void OnCambiarfamilabuttonClicked (object sender, EventArgs e)
		{			
			this.entry2.Hide();
			this.combobox2.Show();
			this.CargarTiposFamiliaComboboxa();

		
		
		}

		protected void OnVigentecheckbuttonToggled (object sender, EventArgs e)
		{
			if(vigentecheckbutton.Active)
			{
				vigentecheckbutton.Active=true;
			}
			else
			{
				
				vigentecheckbutton.Active=false;

			}
		}

		
		protected void OnButtonOkClicked (object sender, EventArgs e)
		{

			string nombre = "", precio = "",familia="",vigencia="";
			
			if (entry4.Text.Trim().Length == 0)
			{
				//mostrar mensaje y terminar
				return;
			}
			else
			{
				nombre = entry4.Text.Trim();
			}
			if (entry5.Text.Trim().Length == 0)
			{
				//mostrar mensaje y terminar
				return;
			}
			else
			{
				precio = entry5.Text.Trim();
			}
			if (entry2.Text.Trim().Length == 0)
			{
				//mostrar mensaje y terminar
				return;
			}
			else
			{
				familia = combobox2.ActiveText;
			}
			vigentecheckbutton.Active=true;

		//	if (vigentecheckbutton.Activate)
		//	{
				//mostrar mensaje y terminar
		//		return;
		//	}
		//	else
		//	{
		//		vigencia = vigentecheckbutton.Activate;
		//	}
			
			
			
			EditarProductoDialogChangedEventArgs args = new EditarProductoDialogChangedEventArgs(nombre,precio,familia,vigencia);
			this.OnEditarProductoDialogChanged(args);
			
			this.Destroy();	
		}
		}
	}


	