
// This file has been generated by the GUI designer. Do not modify.
namespace punto.gui
{
	public partial class EditarProductoDialog
	{
		private global::Gtk.Frame frame3;
		private global::Gtk.Alignment GtkAlignment2;
		private global::Gtk.VBox vbox3;
		private global::Gtk.HBox hbox3;
		private global::Gtk.Label label3;
		private global::Gtk.Entry entry4;
		private global::Gtk.Button EditarButton;
		private global::Gtk.HBox hbox4;
		private global::Gtk.Label label4;
		private global::Gtk.Entry entry5;
		private global::Gtk.Label GtkLabel2;
		private global::Gtk.Button buttonCancel;
		private global::Gtk.Button buttonOk;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget punto.gui.EditarProductoDialog
			this.Name = "punto.gui.EditarProductoDialog";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child punto.gui.EditarProductoDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.frame3 = new global::Gtk.Frame ();
			this.frame3.Name = "frame3";
			this.frame3.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame3.Gtk.Container+ContainerChild
			this.GtkAlignment2 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment2.Name = "GtkAlignment2";
			this.GtkAlignment2.LeftPadding = ((uint)(12));
			// Container child GtkAlignment2.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("label3");
			this.hbox3.Add (this.label3);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.label3]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.entry4 = new global::Gtk.Entry ();
			this.entry4.CanFocus = true;
			this.entry4.Name = "entry4";
			this.entry4.IsEditable = true;
			this.entry4.InvisibleChar = '●';
			this.hbox3.Add (this.entry4);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.entry4]));
			w3.Position = 1;
			// Container child hbox3.Gtk.Box+BoxChild
			this.EditarButton = new global::Gtk.Button ();
			this.EditarButton.CanFocus = true;
			this.EditarButton.Name = "EditarButton";
			this.EditarButton.UseUnderline = true;
			this.EditarButton.Label = global::Mono.Unix.Catalog.GetString ("Editar");
			this.hbox3.Add (this.EditarButton);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.EditarButton]));
			w4.Position = 2;
			w4.Expand = false;
			w4.Fill = false;
			this.vbox3.Add (this.hbox3);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox3]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("label4");
			this.hbox4.Add (this.label4);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.label4]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.entry5 = new global::Gtk.Entry ();
			this.entry5.CanFocus = true;
			this.entry5.Name = "entry5";
			this.entry5.IsEditable = true;
			this.entry5.InvisibleChar = '●';
			this.hbox4.Add (this.entry5);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.entry5]));
			w7.Position = 1;
			this.vbox3.Add (this.hbox4);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox4]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			this.GtkAlignment2.Add (this.vbox3);
			this.frame3.Add (this.GtkAlignment2);
			this.GtkLabel2 = new global::Gtk.Label ();
			this.GtkLabel2.Name = "GtkLabel2";
			this.GtkLabel2.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>GtkFrame</b>");
			this.GtkLabel2.UseMarkup = true;
			this.frame3.LabelWidget = this.GtkLabel2;
			w1.Add (this.frame3);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(w1 [this.frame3]));
			w11.Position = 0;
			// Internal child punto.gui.EditarProductoDialog.ActionArea
			global::Gtk.HButtonBox w12 = this.ActionArea;
			w12.Name = "dialog1_ActionArea";
			w12.Spacing = 10;
			w12.BorderWidth = ((uint)(5));
			w12.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w13 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w12 [this.buttonCancel]));
			w13.Expand = false;
			w13.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w14 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w12 [this.buttonOk]));
			w14.Position = 1;
			w14.Expand = false;
			w14.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.Show ();
			this.EditarButton.Clicked += new global::System.EventHandler (this.OnEditarButtonClicked);
		}
	}
}
