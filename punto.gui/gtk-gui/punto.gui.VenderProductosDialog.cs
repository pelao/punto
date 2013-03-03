
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
		private global::Gtk.Action OpcionesAction;
		private global::Gtk.Action GenerarReportesAction;
		private global::Gtk.Action EditarNmeroBoletaAction;
		private global::Gtk.Action AyudaAction;
		private global::Gtk.Action AcercaDeAction;
		private global::Gtk.Action IngresoDineroCajaAction;
		private global::Gtk.Action SalidaDineroCajaAction;
		private global::Gtk.VBox dialog1_VBox1;
		private global::Gtk.HBox hbox3;
		private global::Gtk.MenuBar menubar1;
		private global::Gtk.Alignment alignment18;
		private global::Gtk.Label label7;
		private global::Gtk.Label labelHora;
		private global::Gtk.Label labelNombreCajero1;
		private global::Gtk.Label labelNombreCajero;
		private global::Gtk.Label labelCajero;
		private global::Gtk.HBox hbox1;
		private global::Gtk.HBox hbox2;
		private global::Gtk.HPaned hpaned3;
		private global::Gtk.Frame frame1;
		private global::Gtk.Alignment GtkAlignment2;
		private global::Gtk.VBox vbox2;
		private global::Gtk.Alignment alignment1;
		private global::Gtk.Image imageLogo;
		private global::Gtk.HSeparator hseparator1;
		private global::Gtk.Label labelFecha;
		private global::Gtk.Label GtkLabel4;
		private global::Gtk.VBox vbox5;
		private global::Gtk.HBox hbox4;
		private global::Gtk.Label labelNumProducto;
		private global::Gtk.Entry entryCodigoBarra;
		private global::Gtk.Label label18;
		private global::Gtk.Label label19;
		private global::Gtk.Label label20;
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
			this.OpcionesAction = new global::Gtk.Action ("OpcionesAction", global::Mono.Unix.Catalog.GetString ("Opciones"), null, null);
			this.OpcionesAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Opciones");
			w1.Add (this.OpcionesAction, null);
			this.GenerarReportesAction = new global::Gtk.Action ("GenerarReportesAction", global::Mono.Unix.Catalog.GetString ("Generar Reportes"), null, null);
			this.GenerarReportesAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Reporte");
			w1.Add (this.GenerarReportesAction, null);
			this.EditarNmeroBoletaAction = new global::Gtk.Action ("EditarNmeroBoletaAction", global::Mono.Unix.Catalog.GetString ("Editar Número Boleta"), null, null);
			this.EditarNmeroBoletaAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Editar Boleta");
			w1.Add (this.EditarNmeroBoletaAction, null);
			this.AyudaAction = new global::Gtk.Action ("AyudaAction", global::Mono.Unix.Catalog.GetString ("Ayuda"), null, null);
			this.AyudaAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Ayuda");
			w1.Add (this.AyudaAction, null);
			this.AcercaDeAction = new global::Gtk.Action ("AcercaDeAction", global::Mono.Unix.Catalog.GetString ("Acerca de"), null, null);
			this.AcercaDeAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Acerca de");
			w1.Add (this.AcercaDeAction, null);
			this.IngresoDineroCajaAction = new global::Gtk.Action ("IngresoDineroCajaAction", global::Mono.Unix.Catalog.GetString ("Ingreso Dinero Caja"), null, null);
			this.IngresoDineroCajaAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Ingreso Dinero Caja");
			w1.Add (this.IngresoDineroCajaAction, null);
			this.SalidaDineroCajaAction = new global::Gtk.Action ("SalidaDineroCajaAction", global::Mono.Unix.Catalog.GetString ("Salida Dinero Caja"), null, null);
			this.SalidaDineroCajaAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Salida Dinero Caja");
			w1.Add (this.SalidaDineroCajaAction, null);
			this.UIManager.InsertActionGroup (w1, 0);
			this.AddAccelGroup (this.UIManager.AccelGroup);
			this.Name = "punto.gui.VenderProductosDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Punto de Ventas Minimarket El Coke");
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
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString (@"<ui><menubar name='menubar1'><menu name='SesionAction' action='SesionAction'><menuitem name='CerrarAction' action='CerrarAction'/></menu><menu name='ProductosAction' action='ProductosAction'><menuitem name='RegistrarEditarAction' action='RegistrarEditarAction'/><menuitem name='FamiliaProductosAction' action='FamiliaProductosAction'/></menu><menu name='UsuarioAction' action='UsuarioAction'><menuitem name='RegistrarEditarAction1' action='RegistrarEditarAction1'/></menu><menu name='OpcionesAction' action='OpcionesAction'><menuitem name='GenerarReportesAction' action='GenerarReportesAction'/><menuitem name='EditarNmeroBoletaAction' action='EditarNmeroBoletaAction'/><menuitem name='IngresoDineroCajaAction' action='IngresoDineroCajaAction'/><menuitem name='SalidaDineroCajaAction' action='SalidaDineroCajaAction'/></menu><menu name='AyudaAction' action='AyudaAction'><menuitem name='AcercaDeAction' action='AcercaDeAction'/></menu></menubar></ui>");
			this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar1")));
			this.menubar1.Name = "menubar1";
			this.hbox3.Add (this.menubar1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.menubar1]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.alignment18 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment18.Name = "alignment18";
			// Container child alignment18.Gtk.Container+ContainerChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("                                                                                 " +
				"      ");
			this.alignment18.Add (this.label7);
			this.hbox3.Add (this.alignment18);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.alignment18]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.labelHora = new global::Gtk.Label ();
			this.labelHora.Name = "labelHora";
			this.labelHora.LabelProp = global::Mono.Unix.Catalog.GetString ("                                                                              ");
			this.hbox3.Add (this.labelHora);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.labelHora]));
			w6.Position = 2;
			w6.Expand = false;
			w6.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.labelNombreCajero1 = new global::Gtk.Label ();
			this.labelNombreCajero1.Name = "labelNombreCajero1";
			this.labelNombreCajero1.LabelProp = global::Mono.Unix.Catalog.GetString ("     ");
			this.hbox3.Add (this.labelNombreCajero1);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.labelNombreCajero1]));
			w7.PackType = ((global::Gtk.PackType)(1));
			w7.Position = 3;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.labelNombreCajero = new global::Gtk.Label ();
			this.labelNombreCajero.Name = "labelNombreCajero";
			this.labelNombreCajero.LabelProp = global::Mono.Unix.Catalog.GetString ("   ");
			this.hbox3.Add (this.labelNombreCajero);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.labelNombreCajero]));
			w8.PackType = ((global::Gtk.PackType)(1));
			w8.Position = 4;
			w8.Expand = false;
			w8.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.labelCajero = new global::Gtk.Label ();
			this.labelCajero.Name = "labelCajero";
			this.labelCajero.LabelProp = global::Mono.Unix.Catalog.GetString ("Cajero: ");
			this.hbox3.Add (this.labelCajero);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.labelCajero]));
			w9.PackType = ((global::Gtk.PackType)(1));
			w9.Position = 5;
			w9.Expand = false;
			w9.Fill = false;
			this.dialog1_VBox1.Add (this.hbox3);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.dialog1_VBox1 [this.hbox3]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
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
			this.hpaned3.Position = 342;
			// Container child hpaned3.Gtk.Paned+PanedChild
			this.frame1 = new global::Gtk.Frame ();
			this.frame1.Name = "frame1";
			this.frame1.BorderWidth = ((uint)(5));
			// Container child frame1.Gtk.Container+ContainerChild
			this.GtkAlignment2 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment2.Name = "GtkAlignment2";
			this.GtkAlignment2.LeftPadding = ((uint)(12));
			// Container child GtkAlignment2.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.alignment1 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment1.Name = "alignment1";
			// Container child alignment1.Gtk.Container+ContainerChild
			this.imageLogo = new global::Gtk.Image ();
			this.imageLogo.Name = "imageLogo";
			this.imageLogo.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("punto.gui.logo.png");
			this.alignment1.Add (this.imageLogo);
			this.vbox2.Add (this.alignment1);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.alignment1]));
			w12.Position = 0;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator ();
			this.hseparator1.Name = "hseparator1";
			this.vbox2.Add (this.hseparator1);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hseparator1]));
			w13.Position = 1;
			// Container child vbox2.Gtk.Box+BoxChild
			this.labelFecha = new global::Gtk.Label ();
			this.labelFecha.Name = "labelFecha";
			this.vbox2.Add (this.labelFecha);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.labelFecha]));
			w14.PackType = ((global::Gtk.PackType)(1));
			w14.Position = 2;
			w14.Fill = false;
			this.GtkAlignment2.Add (this.vbox2);
			this.frame1.Add (this.GtkAlignment2);
			this.GtkLabel4 = new global::Gtk.Label ();
			this.GtkLabel4.Name = "GtkLabel4";
			this.GtkLabel4.UseMarkup = true;
			this.frame1.LabelWidget = this.GtkLabel4;
			this.hpaned3.Add (this.frame1);
			global::Gtk.Paned.PanedChild w17 = ((global::Gtk.Paned.PanedChild)(this.hpaned3 [this.frame1]));
			w17.Resize = false;
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
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.labelNumProducto]));
			w18.Position = 0;
			w18.Expand = false;
			w18.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.entryCodigoBarra = new global::Gtk.Entry ();
			this.entryCodigoBarra.CanFocus = true;
			this.entryCodigoBarra.Events = ((global::Gdk.EventMask)(1024));
			this.entryCodigoBarra.Name = "entryCodigoBarra";
			this.entryCodigoBarra.IsEditable = true;
			this.entryCodigoBarra.InvisibleChar = '●';
			this.hbox4.Add (this.entryCodigoBarra);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.entryCodigoBarra]));
			w19.Position = 1;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label18 = new global::Gtk.Label ();
			this.label18.Name = "label18";
			this.label18.LabelProp = global::Mono.Unix.Catalog.GetString ("                                  ");
			this.hbox4.Add (this.label18);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.label18]));
			w20.Position = 2;
			w20.Expand = false;
			w20.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label19 = new global::Gtk.Label ();
			this.label19.Name = "label19";
			this.label19.LabelProp = global::Mono.Unix.Catalog.GetString ("                                  ");
			this.hbox4.Add (this.label19);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.label19]));
			w21.Position = 3;
			w21.Expand = false;
			w21.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label20 = new global::Gtk.Label ();
			this.label20.Name = "label20";
			this.label20.LabelProp = global::Mono.Unix.Catalog.GetString ("                                  ");
			this.hbox4.Add (this.label20);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.label20]));
			w22.PackType = ((global::Gtk.PackType)(1));
			w22.Position = 4;
			w22.Expand = false;
			w22.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.labelNumBoleta1 = new global::Gtk.Label ();
			this.labelNumBoleta1.Name = "labelNumBoleta1";
			this.labelNumBoleta1.Xalign = 1F;
			this.hbox4.Add (this.labelNumBoleta1);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.labelNumBoleta1]));
			w23.PackType = ((global::Gtk.PackType)(1));
			w23.Position = 5;
			w23.Expand = false;
			w23.Fill = false;
			this.vbox5.Add (this.hbox4);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.hbox4]));
			w24.Position = 0;
			w24.Expand = false;
			w24.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.frame6 = new global::Gtk.Frame ();
			this.frame6.Name = "frame6";
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
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.frame6]));
			w28.Position = 1;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox ();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.labelTotal1 = new global::Gtk.Label ();
			this.labelTotal1.Name = "labelTotal1";
			this.labelTotal1.LabelProp = global::Mono.Unix.Catalog.GetString ("Total:");
			this.hbox6.Add (this.labelTotal1);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.labelTotal1]));
			w29.Position = 0;
			w29.Expand = false;
			w29.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.labelTotalVenta = new global::Gtk.Label ();
			this.labelTotalVenta.Name = "labelTotalVenta";
			this.labelTotalVenta.LabelProp = global::Mono.Unix.Catalog.GetString ("0");
			this.hbox6.Add (this.labelTotalVenta);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.labelTotalVenta]));
			w30.Position = 1;
			w30.Expand = false;
			w30.Fill = false;
			this.vbox5.Add (this.hbox6);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.hbox6]));
			w31.Position = 2;
			w31.Expand = false;
			w31.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbox7 = new global::Gtk.HBox ();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.alignment4 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment4.Name = "alignment4";
			this.hbox7.Add (this.alignment4);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.alignment4]));
			w32.Position = 0;
			// Container child hbox7.Gtk.Box+BoxChild
			this.ButtonVenta = new global::Gtk.Button ();
			this.ButtonVenta.CanFocus = true;
			this.ButtonVenta.Name = "ButtonVenta";
			this.ButtonVenta.UseUnderline = true;
			// Container child ButtonVenta.Gtk.Container+ContainerChild
			global::Gtk.Alignment w33 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w34 = new global::Gtk.HBox ();
			w34.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w35 = new global::Gtk.Image ();
			w35.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-index", global::Gtk.IconSize.Menu);
			w34.Add (w35);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w37 = new global::Gtk.Label ();
			w37.LabelProp = global::Mono.Unix.Catalog.GetString ("Venta");
			w37.UseUnderline = true;
			w34.Add (w37);
			w33.Add (w34);
			this.ButtonVenta.Add (w33);
			this.hbox7.Add (this.ButtonVenta);
			global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.ButtonVenta]));
			w41.Position = 1;
			w41.Expand = false;
			w41.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.alignment5 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment5.Name = "alignment5";
			this.hbox7.Add (this.alignment5);
			global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.alignment5]));
			w42.Position = 2;
			this.vbox5.Add (this.hbox7);
			global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.hbox7]));
			w43.Position = 3;
			w43.Expand = false;
			w43.Fill = false;
			this.hpaned3.Add (this.vbox5);
			this.hbox2.Add (this.hpaned3);
			global::Gtk.Box.BoxChild w45 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.hpaned3]));
			w45.Position = 0;
			this.hbox1.Add (this.hbox2);
			global::Gtk.Box.BoxChild w46 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.hbox2]));
			w46.Position = 0;
			this.dialog1_VBox1.Add (this.hbox1);
			global::Gtk.Box.BoxChild w47 = ((global::Gtk.Box.BoxChild)(this.dialog1_VBox1 [this.hbox1]));
			w47.Position = 1;
			w2.Add (this.dialog1_VBox1);
			global::Gtk.Box.BoxChild w48 = ((global::Gtk.Box.BoxChild)(w2 [this.dialog1_VBox1]));
			w48.Position = 0;
			// Internal child punto.gui.VenderProductosDialog.ActionArea
			global::Gtk.HButtonBox w49 = this.ActionArea;
			w49.Name = "__gtksharp_56_Stetic_TopLevelDialog_ActionArea";
			// Container child __gtksharp_56_Stetic_TopLevelDialog_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.button790 = new global::Gtk.Button ();
			this.button790.CanFocus = true;
			this.button790.Name = "button790";
			this.button790.UseUnderline = true;
			this.button790.Label = global::Mono.Unix.Catalog.GetString ("GtkButton");
			this.AddActionWidget (this.button790, 0);
			global::Gtk.ButtonBox.ButtonBoxChild w50 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w49 [this.button790]));
			w50.Expand = false;
			w50.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 1353;
			this.DefaultHeight = 546;
			w49.Hide ();
			this.Hide ();
			this.CerrarAction.Activated += new global::System.EventHandler (this.OnCerrarActionActivated);
			this.RegistrarEditarAction.Activated += new global::System.EventHandler (this.OnIngresarEditarProductosActionActivated);
			this.FamiliaProductosAction.Activated += new global::System.EventHandler (this.OnFamiliaProductosActionActivated);
			this.RegistrarEditarAction1.Activated += new global::System.EventHandler (this.OnRegistrarEditarUsuarioActionActivated);
			this.GenerarReportesAction.Activated += new global::System.EventHandler (this.OnGenerarReportesActionActivated);
			this.EditarNmeroBoletaAction.Activated += new global::System.EventHandler (this.OnEditarNmeroBoletaActionActivated);
			this.entryCodigoBarra.KeyPressEvent += new global::Gtk.KeyPressEventHandler (this.OnEntryCodigoBarraKeyPressEvent);
			this.ButtonVenta.Clicked += new global::System.EventHandler (this.OnButtonVentaClicked);
		}
	}
}
