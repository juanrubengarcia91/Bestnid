/*
 * Created by SharpDevelop.
 * User: Jopo
 * Date: 08/04/2015
 * Time: 04:12 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace Bestnid
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public static SQLiteConnection conexion;
		
		//constructor
		public static void abrirBD(){
			if (!File.Exists("BestnidBD.sqlite")) {
				conexion= new SQLiteConnection("Data Source=BestnidBD.sqlite;Version=3;New=True;Compress=True;");
				
				//conexion con BD
				conexion.Open();
				
				//crear tabla
				String usuario= "create table usuarios (usuario varchar(20), contra varchar(20), nombre varchar(20), apellido varchar(20), dni varchar(8), fecha_nacimiento varchar(8), calle varchar(20), numero varchar(20), torre varchar(1), piso varchar(2), departamento varchar(2), telefono varchar(15), mail varchar(30), nom_tit_tarjeta varchar(20), ape_tit_tarjeta varchar(20), empresa_tarjeta varchar(20), numero_tarjeta varchar(10), codigo_tarjeta varchar (3));";
				SQLiteCommand crear_tabla= new SQLiteCommand(usuario, conexion);
				crear_tabla.ExecuteNonQuery();
			} else{
				conexion= new SQLiteConnection("Data Source=BestnidBD.sqlite;Version=3;New=False;Compress=True;");
				conexion.Open();
			}
		}
		
		public MainForm()
		{
			InitializeComponent();
			abrirBD();
		}
		
		void Bot_registrarseClick(object sender, EventArgs e)
		{
			Registro form_registro= new Registro();
			form_registro.Show();
			
		}
		void Bot_imprimirClick(object sender, EventArgs e)
		{
			if (conexion.State == 0){
				conexion.Open();
			}
			
			String sql_mostrar_todos= "select * from usuarios";
			SQLiteCommand mostrar_todos= new SQLiteCommand (sql_mostrar_todos, conexion);
			//crea el comando con la sentencia sql(sql_mostar_tods) y dice donde ejecutarla (conexion)
			
			SQLiteDataReader datos= mostrar_todos.ExecuteReader();
			//exe el comando y guarda todo el resultado en "datos"
			
			caja.Text= "";
			
			while (datos.Read()) {
				String usuario= Convert.ToString(datos[0]);
				String contra= Convert.ToString(datos[1]);
				
				caja.Text= caja.Text + usuario + " " + contra + "\n";
			}
		}

		void Bot_entrarClick(object sender, EventArgs e)
		{
			String usuario= tex_usuario.Text;
			String contra= tex_contra.Text;
			
			String sql_credenciales= "select count (*) " +
				"from usuarios " +
				"where usuario='" + usuario + "' and "+
				"contra='" + contra + "';";
			
			SQLiteCommand credenciales= new SQLiteCommand (sql_credenciales, conexion);
			int cantidad= Convert.ToInt32(((SQLiteDataReader)(credenciales.ExecuteReader()))[0]);
			
			if (cantidad.Equals(1)){
				MessageBox.Show("Login correcto.");
				
				UsuarioForm form_registrado= new UsuarioForm();

				form_registrado.Show();
				
				if (usuario != "admin"){ //para cuando log admin
					((SplitContainer)(form_registrado.Controls["Contenedor_usuario"])).Panel1Collapsed=true;
				}
				this.Hide();
			}else{
				MessageBox.Show("usuario o contraseña incorrectos");
			}
			
		}
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			this.Hide();
			//MessageBox.Show("Gracias por utilizar Bestnid!");
			this.Dispose();
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			CenterToScreen();
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
