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


namespace punto.gui
{
	public partial class GenerarReportesDialog : Gtk.Dialog
	{
		public string ruta_destino = null;

		public GenerarReportesDialog ()
		{
		

			this.Build ();


		}

		private void SelectTextFile ( )
		{ 

			SaveFileDialog dialog = new SaveFileDialog(); 
			dialog.Filter = 
				"*.pdf|*.pdf|All files (*.*)|*.*"; 
			dialog.InitialDirectory = "/Users/Esteban/Desktop"; 
			dialog.Title = "Guardar Reporte"; 
			if(dialog.ShowDialog() == DialogResult.OK){ 
				ruta_destino = dialog.FileName;
			}
		//	return ( dialog.ShowDialog() == DialogResult.OK )
		//		? dialog.FileName : null;
		}


		protected void OnButtonGuardarReporteClicked (object sender, EventArgs e)
		{

			Document myDocument;
			SelectTextFile();
		
			if(this.ruta_destino!=null){
				Console.WriteLine("iText Demo");
				

				
				try 
				{
					// step 1: creation of a document-object
					myDocument = new Document(PageSize.A4.Rotate());
					
					Console.WriteLine("hora: "+DateTime.Now.ToShortTimeString());
					
					Console.WriteLine("Fecha: "+DateTime.Now.ToShortDateString());

					ControladorBaseDatos db = new ControladorBaseDatos();
					Produc producto = db.ObtenerProductosVenta(entryCodigoBarra.Text.Trim ());
					// step 2:
					// Now create a writer that listens to this doucment and writes the document to desired Stream.
					
					PdfWriter.GetInstance(myDocument, new FileStream(this.ruta_destino, FileMode.Create));
					
					// step 3:  Open the document now using
					myDocument.Open();
					
					// step 4: Now add some contents to the document
					
					myDocument.Add(new Paragraph("Nombre: "));
			
					
				}
				catch(DocumentException de) 
				{
					Console.Error.WriteLine(de.Message);
				}
				catch(FileNotFoundException ioe) 
				{
					Console.Error.WriteLine(ioe.Message);
					Dialog dialog = new Dialog("ERROR", this, Gtk.DialogFlags.DestroyWithParent);
					dialog.Modal = true;
					dialog.Resizable = false;
					Gtk.Label etiqueta = new Gtk.Label();
					etiqueta.Markup = "Documento actual se encuentra abierto";
					dialog.BorderWidth = 8;
					dialog.VBox.BorderWidth = 8;
					dialog.VBox.PackStart(etiqueta, false, false, 0);
					dialog.AddButton ("Cerrar", ResponseType.Close);
					dialog.ShowAll();
					dialog.Run ();
					dialog.Destroy ();
				}
				
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

