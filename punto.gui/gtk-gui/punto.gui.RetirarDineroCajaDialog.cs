
// This file has been generated by the GUI designer. Do not modify.
namespace punto.gui
{
	public partial class RetirarDineroCajaDialog
	{
		private global::Gtk.Alignment alignment1;
		private global::Gtk.Frame frame1;
		private global::Gtk.Alignment GtkAlignment2;
		private global::Gtk.VBox vbox2;
		private global::Gtk.Alignment alignment2;
		private global::Gtk.Alignment alignment3;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Alignment alignment4;
		private global::Gtk.Label labelMontoDinero;
		private global::Gtk.Entry entryRetirarDinero;
		private global::Gtk.Button buttonRetirarDinero;
		private global::Gtk.Alignment alignment5;
		private global::Gtk.Alignment alignment6;
		private global::Gtk.Alignment alignment7;
		private global::Gtk.Label GtkLabel2;
		private global::Gtk.Alignment alignment8;
		private global::Gtk.Button buttonCancel;
		private global::Gtk.Button buttonOk;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget punto.gui.RetirarDineroCajaDialog
			this.Name = "punto.gui.RetirarDineroCajaDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Salida Dinero Caja");
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			// Internal child punto.gui.RetirarDineroCajaDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.alignment1 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment1.Name = "alignment1";
			w1.Add (this.alignment1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(w1 [this.alignment1]));
			w2.Position = 0;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
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
			this.alignment2 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment2.Name = "alignment2";
			this.vbox2.Add (this.alignment2);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.alignment2]));
			w3.Position = 0;
			// Container child vbox2.Gtk.Box+BoxChild
			this.alignment3 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment3.Name = "alignment3";
			this.vbox2.Add (this.alignment3);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.alignment3]));
			w4.Position = 1;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.alignment4 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment4.Name = "alignment4";
			this.hbox1.Add (this.alignment4);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.alignment4]));
			w5.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.labelMontoDinero = new global::Gtk.Label ();
			this.labelMontoDinero.Name = "labelMontoDinero";
			this.labelMontoDinero.LabelProp = global::Mono.Unix.Catalog.GetString ("Monto a Retirar: $");
			this.hbox1.Add (this.labelMontoDinero);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.labelMontoDinero]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.entryRetirarDinero = new global::Gtk.Entry ();
			this.entryRetirarDinero.CanFocus = true;
			this.entryRetirarDinero.Name = "entryRetirarDinero";
			this.entryRetirarDinero.IsEditable = true;
			this.entryRetirarDinero.InvisibleChar = '●';
			this.hbox1.Add (this.entryRetirarDinero);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.entryRetirarDinero]));
			w7.Position = 2;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonRetirarDinero = new global::Gtk.Button ();
			this.buttonRetirarDinero.CanFocus = true;
			this.buttonRetirarDinero.Name = "buttonRetirarDinero";
			this.buttonRetirarDinero.UseUnderline = true;
			this.buttonRetirarDinero.Label = global::Mono.Unix.Catalog.GetString ("Retirar Dinero");
			this.hbox1.Add (this.buttonRetirarDinero);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonRetirarDinero]));
			w8.Position = 3;
			w8.Expand = false;
			w8.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.alignment5 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment5.Name = "alignment5";
			this.hbox1.Add (this.alignment5);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.alignment5]));
			w9.Position = 4;
			this.vbox2.Add (this.hbox1);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox1]));
			w10.Position = 2;
			w10.Expand = false;
			w10.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.alignment6 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment6.Name = "alignment6";
			this.vbox2.Add (this.alignment6);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.alignment6]));
			w11.Position = 3;
			// Container child vbox2.Gtk.Box+BoxChild
			this.alignment7 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment7.Name = "alignment7";
			this.vbox2.Add (this.alignment7);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.alignment7]));
			w12.Position = 4;
			this.GtkAlignment2.Add (this.vbox2);
			this.frame1.Add (this.GtkAlignment2);
			this.GtkLabel2 = new global::Gtk.Label ();
			this.GtkLabel2.Name = "GtkLabel2";
			this.GtkLabel2.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Ingrese monto a retirar de la caja</b>");
			this.GtkLabel2.UseMarkup = true;
			this.frame1.LabelWidget = this.GtkLabel2;
			w1.Add (this.frame1);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(w1 [this.frame1]));
			w15.Position = 1;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.alignment8 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment8.Name = "alignment8";
			w1.Add (this.alignment8);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(w1 [this.alignment8]));
			w16.Position = 2;
			// Internal child punto.gui.RetirarDineroCajaDialog.ActionArea
			global::Gtk.HButtonBox w17 = this.ActionArea;
			w17.Name = "dialog1_ActionArea";
			w17.Spacing = 10;
			w17.BorderWidth = ((uint)(5));
			w17.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w18 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w17 [this.buttonCancel]));
			w18.Expand = false;
			w18.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w19 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w17 [this.buttonOk]));
			w19.Position = 1;
			w19.Expand = false;
			w19.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 424;
			this.DefaultHeight = 300;
			this.Show ();
			this.buttonRetirarDinero.Clicked += new global::System.EventHandler (this.OnButtonRetirarDineroClicked);
		}
	}
}
