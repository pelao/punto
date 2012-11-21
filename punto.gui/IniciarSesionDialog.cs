
using GLib;

using punto.gui;


using System.Collections.Generic;
using Gtk;
using System;
using punto.code;

namespace punto.gui
{
	public partial class IniciarSesionDialog : Gtk.Dialog
	{
		public IniciarSesionDialog ()
		{
			this.Build ();
		}
		
		
		protected void OnButton505Clicked (object sender, EventArgs e)
		{
			
			ControladorBaseDatos Bd = new ControladorBaseDatos();
			
			string[] usuarioClave = new string[2];
			
			usuarioClave = Bd.ObtenerUsuarioContraseñaBd(entry3.Text);
			
			if(usuarioClave[0]==entry3.Text & usuarioClave[1]==entry4.Text)
			{
				PrincipalWindow rcd = new PrincipalWindow();
				
				//				try 
				//				{
				base.Destroy();
				rcd.Show();
				
				//				}
				//				catch (MySql.Data.MySqlClient.MySqlException e)
				//				{
				//					rcd.Destroy();
				//#if DEBUG
				//					Console.WriteLine(e.Message);
				//#endif
			}
			
			
			
			
			/*				Dialog dialog = new Dialog("Iniciar Sesion", this, Gtk.DialogFlags.DestroyWithParent);
				dialog.Modal = true;
				dialog.Resizable = false;
				Gtk.Label etiqueta = new Gtk.Label();
				etiqueta.Markup = "Usuario/Clave correctos";
				dialog.BorderWidth = 8;
				dialog.VBox.BorderWidth = 8;
				dialog.VBox.PackStart(etiqueta, false, false, 0);
				dialog.AddButton ("Cerrar", ResponseType.Close);
				dialog.ShowAll();
				dialog.Run ();
				dialog.Destroy ();
			}
			else
			{
				Dialog dialog = new Dialog("Iniciar Sesion", this, Gtk.DialogFlags.DestroyWithParent);
				dialog.Modal = true;
				dialog.Resizable = false;
				Gtk.Label etiqueta = new Gtk.Label();
				etiqueta.Markup = "Usuario/Clave incorrectos";
				dialog.BorderWidth = 8;
				dialog.VBox.BorderWidth = 8;
				dialog.VBox.PackStart(etiqueta, false, false, 0);
				dialog.AddButton ("Cerrar", ResponseType.Close);
				dialog.ShowAll();
				dialog.Run ();
				dialog.Destroy ();

			}*/
			
		}
		[GLib.ConnectBefore ()]
		protected void OnEntry4KeyPressEvent (object o, KeyPressEventArgs args)
		{
			if(args.Event.Key==Gdk.Key.Return ){
				ControladorBaseDatos Bd = new ControladorBaseDatos();
				
				string[] usuarioClave = new string[2];
				
				usuarioClave = Bd.ObtenerUsuarioContraseñaBd(entry3.Text);
				
				if(usuarioClave[0]==entry3.Text & usuarioClave[1]==entry4.Text)
				{
					PrincipalWindow rcd = new PrincipalWindow();
					
					//				try 
					//				{
					base.Destroy();
					rcd.Show();
					
					//				}
					//				catch (MySql.Data.MySqlClient.MySqlException e)
					//				{
					//					rcd.Destroy();
					//#if DEBUG
					//					Console.WriteLine(e.Message);
					//#endif
				}
				
				
				
				
				/*				Dialog dialog = new Dialog("Iniciar Sesion", this, Gtk.DialogFlags.DestroyWithParent);
				dialog.Modal = true;
				dialog.Resizable = false;
				Gtk.Label etiqueta = new Gtk.Label();
				etiqueta.Markup = "Usuario/Clave correctos";
				dialog.BorderWidth = 8;
				dialog.VBox.BorderWidth = 8;
				dialog.VBox.PackStart(etiqueta, false, false, 0);
				dialog.AddButton ("Cerrar", ResponseType.Close);
				dialog.ShowAll();
				dialog.Run ();
				dialog.Destroy ();
			}
			else
			{
				Dialog dialog = new Dialog("Iniciar Sesion", this, Gtk.DialogFlags.DestroyWithParent);
				dialog.Modal = true;
				dialog.Resizable = false;
				Gtk.Label etiqueta = new Gtk.Label();
				etiqueta.Markup = "Usuario/Clave incorrectos";
				dialog.BorderWidth = 8;
				dialog.VBox.BorderWidth = 8;
				dialog.VBox.PackStart(etiqueta, false, false, 0);
				dialog.AddButton ("Cerrar", ResponseType.Close);
				dialog.ShowAll();
				dialog.Run ();
				dialog.Destroy ();

			}*/
				
			}

			}
		}
	}


