
// This file has been generated by the GUI designer. Do not modify.
namespace punto.gui
{
	public partial class VenderProductosDialog
	{
		private global::Gtk.HBox hbox1;
		private global::Gtk.HPaned hpaned12;
		private global::Gtk.VBox vbox5;
		private global::Gtk.HBox hbox4;
		private global::Gtk.Image image2;
		private global::Gtk.HBox hbox5;
		private global::Gtk.VBox vbox2;
		private global::Gtk.Entry entry1;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TreeView treeview2;
		private global::Gtk.Button button81;
		private global::Gtk.VBox vbox3;
		private global::Gtk.Label label1;
		private global::Gtk.HBox hbox3;
		private global::Gtk.Entry entry2;
		private global::Gtk.Button button85;
		private global::Gtk.VBox vbox4;
		private global::Gtk.Label label8;
		private global::Gtk.VPaned vpaned3;
		private global::Gtk.HBox hbox2;
		private global::Gtk.Label label5;
		private global::Gtk.Label label6;
		private global::Gtk.Button button790;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget punto.gui.VenderProductosDialog
			this.Name = "punto.gui.VenderProductosDialog";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
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
			// Container child hpaned12.Gtk.Paned+PanedChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.image2 = new global::Gtk.Image ();
			this.image2.Name = "image2";
			this.image2.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-missing-image", global::Gtk.IconSize.Menu);
			this.hbox4.Add (this.image2);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.image2]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			this.vbox5.Add (this.hbox4);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.hbox4]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox ();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			this.vbox5.Add (this.hbox5);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.hbox5]));
			w4.Position = 2;
			this.hpaned12.Add (this.vbox5);
			this.hbox1.Add (this.hpaned12);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.hpaned12]));
			w6.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.entry1 = new global::Gtk.Entry ();
			this.entry1.CanFocus = true;
			this.entry1.Name = "entry1";
			this.entry1.IsEditable = true;
			this.entry1.InvisibleChar = '●';
			this.vbox2.Add (this.entry1);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.entry1]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.treeview2 = new global::Gtk.TreeView ();
			this.treeview2.CanFocus = true;
			this.treeview2.Name = "treeview2";
			this.GtkScrolledWindow.Add (this.treeview2);
			this.vbox2.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.GtkScrolledWindow]));
			w9.Position = 1;
			// Container child vbox2.Gtk.Box+BoxChild
			this.button81 = new global::Gtk.Button ();
			this.button81.CanFocus = true;
			this.button81.Name = "button81";
			this.button81.UseUnderline = true;
			this.button81.Label = global::Mono.Unix.Catalog.GetString ("Vender");
			this.vbox2.Add (this.button81);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.button81]));
			w10.Position = 2;
			w10.Expand = false;
			w10.Fill = false;
			this.hbox1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox2]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Nº Boleta");
			this.vbox3.Add (this.label1);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.label1]));
			w12.Position = 0;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.entry2 = new global::Gtk.Entry ();
			this.entry2.CanFocus = true;
			this.entry2.Name = "entry2";
			this.entry2.IsEditable = false;
			this.entry2.InvisibleChar = '●';
			this.hbox3.Add (this.entry2);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.entry2]));
			w13.Position = 0;
			// Container child hbox3.Gtk.Box+BoxChild
			this.button85 = new global::Gtk.Button ();
			this.button85.CanFocus = true;
			this.button85.Name = "button85";
			this.button85.UseUnderline = true;
			// Container child button85.Gtk.Container+ContainerChild
			global::Gtk.Alignment w14 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w15 = new global::Gtk.HBox ();
			w15.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w16 = new global::Gtk.Image ();
			w16.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-edit", global::Gtk.IconSize.Menu);
			w15.Add (w16);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w18 = new global::Gtk.Label ();
			w18.LabelProp = global::Mono.Unix.Catalog.GetString ("Edit");
			w18.UseUnderline = true;
			w15.Add (w18);
			w14.Add (w15);
			this.button85.Add (w14);
			this.hbox3.Add (this.button85);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.button85]));
			w22.Position = 1;
			w22.Expand = false;
			w22.Fill = false;
			this.vbox3.Add (this.hbox3);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox3]));
			w23.Position = 1;
			w23.Expand = false;
			w23.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.label8 = new global::Gtk.Label ();
			this.label8.Name = "label8";
			this.vbox4.Add (this.label8);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.label8]));
			w24.Position = 0;
			w24.Expand = false;
			w24.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.vpaned3 = new global::Gtk.VPaned ();
			this.vpaned3.CanFocus = true;
			this.vpaned3.Name = "vpaned3";
			this.vpaned3.Position = 10;
			this.vbox4.Add (this.vpaned3);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.vpaned3]));
			w25.Position = 1;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Total:");
			this.hbox2.Add (this.label5);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.label5]));
			w26.Position = 0;
			w26.Expand = false;
			w26.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("0");
			this.hbox2.Add (this.label6);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.label6]));
			w27.Position = 1;
			w27.Expand = false;
			w27.Fill = false;
			this.vbox4.Add (this.hbox2);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox2]));
			w28.Position = 2;
			w28.Expand = false;
			w28.Fill = false;
			this.vbox3.Add (this.vbox4);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.vbox4]));
			w29.Position = 2;
			this.hbox1.Add (this.vbox3);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox3]));
			w30.Position = 2;
			w30.Expand = false;
			w30.Fill = false;
			w1.Add (this.hbox1);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(w1 [this.hbox1]));
			w31.Position = 0;
			// Internal child punto.gui.VenderProductosDialog.ActionArea
			global::Gtk.HButtonBox w32 = this.ActionArea;
			w32.Name = "__gtksharp_56_Stetic_TopLevelDialog_ActionArea";
			// Container child __gtksharp_56_Stetic_TopLevelDialog_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.button790 = new global::Gtk.Button ();
			this.button790.CanFocus = true;
			this.button790.Name = "button790";
			this.button790.UseUnderline = true;
			this.button790.Label = global::Mono.Unix.Catalog.GetString ("GtkButton");
			this.AddActionWidget (this.button790, 0);
			global::Gtk.ButtonBox.ButtonBoxChild w33 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w32 [this.button790]));
			w33.Expand = false;
			w33.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 709;
			this.DefaultHeight = 418;
			w32.Hide ();
			this.Hide ();
			this.entry1.TextInserted += new global::Gtk.TextInsertedHandler (this.OnEntry1TextInserted);
			this.entry1.EditingDone += new global::System.EventHandler (this.OnEntry1EditingDone);
			this.entry1.KeyPressEvent += new global::Gtk.KeyPressEventHandler (this.OnEntry1KeyPressEvent);
			this.button81.Clicked += new global::System.EventHandler (this.OnButton81Clicked);
			this.entry2.TextInserted += new global::Gtk.TextInsertedHandler (this.OnEntry2TextInserted);
			this.button85.Clicked += new global::System.EventHandler (this.OnButton85Clicked);
		}
	}
}
