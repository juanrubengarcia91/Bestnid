/*
 * Created by SharpDevelop.
 * User: Jopo
 * Date: 08/04/2015
 * Time: 03:52 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Bestnid
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			
			Console.WriteLine("Creando la BD!");
			
			//crear conexion a bd
			SQLiteConnection conexion= new SQLiteConnection("Data Source=BestnidDB.sqlite;Version=3;New=False;Compress=True;");
			conexion.Open();
			
			//crear tabla
			String usuario= "create table usuario (nom varchar(20), contra varchar(20));";
			SQLiteCommand crear_tabla= new SQLiteCommand(usuario, conexion);
			crear_tabla.ExecuteNonQuery();
			
			
			
			
			
			//
		}
		void Bot_registrarClick(object sender, EventArgs e)
		{
			String usuario= tex_usuario.Text;
			String contra= tex_contra.Text;
			
			textBox1.Text= usuario + " " + contra;
		}
		
	}
}


//	
//			//instertar en la table creada leyendo de consola. 4 personas
//			String insercion;
//			
//			for (int i = 0; i < 4; i++) {
//				Console.WriteLine("Ingrese nombre: ");
//				
//				insercion= "insert into persona (nom, dni)" + "values('" + Console.ReadLine() + "',12345678);";
//				comando= new SQLiteCommand(insercion, conexion);
//				comando.ExecuteNonQuery();
//			}
//			
//			//leer desde la tabla e imprimir.
//			String consulta= "select * from persona"; //define la consulta
//			SQLiteCommand leer= new SQLiteCommand(consulta, conexion); //prepara el comando para exe
//			SQLiteDataReader datos= leer.ExecuteReader(); //defina la estructura donde se guarda lo que se lee con "leer"
//			
//			while (datos.Read()) {
//				//String nom= Convert.ToString(datos[0]);
//				int dni= Convert.ToInt32(datos[1]);
//				
//				Console.WriteLine("Nombre: {0}. Dni: {1}", Convert.ToString(datos[0]), dni);
//			}
