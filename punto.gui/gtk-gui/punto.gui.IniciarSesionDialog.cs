
// This file has been generated by the GUI designer. Do not modify.
namespace punto.gui
{
	public partial class IniciarSesionDialog
	{
		private global::Gtk.VBox vbox3;
		private global::Gtk.Table table2;
		private global::Gtk.Alignment alignment10;
		private global::Gtk.Alignment alignment57;
		private global::Gtk.Alignment alignment59;
		private global::Gtk.Alignment alignment58;
		private global::Gtk.Table table1;
		private global::Gtk.Alignment alignment1;
		private global::Gtk.Alignment alignment2;
		private global::Gtk.Alignment alignment12;
		private global::Gtk.Alignment alignment3;
		private global::Gtk.Alignment alignment4;
		private global::Gtk.Alignment alignment11;
		private global::Gtk.Alignment alignment5;
		private global::Gtk.Alignment alignment6;
		private global::Gtk.Image image161;
		private global::Gtk.Alignment alignment7;
		private global::Gtk.Alignment alignment60;
		private global::Gtk.Alignment alignment62;
		private global::Gtk.Alignment alignment63;
		private global::Gtk.Label labelContraseña;
		private global::Gtk.Alignment alignment64;
		private global::Gtk.Alignment alignment68;
		private global::Gtk.Alignment alignment69;
		private global::Gtk.Entry entryClave;
		private global::Gtk.Alignment alignment70;
		private global::Gtk.Entry entryUsuario;
		private global::Gtk.HBox hbox2;
		private global::Gtk.Alignment alignment66;
		private global::Gtk.Button buttonIngresar;
		private global::Gtk.Alignment alignment67;
		private global::Gtk.Button BotonSalir;
		private global::Gtk.Label labelUsuario;
		private global::Gtk.Button button1218;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget punto.gui.IniciarSesionDialog
			this.Name = "punto.gui.IniciarSesionDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("INICIO SESION");
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			this.DefaultWidth = 1280;
			this.DefaultHeight = 720;
			// Internal child punto.gui.IniciarSesionDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.table2 = new global::Gtk.Table (((uint)(7)), ((uint)(3)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			// Container child table2.Gtk.Table+TableChild
			this.alignment10 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment10.Name = "alignment10";
			this.table2.Add (this.alignment10);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table2 [this.alignment10]));
			w2.TopAttach = ((uint)(6));
			w2.BottomAttach = ((uint)(7));
			w2.LeftAttach = ((uint)(2));
			w2.RightAttach = ((uint)(3));
			// Container child table2.Gtk.Table+TableChild
			this.alignment57 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment57.Name = "alignment57";
			// Container child alignment57.Gtk.Container+ContainerChild
			this.alignment59 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment59.Name = "alignment59";
			this.alignment57.Add (this.alignment59);
			this.table2.Add (this.alignment57);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table2 [this.alignment57]));
			w4.LeftAttach = ((uint)(2));
			w4.RightAttach = ((uint)(3));
			// Container child table2.Gtk.Table+TableChild
			this.alignment58 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment58.Name = "alignment58";
			// Container child alignment58.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table (((uint)(3)), ((uint)(3)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.alignment1 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment1.Name = "alignment1";
			this.table1.Add (this.alignment1);
			// Container child table1.Gtk.Table+TableChild
			this.alignment2 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment2.Name = "alignment2";
			// Container child alignment2.Gtk.Container+ContainerChild
			this.alignment12 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment12.Name = "alignment12";
			this.alignment2.Add (this.alignment12);
			this.table1.Add (this.alignment2);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1 [this.alignment2]));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.alignment3 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment3.Name = "alignment3";
			this.table1.Add (this.alignment3);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1 [this.alignment3]));
			w8.LeftAttach = ((uint)(2));
			w8.RightAttach = ((uint)(3));
			// Container child table1.Gtk.Table+TableChild
			this.alignment4 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment4.Name = "alignment4";
			// Container child alignment4.Gtk.Container+ContainerChild
			this.alignment11 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment11.Name = "alignment11";
			this.alignment4.Add (this.alignment11);
			this.table1.Add (this.alignment4);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1 [this.alignment4]));
			w10.TopAttach = ((uint)(1));
			w10.BottomAttach = ((uint)(2));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.alignment5 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment5.Name = "alignment5";
			this.table1.Add (this.alignment5);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1 [this.alignment5]));
			w11.TopAttach = ((uint)(1));
			w11.BottomAttach = ((uint)(2));
			w11.LeftAttach = ((uint)(2));
			w11.RightAttach = ((uint)(3));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.alignment6 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment6.Name = "alignment6";
			// Container child alignment6.Gtk.Container+ContainerChild
			this.image161 = new global::Gtk.Image ();
			this.image161.Name = "image161";
			this.image161.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("punto.gui.sesion.png");
			this.alignment6.Add (this.image161);
			this.table1.Add (this.alignment6);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1 [this.alignment6]));
			w13.TopAttach = ((uint)(1));
			w13.BottomAttach = ((uint)(2));
			w13.LeftAttach = ((uint)(1));
			w13.RightAttach = ((uint)(2));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.alignment7 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment7.Name = "alignment7";
			this.table1.Add (this.alignment7);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table1 [this.alignment7]));
			w14.TopAttach = ((uint)(2));
			w14.BottomAttach = ((uint)(3));
			w14.LeftAttach = ((uint)(1));
			w14.RightAttach = ((uint)(2));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			this.alignment58.Add (this.table1);
			this.table2.Add (this.alignment58);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table2 [this.alignment58]));
			w16.LeftAttach = ((uint)(1));
			w16.RightAttach = ((uint)(2));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.alignment60 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment60.Name = "alignment60";
			this.table2.Add (this.alignment60);
			// Container child table2.Gtk.Table+TableChild
			this.alignment62 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment62.Name = "alignment62";
			this.table2.Add (this.alignment62);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table2 [this.alignment62]));
			w18.TopAttach = ((uint)(3));
			w18.BottomAttach = ((uint)(4));
			w18.LeftAttach = ((uint)(2));
			w18.RightAttach = ((uint)(3));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.alignment63 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment63.Name = "alignment63";
			// Container child alignment63.Gtk.Container+ContainerChild
			this.labelContraseña = new global::Gtk.Label ();
			this.labelContraseña.Name = "labelContraseña";
			this.labelContraseña.Xalign = 0F;
			this.labelContraseña.LabelProp = global::Mono.Unix.Catalog.GetString ("Contraseña:");
			this.alignment63.Add (this.labelContraseña);
			this.table2.Add (this.alignment63);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table2 [this.alignment63]));
			w20.TopAttach = ((uint)(3));
			w20.BottomAttach = ((uint)(4));
			w20.LeftAttach = ((uint)(1));
			w20.RightAttach = ((uint)(2));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.alignment64 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment64.Name = "alignment64";
			this.table2.Add (this.alignment64);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table2 [this.alignment64]));
			w21.TopAttach = ((uint)(3));
			w21.BottomAttach = ((uint)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.alignment68 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment68.Name = "alignment68";
			this.table2.Add (this.alignment68);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table2 [this.alignment68]));
			w22.TopAttach = ((uint)(4));
			w22.BottomAttach = ((uint)(5));
			w22.LeftAttach = ((uint)(2));
			w22.RightAttach = ((uint)(3));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.alignment69 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment69.Name = "alignment69";
			// Container child alignment69.Gtk.Container+ContainerChild
			this.entryClave = new global::Gtk.Entry ();
			this.entryClave.CanFocus = true;
			this.entryClave.Name = "entryClave";
			this.entryClave.IsEditable = true;
			this.entryClave.Visibility = false;
			this.entryClave.InvisibleChar = '●';
			this.alignment69.Add (this.entryClave);
			this.table2.Add (this.alignment69);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table2 [this.alignment69]));
			w24.TopAttach = ((uint)(4));
			w24.BottomAttach = ((uint)(5));
			w24.LeftAttach = ((uint)(1));
			w24.RightAttach = ((uint)(2));
			w24.XOptions = ((global::Gtk.AttachOptions)(4));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.alignment70 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment70.Name = "alignment70";
			this.table2.Add (this.alignment70);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table2 [this.alignment70]));
			w25.TopAttach = ((uint)(4));
			w25.BottomAttach = ((uint)(5));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.entryUsuario = new global::Gtk.Entry ();
			this.entryUsuario.CanFocus = true;
			this.entryUsuario.Name = "entryUsuario";
			this.entryUsuario.IsEditable = true;
			this.entryUsuario.InvisibleChar = '●';
			this.table2.Add (this.entryUsuario);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.table2 [this.entryUsuario]));
			w26.TopAttach = ((uint)(2));
			w26.BottomAttach = ((uint)(3));
			w26.LeftAttach = ((uint)(1));
			w26.RightAttach = ((uint)(2));
			w26.XOptions = ((global::Gtk.AttachOptions)(4));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			this.hbox2.BorderWidth = ((uint)(24));
			// Container child hbox2.Gtk.Box+BoxChild
			this.alignment66 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment66.Name = "alignment66";
			// Container child alignment66.Gtk.Container+ContainerChild
			this.buttonIngresar = new global::Gtk.Button ();
			this.buttonIngresar.CanFocus = true;
			this.buttonIngresar.Name = "buttonIngresar";
			this.buttonIngresar.UseUnderline = true;
			this.buttonIngresar.Label = global::Mono.Unix.Catalog.GetString ("Ingresar");
			this.alignment66.Add (this.buttonIngresar);
			this.hbox2.Add (this.alignment66);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.alignment66]));
			w28.Position = 0;
			w28.Expand = false;
			w28.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.alignment67 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment67.Name = "alignment67";
			// Container child alignment67.Gtk.Container+ContainerChild
			this.BotonSalir = new global::Gtk.Button ();
			this.BotonSalir.CanFocus = true;
			this.BotonSalir.Name = "BotonSalir";
			this.BotonSalir.UseUnderline = true;
			this.BotonSalir.Label = global::Mono.Unix.Catalog.GetString ("   Salir   ");
			this.alignment67.Add (this.BotonSalir);
			this.hbox2.Add (this.alignment67);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.alignment67]));
			w30.Position = 1;
			w30.Expand = false;
			w30.Fill = false;
			this.table2.Add (this.hbox2);
			global::Gtk.Table.TableChild w31 = ((global::Gtk.Table.TableChild)(this.table2 [this.hbox2]));
			w31.TopAttach = ((uint)(5));
			w31.BottomAttach = ((uint)(6));
			w31.LeftAttach = ((uint)(1));
			w31.RightAttach = ((uint)(2));
			w31.XOptions = ((global::Gtk.AttachOptions)(4));
			w31.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.labelUsuario = new global::Gtk.Label ();
			this.labelUsuario.Name = "labelUsuario";
			this.labelUsuario.Xalign = 0F;
			this.labelUsuario.LabelProp = global::Mono.Unix.Catalog.GetString ("Usuario:");
			this.table2.Add (this.labelUsuario);
			global::Gtk.Table.TableChild w32 = ((global::Gtk.Table.TableChild)(this.table2 [this.labelUsuario]));
			w32.TopAttach = ((uint)(1));
			w32.BottomAttach = ((uint)(2));
			w32.LeftAttach = ((uint)(1));
			w32.RightAttach = ((uint)(2));
			w32.XOptions = ((global::Gtk.AttachOptions)(4));
			w32.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox3.Add (this.table2);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.table2]));
			w33.Position = 0;
			w1.Add (this.vbox3);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(w1 [this.vbox3]));
			w34.Position = 0;
			// Internal child punto.gui.IniciarSesionDialog.ActionArea
			global::Gtk.HButtonBox w35 = this.ActionArea;
			w35.Name = "__gtksharp_70_Stetic_TopLevelDialog_ActionArea";
			// Container child __gtksharp_70_Stetic_TopLevelDialog_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.button1218 = new global::Gtk.Button ();
			this.button1218.CanFocus = true;
			this.button1218.Name = "button1218";
			this.button1218.UseUnderline = true;
			this.button1218.Label = global::Mono.Unix.Catalog.GetString ("GtkButton");
			this.AddActionWidget (this.button1218, 0);
			global::Gtk.ButtonBox.ButtonBoxChild w36 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w35 [this.button1218]));
			w36.Expand = false;
			w36.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.button1218.Hide ();
			w35.Hide ();
			this.Show ();
			this.buttonIngresar.Clicked += new global::System.EventHandler (this.OnButtonIngresarClicked);
			this.BotonSalir.Clicked += new global::System.EventHandler (this.OnBotonSalirClicked);
		}
	}
}
