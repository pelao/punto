
// This file has been generated by the GUI designer. Do not modify.
namespace punto.gui
{
	public partial class VenderProductosDialog
	{
		private global::Gtk.HBox hbox1;
		private global::Gtk.HPaned hpaned12;
		private global::Gtk.VBox vbox5;
		private global::Gtk.Alignment alignment1;
		private global::Gtk.Frame frame1;
		private global::Gtk.Alignment GtkAlignment1;
		private global::Gtk.HBox hbox4;
		private global::Gtk.Alignment alignment4;
		private global::Gtk.Image image2;
		private global::Gtk.Alignment alignment5;
		private global::Gtk.Frame frame3;
		private global::Gtk.Alignment GtkAlignment2;
		private global::Gtk.VBox vbox2;
		private global::Gtk.Entry entryCodigoBarra;
		private global::Gtk.Alignment alignment3;
		private global::Gtk.HPaned hpaned1;
		private global::Gtk.Frame frame5;
		private global::Gtk.Alignment GtkAlignment3;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TreeView treeviewListaProductos;
		private global::Gtk.Label GtkLabel2;
		private global::Gtk.HBox hbox5;
		private global::Gtk.Alignment alignment6;
		private global::Gtk.Alignment alignment7;
		private global::Gtk.Button ButtonVenta;
		private global::Gtk.VBox vbox3;
		private global::Gtk.Label labelNumBoleta;
		private global::Gtk.HBox hbox3;
		private global::Gtk.Entry entryNumBoleta;
		private global::Gtk.Button buttonEdit;
		private global::Gtk.VBox vbox4;
		private global::Gtk.Label label8;
		private global::Gtk.VPaned vpaned3;
		private global::Gtk.HBox hbox2;
		private global::Gtk.Label labelTotal;
		private global::Gtk.Label labelTotalVenta;
		private global::Gtk.Button button790;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget punto.gui.VenderProductosDialog
			this.Name = "punto.gui.VenderProductosDialog";
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			// Internal child punto.gui.VenderProductosDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.hpaned12 = new global::Gtk.HPaned ();
			this.hpaned12.CanFocus = true;
			this.hpaned12.Name = "hpaned12";
			this.hpaned12.Position = 8;
			// Container child hpaned12.Gtk.Paned+PanedChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.alignment1 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment1.Name = "alignment1";
			// Container child alignment1.Gtk.Container+ContainerChild
			this.frame1 = new global::Gtk.Frame ();
			this.frame1.Name = "frame1";
			this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame1.Gtk.Container+ContainerChild
			this.GtkAlignment1 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment1.Name = "GtkAlignment1";
			this.GtkAlignment1.LeftPadding = ((uint)(12));
			this.frame1.Add (this.GtkAlignment1);
			this.alignment1.Add (this.frame1);
			this.vbox5.Add (this.alignment1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.alignment1]));
			w4.Position = 0;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.alignment4 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment4.Name = "alignment4";
			this.hbox4.Add (this.alignment4);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.alignment4]));
			w5.Position = 0;
			// Container child hbox4.Gtk.Box+BoxChild
			this.image2 = new global::Gtk.Image ();
			this.image2.Name = "image2";
			this.image2.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-missing-image", global::Gtk.IconSize.Menu);
			this.hbox4.Add (this.image2);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.image2]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.alignment5 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment5.Name = "alignment5";
			this.hbox4.Add (this.alignment5);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.alignment5]));
			w7.Position = 2;
			this.vbox5.Add (this.hbox4);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.hbox4]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.frame3 = new global::Gtk.Frame ();
			this.frame3.Name = "frame3";
			this.frame3.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame3.Gtk.Container+ContainerChild
			this.GtkAlignment2 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment2.Name = "GtkAlignment2";
			this.GtkAlignment2.LeftPadding = ((uint)(12));
			this.frame3.Add (this.GtkAlignment2);
			this.vbox5.Add (this.frame3);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.frame3]));
			w10.Position = 2;
			this.hpaned12.Add (this.vbox5);
			this.hbox1.Add (this.hpaned12);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.hpaned12]));
			w12.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.entryCodigoBarra = new global::Gtk.Entry ();
			this.entryCodigoBarra.CanFocus = true;
			this.entryCodigoBarra.Name = "entryCodigoBarra";
			this.entryCodigoBarra.IsEditable = true;
			this.entryCodigoBarra.InvisibleChar = '●';
			this.vbox2.Add (this.entryCodigoBarra);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.entryCodigoBarra]));
			w13.Position = 0;
			w13.Expand = false;
			w13.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.alignment3 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment3.Name = "alignment3";
			// Container child alignment3.Gtk.Container+ContainerChild
			this.hpaned1 = new global::Gtk.HPaned ();
			this.hpaned1.CanFocus = true;
			this.hpaned1.Name = "hpaned1";
			this.hpaned1.Position = 10;
			// Container child hpaned1.Gtk.Paned+PanedChild
			this.frame5 = new global::Gtk.Frame ();
			this.frame5.Name = "frame5";
			this.frame5.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame5.Gtk.Container+ContainerChild
			this.GtkAlignment3 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment3.Name = "GtkAlignment3";
			this.GtkAlignment3.LeftPadding = ((uint)(12));
			// Container child GtkAlignment3.Gtk.Container+ContainerChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.treeviewListaProductos = new global::Gtk.TreeView ();
			this.treeviewListaProductos.HeightRequest = 0;
			this.treeviewListaProductos.ExtensionEvents = ((global::Gdk.ExtensionMode)(1));
			this.treeviewListaProductos.Name = "treeviewListaProductos";
			this.treeviewListaProductos.HeadersVisible = false;
			this.treeviewListaProductos.RulesHint = true;
			this.GtkScrolledWindow.Add (this.treeviewListaProductos);
			this.GtkAlignment3.Add (this.GtkScrolledWindow);
			this.frame5.Add (this.GtkAlignment3);
			this.GtkLabel2 = new global::Gtk.Label ();
			this.GtkLabel2.Name = "GtkLabel2";
			this.GtkLabel2.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Lista De Productos</b>");
			this.GtkLabel2.UseMarkup = true;
			this.frame5.LabelWidget = this.GtkLabel2;
			this.hpaned1.Add (this.frame5);
			this.alignment3.Add (this.hpaned1);
			this.vbox2.Add (this.alignment3);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.alignment3]));
			w19.Position = 1;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox ();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.alignment6 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment6.Name = "alignment6";
			this.hbox5.Add (this.alignment6);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.alignment6]));
			w20.Position = 0;
			// Container child hbox5.Gtk.Box+BoxChild
			this.alignment7 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment7.Name = "alignment7";
			this.hbox5.Add (this.alignment7);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.alignment7]));
			w21.Position = 1;
			// Container child hbox5.Gtk.Box+BoxChild
			this.ButtonVenta = new global::Gtk.Button ();
			this.ButtonVenta.CanFocus = true;
			this.ButtonVenta.Name = "ButtonVenta";
			this.ButtonVenta.UseUnderline = true;
			// Container child ButtonVenta.Gtk.Container+ContainerChild
			global::Gtk.Alignment w22 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w23 = new global::Gtk.HBox ();
			w23.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w24 = new global::Gtk.Image ();
			w24.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-index", global::Gtk.IconSize.Menu);
			w23.Add (w24);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w26 = new global::Gtk.Label ();
			w26.LabelProp = global::Mono.Unix.Catalog.GetString ("Venta");
			w26.UseUnderline = true;
			w23.Add (w26);
			w22.Add (w23);
			this.ButtonVenta.Add (w22);
			this.hbox5.Add (this.ButtonVenta);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.ButtonVenta]));
			w30.Position = 2;
			w30.Expand = false;
			w30.Fill = false;
			this.vbox2.Add (this.hbox5);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox5]));
			w31.Position = 2;
			w31.Expand = false;
			w31.Fill = false;
			this.hbox1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox2]));
			w32.Position = 1;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.labelNumBoleta = new global::Gtk.Label ();
			this.labelNumBoleta.Name = "labelNumBoleta";
			this.labelNumBoleta.LabelProp = global::Mono.Unix.Catalog.GetString ("Nº Boleta");
			this.vbox3.Add (this.labelNumBoleta);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.labelNumBoleta]));
			w33.Position = 0;
			w33.Expand = false;
			w33.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.entryNumBoleta = new global::Gtk.Entry ();
			this.entryNumBoleta.CanFocus = true;
			this.entryNumBoleta.Name = "entryNumBoleta";
			this.entryNumBoleta.IsEditable = false;
			this.entryNumBoleta.InvisibleChar = '●';
			this.hbox3.Add (this.entryNumBoleta);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.entryNumBoleta]));
			w34.Position = 0;
			// Container child hbox3.Gtk.Box+BoxChild
			this.buttonEdit = new global::Gtk.Button ();
			this.buttonEdit.CanFocus = true;
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.UseUnderline = true;
			// Container child buttonEdit.Gtk.Container+ContainerChild
			global::Gtk.Alignment w35 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w36 = new global::Gtk.HBox ();
			w36.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w37 = new global::Gtk.Image ();
			w37.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-edit", global::Gtk.IconSize.Menu);
			w36.Add (w37);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w39 = new global::Gtk.Label ();
			w39.LabelProp = global::Mono.Unix.Catalog.GetString ("Edit");
			w39.UseUnderline = true;
			w36.Add (w39);
			w35.Add (w36);
			this.buttonEdit.Add (w35);
			this.hbox3.Add (this.buttonEdit);
			global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.buttonEdit]));
			w43.Position = 1;
			w43.Expand = false;
			w43.Fill = false;
			this.vbox3.Add (this.hbox3);
			global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox3]));
			w44.Position = 1;
			w44.Expand = false;
			w44.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.label8 = new global::Gtk.Label ();
			this.label8.Name = "label8";
			this.vbox4.Add (this.label8);
			global::Gtk.Box.BoxChild w45 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.label8]));
			w45.Position = 0;
			w45.Expand = false;
			w45.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.vpaned3 = new global::Gtk.VPaned ();
			this.vpaned3.CanFocus = true;
			this.vpaned3.Name = "vpaned3";
			this.vpaned3.Position = 142;
			this.vbox4.Add (this.vpaned3);
			global::Gtk.Box.BoxChild w46 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.vpaned3]));
			w46.Position = 1;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.labelTotal = new global::Gtk.Label ();
			this.labelTotal.Name = "labelTotal";
			this.labelTotal.LabelProp = global::Mono.Unix.Catalog.GetString ("Total:");
			this.hbox2.Add (this.labelTotal);
			global::Gtk.Box.BoxChild w47 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.labelTotal]));
			w47.Position = 0;
			w47.Expand = false;
			w47.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.labelTotalVenta = new global::Gtk.Label ();
			this.labelTotalVenta.Name = "labelTotalVenta";
			this.labelTotalVenta.LabelProp = global::Mono.Unix.Catalog.GetString ("0");
			this.hbox2.Add (this.labelTotalVenta);
			global::Gtk.Box.BoxChild w48 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.labelTotalVenta]));
			w48.Position = 1;
			w48.Expand = false;
			w48.Fill = false;
			this.vbox4.Add (this.hbox2);
			global::Gtk.Box.BoxChild w49 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox2]));
			w49.Position = 2;
			w49.Expand = false;
			w49.Fill = false;
			this.vbox3.Add (this.vbox4);
			global::Gtk.Box.BoxChild w50 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.vbox4]));
			w50.Position = 2;
			this.hbox1.Add (this.vbox3);
			global::Gtk.Box.BoxChild w51 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox3]));
			w51.Position = 2;
			w51.Expand = false;
			w51.Fill = false;
			w1.Add (this.hbox1);
			global::Gtk.Box.BoxChild w52 = ((global::Gtk.Box.BoxChild)(w1 [this.hbox1]));
			w52.Position = 0;
			// Internal child punto.gui.VenderProductosDialog.ActionArea
			global::Gtk.HButtonBox w53 = this.ActionArea;
			w53.Name = "__gtksharp_56_Stetic_TopLevelDialog_ActionArea";
			// Container child __gtksharp_56_Stetic_TopLevelDialog_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.button790 = new global::Gtk.Button ();
			this.button790.CanFocus = true;
			this.button790.Name = "button790";
			this.button790.UseUnderline = true;
			this.button790.Label = global::Mono.Unix.Catalog.GetString ("GtkButton");
			this.AddActionWidget (this.button790, 0);
			global::Gtk.ButtonBox.ButtonBoxChild w54 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w53 [this.button790]));
			w54.Expand = false;
			w54.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 709;
			this.DefaultHeight = 432;
			w53.Hide ();
			this.Hide ();
			this.entryCodigoBarra.KeyPressEvent += new global::Gtk.KeyPressEventHandler (this.OnEntryCodigoBarraKeyPressEvent);
			this.entryCodigoBarra.TextInserted += new global::Gtk.TextInsertedHandler (this.OnEntryCodigoBarraTextInserted);
			this.treeviewListaProductos.KeyPressEvent += new global::Gtk.KeyPressEventHandler (this.OnTreeviewListaProductosKeyPressEvent);
			this.ButtonVenta.Clicked += new global::System.EventHandler (this.OnButtonVentaClicked);
			this.entryNumBoleta.TextInserted += new global::Gtk.TextInsertedHandler (this.OnEntry2TextInserted);
			this.buttonEdit.Clicked += new global::System.EventHandler (this.OnButton85Clicked);
		}
	}
}
