/*
 * Created by SharpDevelop.
 * User: Jopo
 * Date: 08/04/2015
 * Time: 04:12 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace Bestnid
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label etiq_usuario;
		private System.Windows.Forms.Label etiq_contra;
		private System.Windows.Forms.Button Bot_registrarse;
		private System.Windows.Forms.Button bot_entrar;
		private System.Windows.Forms.TextBox tex_usuario;
		private System.Windows.Forms.TextBox tex_contra;
		private System.Windows.Forms.Button bot_imprimir;
		private System.Windows.Forms.RichTextBox caja;
		private System.Windows.Forms.Button Bot_eliminar;
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
			this.etiq_usuario = new System.Windows.Forms.Label();
			this.etiq_contra = new System.Windows.Forms.Label();
			this.Bot_registrarse = new System.Windows.Forms.Button();
			this.bot_entrar = new System.Windows.Forms.Button();
			this.tex_usuario = new System.Windows.Forms.TextBox();
			this.tex_contra = new System.Windows.Forms.TextBox();
			this.caja = new System.Windows.Forms.RichTextBox();
			this.bot_imprimir = new System.Windows.Forms.Button();
			this.Bot_eliminar = new System.Windows.Forms.Button();
			this.tex_eliminar = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// etiq_usuario
			// 
			this.etiq_usuario.Location = new System.Drawing.Point(40, 35);
			this.etiq_usuario.Name = "etiq_usuario";
			this.etiq_usuario.Size = new System.Drawing.Size(100, 23);
			this.etiq_usuario.TabIndex = 0;
			this.etiq_usuario.Text = "usuario";
			this.etiq_usuario.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// etiq_contra
			// 
			this.etiq_contra.Location = new System.Drawing.Point(40, 77);
			this.etiq_contra.Name = "etiq_contra";
			this.etiq_contra.Size = new System.Drawing.Size(100, 23);
			this.etiq_contra.TabIndex = 1;
			this.etiq_contra.Text = "contraseña";
			this.etiq_contra.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Bot_registrarse
			// 
			this.Bot_registrarse.Location = new System.Drawing.Point(146, 115);
			this.Bot_registrarse.Name = "Bot_registrarse";
			this.Bot_registrarse.Size = new System.Drawing.Size(94, 44);
			this.Bot_registrarse.TabIndex = 2;
			this.Bot_registrarse.Text = "Registrarse";
			this.Bot_registrarse.UseVisualStyleBackColor = true;
			this.Bot_registrarse.Click += new System.EventHandler(this.Bot_registrarseClick);
			// 
			// bot_entrar
			// 
			this.bot_entrar.Location = new System.Drawing.Point(246, 115);
			this.bot_entrar.Name = "bot_entrar";
			this.bot_entrar.Size = new System.Drawing.Size(94, 44);
			this.bot_entrar.TabIndex = 2;
			this.bot_entrar.Text = "entrar";
			this.bot_entrar.UseVisualStyleBackColor = true;
			this.bot_entrar.Click += new System.EventHandler(this.Bot_entrarClick);
			// 
			// tex_usuario
			// 
			this.tex_usuario.Location = new System.Drawing.Point(146, 38);
			this.tex_usuario.Name = "tex_usuario";
			this.tex_usuario.Size = new System.Drawing.Size(194, 20);
			this.tex_usuario.TabIndex = 3;
			this.tex_usuario.Text = "admin";
			// 
			// tex_contra
			// 
			this.tex_contra.Location = new System.Drawing.Point(146, 77);
			this.tex_contra.Name = "tex_contra";
			this.tex_contra.PasswordChar = '*';
			this.tex_contra.Size = new System.Drawing.Size(194, 20);
			this.tex_contra.TabIndex = 3;
			this.tex_contra.Text = "admin";
			// 
			// caja
			// 
			this.caja.Location = new System.Drawing.Point(40, 165);
			this.caja.Name = "caja";
			this.caja.Size = new System.Drawing.Size(300, 178);
			this.caja.TabIndex = 4;
			this.caja.Text = "";
			// 
			// bot_imprimir
			// 
			this.bot_imprimir.Location = new System.Drawing.Point(491, 223);
			this.bot_imprimir.Name = "bot_imprimir";
			this.bot_imprimir.Size = new System.Drawing.Size(94, 44);
			this.bot_imprimir.TabIndex = 5;
			this.bot_imprimir.Text = "imprimir BD";
			this.bot_imprimir.UseVisualStyleBackColor = true;
			this.bot_imprimir.Click += new System.EventHandler(this.Bot_imprimirClick);
			// 
			// Bot_eliminar
			// 
			this.Bot_eliminar.Location = new System.Drawing.Point(491, 299);
			this.Bot_eliminar.Name = "Bot_eliminar";
			this.Bot_eliminar.Size = new System.Drawing.Size(94, 44);
			this.Bot_eliminar.TabIndex = 2;
			this.Bot_eliminar.Text = "eliminar";
			this.Bot_eliminar.UseVisualStyleBackColor = true;
			// 
			// tex_eliminar
			// 
			this.tex_eliminar.Location = new System.Drawing.Point(391, 273);
			this.tex_eliminar.Name = "tex_eliminar";
			this.tex_eliminar.Size = new System.Drawing.Size(194, 20);
			this.tex_eliminar.TabIndex = 3;
			this.tex_eliminar.Text = "Ingrese nombre a eliminar";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(597, 368);
			this.Controls.Add(this.bot_imprimir);
			this.Controls.Add(this.caja);
			this.Controls.Add(this.tex_eliminar);
			this.Controls.Add(this.tex_contra);
			this.Controls.Add(this.tex_usuario);
			this.Controls.Add(this.Bot_eliminar);
			this.Controls.Add(this.bot_entrar);
			this.Controls.Add(this.Bot_registrarse);
			this.Controls.Add(this.etiq_contra);
			this.Controls.Add(this.etiq_usuario);
			this.Name = "MainForm";
			this.Text = "Bestnid";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}}

		
	

