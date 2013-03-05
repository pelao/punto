using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using Gtk;
using System.Diagnostics;
using punto.code;
using iTextSharp;
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
		//	this.CargarFechaInicial();
		//	this.CargarFechaFinal();
		//	comboboxFechasInicial.Active = 0;
		//	comboboxFechasFinal.Active = 0;


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
		
		
		/*	public void CargarFechaInicial()
		{
			ControladorBaseDatos db = new ControladorBaseDatos();

			try {
				//db.ordenarFecha();
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
			//db.ordenarFecha();
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
		
*/

		protected void OnButtonGuardarReporteClicked (object sender, EventArgs e)
		{
			string fechaInicial = calendarFInicial.GetDate ().ToString ("yyyy-MM-dd").Trim ();
			string fechaFinal = calendarFFinal.GetDate ().ToString ("yyyy-MM-dd").Trim ();

			this.OnCalendarFInicialDaySelected(sender,e);
			this.OnCalendarFFinalDaySelected(sender,e);

			if(fechaInicial.CompareTo(fechaFinal)==1){
				
				Dialog dialog = new Dialog("ADVERTENCIA", this, Gtk.DialogFlags.DestroyWithParent);
				dialog.Modal = true;
				dialog.Resizable = false;
				Gtk.Label etiqueta = new Gtk.Label();
				etiqueta.Markup = "fecha final no puede ser anterior a fecha inicial";
				dialog.BorderWidth = 8;
				dialog.VBox.BorderWidth = 8;
				dialog.VBox.PackStart(etiqueta, false, false, 0);
				dialog.AddButton ("Cerrar", ResponseType.Close);
				dialog.ShowAll();
				dialog.Run ();
				dialog.Destroy ();
			}
			else{
				
			//	string fechaInicial = comboboxFechasInicial.ActiveText;
			//	string fechaFinal = comboboxFechasFinal.ActiveText;
				
				Document myDocument;
				
				SeleccionarRuta();
				
				
				//			for(int aux=0; aux<listaVentas.Count; aux++){
				//				Console.WriteLine("Numero Boleta: "+Convert.ToString(listaVentas[aux].Idventa));
				//myDocument.Add(new Paragraph("Numero Boleta: "+listaVentas[aux].Idventa));
				//			}
				if(this.ruta_destino!=null){
					Console.WriteLine("iText Demo");
					
					// step 1: creation of a document-object
					myDocument = new Document(PageSize.LETTER);
					
					Console.WriteLine("hora: "+DateTime.Now.ToShortTimeString());
					
					Console.WriteLine("Fecha: "+DateTime.Now.ToShortDateString());
					
					
					// step 2:
					// Now create a writer that listens to this doucment and writes the document to desired Stream.
					
					PdfWriter.GetInstance(myDocument, new FileStream(this.ruta_destino, FileMode.Create));
					
					// step 3:  Open the document now using
					myDocument.Open();
					
					PdfPTable tabla = new PdfPTable(4);
					
					tabla.AddCell("N° Boleta ");
					tabla.AddCell("Fecha " );
					tabla.AddCell("Total Venta " );
					tabla.AddCell("Cajero ");

					foreach (PdfPCell celda in tabla.Rows[0].GetCells())
					{
						celda.BackgroundColor = BaseColor.LIGHT_GRAY;
						celda.HorizontalAlignment = 1;
						celda.Padding = 3;
					}
					
					try {
						ControladorBaseDatos objeto = new ControladorBaseDatos();
						//List<string> listaVentas = objeto.ObtenerIntervaloFechasBd(fechaInicial,fechaFinal);
						List<Venta> listaVentas = objeto.ObtenerIntervaloFechasBd(fechaInicial,fechaFinal);
						Console.WriteLine("tamaño listaVentas"+listaVentas.Count);

					
						myDocument.Add(new Paragraph("                                                                                                                                                                                                                                                                                                                                                                                                                 Emitido el: "+DateTime.Now.ToShortDateString()+ " a las: "+DateTime.Now.ToShortTimeString()+" Horas",
						                             FontFactory.GetFont("arial",   // fuente
						                    8,                            // tamaño
						                    Font.NORMAL,                   // estilo
						                    BaseColor.BLACK)));
						myDocument.Add(new Paragraph(" "));
						myDocument.Add(new Paragraph("                            Reporte Ventas Minimarket El Coke",
						                             FontFactory.GetFont("arial",   // fuente
						                    18,                            // tamaño
						                    Font.NORMAL,                   // estilo
						                    BaseColor.BLACK)));
	
				// AQUI VA EL LOGO DEL MINIMARKET

						iTextSharp.text.Image imgP = iTextSharp.text.Image.GetInstance("/Users/Esteban/Projects/Git43Felo/punto.gui/iconos/imagen.png");
						imgP.ScalePercent(40, 40);
						imgP.Alignment = Element.ALIGN_CENTER;
						myDocument.Add(imgP);

						myDocument.Add(new Paragraph(" "));
						myDocument.Add(new Paragraph("                                              Ventas realizadas entre "+fechaInicial+" y "+fechaFinal,
						                            FontFactory.GetFont("arial",   // fuente
						                    10,                            // tamaño
						                    Font.NORMAL,                   // estilo
						                    BaseColor.BLACK)));
						int tamanio = listaVentas.Count;

						string[,] arreglo = new string[tamanio,4];
						
						for(int i=0; i<tamanio; i++){
							for(int j=0; j<4; j++){
								switch(j)
								{
								case 0:
									arreglo[i,j] =Convert.ToString(listaVentas[i].Idventa);
									break;
								case 1:
									arreglo[i,j] =listaVentas[i].Var_fecha;
									break;
								case 2:
									arreglo[i,j] =listaVentas[i].Total;
									break;
								case 3:
									arreglo[i,j] =listaVentas[i].Usuarios_userlogin;
									break;
								default:
									Console.WriteLine("Default case");
									break;
									
								}
								
							}
						}
						List<string> lista2 = new List<string>();
						for(int i=0; i<tamanio; i++){
							for(int j=0; j<4; j++){
								Console.WriteLine("["+i+"]["+j+"]: "+arreglo[i,j]+" ");
								lista2.Add(arreglo[i,j]);
							}
							Console.WriteLine("\n");
						}

						for (int i = 0; i < (tamanio*4); i++){
							tabla.AddCell(lista2[i]);
						}

						int total = 0;
						for(int aux=0; aux<listaVentas.Count; aux++){

							total+=Int32.Parse(listaVentas[aux].Total);
						}
						Console.WriteLine("Total: "+total);

						myDocument.Add(new Paragraph(" "));
						myDocument.Add(tabla);
						myDocument.Add(new Paragraph(" "));
						myDocument.Add(new Paragraph("                                                                                                                                                                                                                               Total______$"+total+".-",
						                             FontFactory.GetFont("arial",   // fuente
						                    22,                            // tamaño
						                    Font.NORMAL,                   // estilo
						                    BaseColor.RED)));
					/*	for(int aux=0; aux<listaVentas.Count; aux++){
							Console.WriteLine("Numero Boleta: "+listaVentas[aux].Tipo_pago);
							myDocument.Add(new Paragraph("Numero Boleta: "+Convert.ToString(listaVentas[aux].Idventa)));
							myDocument.Add(new Paragraph("Fecha: "+listaVentas[aux].Var_fecha));
							myDocument.Add(new Paragraph("Total: "+listaVentas[aux].Total));
							myDocument.Add(new Paragraph("Cajero: "+listaVentas[aux].Usuarios_userlogin));
							myDocument.Add(new Paragraph("***********************"));
						}*/
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


		protected void OnCalendarFInicialDaySelected (object sender, EventArgs e)
		{
			ControladorBaseDatos db = new ControladorBaseDatos ();
			string fechaI="";

			//DateTime.Now.ToString("yyyy-MM-dd")
			fechaI = calendarFInicial.GetDate ().ToString ("yyyy-MM-dd").Trim ();
			Console.WriteLine("fecha seleccionada I: "+fechaI);

			if (!db.ExisteFechaBd (fechaI)) {
				Console.WriteLine ("NO existe venta");

				Dialog dialog = new Dialog("Advertencia", this, Gtk.DialogFlags.DestroyWithParent);
				dialog.Modal = true;
				dialog.Resizable = false;
				Gtk.Label etiqueta = new Gtk.Label();
				etiqueta.Markup = "No existen ventas en el día seleccionado";
				dialog.BorderWidth = 8;
				dialog.VBox.BorderWidth = 8;
				dialog.VBox.PackStart(etiqueta, false, false, 0);
				dialog.AddButton ("Cerrar", ResponseType.Close);
				dialog.ShowAll();
				dialog.Run ();
				dialog.Destroy ();
			} else {
				Console.WriteLine ("existe venta");

			
			}
		}

		protected void OnCalendarFFinalDaySelected (object sender, EventArgs e)
		{
			ControladorBaseDatos db = new ControladorBaseDatos ();
			string fechaF="";
			
			//DateTime.Now.ToString("yyyy-MM-dd")
			fechaF = calendarFFinal.GetDate ().ToString ("yyyy-MM-dd").Trim ();
			Console.WriteLine("fecha seleccionada F: "+fechaF);
			
			if (!db.ExisteFechaBd (fechaF)) {
				Console.WriteLine ("NO existe venta");

				Dialog dialog = new Dialog("Advertencia", this, Gtk.DialogFlags.DestroyWithParent);
				dialog.Modal = true;
				dialog.Resizable = false;
				Gtk.Label etiqueta = new Gtk.Label();
				etiqueta.Markup = "No existen ventas en el día seleccionado";
				dialog.BorderWidth = 8;
				dialog.VBox.BorderWidth = 8;
				dialog.VBox.PackStart(etiqueta, false, false, 0);
				dialog.AddButton ("Cerrar", ResponseType.Close);
				dialog.ShowAll();
				dialog.Run ();
				dialog.Destroy ();
			} else {
				Console.WriteLine ("existe venta");
			}
		}
	}
}

