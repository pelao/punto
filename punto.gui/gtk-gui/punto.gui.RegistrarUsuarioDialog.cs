
// This file has been generated by the GUI designer. Do not modify.
namespace punto.gui
{
	public partial class RegistrarUsuarioDialog
	{
		private global::Gtk.Notebook notebook1;
		private global::Gtk.VBox vbox3;
		private global::Gtk.Alignment alignment3;
		private global::Gtk.VBox vbox6;
		private global::Gtk.Table table1;
		private global::Gtk.ComboBox comboboxTipoUsuario;
		private global::Gtk.Entry entryApellidos;
		private global::Gtk.Entry entryContraseña;
		private global::Gtk.Entry entryNombre;
		private global::Gtk.Entry entryNombreUsuario;
		private global::Gtk.Entry entryRut;
		private global::Gtk.Entry entryTelefono;
		private global::Gtk.Label label21;
		private global::Gtk.Label LabelApellidos;
		private global::Gtk.Label LabelContraseña;
		private global::Gtk.Label LabelNombre;
		private global::Gtk.Label LabelNombreUsuario;
		private global::Gtk.Label LabelRut;
		private global::Gtk.Label LabelTipoUsuario;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Label label5;
		private global::Gtk.Button BotonAgregar;
		private global::Gtk.Button BotonCancelar;
		private global::Gtk.Label label6;
		private global::Gtk.Label LabelRegistrarUsuario;
		private global::Gtk.VBox vbox4;
		private global::Gtk.Alignment alignment4;
		private global::Gtk.VBox vbox7;
		private global::Gtk.Table table2;
		private global::Gtk.ComboBox comboboxTipoUsuarioMod;
		private global::Gtk.ComboBox comboboxUsuarioModificar;
		private global::Gtk.Entry entryApellidosEdit;
		private global::Gtk.Entry entryContraseñaEdit;
		private global::Gtk.Entry entryNombreEdit;
		private global::Gtk.Entry entryRutEdit;
		private global::Gtk.Entry entryTelefonoEdit;
		private global::Gtk.Entry entryUsuarioEdit;
		private global::Gtk.Label LabelApellidosMod;
		private global::Gtk.Label LabelContraseñaMod;
		private global::Gtk.Label labelNombreEdit;
		private global::Gtk.Label LabelNombreMod;
		private global::Gtk.Label LabelRutMod;
		private global::Gtk.Label LabelTelefonoMod;
		private global::Gtk.Label LabelTipoUsuarioMod;
		private global::Gtk.Label LabelUsuarioMod;
		private global::Gtk.HBox hbox2;
		private global::Gtk.Label label1;
		private global::Gtk.Button BotonModificar;
		private global::Gtk.Button BotonCancelarMod;
		private global::Gtk.Label label2;
		private global::Gtk.Label LabelModificarUsuario;
		private global::Gtk.Button buttonCancel;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget punto.gui.RegistrarUsuarioDialog
			this.Name = "punto.gui.RegistrarUsuarioDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Registrar/Modificar Usuario");
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			// Internal child punto.gui.RegistrarUsuarioDialog.VBox
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
			this.alignment3 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment3.Name = "alignment3";
			// Container child alignment3.Gtk.Container+ContainerChild
			this.vbox6 = new global::Gtk.VBox ();
			this.vbox6.Name = "vbox6";
			this.vbox6.Spacing = 6;
			// Container child vbox6.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table (((uint)(7)), ((uint)(2)), true);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			this.table1.BorderWidth = ((uint)(7));
			// Container child table1.Gtk.Table+TableChild
			this.comboboxTipoUsuario = global::Gtk.ComboBox.NewText ();
			this.comboboxTipoUsuario.Name = "comboboxTipoUsuario";
			this.table1.Add (this.comboboxTipoUsuario);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1 [this.comboboxTipoUsuario]));
			w2.TopAttach = ((uint)(6));
			w2.BottomAttach = ((uint)(7));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryApellidos = new global::Gtk.Entry ();
			this.entryApellidos.CanFocus = true;
			this.entryApellidos.Name = "entryApellidos";
			this.entryApellidos.IsEditable = true;
			this.entryApellidos.InvisibleChar = '●';
			this.table1.Add (this.entryApellidos);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryApellidos]));
			w3.TopAttach = ((uint)(2));
			w3.BottomAttach = ((uint)(3));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryContraseña = new global::Gtk.Entry ();
			this.entryContraseña.CanFocus = true;
			this.entryContraseña.Name = "entryContraseña";
			this.entryContraseña.IsEditable = true;
			this.entryContraseña.Visibility = false;
			this.entryContraseña.InvisibleChar = '●';
			this.table1.Add (this.entryContraseña);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryContraseña]));
			w4.TopAttach = ((uint)(5));
			w4.BottomAttach = ((uint)(6));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryNombre = new global::Gtk.Entry ();
			this.entryNombre.CanFocus = true;
			this.entryNombre.Name = "entryNombre";
			this.entryNombre.IsEditable = true;
			this.entryNombre.InvisibleChar = '●';
			this.table1.Add (this.entryNombre);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryNombre]));
			w5.TopAttach = ((uint)(1));
			w5.BottomAttach = ((uint)(2));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(2));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryNombreUsuario = new global::Gtk.Entry ();
			this.entryNombreUsuario.CanFocus = true;
			this.entryNombreUsuario.Name = "entryNombreUsuario";
			this.entryNombreUsuario.IsEditable = true;
			this.entryNombreUsuario.InvisibleChar = '●';
			this.table1.Add (this.entryNombreUsuario);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryNombreUsuario]));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryRut = new global::Gtk.Entry ();
			this.entryRut.CanFocus = true;
			this.entryRut.Name = "entryRut";
			this.entryRut.IsEditable = true;
			this.entryRut.InvisibleChar = '●';
			this.table1.Add (this.entryRut);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryRut]));
			w7.TopAttach = ((uint)(4));
			w7.BottomAttach = ((uint)(5));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryTelefono = new global::Gtk.Entry ();
			this.entryTelefono.CanFocus = true;
			this.entryTelefono.Name = "entryTelefono";
			this.entryTelefono.IsEditable = true;
			this.entryTelefono.InvisibleChar = '●';
			this.table1.Add (this.entryTelefono);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryTelefono]));
			w8.TopAttach = ((uint)(3));
			w8.BottomAttach = ((uint)(4));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label21 = new global::Gtk.Label ();
			this.label21.Name = "label21";
			this.label21.Xalign = 0F;
			this.label21.LabelProp = global::Mono.Unix.Catalog.GetString ("     Telefono:");
			this.table1.Add (this.label21);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1 [this.label21]));
			w9.TopAttach = ((uint)(3));
			w9.BottomAttach = ((uint)(4));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.LabelApellidos = new global::Gtk.Label ();
			this.LabelApellidos.Name = "LabelApellidos";
			this.LabelApellidos.Xalign = 0F;
			this.LabelApellidos.LabelProp = global::Mono.Unix.Catalog.GetString ("     Apellidos:");
			this.table1.Add (this.LabelApellidos);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1 [this.LabelApellidos]));
			w10.TopAttach = ((uint)(2));
			w10.BottomAttach = ((uint)(3));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.LabelContraseña = new global::Gtk.Label ();
			this.LabelContraseña.Name = "LabelContraseña";
			this.LabelContraseña.Xalign = 0F;
			this.LabelContraseña.LabelProp = global::Mono.Unix.Catalog.GetString ("     Contraseña:");
			this.table1.Add (this.LabelContraseña);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1 [this.LabelContraseña]));
			w11.TopAttach = ((uint)(5));
			w11.BottomAttach = ((uint)(6));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.LabelNombre = new global::Gtk.Label ();
			this.LabelNombre.Name = "LabelNombre";
			this.LabelNombre.Xalign = 0F;
			this.LabelNombre.LabelProp = global::Mono.Unix.Catalog.GetString ("     Nombre:");
			this.table1.Add (this.LabelNombre);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1 [this.LabelNombre]));
			w12.TopAttach = ((uint)(1));
			w12.BottomAttach = ((uint)(2));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.LabelNombreUsuario = new global::Gtk.Label ();
			this.LabelNombreUsuario.Name = "LabelNombreUsuario";
			this.LabelNombreUsuario.Xalign = 0F;
			this.LabelNombreUsuario.LabelProp = global::Mono.Unix.Catalog.GetString ("     Nombre de Usuario: ");
			this.LabelNombreUsuario.Ellipsize = ((global::Pango.EllipsizeMode)(1));
			this.table1.Add (this.LabelNombreUsuario);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1 [this.LabelNombreUsuario]));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.LabelRut = new global::Gtk.Label ();
			this.LabelRut.Name = "LabelRut";
			this.LabelRut.Xalign = 0F;
			this.LabelRut.LabelProp = global::Mono.Unix.Catalog.GetString ("     Rut:");
			this.table1.Add (this.LabelRut);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table1 [this.LabelRut]));
			w14.TopAttach = ((uint)(4));
			w14.BottomAttach = ((uint)(5));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.LabelTipoUsuario = new global::Gtk.Label ();
			this.LabelTipoUsuario.Name = "LabelTipoUsuario";
			this.LabelTipoUsuario.Xalign = 0F;
			this.LabelTipoUsuario.LabelProp = global::Mono.Unix.Catalog.GetString ("     Tipo Usuario:");
			this.table1.Add (this.LabelTipoUsuario);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table1 [this.LabelTipoUsuario]));
			w15.TopAttach = ((uint)(6));
			w15.BottomAttach = ((uint)(7));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox6.Add (this.table1);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.table1]));
			w16.Position = 0;
			w16.Expand = false;
			w16.Fill = false;
			this.alignment3.Add (this.vbox6);
			this.vbox3.Add (this.alignment3);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.alignment3]));
			w18.Position = 1;
			w18.Expand = false;
			w18.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("              ");
			this.hbox1.Add (this.label5);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label5]));
			w19.Position = 0;
			w19.Expand = false;
			w19.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.BotonAgregar = new global::Gtk.Button ();
			this.BotonAgregar.CanFocus = true;
			this.BotonAgregar.Name = "BotonAgregar";
			this.BotonAgregar.UseUnderline = true;
			this.BotonAgregar.Label = global::Mono.Unix.Catalog.GetString ("Agregar");
			this.hbox1.Add (this.BotonAgregar);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.BotonAgregar]));
			w20.Position = 1;
			w20.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.BotonCancelar = new global::Gtk.Button ();
			this.BotonCancelar.CanFocus = true;
			this.BotonCancelar.Name = "BotonCancelar";
			this.BotonCancelar.UseUnderline = true;
			this.BotonCancelar.Label = global::Mono.Unix.Catalog.GetString ("Cancelar");
			this.hbox1.Add (this.BotonCancelar);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.BotonCancelar]));
			w21.Position = 2;
			w21.Expand = false;
			w21.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("                 ");
			this.hbox1.Add (this.label6);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label6]));
			w22.Position = 3;
			w22.Expand = false;
			w22.Fill = false;
			this.vbox3.Add (this.hbox1);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox1]));
			w23.Position = 3;
			w23.Expand = false;
			w23.Fill = false;
			this.notebook1.Add (this.vbox3);
			// Notebook tab
			this.LabelRegistrarUsuario = new global::Gtk.Label ();
			this.LabelRegistrarUsuario.Name = "LabelRegistrarUsuario";
			this.LabelRegistrarUsuario.LabelProp = global::Mono.Unix.Catalog.GetString ("Registrar Usuario");
			this.notebook1.SetTabLabel (this.vbox3, this.LabelRegistrarUsuario);
			this.LabelRegistrarUsuario.ShowAll ();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.alignment4 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment4.Name = "alignment4";
			// Container child alignment4.Gtk.Container+ContainerChild
			this.vbox7 = new global::Gtk.VBox ();
			this.vbox7.Name = "vbox7";
			this.vbox7.Spacing = 6;
			// Container child vbox7.Gtk.Box+BoxChild
			this.table2 = new global::Gtk.Table (((uint)(8)), ((uint)(2)), true);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			this.table2.BorderWidth = ((uint)(7));
			// Container child table2.Gtk.Table+TableChild
			this.comboboxTipoUsuarioMod = global::Gtk.ComboBox.NewText ();
			this.comboboxTipoUsuarioMod.Name = "comboboxTipoUsuarioMod";
			this.table2.Add (this.comboboxTipoUsuarioMod);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table2 [this.comboboxTipoUsuarioMod]));
			w25.TopAttach = ((uint)(7));
			w25.BottomAttach = ((uint)(8));
			w25.LeftAttach = ((uint)(1));
			w25.RightAttach = ((uint)(2));
			w25.XOptions = ((global::Gtk.AttachOptions)(4));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.comboboxUsuarioModificar = global::Gtk.ComboBox.NewText ();
			this.comboboxUsuarioModificar.Name = "comboboxUsuarioModificar";
			this.table2.Add (this.comboboxUsuarioModificar);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.table2 [this.comboboxUsuarioModificar]));
			w26.LeftAttach = ((uint)(1));
			w26.RightAttach = ((uint)(2));
			w26.XOptions = ((global::Gtk.AttachOptions)(4));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.entryApellidosEdit = new global::Gtk.Entry ();
			this.entryApellidosEdit.CanFocus = true;
			this.entryApellidosEdit.Name = "entryApellidosEdit";
			this.entryApellidosEdit.IsEditable = true;
			this.entryApellidosEdit.InvisibleChar = '●';
			this.table2.Add (this.entryApellidosEdit);
			global::Gtk.Table.TableChild w27 = ((global::Gtk.Table.TableChild)(this.table2 [this.entryApellidosEdit]));
			w27.TopAttach = ((uint)(3));
			w27.BottomAttach = ((uint)(4));
			w27.LeftAttach = ((uint)(1));
			w27.RightAttach = ((uint)(2));
			w27.XOptions = ((global::Gtk.AttachOptions)(4));
			w27.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.entryContraseñaEdit = new global::Gtk.Entry ();
			this.entryContraseñaEdit.CanFocus = true;
			this.entryContraseñaEdit.Name = "entryContraseñaEdit";
			this.entryContraseñaEdit.IsEditable = true;
			this.entryContraseñaEdit.InvisibleChar = '●';
			this.table2.Add (this.entryContraseñaEdit);
			global::Gtk.Table.TableChild w28 = ((global::Gtk.Table.TableChild)(this.table2 [this.entryContraseñaEdit]));
			w28.TopAttach = ((uint)(6));
			w28.BottomAttach = ((uint)(7));
			w28.LeftAttach = ((uint)(1));
			w28.RightAttach = ((uint)(2));
			w28.XOptions = ((global::Gtk.AttachOptions)(4));
			w28.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.entryNombreEdit = new global::Gtk.Entry ();
			this.entryNombreEdit.CanFocus = true;
			this.entryNombreEdit.Name = "entryNombreEdit";
			this.entryNombreEdit.IsEditable = true;
			this.entryNombreEdit.InvisibleChar = '●';
			this.table2.Add (this.entryNombreEdit);
			global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.table2 [this.entryNombreEdit]));
			w29.TopAttach = ((uint)(2));
			w29.BottomAttach = ((uint)(3));
			w29.LeftAttach = ((uint)(1));
			w29.RightAttach = ((uint)(2));
			w29.XOptions = ((global::Gtk.AttachOptions)(4));
			w29.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.entryRutEdit = new global::Gtk.Entry ();
			this.entryRutEdit.CanFocus = true;
			this.entryRutEdit.Name = "entryRutEdit";
			this.entryRutEdit.IsEditable = true;
			this.entryRutEdit.InvisibleChar = '●';
			this.table2.Add (this.entryRutEdit);
			global::Gtk.Table.TableChild w30 = ((global::Gtk.Table.TableChild)(this.table2 [this.entryRutEdit]));
			w30.TopAttach = ((uint)(5));
			w30.BottomAttach = ((uint)(6));
			w30.LeftAttach = ((uint)(1));
			w30.RightAttach = ((uint)(2));
			w30.XOptions = ((global::Gtk.AttachOptions)(4));
			w30.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.entryTelefonoEdit = new global::Gtk.Entry ();
			this.entryTelefonoEdit.CanFocus = true;
			this.entryTelefonoEdit.Name = "entryTelefonoEdit";
			this.entryTelefonoEdit.IsEditable = true;
			this.entryTelefonoEdit.InvisibleChar = '●';
			this.table2.Add (this.entryTelefonoEdit);
			global::Gtk.Table.TableChild w31 = ((global::Gtk.Table.TableChild)(this.table2 [this.entryTelefonoEdit]));
			w31.TopAttach = ((uint)(4));
			w31.BottomAttach = ((uint)(5));
			w31.LeftAttach = ((uint)(1));
			w31.RightAttach = ((uint)(2));
			w31.XOptions = ((global::Gtk.AttachOptions)(4));
			w31.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.entryUsuarioEdit = new global::Gtk.Entry ();
			this.entryUsuarioEdit.CanFocus = true;
			this.entryUsuarioEdit.Name = "entryUsuarioEdit";
			this.entryUsuarioEdit.IsEditable = true;
			this.entryUsuarioEdit.InvisibleChar = '●';
			this.table2.Add (this.entryUsuarioEdit);
			global::Gtk.Table.TableChild w32 = ((global::Gtk.Table.TableChild)(this.table2 [this.entryUsuarioEdit]));
			w32.TopAttach = ((uint)(1));
			w32.BottomAttach = ((uint)(2));
			w32.LeftAttach = ((uint)(1));
			w32.RightAttach = ((uint)(2));
			w32.XOptions = ((global::Gtk.AttachOptions)(4));
			w32.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.LabelApellidosMod = new global::Gtk.Label ();
			this.LabelApellidosMod.Name = "LabelApellidosMod";
			this.LabelApellidosMod.Xalign = 0F;
			this.LabelApellidosMod.LabelProp = global::Mono.Unix.Catalog.GetString ("    Apellidos:");
			this.table2.Add (this.LabelApellidosMod);
			global::Gtk.Table.TableChild w33 = ((global::Gtk.Table.TableChild)(this.table2 [this.LabelApellidosMod]));
			w33.TopAttach = ((uint)(3));
			w33.BottomAttach = ((uint)(4));
			w33.XOptions = ((global::Gtk.AttachOptions)(4));
			w33.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.LabelContraseñaMod = new global::Gtk.Label ();
			this.LabelContraseñaMod.Name = "LabelContraseñaMod";
			this.LabelContraseñaMod.Xalign = 0F;
			this.LabelContraseñaMod.LabelProp = global::Mono.Unix.Catalog.GetString ("    Contraseña:");
			this.table2.Add (this.LabelContraseñaMod);
			global::Gtk.Table.TableChild w34 = ((global::Gtk.Table.TableChild)(this.table2 [this.LabelContraseñaMod]));
			w34.TopAttach = ((uint)(6));
			w34.BottomAttach = ((uint)(7));
			w34.XOptions = ((global::Gtk.AttachOptions)(4));
			w34.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.labelNombreEdit = new global::Gtk.Label ();
			this.labelNombreEdit.Name = "labelNombreEdit";
			this.labelNombreEdit.Xalign = 0F;
			this.labelNombreEdit.LabelProp = global::Mono.Unix.Catalog.GetString ("Nombre:");
			this.table2.Add (this.labelNombreEdit);
			global::Gtk.Table.TableChild w35 = ((global::Gtk.Table.TableChild)(this.table2 [this.labelNombreEdit]));
			w35.TopAttach = ((uint)(2));
			w35.BottomAttach = ((uint)(3));
			w35.XOptions = ((global::Gtk.AttachOptions)(4));
			w35.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.LabelNombreMod = new global::Gtk.Label ();
			this.LabelNombreMod.Name = "LabelNombreMod";
			this.LabelNombreMod.Xalign = 0F;
			this.LabelNombreMod.LabelProp = global::Mono.Unix.Catalog.GetString ("    Nombre de Usuario:");
			this.table2.Add (this.LabelNombreMod);
			global::Gtk.Table.TableChild w36 = ((global::Gtk.Table.TableChild)(this.table2 [this.LabelNombreMod]));
			w36.TopAttach = ((uint)(1));
			w36.BottomAttach = ((uint)(2));
			w36.XOptions = ((global::Gtk.AttachOptions)(4));
			w36.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.LabelRutMod = new global::Gtk.Label ();
			this.LabelRutMod.Name = "LabelRutMod";
			this.LabelRutMod.Xalign = 0F;
			this.LabelRutMod.LabelProp = global::Mono.Unix.Catalog.GetString ("    Rut:");
			this.table2.Add (this.LabelRutMod);
			global::Gtk.Table.TableChild w37 = ((global::Gtk.Table.TableChild)(this.table2 [this.LabelRutMod]));
			w37.TopAttach = ((uint)(5));
			w37.BottomAttach = ((uint)(6));
			w37.XOptions = ((global::Gtk.AttachOptions)(4));
			w37.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.LabelTelefonoMod = new global::Gtk.Label ();
			this.LabelTelefonoMod.Name = "LabelTelefonoMod";
			this.LabelTelefonoMod.Xalign = 0F;
			this.LabelTelefonoMod.LabelProp = global::Mono.Unix.Catalog.GetString ("    Teléfono:");
			this.table2.Add (this.LabelTelefonoMod);
			global::Gtk.Table.TableChild w38 = ((global::Gtk.Table.TableChild)(this.table2 [this.LabelTelefonoMod]));
			w38.TopAttach = ((uint)(4));
			w38.BottomAttach = ((uint)(5));
			w38.XOptions = ((global::Gtk.AttachOptions)(4));
			w38.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.LabelTipoUsuarioMod = new global::Gtk.Label ();
			this.LabelTipoUsuarioMod.Name = "LabelTipoUsuarioMod";
			this.LabelTipoUsuarioMod.Xalign = 0F;
			this.LabelTipoUsuarioMod.LabelProp = global::Mono.Unix.Catalog.GetString ("    Tipo Usuario:");
			this.table2.Add (this.LabelTipoUsuarioMod);
			global::Gtk.Table.TableChild w39 = ((global::Gtk.Table.TableChild)(this.table2 [this.LabelTipoUsuarioMod]));
			w39.TopAttach = ((uint)(7));
			w39.BottomAttach = ((uint)(8));
			w39.XOptions = ((global::Gtk.AttachOptions)(4));
			w39.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.LabelUsuarioMod = new global::Gtk.Label ();
			this.LabelUsuarioMod.Name = "LabelUsuarioMod";
			this.LabelUsuarioMod.Xalign = 0F;
			this.LabelUsuarioMod.LabelProp = global::Mono.Unix.Catalog.GetString ("    Usuario a modificar: ");
			this.table2.Add (this.LabelUsuarioMod);
			global::Gtk.Table.TableChild w40 = ((global::Gtk.Table.TableChild)(this.table2 [this.LabelUsuarioMod]));
			w40.XOptions = ((global::Gtk.AttachOptions)(4));
			w40.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox7.Add (this.table2);
			global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.table2]));
			w41.Position = 0;
			w41.Expand = false;
			w41.Fill = false;
			this.alignment4.Add (this.vbox7);
			this.vbox4.Add (this.alignment4);
			global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.alignment4]));
			w43.Position = 1;
			w43.Expand = false;
			w43.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("                             ");
			this.hbox2.Add (this.label1);
			global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.label1]));
			w44.Position = 0;
			w44.Expand = false;
			w44.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.BotonModificar = new global::Gtk.Button ();
			this.BotonModificar.CanFocus = true;
			this.BotonModificar.Name = "BotonModificar";
			this.BotonModificar.UseUnderline = true;
			this.BotonModificar.Label = global::Mono.Unix.Catalog.GetString ("Modificar");
			this.hbox2.Add (this.BotonModificar);
			global::Gtk.Box.BoxChild w45 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.BotonModificar]));
			w45.Position = 1;
			w45.Expand = false;
			w45.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.BotonCancelarMod = new global::Gtk.Button ();
			this.BotonCancelarMod.CanFocus = true;
			this.BotonCancelarMod.Name = "BotonCancelarMod";
			this.BotonCancelarMod.UseUnderline = true;
			this.BotonCancelarMod.Label = global::Mono.Unix.Catalog.GetString ("Cancelar");
			this.hbox2.Add (this.BotonCancelarMod);
			global::Gtk.Box.BoxChild w46 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.BotonCancelarMod]));
			w46.Position = 2;
			w46.Expand = false;
			w46.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("    ");
			this.hbox2.Add (this.label2);
			global::Gtk.Box.BoxChild w47 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.label2]));
			w47.Position = 3;
			w47.Expand = false;
			w47.Fill = false;
			this.vbox4.Add (this.hbox2);
			global::Gtk.Box.BoxChild w48 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox2]));
			w48.Position = 2;
			w48.Expand = false;
			w48.Fill = false;
			this.notebook1.Add (this.vbox4);
			global::Gtk.Notebook.NotebookChild w49 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.vbox4]));
			w49.Position = 1;
			// Notebook tab
			this.LabelModificarUsuario = new global::Gtk.Label ();
			this.LabelModificarUsuario.Name = "LabelModificarUsuario";
			this.LabelModificarUsuario.LabelProp = global::Mono.Unix.Catalog.GetString ("Modificar Usuario");
			this.notebook1.SetTabLabel (this.vbox4, this.LabelModificarUsuario);
			this.LabelModificarUsuario.ShowAll ();
			w1.Add (this.notebook1);
			global::Gtk.Box.BoxChild w50 = ((global::Gtk.Box.BoxChild)(w1 [this.notebook1]));
			w50.Position = 0;
			// Internal child punto.gui.RegistrarUsuarioDialog.ActionArea
			global::Gtk.HButtonBox w51 = this.ActionArea;
			w51.Name = "dialog1_ActionArea";
			w51.Spacing = 10;
			w51.BorderWidth = ((uint)(5));
			w51.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w52 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w51 [this.buttonCancel]));
			w52.Expand = false;
			w52.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 432;
			this.buttonCancel.Hide ();
			this.Show ();
			this.BotonAgregar.Clicked += new global::System.EventHandler (this.OnBotonAgregarClicked);
			this.BotonCancelar.Clicked += new global::System.EventHandler (this.OnBotonCancelarClicked);
			this.comboboxUsuarioModificar.Changed += new global::System.EventHandler (this.OnComboboxUsuarioModificarChanged);
			this.BotonModificar.Clicked += new global::System.EventHandler (this.OnBotonModificarClicked);
			this.BotonCancelarMod.Clicked += new global::System.EventHandler (this.OnBotonCancelarModClicked);
			this.LabelModificarUsuario.KeyPressEvent += new global::Gtk.KeyPressEventHandler (this.OnLabelModificarUsuarioKeyPressEvent);
		}
	}
}
