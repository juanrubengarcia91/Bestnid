/*
 * Created by SharpDevelop.
 * User: Jopo
 * Date: 09/04/2015
 * Time: 05:18 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Bestnid
{
	partial class UsuarioForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button Bot_cerrar_sesion;
		private System.Windows.Forms.Label etiq_bienvenido;
		private System.Windows.Forms.Button Bot_mi_perfil;
		private System.Windows.Forms.PictureBox Imagen_perfil;
		private System.Windows.Forms.Button Bot_subastar;
		private System.Windows.Forms.Button Bot_finalizadas;
		private System.Windows.Forms.Button Bot_eliminar;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button Bot_ver_usuarios;
		private System.Windows.Forms.SplitContainer Contenedor_usuario;
		private System.Windows.Forms.Panel Panel_opciones;
		private System.Windows.Forms.SplitContainer Contenedor_derecha;
		private System.Windows.Forms.TextBox tex_eliminar;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioForm));
			this.Bot_cerrar_sesion = new System.Windows.Forms.Button();
			this.etiq_bienvenido = new System.Windows.Forms.Label();
			this.Bot_mi_perfil = new System.Windows.Forms.Button();
			this.Imagen_perfil = new System.Windows.Forms.PictureBox();
			this.Bot_subastar = new System.Windows.Forms.Button();
			this.Bot_finalizadas = new System.Windows.Forms.Button();
			this.Bot_eliminar = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.Bot_ver_usuarios = new System.Windows.Forms.Button();
			this.Contenedor_usuario = new System.Windows.Forms.SplitContainer();
			this.tex_eliminar = new System.Windows.Forms.TextBox();
			this.Contenedor_derecha = new System.Windows.Forms.SplitContainer();
			this.Panel_opciones = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.Imagen_perfil)).BeginInit();
			this.Contenedor_usuario.Panel1.SuspendLayout();
			this.Contenedor_usuario.Panel2.SuspendLayout();
			this.Contenedor_usuario.SuspendLayout();
			this.Contenedor_derecha.Panel1.SuspendLayout();
			this.Contenedor_derecha.Panel2.SuspendLayout();
			this.Contenedor_derecha.SuspendLayout();
			this.Panel_opciones.SuspendLayout();
			this.SuspendLayout();
			// 
			// Bot_cerrar_sesion
			// 
			this.Bot_cerrar_sesion.AutoSize = true;
			this.Bot_cerrar_sesion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Bot_cerrar_sesion.Location = new System.Drawing.Point(203, 34);
			this.Bot_cerrar_sesion.Name = "Bot_cerrar_sesion";
			this.Bot_cerrar_sesion.Size = new System.Drawing.Size(80, 23);
			this.Bot_cerrar_sesion.TabIndex = 0;
			this.Bot_cerrar_sesion.Text = "Cerrar Sesión";
			this.Bot_cerrar_sesion.UseVisualStyleBackColor = true;
			this.Bot_cerrar_sesion.Click += new System.EventHandler(this.Bot_cerrar_sesionClick);
			// 
			// etiq_bienvenido
			// 
			this.etiq_bienvenido.AutoSize = true;
			this.etiq_bienvenido.Location = new System.Drawing.Point(116, 11);
			this.etiq_bienvenido.Name = "etiq_bienvenido";
			this.etiq_bienvenido.Size = new System.Drawing.Size(167, 13);
			this.etiq_bienvenido.TabIndex = 1;
			this.etiq_bienvenido.Text = "¡Bienvenido,      NOMBRE______";
			// 
			// Bot_mi_perfil
			// 
			this.Bot_mi_perfil.AutoSize = true;
			this.Bot_mi_perfil.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Bot_mi_perfil.Dock = System.Windows.Forms.DockStyle.Right;
			this.Bot_mi_perfil.Location = new System.Drawing.Point(191, 0);
			this.Bot_mi_perfil.Name = "Bot_mi_perfil";
			this.Bot_mi_perfil.Size = new System.Drawing.Size(54, 35);
			this.Bot_mi_perfil.TabIndex = 2;
			this.Bot_mi_perfil.Text = "Mi Perfil";
			this.Bot_mi_perfil.UseVisualStyleBackColor = true;
			this.Bot_mi_perfil.Click += new System.EventHandler(this.Bot_mi_perfilClick);
			// 
			// Imagen_perfil
			// 
			this.Imagen_perfil.Dock = System.Windows.Forms.DockStyle.Left;
			this.Imagen_perfil.Image = ((System.Drawing.Image)(resources.GetObject("Imagen_perfil.Image")));
			this.Imagen_perfil.Location = new System.Drawing.Point(0, 0);
			this.Imagen_perfil.Name = "Imagen_perfil";
			this.Imagen_perfil.Size = new System.Drawing.Size(90, 89);
			this.Imagen_perfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Imagen_perfil.TabIndex = 3;
			this.Imagen_perfil.TabStop = false;
			// 
			// Bot_subastar
			// 
			this.Bot_subastar.AutoSize = true;
			this.Bot_subastar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Bot_subastar.Dock = System.Windows.Forms.DockStyle.Right;
			this.Bot_subastar.Location = new System.Drawing.Point(19, 0);
			this.Bot_subastar.Name = "Bot_subastar";
			this.Bot_subastar.Size = new System.Drawing.Size(59, 35);
			this.Bot_subastar.TabIndex = 4;
			this.Bot_subastar.Text = "Subastar";
			this.Bot_subastar.UseVisualStyleBackColor = true;
			// 
			// Bot_finalizadas
			// 
			this.Bot_finalizadas.AutoSize = true;
			this.Bot_finalizadas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Bot_finalizadas.Dock = System.Windows.Forms.DockStyle.Right;
			this.Bot_finalizadas.Location = new System.Drawing.Point(78, 0);
			this.Bot_finalizadas.Name = "Bot_finalizadas";
			this.Bot_finalizadas.Size = new System.Drawing.Size(113, 35);
			this.Bot_finalizadas.TabIndex = 4;
			this.Bot_finalizadas.Text = "Subastas finalizadas";
			this.Bot_finalizadas.UseVisualStyleBackColor = true;
			// 
			// Bot_eliminar
			// 
			this.Bot_eliminar.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.Bot_eliminar.Location = new System.Drawing.Point(0, 335);
			this.Bot_eliminar.Name = "Bot_eliminar";
			this.Bot_eliminar.Size = new System.Drawing.Size(128, 34);
			this.Bot_eliminar.TabIndex = 4;
			this.Bot_eliminar.Text = "Eliminar usuario";
			this.Bot_eliminar.UseVisualStyleBackColor = true;
			this.Bot_eliminar.Click += new System.EventHandler(this.Bot_eliminarClick);
			// 
			// button4
			// 
			this.button4.Dock = System.Windows.Forms.DockStyle.Top;
			this.button4.Location = new System.Drawing.Point(0, 0);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(128, 34);
			this.button4.TabIndex = 4;
			this.button4.Text = "Listado 1";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// Bot_ver_usuarios
			// 
			this.Bot_ver_usuarios.Dock = System.Windows.Forms.DockStyle.Top;
			this.Bot_ver_usuarios.Location = new System.Drawing.Point(0, 34);
			this.Bot_ver_usuarios.Name = "Bot_ver_usuarios";
			this.Bot_ver_usuarios.Size = new System.Drawing.Size(128, 34);
			this.Bot_ver_usuarios.TabIndex = 4;
			this.Bot_ver_usuarios.Text = "Ver usuarios";
			this.Bot_ver_usuarios.UseVisualStyleBackColor = true;
			this.Bot_ver_usuarios.Click += new System.EventHandler(this.Bot_ver_usuariosClick);
			// 
			// Contenedor_usuario
			// 
			this.Contenedor_usuario.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Contenedor_usuario.Location = new System.Drawing.Point(0, 0);
			this.Contenedor_usuario.Name = "Contenedor_usuario";
			// 
			// Contenedor_usuario.Panel1
			// 
			this.Contenedor_usuario.Panel1.BackColor = System.Drawing.Color.CornflowerBlue;
			this.Contenedor_usuario.Panel1.Controls.Add(this.tex_eliminar);
			this.Contenedor_usuario.Panel1.Controls.Add(this.Bot_ver_usuarios);
			this.Contenedor_usuario.Panel1.Controls.Add(this.Bot_eliminar);
			this.Contenedor_usuario.Panel1.Controls.Add(this.button4);
			// 
			// Contenedor_usuario.Panel2
			// 
			this.Contenedor_usuario.Panel2.Controls.Add(this.Contenedor_derecha);
			this.Contenedor_usuario.Panel2MinSize = 35;
			this.Contenedor_usuario.Size = new System.Drawing.Size(526, 369);
			this.Contenedor_usuario.SplitterDistance = 128;
			this.Contenedor_usuario.TabIndex = 5;
			// 
			// tex_eliminar
			// 
			this.tex_eliminar.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tex_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tex_eliminar.ForeColor = System.Drawing.Color.Red;
			this.tex_eliminar.Location = new System.Drawing.Point(0, 315);
			this.tex_eliminar.Name = "tex_eliminar";
			this.tex_eliminar.Size = new System.Drawing.Size(128, 20);
			this.tex_eliminar.TabIndex = 5;
			// 
			// Contenedor_derecha
			// 
			this.Contenedor_derecha.Dock = System.Windows.Forms.DockStyle.Top;
			this.Contenedor_derecha.IsSplitterFixed = true;
			this.Contenedor_derecha.Location = new System.Drawing.Point(0, 0);
			this.Contenedor_derecha.Name = "Contenedor_derecha";
			this.Contenedor_derecha.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// Contenedor_derecha.Panel1
			// 
			this.Contenedor_derecha.Panel1.Controls.Add(this.Imagen_perfil);
			this.Contenedor_derecha.Panel1.Controls.Add(this.Bot_cerrar_sesion);
			this.Contenedor_derecha.Panel1.Controls.Add(this.etiq_bienvenido);
			// 
			// Contenedor_derecha.Panel2
			// 
			this.Contenedor_derecha.Panel2.Controls.Add(this.Panel_opciones);
			this.Contenedor_derecha.Panel2MinSize = 50;
			this.Contenedor_derecha.Size = new System.Drawing.Size(394, 178);
			this.Contenedor_derecha.SplitterDistance = 89;
			this.Contenedor_derecha.TabIndex = 6;
			// 
			// Panel_opciones
			// 
			this.Panel_opciones.Controls.Add(this.Bot_subastar);
			this.Panel_opciones.Controls.Add(this.Bot_finalizadas);
			this.Panel_opciones.Controls.Add(this.Bot_mi_perfil);
			this.Panel_opciones.Dock = System.Windows.Forms.DockStyle.Right;
			this.Panel_opciones.Location = new System.Drawing.Point(149, 0);
			this.Panel_opciones.MaximumSize = new System.Drawing.Size(400, 35);
			this.Panel_opciones.Name = "Panel_opciones";
			this.Panel_opciones.Size = new System.Drawing.Size(245, 35);
			this.Panel_opciones.TabIndex = 5;
			// 
			// UsuarioForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(526, 369);
			this.Controls.Add(this.Contenedor_usuario);
			this.MinimumSize = new System.Drawing.Size(400, 210);
			this.Name = "UsuarioForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Usuario Registrado";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UsuarioFormFormClosing);
			((System.ComponentModel.ISupportInitialize)(this.Imagen_perfil)).EndInit();
			this.Contenedor_usuario.Panel1.ResumeLayout(false);
			this.Contenedor_usuario.Panel1.PerformLayout();
			this.Contenedor_usuario.Panel2.ResumeLayout(false);
			this.Contenedor_usuario.ResumeLayout(false);
			this.Contenedor_derecha.Panel1.ResumeLayout(false);
			this.Contenedor_derecha.Panel1.PerformLayout();
			this.Contenedor_derecha.Panel2.ResumeLayout(false);
			this.Contenedor_derecha.ResumeLayout(false);
			this.Panel_opciones.ResumeLayout(false);
			this.Panel_opciones.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
