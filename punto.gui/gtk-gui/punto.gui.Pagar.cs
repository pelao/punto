
// This file has been generated by the GUI designer. Do not modify.
namespace punto.gui
{
	public partial class Pagar
	{
		private global::Gtk.HBox hbox25;
		private global::Gtk.VBox vbox8;
		private global::Gtk.HBox hbox3;
		private global::Gtk.VBox vbox7;
		private global::Gtk.HPaned hpaned4;
		private global::Gtk.Label labelTotal;
		private global::Gtk.HPaned hpaned6;
		private global::Gtk.Label labelEfectivo;
		private global::Gtk.HPaned hpaned8;
		private global::Gtk.Label labelVuelto;
		private global::Gtk.VBox vbox6;
		private global::Gtk.Alignment alignment39;
		private global::Gtk.HPaned hpaned5;
		private global::Gtk.Label label5;
		private global::Gtk.Alignment alignment40;
		private global::Gtk.Entry entryPagoEfectivo;
		private global::Gtk.HPaned hpaned9;
		private global::Gtk.Label label10;
		private global::Gtk.Alignment alignment3;
		private global::Gtk.Frame frame2;
		private global::Gtk.Alignment GtkAlignment2;
		private global::Gtk.HBox hbox2;
		private global::Gtk.VBox vbox3;
		private global::Gtk.HPaned hpaned1;
		private global::Gtk.Button buttonPagoEfectivo;
		private global::Gtk.VBox vbox4;
		private global::Gtk.HPaned hpaned2;
		private global::Gtk.Button buttonPagoTransBank;
		private global::Gtk.VBox vbox5;
		private global::Gtk.HPaned hpaned3;
		private global::Gtk.Button buttonOtro;
		private global::Gtk.Label GtkLabel5;
		private global::Gtk.Alignment alignment41;
		private global::Gtk.Fixed fixed7;
		private global::Gtk.Button buttonCancel;
		private global::Gtk.Button buttonOk;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget punto.gui.Pagar
			this.Name = "punto.gui.Pagar";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child punto.gui.Pagar.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.hbox25 = new global::Gtk.HBox ();
			this.hbox25.Name = "hbox25";
			this.hbox25.Spacing = 6;
			// Container child hbox25.Gtk.Box+BoxChild
			this.vbox8 = new global::Gtk.VBox ();
			this.vbox8.Name = "vbox8";
			this.vbox8.Spacing = 6;
			// Container child vbox8.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.WidthRequest = 371;
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.vbox7 = new global::Gtk.VBox ();
			this.vbox7.Name = "vbox7";
			this.vbox7.Spacing = 6;
			// Container child vbox7.Gtk.Box+BoxChild
			this.hpaned4 = new global::Gtk.HPaned ();
			this.hpaned4.CanFocus = true;
			this.hpaned4.Name = "hpaned4";
			this.hpaned4.Position = 10;
			// Container child hpaned4.Gtk.Paned+PanedChild
			this.labelTotal = new global::Gtk.Label ();
			this.labelTotal.Name = "labelTotal";
			this.labelTotal.LabelProp = global::Mono.Unix.Catalog.GetString ("Total:");
			this.labelTotal.Justify = ((global::Gtk.Justification)(2));
			this.labelTotal.Ellipsize = ((global::Pango.EllipsizeMode)(2));
			this.hpaned4.Add (this.labelTotal);
			this.vbox7.Add (this.hpaned4);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.hpaned4]));
			w3.Position = 0;
			// Container child vbox7.Gtk.Box+BoxChild
			this.hpaned6 = new global::Gtk.HPaned ();
			this.hpaned6.CanFocus = true;
			this.hpaned6.Name = "hpaned6";
			this.hpaned6.Position = 10;
			// Container child hpaned6.Gtk.Paned+PanedChild
			this.labelEfectivo = new global::Gtk.Label ();
			this.labelEfectivo.Name = "labelEfectivo";
			this.labelEfectivo.LabelProp = global::Mono.Unix.Catalog.GetString ("Efectivo:");
			this.hpaned6.Add (this.labelEfectivo);
			this.vbox7.Add (this.hpaned6);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.hpaned6]));
			w5.Position = 1;
			// Container child vbox7.Gtk.Box+BoxChild
			this.hpaned8 = new global::Gtk.HPaned ();
			this.hpaned8.CanFocus = true;
			this.hpaned8.Name = "hpaned8";
			this.hpaned8.Position = 10;
			// Container child hpaned8.Gtk.Paned+PanedChild
			this.labelVuelto = new global::Gtk.Label ();
			this.labelVuelto.Name = "labelVuelto";
			this.labelVuelto.LabelProp = global::Mono.Unix.Catalog.GetString ("Vuelto:");
			this.hpaned8.Add (this.labelVuelto);
			this.vbox7.Add (this.hpaned8);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.hpaned8]));
			w7.Position = 2;
			this.hbox3.Add (this.vbox7);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.vbox7]));
			w8.Position = 0;
			// Container child hbox3.Gtk.Box+BoxChild
			this.vbox6 = new global::Gtk.VBox ();
			this.vbox6.Name = "vbox6";
			this.vbox6.Spacing = 6;
			// Container child vbox6.Gtk.Box+BoxChild
			this.alignment39 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment39.Name = "alignment39";
			// Container child alignment39.Gtk.Container+ContainerChild
			this.hpaned5 = new global::Gtk.HPaned ();
			this.hpaned5.CanFocus = true;
			this.hpaned5.Name = "hpaned5";
			this.hpaned5.Position = 10;
			// Container child hpaned5.Gtk.Paned+PanedChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.hpaned5.Add (this.label5);
			this.alignment39.Add (this.hpaned5);
			this.vbox6.Add (this.alignment39);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.alignment39]));
			w11.Position = 0;
			// Container child vbox6.Gtk.Box+BoxChild
			this.alignment40 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment40.Name = "alignment40";
			// Container child alignment40.Gtk.Container+ContainerChild
			this.entryPagoEfectivo = new global::Gtk.Entry ();
			this.entryPagoEfectivo.WidthRequest = 20;
			this.entryPagoEfectivo.CanFocus = true;
			this.entryPagoEfectivo.Name = "entryPagoEfectivo";
			this.entryPagoEfectivo.IsEditable = true;
			this.entryPagoEfectivo.InvisibleChar = '●';
			this.alignment40.Add (this.entryPagoEfectivo);
			this.vbox6.Add (this.alignment40);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.alignment40]));
			w13.Position = 1;
			w13.Expand = false;
			w13.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.hpaned9 = new global::Gtk.HPaned ();
			this.hpaned9.CanFocus = true;
			this.hpaned9.Name = "hpaned9";
			this.hpaned9.Position = 10;
			// Container child hpaned9.Gtk.Paned+PanedChild
			this.label10 = new global::Gtk.Label ();
			this.label10.Name = "label10";
			this.hpaned9.Add (this.label10);
			this.vbox6.Add (this.hpaned9);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.hpaned9]));
			w15.Position = 2;
			this.hbox3.Add (this.vbox6);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.vbox6]));
			w16.Position = 1;
			this.vbox8.Add (this.hbox3);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.hbox3]));
			w17.Position = 0;
			// Container child vbox8.Gtk.Box+BoxChild
			this.alignment3 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment3.Name = "alignment3";
			// Container child alignment3.Gtk.Container+ContainerChild
			this.frame2 = new global::Gtk.Frame ();
			this.frame2.Name = "frame2";
			this.frame2.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame2.Gtk.Container+ContainerChild
			this.GtkAlignment2 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment2.Name = "GtkAlignment2";
			this.GtkAlignment2.LeftPadding = ((uint)(12));
			// Container child GtkAlignment2.Gtk.Container+ContainerChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hpaned1 = new global::Gtk.HPaned ();
			this.hpaned1.CanFocus = true;
			this.hpaned1.Name = "hpaned1";
			this.hpaned1.Position = 10;
			// Container child hpaned1.Gtk.Paned+PanedChild
			this.buttonPagoEfectivo = new global::Gtk.Button ();
			this.buttonPagoEfectivo.CanFocus = true;
			this.buttonPagoEfectivo.Name = "buttonPagoEfectivo";
			this.buttonPagoEfectivo.UseUnderline = true;
			this.buttonPagoEfectivo.BorderWidth = ((uint)(3));
			this.buttonPagoEfectivo.Label = global::Mono.Unix.Catalog.GetString ("Pago Efectivo \n   (teclear 1)");
			this.hpaned1.Add (this.buttonPagoEfectivo);
			this.vbox3.Add (this.hpaned1);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hpaned1]));
			w19.Position = 1;
			this.hbox2.Add (this.vbox3);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.vbox3]));
			w20.Position = 0;
			// Container child hbox2.Gtk.Box+BoxChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hpaned2 = new global::Gtk.HPaned ();
			this.hpaned2.CanFocus = true;
			this.hpaned2.Name = "hpaned2";
			this.hpaned2.Position = 10;
			// Container child hpaned2.Gtk.Paned+PanedChild
			this.buttonPagoTransBank = new global::Gtk.Button ();
			this.buttonPagoTransBank.CanFocus = true;
			this.buttonPagoTransBank.Name = "buttonPagoTransBank";
			this.buttonPagoTransBank.UseUnderline = true;
			this.buttonPagoTransBank.Label = global::Mono.Unix.Catalog.GetString ("Pago Tarjeta\n  (teclear 2)");
			this.hpaned2.Add (this.buttonPagoTransBank);
			this.vbox4.Add (this.hpaned2);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hpaned2]));
			w22.Position = 1;
			this.hbox2.Add (this.vbox4);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.vbox4]));
			w23.Position = 1;
			// Container child hbox2.Gtk.Box+BoxChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hpaned3 = new global::Gtk.HPaned ();
			this.hpaned3.CanFocus = true;
			this.hpaned3.Name = "hpaned3";
			this.hpaned3.Position = 10;
			// Container child hpaned3.Gtk.Paned+PanedChild
			this.buttonOtro = new global::Gtk.Button ();
			this.buttonOtro.CanFocus = true;
			this.buttonOtro.Name = "buttonOtro";
			this.buttonOtro.UseUnderline = true;
			this.buttonOtro.Label = global::Mono.Unix.Catalog.GetString ("Pago Cheque\n  (teclear 3)");
			this.hpaned3.Add (this.buttonOtro);
			this.vbox5.Add (this.hpaned3);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.hpaned3]));
			w25.Position = 1;
			this.hbox2.Add (this.vbox5);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.vbox5]));
			w26.Position = 2;
			this.GtkAlignment2.Add (this.hbox2);
			this.frame2.Add (this.GtkAlignment2);
			this.GtkLabel5 = new global::Gtk.Label ();
			this.GtkLabel5.Name = "GtkLabel5";
			this.GtkLabel5.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>GtkFrame</b>");
			this.GtkLabel5.UseMarkup = true;
			this.frame2.LabelWidget = this.GtkLabel5;
			this.alignment3.Add (this.frame2);
			this.vbox8.Add (this.alignment3);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.alignment3]));
			w30.Position = 1;
			this.hbox25.Add (this.vbox8);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.hbox25 [this.vbox8]));
			w31.Position = 0;
			w31.Expand = false;
			w31.Fill = false;
			w1.Add (this.hbox25);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(w1 [this.hbox25]));
			w32.Position = 0;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.alignment41 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment41.Name = "alignment41";
			// Container child alignment41.Gtk.Container+ContainerChild
			this.fixed7 = new global::Gtk.Fixed ();
			this.fixed7.Name = "fixed7";
			this.fixed7.HasWindow = false;
			this.alignment41.Add (this.fixed7);
			w1.Add (this.alignment41);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(w1 [this.alignment41]));
			w34.Position = 1;
			w34.Expand = false;
			w34.Fill = false;
			// Internal child punto.gui.Pagar.ActionArea
			global::Gtk.HButtonBox w35 = this.ActionArea;
			w35.Name = "dialog1_ActionArea";
			w35.Spacing = 10;
			w35.BorderWidth = ((uint)(5));
			w35.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w36 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w35 [this.buttonCancel]));
			w36.Expand = false;
			w36.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w37 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w35 [this.buttonOk]));
			w37.Position = 1;
			w37.Expand = false;
			w37.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 347;
			this.Show ();
			this.entryPagoEfectivo.KeyPressEvent += new global::Gtk.KeyPressEventHandler (this.OnEntryPagoEfectivoKeyPressEvent);
			this.buttonPagoEfectivo.Clicked += new global::System.EventHandler (this.OnPagoEnEfectivo);
		}
	}
}
