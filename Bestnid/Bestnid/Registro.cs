/*
 * Created by SharpDevelop.
 * User: Jopo
 * Date: 09/04/2015
 * Time: 12:58 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Collections;

namespace Bestnid
{
	/// <summary>
	/// Description of Registro.
	/// </summary>
	public partial class Registro : Form
	{
		
		public static Form principal= MainForm.ActiveForm;
		
		public Registro()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			principal.Hide();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

		void Bot_registrarClick(object sender, EventArgs e)
		{
			
//			if (conexion.State == 0){
//				conexion.Open();
//			}
			
			String usuario= tex_usuario.Text;
			String contra= tex_contra.Text;
			
			//chequear usuarios repetidos
			String sql_cantidad= "select count (*) from usuarios where usuario='" + usuario + "';";
			SQLiteCommand cantidad= new SQLiteCommand(sql_cantidad, MainForm.conexion);
			SQLiteDataReader cant= cantidad.ExecuteReader();
			
			int cantidad_nom= Convert.ToInt32(cant[0]);
			
			if (cantidad_nom.Equals(1)){
				MessageBox.Show("Nombre de usuario no disponible");
			} else{
				ArrayList campos= new ArrayList();
				
				campos.Add(tex_usuario.Text); campos.Add(tex_contra.Text); campos.Add(tex_nombre.Text);
				campos.Add(tex_apellido.Text); campos.Add(tex_dni.Text); campos.Add(date_fecha_nacimiento.Text);
				campos.Add(tex_calle.Text); campos.Add(tex_nro.Text); campos.Add(tex_torre.Text); campos.Add(tex_piso.Text);
				campos.Add(tex_dpto.Text); campos.Add(tex_telefono.Text); campos.Add(tex_mail.Text+"@"+tex_dominio.Text);
				campos.Add(tex_nombre_titular_tarjeta.Text); campos.Add(tex_apellido_titular_tarjeta.Text);
				campos.Add(Combo_nombre_empresa.SelectedItem); campos.Add(tex_numero_tarjeta.Text); 
				campos.Add(tex_codigo_seguridad.Text);
				
				String sql_agregar="insert into usuarios (usuario, contra, nombre, apellido, dni, fecha_nacimiento, calle, numero, torre, piso, departamento, telefono, mail, nom_tit_tarjeta, ape_tit_tarjeta, empresa_tarjeta, numero_tarjeta, codigo_tarjeta) values ('"+campos[0]+"','"+campos[1]+"','"+campos[2]+"','"+campos[3]+"','"+campos[4]+"','"+campos[5]+"','"+campos[6]+"','"+campos[7]+"','"+campos[8]+"','"+campos[9]+"','"+campos[10]+"','"+campos[11]+"','"+campos[12]+"','"+campos[13]+"','"+campos[14]+"','"+campos[15]+"','"+campos[16]+"','"+campos[17]+"');";
				SQLiteCommand agregar= new SQLiteCommand (sql_agregar, MainForm.conexion);
				agregar.ExecuteNonQuery();
				MessageBox.Show("Registro Exitoso!");
			}
		}
		void Bot_volverClick(object sender, EventArgs e)
		{
			this.Dispose();
			principal.Show();
		}
		void Bot_verificar_usuarioClick(object sender, EventArgs e)
		{
			String usuario= tex_usuario.Text;
			String contra= tex_contra.Text;
			
			//chequear usuarios repetidos
			String sql_cantidad= "select count (*) from usuarios where usuario='" + usuario + "';";
			SQLiteCommand cantidad= new SQLiteCommand(sql_cantidad, MainForm.conexion);
			SQLiteDataReader cant= cantidad.ExecuteReader();
			
			int cantidad_nom= Convert.ToInt32(cant[0]);
			
			if (cantidad_nom.Equals(1)){
				MessageBox.Show("Nombre de usuario no disponible");
			}else{
				MessageBox.Show("Nombre de usuario disponible");
			}
		}
		void RegistroFormClosing(object sender, FormClosingEventArgs e)
		{
			this.Dispose();
			principal.Show();
		}
	}
}
