
// This file has been generated by the GUI designer. Do not modify.
namespace punto.gui
{
	public partial class EditarNumBoletaDialog
	{
		private global::Gtk.VBox vbox2;
		private global::Gtk.Alignment alignment4;
		private global::Gtk.Frame frame2;
		private global::Gtk.VBox vbox3;
		private global::Gtk.Alignment alignment13;
		private global::Gtk.Alignment alignment10;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Alignment alignment5;
		private global::Gtk.Label labelNumBoleta;
		private global::Gtk.Entry entryNumBoleta;
		private global::Gtk.Button buttonEditarNumBoleta;
		private global::Gtk.Alignment alignment6;
		private global::Gtk.Alignment alignment11;
		private global::Gtk.Alignment alignment12;
		private global::Gtk.Label GtkLabel3;
		private global::Gtk.Alignment alignment14;
		private global::Gtk.Button buttonCancel;
		private global::Gtk.Button buttonOk;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget punto.gui.EditarNumBoletaDialog
			this.Name = "punto.gui.EditarNumBoletaDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Editar Número Boleta");
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			// Internal child punto.gui.EditarNumBoletaDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.alignment4 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment4.Name = "alignment4";
			this.vbox2.Add (this.alignment4);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.alignment4]));
			w2.Position = 0;
			// Container child vbox2.Gtk.Box+BoxChild
			this.frame2 = new global::Gtk.Frame ();
			this.frame2.Name = "frame2";
			this.frame2.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child frame2.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.alignment13 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment13.Name = "alignment13";
			this.vbox3.Add (this.alignment13);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.alignment13]));
			w3.Position = 0;
			// Container child vbox3.Gtk.Box+BoxChild
			this.alignment10 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment10.Name = "alignment10";
			this.vbox3.Add (this.alignment10);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.alignment10]));
			w4.Position = 1;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.alignment5 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment5.Name = "alignment5";
			this.hbox1.Add (this.alignment5);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.alignment5]));
			w5.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.labelNumBoleta = new global::Gtk.Label ();
			this.labelNumBoleta.Name = "labelNumBoleta";
			this.labelNumBoleta.LabelProp = global::Mono.Unix.Catalog.GetString ("Número Boleta: ");
			this.hbox1.Add (this.labelNumBoleta);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.labelNumBoleta]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.entryNumBoleta = new global::Gtk.Entry ();
			this.entryNumBoleta.CanFocus = true;
			this.entryNumBoleta.Name = "entryNumBoleta";
			this.entryNumBoleta.IsEditable = true;
			this.entryNumBoleta.InvisibleChar = '●';
			this.hbox1.Add (this.entryNumBoleta);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.entryNumBoleta]));
			w7.Position = 2;
			w7.Expand = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonEditarNumBoleta = new global::Gtk.Button ();
			this.buttonEditarNumBoleta.CanFocus = true;
			this.buttonEditarNumBoleta.Name = "buttonEditarNumBoleta";
			this.buttonEditarNumBoleta.UseUnderline = true;
			this.buttonEditarNumBoleta.Label = global::Mono.Unix.Catalog.GetString ("Editar");
			this.hbox1.Add (this.buttonEditarNumBoleta);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonEditarNumBoleta]));
			w8.Position = 3;
			w8.Expand = false;
			w8.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.alignment6 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment6.Name = "alignment6";
			this.hbox1.Add (this.alignment6);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.alignment6]));
			w9.Position = 4;
			this.vbox3.Add (this.hbox1);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox1]));
			w10.Position = 2;
			w10.Expand = false;
			w10.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.alignment11 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment11.Name = "alignment11";
			this.vbox3.Add (this.alignment11);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.alignment11]));
			w11.Position = 3;
			// Container child vbox3.Gtk.Box+BoxChild
			this.alignment12 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment12.Name = "alignment12";
			this.vbox3.Add (this.alignment12);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.alignment12]));
			w12.Position = 4;
			this.frame2.Add (this.vbox3);
			this.GtkLabel3 = new global::Gtk.Label ();
			this.GtkLabel3.Name = "GtkLabel3";
			this.GtkLabel3.LabelProp = global::Mono.Unix.Catalog.GetString ("Ingrese nuevo número de boleta");
			this.GtkLabel3.UseMarkup = true;
			this.frame2.LabelWidget = this.GtkLabel3;
			this.vbox2.Add (this.frame2);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.frame2]));
			w14.Position = 1;
			w1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(w1 [this.vbox2]));
			w15.Position = 0;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.alignment14 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment14.Name = "alignment14";
			w1.Add (this.alignment14);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(w1 [this.alignment14]));
			w16.Position = 1;
			// Internal child punto.gui.EditarNumBoletaDialog.ActionArea
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
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.Show ();
			this.buttonEditarNumBoleta.Clicked += new global::System.EventHandler (this.OnButtonEditarNumBoletaClicked);
		}
	}
}
