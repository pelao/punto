
// This file has been generated by the GUI designer. Do not modify.
namespace punto.gui
{
	public partial class GenerarReportesDialog
	{
		private global::Gtk.VBox vbox4;
		private global::Gtk.Alignment alignment15;
		private global::Gtk.Frame frame1;
		private global::Gtk.Alignment GtkAlignment2;
		private global::Gtk.VBox vbox2;
		private global::Gtk.Alignment alignment3;
		private global::Gtk.HBox hbox2;
		private global::Gtk.Alignment alignment4;
		private global::Gtk.Label labelFechaInicial;
		private global::Gtk.Alignment alignment5;
		private global::Gtk.Label labelFechaFinal;
		private global::Gtk.Alignment alignment6;
		private global::Gtk.HBox hbox3;
		private global::Gtk.Alignment alignment7;
		private global::Gtk.ComboBox comboboxFechasInicial;
		private global::Gtk.Alignment alignment8;
		private global::Gtk.ComboBox comboboxFechasFinal;
		private global::Gtk.Alignment alignment9;
		private global::Gtk.Alignment alignment10;
		private global::Gtk.HBox hbox4;
		private global::Gtk.Alignment alignment12;
		private global::Gtk.Button buttonGuardarReporte;
		private global::Gtk.Alignment alignment11;
		private global::Gtk.Label GtkLabel3;
		private global::Gtk.Alignment alignment13;
		private global::Gtk.Button buttonCancel;
		private global::Gtk.Button buttonOk;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget punto.gui.GenerarReportesDialog
			this.Name = "punto.gui.GenerarReportesDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Reporte Ventas");
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			// Internal child punto.gui.GenerarReportesDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.alignment15 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment15.Name = "alignment15";
			this.vbox4.Add (this.alignment15);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.alignment15]));
			w2.Position = 0;
			// Container child vbox4.Gtk.Box+BoxChild
			this.frame1 = new global::Gtk.Frame ();
			this.frame1.Name = "frame1";
			this.frame1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child frame1.Gtk.Container+ContainerChild
			this.GtkAlignment2 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment2.Name = "GtkAlignment2";
			this.GtkAlignment2.LeftPadding = ((uint)(12));
			// Container child GtkAlignment2.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.alignment3 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment3.Name = "alignment3";
			this.vbox2.Add (this.alignment3);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.alignment3]));
			w3.Position = 0;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.alignment4 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment4.Name = "alignment4";
			this.hbox2.Add (this.alignment4);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.alignment4]));
			w4.Position = 0;
			// Container child hbox2.Gtk.Box+BoxChild
			this.labelFechaInicial = new global::Gtk.Label ();
			this.labelFechaInicial.Name = "labelFechaInicial";
			this.labelFechaInicial.LabelProp = global::Mono.Unix.Catalog.GetString ("Fecha Inicial:");
			this.hbox2.Add (this.labelFechaInicial);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.labelFechaInicial]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.alignment5 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment5.Name = "alignment5";
			this.hbox2.Add (this.alignment5);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.alignment5]));
			w6.Position = 2;
			// Container child hbox2.Gtk.Box+BoxChild
			this.labelFechaFinal = new global::Gtk.Label ();
			this.labelFechaFinal.Name = "labelFechaFinal";
			this.labelFechaFinal.LabelProp = global::Mono.Unix.Catalog.GetString ("Fecha Final:");
			this.hbox2.Add (this.labelFechaFinal);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.labelFechaFinal]));
			w7.Position = 3;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.alignment6 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment6.Name = "alignment6";
			this.hbox2.Add (this.alignment6);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.alignment6]));
			w8.Position = 4;
			this.vbox2.Add (this.hbox2);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox2]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.alignment7 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment7.Name = "alignment7";
			this.hbox3.Add (this.alignment7);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.alignment7]));
			w10.Position = 0;
			// Container child hbox3.Gtk.Box+BoxChild
			this.comboboxFechasInicial = global::Gtk.ComboBox.NewText ();
			this.comboboxFechasInicial.Name = "comboboxFechasInicial";
			this.hbox3.Add (this.comboboxFechasInicial);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.comboboxFechasInicial]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.alignment8 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment8.Name = "alignment8";
			this.hbox3.Add (this.alignment8);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.alignment8]));
			w12.Position = 2;
			// Container child hbox3.Gtk.Box+BoxChild
			this.comboboxFechasFinal = global::Gtk.ComboBox.NewText ();
			this.comboboxFechasFinal.Name = "comboboxFechasFinal";
			this.hbox3.Add (this.comboboxFechasFinal);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.comboboxFechasFinal]));
			w13.Position = 3;
			w13.Expand = false;
			w13.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.alignment9 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment9.Name = "alignment9";
			this.hbox3.Add (this.alignment9);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.alignment9]));
			w14.Position = 4;
			this.vbox2.Add (this.hbox3);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox3]));
			w15.Position = 2;
			w15.Expand = false;
			w15.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.alignment10 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment10.Name = "alignment10";
			this.vbox2.Add (this.alignment10);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.alignment10]));
			w16.Position = 3;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.alignment12 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment12.Name = "alignment12";
			this.hbox4.Add (this.alignment12);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.alignment12]));
			w17.Position = 0;
			// Container child hbox4.Gtk.Box+BoxChild
			this.buttonGuardarReporte = new global::Gtk.Button ();
			this.buttonGuardarReporte.CanFocus = true;
			this.buttonGuardarReporte.Name = "buttonGuardarReporte";
			this.buttonGuardarReporte.UseUnderline = true;
			this.buttonGuardarReporte.Label = global::Mono.Unix.Catalog.GetString ("Guardar Reporte");
			this.hbox4.Add (this.buttonGuardarReporte);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.buttonGuardarReporte]));
			w18.Position = 1;
			w18.Expand = false;
			w18.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.alignment11 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment11.Name = "alignment11";
			this.hbox4.Add (this.alignment11);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.alignment11]));
			w19.Position = 2;
			this.vbox2.Add (this.hbox4);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox4]));
			w20.Position = 4;
			w20.Expand = false;
			w20.Fill = false;
			this.GtkAlignment2.Add (this.vbox2);
			this.frame1.Add (this.GtkAlignment2);
			this.GtkLabel3 = new global::Gtk.Label ();
			this.GtkLabel3.Name = "GtkLabel3";
			this.GtkLabel3.LabelProp = global::Mono.Unix.Catalog.GetString ("Seleccione Fecha");
			this.GtkLabel3.UseMarkup = true;
			this.frame1.LabelWidget = this.GtkLabel3;
			this.vbox4.Add (this.frame1);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.frame1]));
			w23.Position = 1;
			// Container child vbox4.Gtk.Box+BoxChild
			this.alignment13 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment13.Name = "alignment13";
			this.vbox4.Add (this.alignment13);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.alignment13]));
			w24.Position = 2;
			w1.Add (this.vbox4);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(w1 [this.vbox4]));
			w25.Position = 0;
			// Internal child punto.gui.GenerarReportesDialog.ActionArea
			global::Gtk.HButtonBox w26 = this.ActionArea;
			w26.Name = "dialog1_ActionArea";
			w26.Spacing = 10;
			w26.BorderWidth = ((uint)(5));
			w26.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w27 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w26 [this.buttonCancel]));
			w27.Expand = false;
			w27.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w28 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w26 [this.buttonOk]));
			w28.Position = 1;
			w28.Expand = false;
			w28.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.Show ();
			this.buttonGuardarReporte.Clicked += new global::System.EventHandler (this.OnButtonGuardarReporteClicked);
		}
	}
}
