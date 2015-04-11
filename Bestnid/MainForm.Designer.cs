/*
 * Created by SharpDevelop.
 * User: Jopo
 * Date: 08/04/2015
 * Time: 03:52 p.m.
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
		private System.Windows.Forms.TextBox tex_usuario;
		private System.Windows.Forms.TextBox tex_contra;
		private System.Windows.Forms.Button bot_registrar;
		private System.Windows.Forms.Label etiq_usuario;
		private System.Windows.Forms.Label etiq_contra;
		private System.Windows.Forms.Button bot_entrar;
		private System.Windows.Forms.TextBox textBox1;
		
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
			this.tex_usuario = new System.Windows.Forms.TextBox();
			this.tex_contra = new System.Windows.Forms.TextBox();
			this.bot_registrar = new System.Windows.Forms.Button();
			this.etiq_usuario = new System.Windows.Forms.Label();
			this.etiq_contra = new System.Windows.Forms.Label();
			this.bot_entrar = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// tex_usuario
			// 
			this.tex_usuario.Location = new System.Drawing.Point(104, 43);
			this.tex_usuario.Name = "tex_usuario";
			this.tex_usuario.Size = new System.Drawing.Size(207, 20);
			this.tex_usuario.TabIndex = 0;
			// 
			// tex_contra
			// 
			this.tex_contra.Location = new System.Drawing.Point(104, 69);
			this.tex_contra.Name = "tex_contra";
			this.tex_contra.Size = new System.Drawing.Size(207, 20);
			this.tex_contra.TabIndex = 1;
			// 
			// bot_registrar
			// 
			this.bot_registrar.Location = new System.Drawing.Point(104, 111);
			this.bot_registrar.Name = "bot_registrar";
			this.bot_registrar.Size = new System.Drawing.Size(75, 46);
			this.bot_registrar.TabIndex = 2;
			this.bot_registrar.Text = "Registrar";
			this.bot_registrar.UseVisualStyleBackColor = true;
			this.bot_registrar.Click += new System.EventHandler(this.Bot_registrarClick);
			// 
			// etiq_usuario
			// 
			this.etiq_usuario.Location = new System.Drawing.Point(12, 43);
			this.etiq_usuario.Name = "etiq_usuario";
			this.etiq_usuario.Size = new System.Drawing.Size(86, 23);
			this.etiq_usuario.TabIndex = 3;
			this.etiq_usuario.Text = "usuario";
			this.etiq_usuario.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// etiq_contra
			// 
			this.etiq_contra.Location = new System.Drawing.Point(12, 69);
			this.etiq_contra.Name = "etiq_contra";
			this.etiq_contra.Size = new System.Drawing.Size(86, 23);
			this.etiq_contra.TabIndex = 4;
			this.etiq_contra.Text = "contraseña";
			this.etiq_contra.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// bot_entrar
			// 
			this.bot_entrar.Location = new System.Drawing.Point(236, 111);
			this.bot_entrar.Name = "bot_entrar";
			this.bot_entrar.Size = new System.Drawing.Size(75, 46);
			this.bot_entrar.TabIndex = 5;
			this.bot_entrar.Text = "Entrar";
			this.bot_entrar.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(104, 212);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(207, 20);
			this.textBox1.TabIndex = 6;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(478, 312);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.bot_entrar);
			this.Controls.Add(this.etiq_contra);
			this.Controls.Add(this.etiq_usuario);
			this.Controls.Add(this.bot_registrar);
			this.Controls.Add(this.tex_contra);
			this.Controls.Add(this.tex_usuario);
			this.Name = "MainForm";
			this.Text = "Bestnid";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
