
// This file has been generated by the GUI designer. Do not modify.
namespace punto.gui
{
	public partial class PagarDialog
	{
		private global::Gtk.HBox hbox25;
		private global::Gtk.VBox vbox8;
		private global::Gtk.HBox hbox3;
		private global::Gtk.Label label11;
		private global::Gtk.VBox vbox9;
		private global::Gtk.HBox hbox4;
		private global::Gtk.Label labelTotal;
		private global::Gtk.Label labeltotalcompra;
		private global::Gtk.Alignment alignment7;
		private global::Gtk.HBox hbox5;
		private global::Gtk.Label labelEfectivo;
		private global::Gtk.Entry entryPagoEfectivo;
		private global::Gtk.Alignment alignment8;
		private global::Gtk.HBox hbox6;
		private global::Gtk.Label labelVuelto;
		private global::Gtk.Label labelvueltopago;
		private global::Gtk.Alignment alignment9;
		private global::Gtk.Table table1;
		private global::Gtk.Alignment alignment1;
		private global::Gtk.Alignment alignment2;
		private global::Gtk.Button buttonPagar;
		private global::Gtk.Alignment alignment3;
		private global::Gtk.Frame frame2;
		private global::Gtk.Alignment GtkAlignment2;
		private global::Gtk.HBox hbox2;
		private global::Gtk.VBox vbox3;
		private global::Gtk.HPaned hpaned1;
		private global::Gtk.Button buttonPagoEfectivo;
		private global::Gtk.VBox vbox4;
		private global::Gtk.HPaned hpaned2;
		private global::Gtk.Button buttonPagoTarjeta;
		private global::Gtk.VBox vbox5;
		private global::Gtk.HPaned hpaned3;
		private global::Gtk.Button buttonPagoCheque;
		private global::Gtk.Label GtkLabel5;
		private global::Gtk.Alignment alignment41;
		private global::Gtk.Fixed fixed7;
		private global::Gtk.Button buttonOk;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget punto.gui.PagarDialog
			this.Name = "punto.gui.PagarDialog";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child punto.gui.PagarDialog.VBox
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
			this.label11 = new global::Gtk.Label ();
			this.label11.Name = "label11";
			this.hbox3.Add (this.label11);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.label11]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.vbox9 = new global::Gtk.VBox ();
			this.vbox9.Name = "vbox9";
			this.vbox9.Spacing = 6;
			// Container child vbox9.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.labelTotal = new global::Gtk.Label ();
			this.labelTotal.Name = "labelTotal";
			this.labelTotal.Xalign = 0F;
			this.labelTotal.LabelProp = global::Mono.Unix.Catalog.GetString ("Total:");
			this.labelTotal.Justify = ((global::Gtk.Justification)(2));
			this.labelTotal.Ellipsize = ((global::Pango.EllipsizeMode)(2));
			this.hbox4.Add (this.labelTotal);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.labelTotal]));
			w3.Position = 0;
			// Container child hbox4.Gtk.Box+BoxChild
			this.labeltotalcompra = new global::Gtk.Label ();
			this.labeltotalcompra.Name = "labeltotalcompra";
			this.hbox4.Add (this.labeltotalcompra);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.labeltotalcompra]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.alignment7 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment7.Name = "alignment7";
			this.hbox4.Add (this.alignment7);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.alignment7]));
			w5.Position = 2;
			this.vbox9.Add (this.hbox4);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.hbox4]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox9.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox ();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.labelEfectivo = new global::Gtk.Label ();
			this.labelEfectivo.Name = "labelEfectivo";
			this.labelEfectivo.Xalign = 0F;
			this.labelEfectivo.LabelProp = global::Mono.Unix.Catalog.GetString ("Efectivo:");
			this.hbox5.Add (this.labelEfectivo);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.labelEfectivo]));
			w7.Position = 0;
			// Container child hbox5.Gtk.Box+BoxChild
			this.entryPagoEfectivo = new global::Gtk.Entry ();
			this.entryPagoEfectivo.WidthRequest = 20;
			this.entryPagoEfectivo.CanFocus = true;
			this.entryPagoEfectivo.Name = "entryPagoEfectivo";
			this.entryPagoEfectivo.IsEditable = true;
			this.entryPagoEfectivo.InvisibleChar = '●';
			this.hbox5.Add (this.entryPagoEfectivo);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.entryPagoEfectivo]));
			w8.Position = 1;
			// Container child hbox5.Gtk.Box+BoxChild
			this.alignment8 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment8.Name = "alignment8";
			this.hbox5.Add (this.alignment8);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.alignment8]));
			w9.Position = 2;
			this.vbox9.Add (this.hbox5);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.hbox5]));
			w10.Position = 1;
			w10.Expand = false;
			w10.Fill = false;
			// Container child vbox9.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox ();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.labelVuelto = new global::Gtk.Label ();
			this.labelVuelto.Name = "labelVuelto";
			this.labelVuelto.Xalign = 0F;
			this.labelVuelto.LabelProp = global::Mono.Unix.Catalog.GetString ("Vuelto:");
			this.hbox6.Add (this.labelVuelto);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.labelVuelto]));
			w11.Position = 0;
			// Container child hbox6.Gtk.Box+BoxChild
			this.labelvueltopago = new global::Gtk.Label ();
			this.labelvueltopago.Name = "labelvueltopago";
			this.hbox6.Add (this.labelvueltopago);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.labelvueltopago]));
			w12.Position = 1;
			w12.Expand = false;
			w12.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.alignment9 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment9.Name = "alignment9";
			this.hbox6.Add (this.alignment9);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.alignment9]));
			w13.Position = 2;
			this.vbox9.Add (this.hbox6);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.hbox6]));
			w14.Position = 2;
			w14.Expand = false;
			w14.Fill = false;
			// Container child vbox9.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table (((uint)(1)), ((uint)(3)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.alignment1 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment1.Name = "alignment1";
			this.table1.Add (this.alignment1);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table1 [this.alignment1]));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.alignment2 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment2.Name = "alignment2";
			this.table1.Add (this.alignment2);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table1 [this.alignment2]));
			w16.LeftAttach = ((uint)(2));
			w16.RightAttach = ((uint)(3));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.buttonPagar = new global::Gtk.Button ();
			this.buttonPagar.CanFocus = true;
			this.buttonPagar.Name = "buttonPagar";
			this.buttonPagar.UseUnderline = true;
			this.buttonPagar.Label = global::Mono.Unix.Catalog.GetString ("Guardar Venta");
			this.table1.Add (this.buttonPagar);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table1 [this.buttonPagar]));
			w17.LeftAttach = ((uint)(1));
			w17.RightAttach = ((uint)(2));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox9.Add (this.table1);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.table1]));
			w18.Position = 3;
			w18.Expand = false;
			w18.Fill = false;
			this.hbox3.Add (this.vbox9);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.vbox9]));
			w19.Position = 1;
			this.vbox8.Add (this.hbox3);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.hbox3]));
			w20.Position = 0;
			w20.Expand = false;
			w20.Fill = false;
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
			this.hpaned1.Position = 1;
			// Container child hpaned1.Gtk.Paned+PanedChild
			this.buttonPagoEfectivo = new global::Gtk.Button ();
			this.buttonPagoEfectivo.CanFocus = true;
			this.buttonPagoEfectivo.Name = "buttonPagoEfectivo";
			this.buttonPagoEfectivo.UseUnderline = true;
			this.buttonPagoEfectivo.BorderWidth = ((uint)(3));
			this.buttonPagoEfectivo.Label = global::Mono.Unix.Catalog.GetString ("Pago Efectivo \n   (teclear F2)");
			this.hpaned1.Add (this.buttonPagoEfectivo);
			this.vbox3.Add (this.hpaned1);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hpaned1]));
			w22.Position = 1;
			this.hbox2.Add (this.vbox3);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.vbox3]));
			w23.Position = 0;
			// Container child hbox2.Gtk.Box+BoxChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hpaned2 = new global::Gtk.HPaned ();
			this.hpaned2.CanFocus = true;
			this.hpaned2.Name = "hpaned2";
			this.hpaned2.Position = 1;
			// Container child hpaned2.Gtk.Paned+PanedChild
			this.buttonPagoTarjeta = new global::Gtk.Button ();
			this.buttonPagoTarjeta.CanFocus = true;
			this.buttonPagoTarjeta.Name = "buttonPagoTarjeta";
			this.buttonPagoTarjeta.UseUnderline = true;
			this.buttonPagoTarjeta.Label = global::Mono.Unix.Catalog.GetString ("Pago Tarjeta\n  (teclear F3)");
			this.hpaned2.Add (this.buttonPagoTarjeta);
			this.vbox4.Add (this.hpaned2);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hpaned2]));
			w25.Position = 1;
			this.hbox2.Add (this.vbox4);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.vbox4]));
			w26.Position = 1;
			// Container child hbox2.Gtk.Box+BoxChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hpaned3 = new global::Gtk.HPaned ();
			this.hpaned3.CanFocus = true;
			this.hpaned3.Name = "hpaned3";
			this.hpaned3.Position = 1;
			// Container child hpaned3.Gtk.Paned+PanedChild
			this.buttonPagoCheque = new global::Gtk.Button ();
			this.buttonPagoCheque.CanFocus = true;
			this.buttonPagoCheque.Name = "buttonPagoCheque";
			this.buttonPagoCheque.UseUnderline = true;
			this.buttonPagoCheque.Label = global::Mono.Unix.Catalog.GetString ("Pago Cheque\n  (teclear F4)");
			this.hpaned3.Add (this.buttonPagoCheque);
			this.vbox5.Add (this.hpaned3);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.hpaned3]));
			w28.Position = 1;
			this.hbox2.Add (this.vbox5);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.vbox5]));
			w29.Position = 2;
			this.GtkAlignment2.Add (this.hbox2);
			this.frame2.Add (this.GtkAlignment2);
			this.GtkLabel5 = new global::Gtk.Label ();
			this.GtkLabel5.Name = "GtkLabel5";
			this.GtkLabel5.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Forma De Pago</b>");
			this.GtkLabel5.UseMarkup = true;
			this.frame2.LabelWidget = this.GtkLabel5;
			this.alignment3.Add (this.frame2);
			this.vbox8.Add (this.alignment3);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.alignment3]));
			w33.Position = 1;
			this.hbox25.Add (this.vbox8);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.hbox25 [this.vbox8]));
			w34.Position = 0;
			w34.Expand = false;
			w34.Fill = false;
			w1.Add (this.hbox25);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(w1 [this.hbox25]));
			w35.Position = 0;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.alignment41 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment41.Name = "alignment41";
			// Container child alignment41.Gtk.Container+ContainerChild
			this.fixed7 = new global::Gtk.Fixed ();
			this.fixed7.Name = "fixed7";
			this.fixed7.HasWindow = false;
			this.alignment41.Add (this.fixed7);
			w1.Add (this.alignment41);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(w1 [this.alignment41]));
			w37.Position = 1;
			w37.Expand = false;
			w37.Fill = false;
			// Internal child punto.gui.PagarDialog.ActionArea
			global::Gtk.HButtonBox w38 = this.ActionArea;
			w38.Name = "dialog1_ActionArea";
			w38.Spacing = 10;
			w38.BorderWidth = ((uint)(5));
			w38.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w39 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w38 [this.buttonOk]));
			w39.Expand = false;
			w39.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 347;
			this.Show ();
			this.KeyPressEvent += new global::Gtk.KeyPressEventHandler (this.OnKeyPressEvent);
			this.entryPagoEfectivo.KeyPressEvent += new global::Gtk.KeyPressEventHandler (this.OnEntryPagoEfectivoKeyPressEvent);
			this.buttonPagar.Clicked += new global::System.EventHandler (this.OnButtonPagarClicked);
			this.buttonPagoEfectivo.Clicked += new global::System.EventHandler (this.OnPagoEnEfectivo);
			this.buttonPagoTarjeta.Clicked += new global::System.EventHandler (this.OnButtonPagoTarjetaClicked);
			this.buttonPagoCheque.Clicked += new global::System.EventHandler (this.OnButtonPagoChequeClicked);
		}
	}
}
