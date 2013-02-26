
// This file has been generated by the GUI designer. Do not modify.
namespace punto.gui
{
	public partial class IngresarProductosDialog
	{
		private global::Gtk.Notebook notebook1;
		private global::Gtk.VBox vbox3;
		private global::Gtk.Label labelTituloRegistrarProd;
		private global::Gtk.Alignment alignment3;
		private global::Gtk.VBox vbox6;
		private global::Gtk.Table table1;
		private global::Gtk.CheckButton checkbuttonPesable;
		private global::Gtk.CheckButton checkbuttonVigente;
		private global::Gtk.Entry entryCodigoBarra;
		private global::Gtk.Entry entryNombre;
		private global::Gtk.Entry entryPrecioVenta;
		private global::Gtk.HBox hbox3;
		private global::Gtk.ComboBox comboboxFamiliaProd;
		private global::Gtk.Button button334;
		private global::Gtk.Label labelCodigoBarra;
		private global::Gtk.Label labelFamilia;
		private global::Gtk.Label labelNombre;
		private global::Gtk.Label labelPrecioVenta;
		private global::Gtk.HPaned hpaned1;
		private global::Gtk.HBox hbox2;
		private global::Gtk.Fixed fixed1;
		private global::Gtk.Fixed fixed2;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Fixed fixed3;
		private global::Gtk.Button BotonAgregarProd;
		private global::Gtk.Button button485;
		private global::Gtk.Label label6;
		private global::Gtk.Label labelRegistrarProducto;
		private global::Gtk.Frame frame4;
		private global::Gtk.Alignment GtkAlignment2;
		private global::Gtk.VBox vbox4;
		private global::Gtk.HBox hbox5;
		private global::Gtk.Alignment alignment1;
		private global::Gtk.Button BotonEditar;
		private global::Gtk.HBox hbox6;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TreeView treeviewModificarProducto;
		private global::Gtk.Label GtkLabel6;
		private global::Gtk.Label labelModificarProducto;
		private global::Gtk.HButtonBox dialog1_ActionArea;
		private global::Gtk.Button buttonCancel;
		private global::Gtk.Button buttonOk;
		private global::Gtk.Button button3322;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget punto.gui.IngresarProductosDialog
			this.Name = "punto.gui.IngresarProductosDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Registrar / Modificar Producto");
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			// Internal child punto.gui.IngresarProductosDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.notebook1 = new global::Gtk.Notebook ();
			this.notebook1.CanFocus = true;
			this.notebook1.Name = "notebook1";
			this.notebook1.CurrentPage = 0;
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.labelTituloRegistrarProd = new global::Gtk.Label ();
			this.labelTituloRegistrarProd.Name = "labelTituloRegistrarProd";
			this.labelTituloRegistrarProd.Ypad = 10;
			this.labelTituloRegistrarProd.LabelProp = global::Mono.Unix.Catalog.GetString ("Ingreso de productos de la Base de Datos");
			this.vbox3.Add (this.labelTituloRegistrarProd);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.labelTituloRegistrarProd]));
			w2.Position = 0;
			w2.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.alignment3 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment3.Name = "alignment3";
			// Container child alignment3.Gtk.Container+ContainerChild
			this.vbox6 = new global::Gtk.VBox ();
			this.vbox6.Name = "vbox6";
			this.vbox6.Spacing = 6;
			// Container child vbox6.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table (((uint)(6)), ((uint)(2)), true);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			this.table1.BorderWidth = ((uint)(7));
			// Container child table1.Gtk.Table+TableChild
			this.checkbuttonPesable = new global::Gtk.CheckButton ();
			this.checkbuttonPesable.CanFocus = true;
			this.checkbuttonPesable.Name = "checkbuttonPesable";
			this.checkbuttonPesable.Label = global::Mono.Unix.Catalog.GetString ("Pesable");
			this.checkbuttonPesable.DrawIndicator = true;
			this.checkbuttonPesable.UseUnderline = true;
			this.table1.Add (this.checkbuttonPesable);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1 [this.checkbuttonPesable]));
			w3.TopAttach = ((uint)(3));
			w3.BottomAttach = ((uint)(4));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.checkbuttonVigente = new global::Gtk.CheckButton ();
			this.checkbuttonVigente.CanFocus = true;
			this.checkbuttonVigente.Name = "checkbuttonVigente";
			this.checkbuttonVigente.Label = global::Mono.Unix.Catalog.GetString ("Vigente");
			this.checkbuttonVigente.Active = true;
			this.checkbuttonVigente.DrawIndicator = true;
			this.checkbuttonVigente.UseUnderline = true;
			this.table1.Add (this.checkbuttonVigente);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1 [this.checkbuttonVigente]));
			w4.TopAttach = ((uint)(4));
			w4.BottomAttach = ((uint)(5));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryCodigoBarra = new global::Gtk.Entry ();
			this.entryCodigoBarra.CanFocus = true;
			this.entryCodigoBarra.Name = "entryCodigoBarra";
			this.entryCodigoBarra.IsEditable = true;
			this.entryCodigoBarra.InvisibleChar = '●';
			this.table1.Add (this.entryCodigoBarra);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryCodigoBarra]));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(2));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryNombre = new global::Gtk.Entry ();
			this.entryNombre.CanFocus = true;
			this.entryNombre.Name = "entryNombre";
			this.entryNombre.IsEditable = true;
			this.entryNombre.InvisibleChar = '●';
			this.table1.Add (this.entryNombre);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryNombre]));
			w6.TopAttach = ((uint)(1));
			w6.BottomAttach = ((uint)(2));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryPrecioVenta = new global::Gtk.Entry ();
			this.entryPrecioVenta.CanFocus = true;
			this.entryPrecioVenta.Name = "entryPrecioVenta";
			this.entryPrecioVenta.IsEditable = true;
			this.entryPrecioVenta.InvisibleChar = '●';
			this.table1.Add (this.entryPrecioVenta);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryPrecioVenta]));
			w7.TopAttach = ((uint)(2));
			w7.BottomAttach = ((uint)(3));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.comboboxFamiliaProd = global::Gtk.ComboBox.NewText ();
			this.comboboxFamiliaProd.Name = "comboboxFamiliaProd";
			this.hbox3.Add (this.comboboxFamiliaProd);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.comboboxFamiliaProd]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.button334 = new global::Gtk.Button ();
			this.button334.CanFocus = true;
			this.button334.Name = "button334";
			this.button334.UseUnderline = true;
			// Container child button334.Gtk.Container+ContainerChild
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
			w13.LabelProp = global::Mono.Unix.Catalog.GetString ("Agregar Familia");
			w13.UseUnderline = true;
			w10.Add (w13);
			w9.Add (w10);
			this.button334.Add (w9);
			this.hbox3.Add (this.button334);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.button334]));
			w17.Position = 1;
			w17.Expand = false;
			w17.Fill = false;
			this.table1.Add (this.hbox3);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table1 [this.hbox3]));
			w18.TopAttach = ((uint)(5));
			w18.BottomAttach = ((uint)(6));
			w18.LeftAttach = ((uint)(1));
			w18.RightAttach = ((uint)(2));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelCodigoBarra = new global::Gtk.Label ();
			this.labelCodigoBarra.Name = "labelCodigoBarra";
			this.labelCodigoBarra.Xalign = 0F;
			this.labelCodigoBarra.LabelProp = global::Mono.Unix.Catalog.GetString ("     Codigo de Barra: ");
			this.table1.Add (this.labelCodigoBarra);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelCodigoBarra]));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelFamilia = new global::Gtk.Label ();
			this.labelFamilia.Name = "labelFamilia";
			this.labelFamilia.Xalign = 0F;
			this.labelFamilia.LabelProp = global::Mono.Unix.Catalog.GetString ("     Familia:");
			this.table1.Add (this.labelFamilia);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelFamilia]));
			w20.TopAttach = ((uint)(5));
			w20.BottomAttach = ((uint)(6));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelNombre = new global::Gtk.Label ();
			this.labelNombre.Name = "labelNombre";
			this.labelNombre.Xalign = 0F;
			this.labelNombre.LabelProp = global::Mono.Unix.Catalog.GetString ("     Nombre:");
			this.table1.Add (this.labelNombre);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelNombre]));
			w21.TopAttach = ((uint)(1));
			w21.BottomAttach = ((uint)(2));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelPrecioVenta = new global::Gtk.Label ();
			this.labelPrecioVenta.Name = "labelPrecioVenta";
			this.labelPrecioVenta.Xalign = 0F;
			this.labelPrecioVenta.LabelProp = global::Mono.Unix.Catalog.GetString ("     Precio Venta:");
			this.table1.Add (this.labelPrecioVenta);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelPrecioVenta]));
			w22.TopAttach = ((uint)(2));
			w22.BottomAttach = ((uint)(3));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox6.Add (this.table1);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.table1]));
			w23.Position = 0;
			w23.Expand = false;
			w23.Fill = false;
			this.alignment3.Add (this.vbox6);
			this.vbox3.Add (this.alignment3);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.alignment3]));
			w25.Position = 1;
			w25.Expand = false;
			w25.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hpaned1 = new global::Gtk.HPaned ();
			this.hpaned1.CanFocus = true;
			this.hpaned1.Name = "hpaned1";
			this.hpaned1.Position = 1;
			// Container child hpaned1.Gtk.Paned+PanedChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.fixed1 = new global::Gtk.Fixed ();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			this.hbox2.Add (this.fixed1);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.fixed1]));
			w26.Position = 0;
			// Container child hbox2.Gtk.Box+BoxChild
			this.fixed2 = new global::Gtk.Fixed ();
			this.fixed2.Name = "fixed2";
			this.fixed2.HasWindow = false;
			this.hbox2.Add (this.fixed2);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.fixed2]));
			w27.Position = 1;
			// Container child hbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.fixed3 = new global::Gtk.Fixed ();
			this.fixed3.Name = "fixed3";
			this.fixed3.HasWindow = false;
			this.hbox1.Add (this.fixed3);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.fixed3]));
			w28.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.BotonAgregarProd = new global::Gtk.Button ();
			this.BotonAgregarProd.CanFocus = true;
			this.BotonAgregarProd.Name = "BotonAgregarProd";
			this.BotonAgregarProd.UseUnderline = true;
			// Container child BotonAgregarProd.Gtk.Container+ContainerChild
			global::Gtk.Alignment w29 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w30 = new global::Gtk.HBox ();
			w30.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w31 = new global::Gtk.Image ();
			w31.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-add", global::Gtk.IconSize.Menu);
			w30.Add (w31);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w33 = new global::Gtk.Label ();
			w33.LabelProp = global::Mono.Unix.Catalog.GetString ("Agregar");
			w33.UseUnderline = true;
			w30.Add (w33);
			w29.Add (w30);
			this.BotonAgregarProd.Add (w29);
			this.hbox1.Add (this.BotonAgregarProd);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.BotonAgregarProd]));
			w37.Position = 1;
			w37.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button485 = new global::Gtk.Button ();
			this.button485.CanDefault = true;
			this.button485.CanFocus = true;
			this.button485.Name = "button485";
			this.button485.UseUnderline = true;
			// Container child button485.Gtk.Container+ContainerChild
			global::Gtk.Alignment w38 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w39 = new global::Gtk.HBox ();
			w39.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w40 = new global::Gtk.Image ();
			w40.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-clear", global::Gtk.IconSize.Menu);
			w39.Add (w40);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w42 = new global::Gtk.Label ();
			w42.LabelProp = global::Mono.Unix.Catalog.GetString ("_Limpiar");
			w42.UseUnderline = true;
			w39.Add (w42);
			w38.Add (w39);
			this.button485.Add (w38);
			this.hbox1.Add (this.button485);
			global::Gtk.Box.BoxChild w46 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.button485]));
			w46.Position = 2;
			w46.Expand = false;
			w46.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("                 ");
			this.hbox1.Add (this.label6);
			global::Gtk.Box.BoxChild w47 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label6]));
			w47.Position = 3;
			w47.Expand = false;
			w47.Fill = false;
			this.hbox2.Add (this.hbox1);
			global::Gtk.Box.BoxChild w48 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.hbox1]));
			w48.Position = 2;
			this.hpaned1.Add (this.hbox2);
			this.vbox3.Add (this.hpaned1);
			global::Gtk.Box.BoxChild w50 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hpaned1]));
			w50.Position = 2;
			this.notebook1.Add (this.vbox3);
			// Notebook tab
			this.labelRegistrarProducto = new global::Gtk.Label ();
			this.labelRegistrarProducto.Name = "labelRegistrarProducto";
			this.labelRegistrarProducto.LabelProp = global::Mono.Unix.Catalog.GetString ("Registrar Producto");
			this.notebook1.SetTabLabel (this.vbox3, this.labelRegistrarProducto);
			this.labelRegistrarProducto.ShowAll ();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.frame4 = new global::Gtk.Frame ();
			this.frame4.Name = "frame4";
			this.frame4.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame4.Gtk.Container+ContainerChild
			this.GtkAlignment2 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment2.Name = "GtkAlignment2";
			this.GtkAlignment2.LeftPadding = ((uint)(12));
			// Container child GtkAlignment2.Gtk.Container+ContainerChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox ();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.alignment1 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment1.Name = "alignment1";
			this.hbox5.Add (this.alignment1);
			global::Gtk.Box.BoxChild w52 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.alignment1]));
			w52.Position = 0;
			// Container child hbox5.Gtk.Box+BoxChild
			this.BotonEditar = new global::Gtk.Button ();
			this.BotonEditar.CanFocus = true;
			this.BotonEditar.Name = "BotonEditar";
			this.BotonEditar.UseUnderline = true;
			// Container child BotonEditar.Gtk.Container+ContainerChild
			global::Gtk.Alignment w53 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w54 = new global::Gtk.HBox ();
			w54.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w55 = new global::Gtk.Image ();
			w55.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-edit", global::Gtk.IconSize.Menu);
			w54.Add (w55);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w57 = new global::Gtk.Label ();
			w57.LabelProp = global::Mono.Unix.Catalog.GetString ("Editar");
			w57.UseUnderline = true;
			w54.Add (w57);
			w53.Add (w54);
			this.BotonEditar.Add (w53);
			this.hbox5.Add (this.BotonEditar);
			global::Gtk.Box.BoxChild w61 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.BotonEditar]));
			w61.Position = 1;
			w61.Expand = false;
			w61.Fill = false;
			this.vbox4.Add (this.hbox5);
			global::Gtk.Box.BoxChild w62 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox5]));
			w62.Position = 0;
			w62.Expand = false;
			w62.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox ();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.treeviewModificarProducto = new global::Gtk.TreeView ();
			this.treeviewModificarProducto.CanFocus = true;
			this.treeviewModificarProducto.Name = "treeviewModificarProducto";
			this.GtkScrolledWindow.Add (this.treeviewModificarProducto);
			this.hbox6.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w64 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.GtkScrolledWindow]));
			w64.Position = 0;
			this.vbox4.Add (this.hbox6);
			global::Gtk.Box.BoxChild w65 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox6]));
			w65.Position = 1;
			this.GtkAlignment2.Add (this.vbox4);
			this.frame4.Add (this.GtkAlignment2);
			this.GtkLabel6 = new global::Gtk.Label ();
			this.GtkLabel6.Name = "GtkLabel6";
			this.GtkLabel6.UseMarkup = true;
			this.frame4.LabelWidget = this.GtkLabel6;
			this.notebook1.Add (this.frame4);
			global::Gtk.Notebook.NotebookChild w68 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.frame4]));
			w68.Position = 1;
			// Notebook tab
			this.labelModificarProducto = new global::Gtk.Label ();
			this.labelModificarProducto.Name = "labelModificarProducto";
			this.labelModificarProducto.LabelProp = global::Mono.Unix.Catalog.GetString ("Modificar Producto");
			this.notebook1.SetTabLabel (this.frame4, this.labelModificarProducto);
			this.labelModificarProducto.ShowAll ();
			w1.Add (this.notebook1);
			global::Gtk.Box.BoxChild w69 = ((global::Gtk.Box.BoxChild)(w1 [this.notebook1]));
			w69.Position = 0;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.dialog1_ActionArea = new global::Gtk.HButtonBox ();
			this.dialog1_ActionArea.Name = "dialog1_ActionArea";
			this.dialog1_ActionArea.Spacing = 10;
			this.dialog1_ActionArea.BorderWidth = ((uint)(5));
			this.dialog1_ActionArea.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			// Container child buttonCancel.Gtk.Container+ContainerChild
			global::Gtk.Alignment w70 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w71 = new global::Gtk.HBox ();
			w71.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w72 = new global::Gtk.Image ();
			w72.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-cancel", global::Gtk.IconSize.Menu);
			w71.Add (w72);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w74 = new global::Gtk.Label ();
			w74.LabelProp = global::Mono.Unix.Catalog.GetString ("_Cancel");
			w74.UseUnderline = true;
			w71.Add (w74);
			w70.Add (w71);
			this.buttonCancel.Add (w70);
			this.dialog1_ActionArea.Add (this.buttonCancel);
			global::Gtk.ButtonBox.ButtonBoxChild w78 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.dialog1_ActionArea [this.buttonCancel]));
			w78.Expand = false;
			w78.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseUnderline = true;
			// Container child buttonOk.Gtk.Container+ContainerChild
			global::Gtk.Alignment w79 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w80 = new global::Gtk.HBox ();
			w80.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w81 = new global::Gtk.Image ();
			w81.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-apply", global::Gtk.IconSize.Menu);
			w80.Add (w81);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w83 = new global::Gtk.Label ();
			w83.LabelProp = global::Mono.Unix.Catalog.GetString ("_OK");
			w83.UseUnderline = true;
			w80.Add (w83);
			w79.Add (w80);
			this.buttonOk.Add (w79);
			this.dialog1_ActionArea.Add (this.buttonOk);
			global::Gtk.ButtonBox.ButtonBoxChild w87 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.dialog1_ActionArea [this.buttonOk]));
			w87.Position = 1;
			w87.Expand = false;
			w87.Fill = false;
			w1.Add (this.dialog1_ActionArea);
			global::Gtk.Box.BoxChild w88 = ((global::Gtk.Box.BoxChild)(w1 [this.dialog1_ActionArea]));
			w88.PackType = ((global::Gtk.PackType)(1));
			w88.Position = 2;
			w88.Expand = false;
			w88.Fill = false;
			// Internal child punto.gui.IngresarProductosDialog.ActionArea
			global::Gtk.HButtonBox w89 = this.ActionArea;
			w89.Name = "__gtksharp_58_Stetic_TopLevelDialog_ActionArea";
			// Container child __gtksharp_58_Stetic_TopLevelDialog_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.button3322 = new global::Gtk.Button ();
			this.button3322.CanFocus = true;
			this.button3322.Name = "button3322";
			this.button3322.UseUnderline = true;
			this.button3322.Label = global::Mono.Unix.Catalog.GetString ("GtkButton");
			this.AddActionWidget (this.button3322, 0);
			global::Gtk.ButtonBox.ButtonBoxChild w90 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w89 [this.button3322]));
			w90.Expand = false;
			w90.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 437;
			this.button3322.Hide ();
			this.Show ();
			this.checkbuttonVigente.Toggled += new global::System.EventHandler (this.OnCheckbutton8Toggled);
			this.checkbuttonPesable.Toggled += new global::System.EventHandler (this.OnCheckbutton7Toggled);
			this.BotonAgregarProd.Clicked += new global::System.EventHandler (this.OnBotonAgregarPClicked);
			this.button485.Clicked += new global::System.EventHandler (this.BotonCancelar);
			this.BotonEditar.Clicked += new global::System.EventHandler (this.OnBotonEditarClicked);
			this.labelModificarProducto.KeyPressEvent += new global::Gtk.KeyPressEventHandler (this.OnLabelModificarProductoKeyPressEvent);
			this.buttonCancel.Clicked += new global::System.EventHandler (this.OnButtonCancelClicked);
		}
	}
}
