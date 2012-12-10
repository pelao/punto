using System;
using GLib;
using Gtk;
using punto.gui;

namespace pto
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			//PrincipalWindow pri = new PrincipalWindow();
			IniciarSesionDialog pri = new IniciarSesionDialog();
			try 
			{
				pri.Show();
			}
			catch (MySql.Data.MySqlClient.MySqlException e)
			{
				pri.Destroy();
#if DEBUG
				Console.WriteLine(e.Message);
#endif
			}
			
			Application.Run ();
		}
	}
}

