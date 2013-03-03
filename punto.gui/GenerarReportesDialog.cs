using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using Gtk;
using System.Diagnostics;
using punto.code;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms;
using System.Collections;
using GLib;


namespace punto.gui
{
	public partial class GenerarReportesDialog : Gtk.Dialog
	{
		public string ruta_destino = null;
		private Gtk.ListStore fechaInicialModel;
		private Gtk.ListStore fechaFinalModel;

		public GenerarReportesDialog ()
		{
		

			this.Build ();
			this.CargarFechaInicial();
			this.CargarFechaFinal();

		}

		private void SeleccionarRuta( )
		{ 

			SaveFileDialog dialog = new SaveFileDialog(); 
			dialog.Filter = 
				"*.pdf|*.pdf|All files (*.*)|*.*"; 
			//dialog.InitialDirectory = "/Users/Esteban/Desktop"; 
			dialog.Title = "Guardar Reporte"; 
			if(dialog.ShowDialog() == DialogResult.OK){ 
				ruta_destino = dialog.FileName;
			}
		}


		public void CargarFechaInicial()
		{
			ControladorBaseDatos db = new ControladorBaseDatos();
			
			try {
				List<string> fechaInicial = db.ObtenerFechaBd();
				
				comboboxFechasInicial.Clear();
				CellRendererText cell = new CellRendererText();
				comboboxFechasInicial.PackStart(cell, false);
				comboboxFechasInicial.AddAttribute(cell, "text", 0);
				this.fechaInicialModel = new Gtk.ListStore(typeof (string));
				comboboxFechasInicial.Model = fechaInicialModel;
				foreach (string i in fechaInicial)
				{
					this.fechaInicialModel.AppendValues(i);
					
				}
				
				if (fechaInicial.Count != 0)
				{
					this.comboboxFechasInicial.Active = 0;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Excepcion:"+ex);
			}
		}

		public void CargarFechaFinal()
		{
			ControladorBaseDatos db = new ControladorBaseDatos();
			
			try {
				List<string> fechaFinal = db.ObtenerFechaBd();
				
				comboboxFechasFinal.Clear();
				CellRendererText cell2 = new CellRendererText();
				comboboxFechasFinal.PackStart(cell2, false);
				comboboxFechasFinal.AddAttribute(cell2, "text", 0);
				this.fechaFinalModel = new Gtk.ListStore(typeof (string));
				comboboxFechasFinal.Model = fechaFinalModel;
				foreach (string j in fechaFinal)
				{
					this.fechaFinalModel.AppendValues(j);
					
				}
				
				if (fechaFinal.Count != 0)
				{
					this.comboboxFechasFinal.Active = 0;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Excepcion:"+ex);
			}
		}


		protected void OnButtonGuardarReporteClicked (object sender, EventArgs e)
		{
			if(comboboxFechasInicial.Active.CompareTo(comboboxFechasFinal.Active)==1 || 
			   comboboxFechasInicial.Active.CompareTo(comboboxFechasFinal.Active)==0){

				Dialog dialog = new Dialog("ADVERTENCIA", this, Gtk.DialogFlags.DestroyWithParent);
				dialog.Modal = true;
				dialog.Resizable = false;
				Gtk.Label etiqueta = new Gtk.Label();
				etiqueta.Markup = "fecha inicial no puede ser mayor o igual que la fecha final";
				dialog.BorderWidth = 8;
				dialog.VBox.BorderWidth = 8;
				dialog.VBox.PackStart(etiqueta, false, false, 0);
				dialog.AddButton ("Cerrar", ResponseType.Close);
				dialog.ShowAll();
				dialog.Run ();
				dialog.Destroy ();
			}
			else{
				ControladorBaseDatos objeto = new ControladorBaseDatos();
				int boleta = objeto.ObtenerBoleta();



				string fechaInicial = comboboxFechasInicial.ActiveText;
				string fechaFinal = comboboxFechasFinal.ActiveText;
			

				Document myDocument;

		
			

				SeleccionarRuta();


	//			for(int aux=0; aux<listaVentas.Count; aux++){
	//				Console.WriteLine("Numero Boleta: "+Convert.ToString(listaVentas[aux].Idventa));
					//myDocument.Add(new Paragraph("Numero Boleta: "+listaVentas[aux].Idventa));
	//			}
				if(this.ruta_destino!=null){
					Console.WriteLine("iText Demo");
					
					// step 1: creation of a document-object
					myDocument = new Document(PageSize.A4.Rotate());
					
					Console.WriteLine("hora: "+DateTime.Now.ToShortTimeString());
					
					Console.WriteLine("Fecha: "+DateTime.Now.ToShortDateString());
					
					
					// step 2:
					// Now create a writer that listens to this doucment and writes the document to desired Stream.
					
					PdfWriter.GetInstance(myDocument, new FileStream(this.ruta_destino, FileMode.Create));
					
					// step 3:  Open the document now using
					myDocument.Open();

					try {
						//List<string> listaVentas = objeto.ObtenerIntervaloFechasBd(fechaInicial,fechaFinal);
						List<Venta> listaVentas = objeto.ObtenerIntervaloFechasBd(fechaInicial,fechaFinal);
						Console.WriteLine("tamaño listaVentas"+listaVentas.Count);
						
						
						for(int aux=0; aux<listaVentas.Count; aux++){
							Console.WriteLine("Numero Boleta: "+listaVentas[aux].Tipo_pago);
							myDocument.Add(new Paragraph("Numero Boleta: "+Convert.ToString(listaVentas[aux].Idventa)));
							myDocument.Add(new Paragraph("Fecha: "+listaVentas[aux].Var_fecha));
							myDocument.Add(new Paragraph("Total: "+listaVentas[aux].Total));
							myDocument.Add(new Paragraph("Cajero: "+listaVentas[aux].Usuarios_userlogin));
							myDocument.Add(new Paragraph("***********************"));
						}
					}
					catch (Exception ex)
					{
						Console.WriteLine("Excepcion:"+ex);
					}
					// step 4: Now add some contents to the document
	//				for(int aux=0; aux<listaVentas.Count; aux++){
	//					Console.WriteLine("Numero Boleta: "+Convert.ToString(listaVentas[aux].Idventa));
						//myDocument.Add(new Paragraph("Numero Boleta: "+listaVentas[aux].Idventa));
	//				}

					
					// step 5: Remember to close the documnet
					
					myDocument.Close();
					
					Dialog dialog2 = new Dialog("MENSAJE", this, Gtk.DialogFlags.DestroyWithParent);
					dialog2.Modal = true;
					dialog2.Resizable = false;
					Gtk.Label etiqueta2 = new Gtk.Label();
					etiqueta2.Markup = "Documento PDF creado correctamente";
					dialog2.BorderWidth = 8;
					dialog2.VBox.BorderWidth = 8;
					dialog2.VBox.PackStart(etiqueta2, false, false, 0);
					dialog2.AddButton ("Cerrar", ResponseType.Close);
					dialog2.ShowAll();
					dialog2.Run ();
					dialog2.Destroy ();
					
				}
			}


		}
	}
}

