
// This file has been generated by the GUI designer. Do not modify.
namespace punto.gui
{
	public partial class VenderProductosDialog
	{
		private global::Gtk.UIManager UIManager;
		private global::Gtk.Action Action;
		private global::Gtk.Action SesionAction;
		private global::Gtk.Action CerrarAction;
		private global::Gtk.Action ProductosAction;
		private global::Gtk.Action RegistrarEditarAction;
		private global::Gtk.Action FamiliaProductosAction;
		private global::Gtk.Action UsuarioAction;
		private global::Gtk.Action RegistrarEditarAction1;
		private global::Gtk.VBox dialog1_VBox1;
		private global::Gtk.MenuBar menubar1;
		private global::Gtk.HBox hbox1;
		private global::Gtk.HBox hbox2;
		private global::Gtk.HPaned hpaned3;
		private global::Gtk.Frame frame1;
		private global::Gtk.Alignment GtkAlignment2;
		private global::Gtk.Label GtkLabel4;
		private global::Gtk.VBox vbox5;
		private global::Gtk.HBox hbox4;
		private global::Gtk.Label labelNumProducto;
		private global::Gtk.Entry entryCodigoBarra;
		private global::Gtk.Label label18;
		private global::Gtk.Button buttonEdit1;
		private global::Gtk.Entry entryNumBoleta;
		private global::Gtk.Label labelNumBoleta1;
		private global::Gtk.Frame frame6;
		private global::Gtk.Alignment GtkAlignment4;
		private global::Gtk.ScrolledWindow GtkScrolledWindow1;
		private global::Gtk.TreeView treeviewListaProductos;
		private global::Gtk.Label GtkLabel6;
		private global::Gtk.HBox hbox6;
		private global::Gtk.Label labelTotal1;
		private global::Gtk.Label labelTotalVenta;
		private global::Gtk.HBox hbox7;
		private global::Gtk.Alignment alignment4;
		private global::Gtk.Button ButtonVenta;
		private global::Gtk.Alignment alignment5;
		private global::Gtk.Button button790;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget punto.gui.VenderProductosDialog
			this.UIManager = new global::Gtk.UIManager ();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
			this.Action = new global::Gtk.Action ("Action", null, null, null);
			w1.Add (this.Action, null);
			this.SesionAction = new global::Gtk.Action ("SesionAction", global::Mono.Unix.Catalog.GetString ("Sesion"), null, null);
			this.SesionAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Sesion");
			w1.Add (this.SesionAction, null);
			this.CerrarAction = new global::Gtk.Action ("CerrarAction", global::Mono.Unix.Catalog.GetString ("Cerrar"), null, null);
			this.CerrarAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Cerrar");
			w1.Add (this.CerrarAction, null);
			this.ProductosAction = new global::Gtk.Action ("ProductosAction", global::Mono.Unix.Catalog.GetString ("Productos"), null, null);
			this.ProductosAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Productos");
			w1.Add (this.ProductosAction, null);
			this.RegistrarEditarAction = new global::Gtk.Action ("RegistrarEditarAction", global::Mono.Unix.Catalog.GetString ("Registrar/Editar"), null, null);
			this.RegistrarEditarAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Registrar/Editar");
			w1.Add (this.RegistrarEditarAction, null);
			this.FamiliaProductosAction = new global::Gtk.Action ("FamiliaProductosAction", global::Mono.Unix.Catalog.GetString ("Familia Productos"), null, null);
			this.FamiliaProductosAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Familia Productos");
			w1.Add (this.FamiliaProductosAction, null);
			this.UsuarioAction = new global::Gtk.Action ("UsuarioAction", global::Mono.Unix.Catalog.GetString ("Usuario"), null, null);
			this.UsuarioAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Usuario");
			w1.Add (this.UsuarioAction, null);
			this.RegistrarEditarAction1 = new global::Gtk.Action ("RegistrarEditarAction1", global::Mono.Unix.Catalog.GetString ("Registrar/Editar"), null, null);
			this.RegistrarEditarAction1.ShortLabel = global::Mono.Unix.Catalog.GetString ("Registrar/Editar");
			w1.Add (this.RegistrarEditarAction1, null);
			this.UIManager.InsertActionGroup (w1, 0);
			this.AddAccelGroup (this.UIManager.AccelGroup);
			this.Name = "punto.gui.VenderProductosDialog";
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			// Internal child punto.gui.VenderProductosDialog.VBox
			global::Gtk.VBox w2 = this.VBox;
			w2.Name = "dialog1_VBox";
			w2.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.dialog1_VBox1 = new global::Gtk.VBox ();
			this.dialog1_VBox1.Name = "dialog1_VBox1";
			this.dialog1_VBox1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox1.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString (@"<ui><menubar name='menubar1'><menu name='SesionAction' action='SesionAction'><menuitem name='CerrarAction' action='CerrarAction'/></menu><menu name='ProductosAction' action='ProductosAction'><menuitem name='RegistrarEditarAction' action='RegistrarEditarAction'/><menuitem name='FamiliaProductosAction' action='FamiliaProductosAction'/></menu><menu name='UsuarioAction' action='UsuarioAction'><menuitem name='RegistrarEditarAction1' action='RegistrarEditarAction1'/></menu></menubar></ui>");
			this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar1")));
			this.menubar1.Name = "menubar1";
			this.dialog1_VBox1.Add (this.menubar1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.dialog1_VBox1 [this.menubar1]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child dialog1_VBox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.hpaned3 = new global::Gtk.HPaned ();
			this.hpaned3.CanFocus = true;
			this.hpaned3.Name = "hpaned3";
			this.hpaned3.Position = 318;
			// Container child hpaned3.Gtk.Paned+PanedChild
			this.frame1 = new global::Gtk.Frame ();
			this.frame1.Name = "frame1";
			this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame1.Gtk.Container+ContainerChild
			this.GtkAlignment2 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment2.Name = "GtkAlignment2";
			this.GtkAlignment2.LeftPadding = ((uint)(12));
			this.frame1.Add (this.GtkAlignment2);
			this.GtkLabel4 = new global::Gtk.Label ();
			this.GtkLabel4.Name = "GtkLabel4";
			this.GtkLabel4.UseMarkup = true;
			this.frame1.LabelWidget = this.GtkLabel4;
			this.hpaned3.Add (this.frame1);
			global::Gtk.Paned.PanedChild w5 = ((global::Gtk.Paned.PanedChild)(this.hpaned3 [this.frame1]));
			w5.Resize = false;
			// Container child hpaned3.Gtk.Paned+PanedChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.labelNumProducto = new global::Gtk.Label ();
			this.labelNumProducto.Name = "labelNumProducto";
			this.labelNumProducto.LabelProp = global::Mono.Unix.Catalog.GetString ("N° Producto:");
			this.hbox4.Add (this.labelNumProducto);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.labelNumProducto]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.entryCodigoBarra = new global::Gtk.Entry ();
			this.entryCodigoBarra.CanFocus = true;
			this.entryCodigoBarra.Events = ((global::Gdk.EventMask)(1024));
			this.entryCodigoBarra.Name = "entryCodigoBarra";
			this.entryCodigoBarra.IsEditable = true;
			this.entryCodigoBarra.InvisibleChar = '●';
			this.hbox4.Add (this.entryCodigoBarra);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.entryCodigoBarra]));
			w7.Position = 1;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label18 = new global::Gtk.Label ();
			this.label18.Name = "label18";
			this.label18.LabelProp = global::Mono.Unix.Catalog.GetString ("                                  ");
			this.hbox4.Add (this.label18);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.label18]));
			w8.Position = 2;
			w8.Expand = false;
			w8.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.buttonEdit1 = new global::Gtk.Button ();
			this.buttonEdit1.CanFocus = true;
			this.buttonEdit1.Name = "buttonEdit1";
			this.buttonEdit1.UseUnderline = true;
			// Container child buttonEdit1.Gtk.Container+ContainerChild
			global::Gtk.Alignment w9 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w10 = new global::Gtk.HBox ();
			w10.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w11 = new global::Gtk.Image ();
			w11.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-edit", global::Gtk.IconSize.Menu);
			w10.Add (w11);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w13 = new global::Gtk.Label ();
			w13.LabelProp = global::Mono.Unix.Catalog.GetString ("Edit");
			w13.UseUnderline = true;
			w10.Add (w13);
			w9.Add (w10);
			this.buttonEdit1.Add (w9);
			this.hbox4.Add (this.buttonEdit1);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.buttonEdit1]));
			w17.PackType = ((global::Gtk.PackType)(1));
			w17.Position = 3;
			w17.Expand = false;
			w17.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.entryNumBoleta = new global::Gtk.Entry ();
			this.entryNumBoleta.CanFocus = true;
			this.entryNumBoleta.Name = "entryNumBoleta";
			this.entryNumBoleta.IsEditable = false;
			this.entryNumBoleta.InvisibleChar = '●';
			this.hbox4.Add (this.entryNumBoleta);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.entryNumBoleta]));
			w18.PackType = ((global::Gtk.PackType)(1));
			w18.Position = 4;
			// Container child hbox4.Gtk.Box+BoxChild
			this.labelNumBoleta1 = new global::Gtk.Label ();
			this.labelNumBoleta1.Name = "labelNumBoleta1";
			this.labelNumBoleta1.Xalign = 1F;
			this.labelNumBoleta1.LabelProp = global::Mono.Unix.Catalog.GetString ("N° Boleta:");
			this.hbox4.Add (this.labelNumBoleta1);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.labelNumBoleta1]));
			w19.PackType = ((global::Gtk.PackType)(1));
			w19.Position = 5;
			w19.Expand = false;
			w19.Fill = false;
			this.vbox5.Add (this.hbox4);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.hbox4]));
			w20.Position = 0;
			w20.Expand = false;
			w20.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.frame6 = new global::Gtk.Frame ();
			this.frame6.Name = "frame6";
			this.frame6.ShadowType = ((global::Gtk.ShadowType)(1));
			this.frame6.BorderWidth = ((uint)(5));
			// Container child frame6.Gtk.Container+ContainerChild
			this.GtkAlignment4 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment4.Name = "GtkAlignment4";
			this.GtkAlignment4.LeftPadding = ((uint)(12));
			// Container child GtkAlignment4.Gtk.Container+ContainerChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.treeviewListaProductos = new global::Gtk.TreeView ();
			this.treeviewListaProductos.HeightRequest = 0;
			this.treeviewListaProductos.ExtensionEvents = ((global::Gdk.ExtensionMode)(1));
			this.treeviewListaProductos.Name = "treeviewListaProductos";
			this.treeviewListaProductos.HeadersVisible = false;
			this.treeviewListaProductos.RulesHint = true;
			this.GtkScrolledWindow1.Add (this.treeviewListaProductos);
			this.GtkAlignment4.Add (this.GtkScrolledWindow1);
			this.frame6.Add (this.GtkAlignment4);
			this.GtkLabel6 = new global::Gtk.Label ();
			this.GtkLabel6.Name = "GtkLabel6";
			this.GtkLabel6.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Lista De Productos</b>");
			this.GtkLabel6.UseMarkup = true;
			this.frame6.LabelWidget = this.GtkLabel6;
			this.vbox5.Add (this.frame6);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.frame6]));
			w24.Position = 1;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox ();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.labelTotal1 = new global::Gtk.Label ();
			this.labelTotal1.Name = "labelTotal1";
			this.labelTotal1.LabelProp = global::Mono.Unix.Catalog.GetString ("Total:");
			this.hbox6.Add (this.labelTotal1);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.labelTotal1]));
			w25.Position = 0;
			w25.Expand = false;
			w25.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.labelTotalVenta = new global::Gtk.Label ();
			this.labelTotalVenta.Name = "labelTotalVenta";
			this.labelTotalVenta.LabelProp = global::Mono.Unix.Catalog.GetString ("0");
			this.hbox6.Add (this.labelTotalVenta);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.labelTotalVenta]));
			w26.Position = 1;
			w26.Expand = false;
			w26.Fill = false;
			this.vbox5.Add (this.hbox6);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.hbox6]));
			w27.Position = 2;
			w27.Expand = false;
			w27.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbox7 = new global::Gtk.HBox ();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.alignment4 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment4.Name = "alignment4";
			this.hbox7.Add (this.alignment4);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.alignment4]));
			w28.Position = 0;
			// Container child hbox7.Gtk.Box+BoxChild
			this.ButtonVenta = new global::Gtk.Button ();
			this.ButtonVenta.CanFocus = true;
			this.ButtonVenta.Name = "ButtonVenta";
			this.ButtonVenta.UseUnderline = true;
			// Container child ButtonVenta.Gtk.Container+ContainerChild
			global::Gtk.Alignment w29 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w30 = new global::Gtk.HBox ();
			w30.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w31 = new global::Gtk.Image ();
			w31.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-index", global::Gtk.IconSize.Menu);
			w30.Add (w31);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w33 = new global::Gtk.Label ();
			w33.LabelProp = global::Mono.Unix.Catalog.GetString ("Venta");
			w33.UseUnderline = true;
			w30.Add (w33);
			w29.Add (w30);
			this.ButtonVenta.Add (w29);
			this.hbox7.Add (this.ButtonVenta);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.ButtonVenta]));
			w37.Position = 1;
			w37.Expand = false;
			w37.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.alignment5 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment5.Name = "alignment5";
			this.hbox7.Add (this.alignment5);
			global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.alignment5]));
			w38.Position = 2;
			this.vbox5.Add (this.hbox7);
			global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.hbox7]));
			w39.Position = 3;
			w39.Expand = false;
			w39.Fill = false;
			this.hpaned3.Add (this.vbox5);
			this.hbox2.Add (this.hpaned3);
			global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.hpaned3]));
			w41.Position = 0;
			this.hbox1.Add (this.hbox2);
			global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.hbox2]));
			w42.Position = 0;
			this.dialog1_VBox1.Add (this.hbox1);
			global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.dialog1_VBox1 [this.hbox1]));
			w43.Position = 1;
			w2.Add (this.dialog1_VBox1);
			global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(w2 [this.dialog1_VBox1]));
			w44.Position = 0;
			// Internal child punto.gui.VenderProductosDialog.ActionArea
			global::Gtk.HButtonBox w45 = this.ActionArea;
			w45.Name = "__gtksharp_56_Stetic_TopLevelDialog_ActionArea";
			// Container child __gtksharp_56_Stetic_TopLevelDialog_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.button790 = new global::Gtk.Button ();
			this.button790.CanFocus = true;
			this.button790.Name = "button790";
			this.button790.UseUnderline = true;
			this.button790.Label = global::Mono.Unix.Catalog.GetString ("GtkButton");
			this.AddActionWidget (this.button790, 0);
			global::Gtk.ButtonBox.ButtonBoxChild w46 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w45 [this.button790]));
			w46.Expand = false;
			w46.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 1084;
			this.DefaultHeight = 488;
			w45.Hide ();
			this.Hide ();
			this.CerrarAction.Activated += new global::System.EventHandler (this.OnCerrarActionActivated);
			this.RegistrarEditarAction.Activated += new global::System.EventHandler (this.OnIngresarEditarProductosActionActivated);
			this.FamiliaProductosAction.Activated += new global::System.EventHandler (this.OnFamiliaProductosActionActivated);
			this.RegistrarEditarAction1.Activated += new global::System.EventHandler (this.OnRegistrarEditarUsuarioActionActivated);
			this.entryCodigoBarra.KeyPressEvent += new global::Gtk.KeyPressEventHandler (this.OnEntryCodigoBarraKeyPressEvent);
			this.entryNumBoleta.TextInserted += new global::Gtk.TextInsertedHandler (this.OnEntry2TextInserted);
			this.buttonEdit1.Clicked += new global::System.EventHandler (this.OnButton85Clicked);
			this.ButtonVenta.Clicked += new global::System.EventHandler (this.OnButtonVentaClicked);
		}
	}
}
