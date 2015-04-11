/*
 * Created by SharpDevelop.
 * User: Jopo
 * Date: 09/04/2015
 * Time: 05:18 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;

namespace Bestnid
{
	/// <summary>
	/// Description of UsuarioForm.
	/// </summary>
	public partial class UsuarioForm : Form
	{
		private static Form principal= MainForm.ActiveForm;
		
		public UsuarioForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Bot_ver_usuariosClick(object sender, EventArgs e)
		{
			String sql_mostrar_todos= "select * from usuarios";
			SQLiteDataAdapter adaptador= new SQLiteDataAdapter (sql_mostrar_todos, MainForm.conexion);
			//crea el comando con la sentencia sql(sql_mostar_tods) y dice donde ejecutarla (conexion)
			
			DataTable tabla_usuarios= new DataTable();
			DataGridView Tab_usuarios= new DataGridView();
			
			adaptador.Fill(tabla_usuarios);
			//Tab_usuarios.Show();
			Tab_usuarios.DataSource= tabla_usuarios;
			Tab_usuarios.Dock= DockStyle.Fill;
			Tab_usuarios.AutoSize=true;
			
			
			Form form_muestra_usuarios= new Form();
			form_muestra_usuarios.Controls.Add(Tab_usuarios);
			
			Tab_usuarios.Location= new Point (10, 10);
			Tab_usuarios.Show();
			form_muestra_usuarios.Show();
			form_muestra_usuarios.Location= Location;
		}

		public void Bot_cerrar_sesionClick(object sender, EventArgs e)
		{
			this.Dispose();
			principal.Show();
		}
		void UsuarioFormFormClosing(object sender, FormClosingEventArgs e)
		{
			this.Dispose();
			principal.Show();
		}
		void Bot_eliminarClick(object sender, EventArgs e)
		{
			
			if (MainForm.conexion.State == 0){
				MainForm.conexion.Open();
			}
			
			String usuario= tex_eliminar.Text;
			String sql_eliminar= "delete from usuarios where usuario='"+usuario+"';";
			SQLiteCommand eliminar= new SQLiteCommand (sql_eliminar, MainForm.conexion);
			eliminar.ExecuteNonQuery();
		}
	}
}
