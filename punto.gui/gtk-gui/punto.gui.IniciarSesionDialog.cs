
// This file has been generated by the GUI designer. Do not modify.
namespace punto.gui
{
	public partial class IniciarSesionDialog
	{
		private global::Gtk.VBox vbox3;
		private global::Gtk.Table table2;
		private global::Gtk.Alignment alignment57;
		private global::Gtk.Alignment alignment59;
		private global::Gtk.Alignment alignment58;
		private global::Gtk.Alignment alignment60;
		private global::Gtk.Alignment alignment61;
		private global::Gtk.Alignment alignment62;
		private global::Gtk.HBox hbox2;
		private global::Gtk.Alignment alignment66;
		private global::Gtk.Button button505;
		private global::Gtk.Alignment alignment67;
		private global::Gtk.Button button590;
		private global::Gtk.Alignment alignment63;
		private global::Gtk.Alignment alignment64;
		private global::Gtk.Alignment alignment65;
		private global::Gtk.Alignment alignment68;
		private global::Gtk.Alignment alignment69;
		private global::Gtk.Alignment alignment70;
		private global::Gtk.Alignment alignment71;
		private global::Gtk.Entry entry3;
		private global::Gtk.Entry entry4;
		private global::Gtk.Label label3;
		private global::Gtk.Label label4;
		private global::Gtk.Button buttonCancel;
		private global::Gtk.Button buttonOk;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget punto.gui.IniciarSesionDialog
			this.Name = "punto.gui.IniciarSesionDialog";
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			// Internal child punto.gui.IniciarSesionDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.table2 = new global::Gtk.Table (((uint)(5)), ((uint)(4)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			// Container child table2.Gtk.Table+TableChild
			this.alignment57 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment57.Name = "alignment57";
			// Container child alignment57.Gtk.Container+ContainerChild
			this.alignment59 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment59.Name = "alignment59";
			this.alignment57.Add (this.alignment59);
			this.table2.Add (this.alignment57);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table2 [this.alignment57]));
			w3.LeftAttach = ((uint)(2));
			w3.RightAttach = ((uint)(3));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.alignment58 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment58.Name = "alignment58";
			this.table2.Add (this.alignment58);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table2 [this.alignment58]));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.alignment60 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment60.Name = "alignment60";
			this.table2.Add (this.alignment60);
			// Container child table2.Gtk.Table+TableChild
			this.alignment61 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment61.Name = "alignment61";
			this.table2.Add (this.alignment61);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table2 [this.alignment61]));
			w6.LeftAttach = ((uint)(3));
			w6.RightAttach = ((uint)(4));
			// Container child table2.Gtk.Table+TableChild
			this.alignment62 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment62.Name = "alignment62";
			// Container child alignment62.Gtk.Container+ContainerChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.alignment66 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment66.Name = "alignment66";
			// Container child alignment66.Gtk.Container+ContainerChild
			this.button505 = new global::Gtk.Button ();
			this.button505.CanFocus = true;
			this.button505.Name = "button505";
			this.button505.UseUnderline = true;
			this.button505.Label = global::Mono.Unix.Catalog.GetString ("Ingresar");
			this.alignment66.Add (this.button505);
			this.hbox2.Add (this.alignment66);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.alignment66]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.alignment67 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment67.Name = "alignment67";
			// Container child alignment67.Gtk.Container+ContainerChild
			this.button590 = new global::Gtk.Button ();
			this.button590.CanFocus = true;
			this.button590.Name = "button590";
			this.button590.UseUnderline = true;
			this.button590.Label = global::Mono.Unix.Catalog.GetString ("   Salir   ");
			this.alignment67.Add (this.button590);
			this.hbox2.Add (this.alignment67);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.alignment67]));
			w10.Position = 1;
			w10.Expand = false;
			w10.Fill = false;
			this.alignment62.Add (this.hbox2);
			this.table2.Add (this.alignment62);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table2 [this.alignment62]));
			w12.TopAttach = ((uint)(3));
			w12.BottomAttach = ((uint)(4));
			w12.LeftAttach = ((uint)(2));
			w12.RightAttach = ((uint)(3));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.alignment63 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment63.Name = "alignment63";
			this.table2.Add (this.alignment63);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table2 [this.alignment63]));
			w13.TopAttach = ((uint)(3));
			w13.BottomAttach = ((uint)(4));
			w13.LeftAttach = ((uint)(1));
			w13.RightAttach = ((uint)(2));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.alignment64 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment64.Name = "alignment64";
			this.table2.Add (this.alignment64);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table2 [this.alignment64]));
			w14.TopAttach = ((uint)(3));
			w14.BottomAttach = ((uint)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.alignment65 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment65.Name = "alignment65";
			this.table2.Add (this.alignment65);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table2 [this.alignment65]));
			w15.TopAttach = ((uint)(3));
			w15.BottomAttach = ((uint)(4));
			w15.LeftAttach = ((uint)(3));
			w15.RightAttach = ((uint)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.alignment68 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment68.Name = "alignment68";
			this.table2.Add (this.alignment68);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table2 [this.alignment68]));
			w16.TopAttach = ((uint)(4));
			w16.BottomAttach = ((uint)(5));
			w16.LeftAttach = ((uint)(2));
			w16.RightAttach = ((uint)(3));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.alignment69 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment69.Name = "alignment69";
			this.table2.Add (this.alignment69);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table2 [this.alignment69]));
			w17.TopAttach = ((uint)(4));
			w17.BottomAttach = ((uint)(5));
			w17.LeftAttach = ((uint)(1));
			w17.RightAttach = ((uint)(2));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.alignment70 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment70.Name = "alignment70";
			this.table2.Add (this.alignment70);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table2 [this.alignment70]));
			w18.TopAttach = ((uint)(4));
			w18.BottomAttach = ((uint)(5));
			// Container child table2.Gtk.Table+TableChild
			this.alignment71 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment71.Name = "alignment71";
			this.table2.Add (this.alignment71);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table2 [this.alignment71]));
			w19.TopAttach = ((uint)(4));
			w19.BottomAttach = ((uint)(5));
			w19.LeftAttach = ((uint)(3));
			w19.RightAttach = ((uint)(4));
			// Container child table2.Gtk.Table+TableChild
			this.entry3 = new global::Gtk.Entry ();
			this.entry3.CanFocus = true;
			this.entry3.Name = "entry3";
			this.entry3.IsEditable = true;
			this.entry3.InvisibleChar = '●';
			this.table2.Add (this.entry3);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table2 [this.entry3]));
			w20.TopAttach = ((uint)(1));
			w20.BottomAttach = ((uint)(2));
			w20.LeftAttach = ((uint)(2));
			w20.RightAttach = ((uint)(3));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.entry4 = new global::Gtk.Entry ();
			this.entry4.CanFocus = true;
			this.entry4.Name = "entry4";
			this.entry4.IsEditable = true;
			this.entry4.Visibility = false;
			this.entry4.InvisibleChar = '●';
			this.table2.Add (this.entry4);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table2 [this.entry4]));
			w21.TopAttach = ((uint)(2));
			w21.BottomAttach = ((uint)(3));
			w21.LeftAttach = ((uint)(2));
			w21.RightAttach = ((uint)(3));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Usuario:");
			this.table2.Add (this.label3);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table2 [this.label3]));
			w22.TopAttach = ((uint)(1));
			w22.BottomAttach = ((uint)(2));
			w22.LeftAttach = ((uint)(1));
			w22.RightAttach = ((uint)(2));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Xalign = 0F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Clave:");
			this.table2.Add (this.label4);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table2 [this.label4]));
			w23.TopAttach = ((uint)(2));
			w23.BottomAttach = ((uint)(3));
			w23.LeftAttach = ((uint)(1));
			w23.RightAttach = ((uint)(2));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox3.Add (this.table2);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.table2]));
			w24.Position = 0;
			w1.Add (this.vbox3);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(w1 [this.vbox3]));
			w25.Position = 0;
			// Internal child punto.gui.IniciarSesionDialog.ActionArea
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
			this.button505.Clicked += new global::System.EventHandler (this.OnButton505Clicked);
		}
	}
}
