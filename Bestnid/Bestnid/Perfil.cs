/*
 * Created by SharpDevelop.
 * User: Jopo
 * Date: 11/04/2015
 * Time: 05:16 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Bestnid
{
	/// <summary>
	/// Description of Perfil.
	/// </summary>
	public partial class Perfil : Form
	{
		private static Form usuario_form= UsuarioForm.ActiveForm;
		
		public Perfil()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			usuario_form.Hide();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Bot_eliminarClick(object sender, EventArgs e)
		{
				
			if (MainForm.conexion.State == 0){
				MainForm.conexion.Open();
			}
			
			String usuario= etiq_usuario1.Text;
			String sql_eliminar= "delete from usuarios where usuario='"+usuario+"';";
			SQLiteCommand eliminar= new SQLiteCommand (sql_eliminar, MainForm.conexion);
			eliminar.ExecuteNonQuery();
			
			UsuarioForm.principal.Show();//como me elimine a mi mismo, debo volver al login
			usuario_form.Dispose();		//entonces muestro el login, cierro esta (mi perfil)
			this.Dispose();				//y tambien cierro la de mi pantalla de logueado
		}
	}
}
