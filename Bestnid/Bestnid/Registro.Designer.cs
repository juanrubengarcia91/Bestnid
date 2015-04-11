/*
 * Created by SharpDevelop.
 * User: Jopo
 * Date: 09/04/2015
 * Time: 12:58 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Bestnid
{
	partial class Registro
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox Grupo_datos_registro;
		private System.Windows.Forms.Label etiq_contra;
		private System.Windows.Forms.Label etiq_usuario;
		private System.Windows.Forms.TextBox tex_usuario;
		private System.Windows.Forms.GroupBox Grupo_datos_personales;
		private System.Windows.Forms.GroupBox Grupo_datos_tarjeta;
		private System.Windows.Forms.TextBox tex_contra;
		private System.Windows.Forms.Button Bot_verificar_usuario;
		private System.Windows.Forms.GroupBox Grupo_contacto;
		private System.Windows.Forms.Label etiq_mail;
		private System.Windows.Forms.Label etiq_telefono;
		private System.Windows.Forms.TextBox tex_dominio;
		private System.Windows.Forms.TextBox tex_telefono;
		private System.Windows.Forms.GroupBox Grupo_direccion;
		private System.Windows.Forms.TextBox tex_torre;
		private System.Windows.Forms.Label etiq_torre;
		private System.Windows.Forms.Label etiq_depto;
		private System.Windows.Forms.Label etiq_piso;
		private System.Windows.Forms.Label etiq_numero;
		private System.Windows.Forms.Label etiq_calle;
		private System.Windows.Forms.TextBox tex_dpto;
		private System.Windows.Forms.TextBox tex_piso;
		private System.Windows.Forms.TextBox tex_nro;
		private System.Windows.Forms.TextBox tex_calle;
		private System.Windows.Forms.Button Bot_registrar;
		private System.Windows.Forms.Button Bot_volver;
		private System.Windows.Forms.TextBox tex_mail;
		private System.Windows.Forms.Label etiq_arroba;
		private System.Windows.Forms.TextBox tex_dni;
		private System.Windows.Forms.TextBox tex_apellido;
		private System.Windows.Forms.TextBox tex_nombre;
		private System.Windows.Forms.Label etiq_dni;
		private System.Windows.Forms.Label etiq_apellido;
		private System.Windows.Forms.Label etiq_nombre;
		private System.Windows.Forms.GroupBox Grupo_fecha_de_nacimiento;
		private System.Windows.Forms.Label etiq_apellido_titular_tarjeta;
		private System.Windows.Forms.Label etiq_nombre_titular_tarjeta;
		private System.Windows.Forms.TextBox tex_codigo_seguridad;
		private System.Windows.Forms.Label etiq_codigo_seguridad;
		private System.Windows.Forms.Label etiq_numero_tarjeta;
		private System.Windows.Forms.Label etiq_empresa;
		private System.Windows.Forms.TextBox tex_numero_tarjeta;
		private System.Windows.Forms.TextBox tex_apellido_titular_tarjeta;
		private System.Windows.Forms.TextBox tex_nombre_titular_tarjeta;
		private System.Windows.Forms.ComboBox Combo_nombre_empresa;
		private System.Windows.Forms.DateTimePicker date_fecha_nacimiento;
		
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
			this.Grupo_datos_registro = new System.Windows.Forms.GroupBox();
			this.Bot_verificar_usuario = new System.Windows.Forms.Button();
			this.etiq_contra = new System.Windows.Forms.Label();
			this.etiq_usuario = new System.Windows.Forms.Label();
			this.tex_contra = new System.Windows.Forms.TextBox();
			this.tex_usuario = new System.Windows.Forms.TextBox();
			this.Grupo_datos_personales = new System.Windows.Forms.GroupBox();
			this.Grupo_fecha_de_nacimiento = new System.Windows.Forms.GroupBox();
			this.date_fecha_nacimiento = new System.Windows.Forms.DateTimePicker();
			this.tex_dni = new System.Windows.Forms.TextBox();
			this.tex_apellido = new System.Windows.Forms.TextBox();
			this.tex_nombre = new System.Windows.Forms.TextBox();
			this.etiq_dni = new System.Windows.Forms.Label();
			this.etiq_apellido = new System.Windows.Forms.Label();
			this.etiq_nombre = new System.Windows.Forms.Label();
			this.Grupo_contacto = new System.Windows.Forms.GroupBox();
			this.tex_mail = new System.Windows.Forms.TextBox();
			this.etiq_arroba = new System.Windows.Forms.Label();
			this.etiq_mail = new System.Windows.Forms.Label();
			this.etiq_telefono = new System.Windows.Forms.Label();
			this.tex_dominio = new System.Windows.Forms.TextBox();
			this.tex_telefono = new System.Windows.Forms.TextBox();
			this.Grupo_direccion = new System.Windows.Forms.GroupBox();
			this.tex_torre = new System.Windows.Forms.TextBox();
			this.etiq_torre = new System.Windows.Forms.Label();
			this.etiq_depto = new System.Windows.Forms.Label();
			this.etiq_piso = new System.Windows.Forms.Label();
			this.etiq_numero = new System.Windows.Forms.Label();
			this.etiq_calle = new System.Windows.Forms.Label();
			this.tex_dpto = new System.Windows.Forms.TextBox();
			this.tex_piso = new System.Windows.Forms.TextBox();
			this.tex_nro = new System.Windows.Forms.TextBox();
			this.tex_calle = new System.Windows.Forms.TextBox();
			this.Bot_volver = new System.Windows.Forms.Button();
			this.Bot_registrar = new System.Windows.Forms.Button();
			this.Grupo_datos_tarjeta = new System.Windows.Forms.GroupBox();
			this.etiq_apellido_titular_tarjeta = new System.Windows.Forms.Label();
			this.etiq_nombre_titular_tarjeta = new System.Windows.Forms.Label();
			this.tex_codigo_seguridad = new System.Windows.Forms.TextBox();
			this.etiq_codigo_seguridad = new System.Windows.Forms.Label();
			this.etiq_numero_tarjeta = new System.Windows.Forms.Label();
			this.etiq_empresa = new System.Windows.Forms.Label();
			this.tex_numero_tarjeta = new System.Windows.Forms.TextBox();
			this.tex_apellido_titular_tarjeta = new System.Windows.Forms.TextBox();
			this.tex_nombre_titular_tarjeta = new System.Windows.Forms.TextBox();
			this.Combo_nombre_empresa = new System.Windows.Forms.ComboBox();
			this.Grupo_datos_registro.SuspendLayout();
			this.Grupo_datos_personales.SuspendLayout();
			this.Grupo_fecha_de_nacimiento.SuspendLayout();
			this.Grupo_contacto.SuspendLayout();
			this.Grupo_direccion.SuspendLayout();
			this.Grupo_datos_tarjeta.SuspendLayout();
			this.SuspendLayout();
			// 
			// Grupo_datos_registro
			// 
			this.Grupo_datos_registro.Controls.Add(this.Bot_verificar_usuario);
			this.Grupo_datos_registro.Controls.Add(this.etiq_contra);
			this.Grupo_datos_registro.Controls.Add(this.etiq_usuario);
			this.Grupo_datos_registro.Controls.Add(this.tex_contra);
			this.Grupo_datos_registro.Controls.Add(this.tex_usuario);
			this.Grupo_datos_registro.Location = new System.Drawing.Point(12, 13);
			this.Grupo_datos_registro.Name = "Grupo_datos_registro";
			this.Grupo_datos_registro.Size = new System.Drawing.Size(590, 96);
			this.Grupo_datos_registro.TabIndex = 0;
			this.Grupo_datos_registro.TabStop = false;
			this.Grupo_datos_registro.Text = "Datos de registro";
			// 
			// Bot_verificar_usuario
			// 
			this.Bot_verificar_usuario.Location = new System.Drawing.Point(434, 23);
			this.Bot_verificar_usuario.Name = "Bot_verificar_usuario";
			this.Bot_verificar_usuario.Size = new System.Drawing.Size(90, 20);
			this.Bot_verificar_usuario.TabIndex = 4;
			this.Bot_verificar_usuario.Text = "verificar usuario";
			this.Bot_verificar_usuario.UseVisualStyleBackColor = true;
			this.Bot_verificar_usuario.Click += new System.EventHandler(this.Bot_verificar_usuarioClick);
			// 
			// etiq_contra
			// 
			this.etiq_contra.Location = new System.Drawing.Point(6, 49);
			this.etiq_contra.Name = "etiq_contra";
			this.etiq_contra.Size = new System.Drawing.Size(100, 23);
			this.etiq_contra.TabIndex = 3;
			this.etiq_contra.Text = "Contraseña:";
			this.etiq_contra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// etiq_usuario
			// 
			this.etiq_usuario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.etiq_usuario.Location = new System.Drawing.Point(6, 20);
			this.etiq_usuario.Name = "etiq_usuario";
			this.etiq_usuario.Size = new System.Drawing.Size(100, 23);
			this.etiq_usuario.TabIndex = 2;
			this.etiq_usuario.Text = "Nombre de usuario:";
			this.etiq_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tex_contra
			// 
			this.tex_contra.Location = new System.Drawing.Point(112, 52);
			this.tex_contra.Name = "tex_contra";
			this.tex_contra.Size = new System.Drawing.Size(286, 20);
			this.tex_contra.TabIndex = 1;
			// 
			// tex_usuario
			// 
			this.tex_usuario.Location = new System.Drawing.Point(112, 23);
			this.tex_usuario.Name = "tex_usuario";
			this.tex_usuario.Size = new System.Drawing.Size(286, 20);
			this.tex_usuario.TabIndex = 0;
			// 
			// Grupo_datos_personales
			// 
			this.Grupo_datos_personales.Controls.Add(this.Grupo_fecha_de_nacimiento);
			this.Grupo_datos_personales.Controls.Add(this.tex_dni);
			this.Grupo_datos_personales.Controls.Add(this.tex_apellido);
			this.Grupo_datos_personales.Controls.Add(this.tex_nombre);
			this.Grupo_datos_personales.Controls.Add(this.etiq_dni);
			this.Grupo_datos_personales.Controls.Add(this.etiq_apellido);
			this.Grupo_datos_personales.Controls.Add(this.etiq_nombre);
			this.Grupo_datos_personales.Controls.Add(this.Grupo_contacto);
			this.Grupo_datos_personales.Location = new System.Drawing.Point(12, 115);
			this.Grupo_datos_personales.Name = "Grupo_datos_personales";
			this.Grupo_datos_personales.Size = new System.Drawing.Size(590, 224);
			this.Grupo_datos_personales.TabIndex = 1;
			this.Grupo_datos_personales.TabStop = false;
			this.Grupo_datos_personales.Text = "Datos personales";
			// 
			// Grupo_fecha_de_nacimiento
			// 
			this.Grupo_fecha_de_nacimiento.Controls.Add(this.date_fecha_nacimiento);
			this.Grupo_fecha_de_nacimiento.Location = new System.Drawing.Point(185, 19);
			this.Grupo_fecha_de_nacimiento.Name = "Grupo_fecha_de_nacimiento";
			this.Grupo_fecha_de_nacimiento.Size = new System.Drawing.Size(213, 49);
			this.Grupo_fecha_de_nacimiento.TabIndex = 6;
			this.Grupo_fecha_de_nacimiento.TabStop = false;
			this.Grupo_fecha_de_nacimiento.Text = "Fecha de nacimiento";
			// 
			// date_fecha_nacimiento
			// 
			this.date_fecha_nacimiento.Location = new System.Drawing.Point(6, 23);
			this.date_fecha_nacimiento.Name = "date_fecha_nacimiento";
			this.date_fecha_nacimiento.Size = new System.Drawing.Size(200, 20);
			this.date_fecha_nacimiento.TabIndex = 7;
			// 
			// tex_dni
			// 
			this.tex_dni.Location = new System.Drawing.Point(67, 71);
			this.tex_dni.Name = "tex_dni";
			this.tex_dni.Size = new System.Drawing.Size(100, 20);
			this.tex_dni.TabIndex = 2;
			// 
			// tex_apellido
			// 
			this.tex_apellido.Location = new System.Drawing.Point(67, 45);
			this.tex_apellido.Name = "tex_apellido";
			this.tex_apellido.Size = new System.Drawing.Size(100, 20);
			this.tex_apellido.TabIndex = 2;
			// 
			// tex_nombre
			// 
			this.tex_nombre.Location = new System.Drawing.Point(67, 19);
			this.tex_nombre.Name = "tex_nombre";
			this.tex_nombre.Size = new System.Drawing.Size(100, 20);
			this.tex_nombre.TabIndex = 2;
			// 
			// etiq_dni
			// 
			this.etiq_dni.Location = new System.Drawing.Point(6, 68);
			this.etiq_dni.Name = "etiq_dni";
			this.etiq_dni.Size = new System.Drawing.Size(55, 23);
			this.etiq_dni.TabIndex = 1;
			this.etiq_dni.Text = "Dni:";
			this.etiq_dni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// etiq_apellido
			// 
			this.etiq_apellido.Location = new System.Drawing.Point(6, 45);
			this.etiq_apellido.Name = "etiq_apellido";
			this.etiq_apellido.Size = new System.Drawing.Size(55, 23);
			this.etiq_apellido.TabIndex = 1;
			this.etiq_apellido.Text = "Apellido:";
			this.etiq_apellido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// etiq_nombre
			// 
			this.etiq_nombre.Location = new System.Drawing.Point(6, 22);
			this.etiq_nombre.Name = "etiq_nombre";
			this.etiq_nombre.Size = new System.Drawing.Size(55, 23);
			this.etiq_nombre.TabIndex = 1;
			this.etiq_nombre.Text = "Nombre:";
			this.etiq_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Grupo_contacto
			// 
			this.Grupo_contacto.Controls.Add(this.tex_mail);
			this.Grupo_contacto.Controls.Add(this.etiq_arroba);
			this.Grupo_contacto.Controls.Add(this.etiq_mail);
			this.Grupo_contacto.Controls.Add(this.etiq_telefono);
			this.Grupo_contacto.Controls.Add(this.tex_dominio);
			this.Grupo_contacto.Controls.Add(this.tex_telefono);
			this.Grupo_contacto.Controls.Add(this.Grupo_direccion);
			this.Grupo_contacto.Location = new System.Drawing.Point(6, 97);
			this.Grupo_contacto.Name = "Grupo_contacto";
			this.Grupo_contacto.Size = new System.Drawing.Size(578, 121);
			this.Grupo_contacto.TabIndex = 0;
			this.Grupo_contacto.TabStop = false;
			this.Grupo_contacto.Text = "Información de contacto";
			// 
			// tex_mail
			// 
			this.tex_mail.Location = new System.Drawing.Point(343, 65);
			this.tex_mail.Name = "tex_mail";
			this.tex_mail.Size = new System.Drawing.Size(100, 20);
			this.tex_mail.TabIndex = 5;
			// 
			// etiq_arroba
			// 
			this.etiq_arroba.AutoSize = true;
			this.etiq_arroba.Location = new System.Drawing.Point(449, 66);
			this.etiq_arroba.Name = "etiq_arroba";
			this.etiq_arroba.Size = new System.Drawing.Size(18, 13);
			this.etiq_arroba.TabIndex = 4;
			this.etiq_arroba.Text = "@";
			// 
			// etiq_mail
			// 
			this.etiq_mail.Location = new System.Drawing.Point(280, 61);
			this.etiq_mail.Name = "etiq_mail";
			this.etiq_mail.Size = new System.Drawing.Size(57, 23);
			this.etiq_mail.TabIndex = 3;
			this.etiq_mail.Text = "Mail:";
			this.etiq_mail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// etiq_telefono
			// 
			this.etiq_telefono.Location = new System.Drawing.Point(280, 36);
			this.etiq_telefono.Name = "etiq_telefono";
			this.etiq_telefono.Size = new System.Drawing.Size(57, 23);
			this.etiq_telefono.TabIndex = 2;
			this.etiq_telefono.Text = "Teléfono:";
			this.etiq_telefono.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tex_dominio
			// 
			this.tex_dominio.AutoCompleteCustomSource.AddRange(new string[] {
			"gmail.com",
			"hotmail.com",
			"hotmail.com.ar",
			"live.com",
			"yahoo.com",
			"yahoo.com.ar"});
			this.tex_dominio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.tex_dominio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.tex_dominio.Location = new System.Drawing.Point(473, 64);
			this.tex_dominio.Name = "tex_dominio";
			this.tex_dominio.Size = new System.Drawing.Size(100, 20);
			this.tex_dominio.TabIndex = 1;
			// 
			// tex_telefono
			// 
			this.tex_telefono.Location = new System.Drawing.Point(343, 39);
			this.tex_telefono.Name = "tex_telefono";
			this.tex_telefono.Size = new System.Drawing.Size(100, 20);
			this.tex_telefono.TabIndex = 1;
			// 
			// Grupo_direccion
			// 
			this.Grupo_direccion.Controls.Add(this.tex_torre);
			this.Grupo_direccion.Controls.Add(this.etiq_torre);
			this.Grupo_direccion.Controls.Add(this.etiq_depto);
			this.Grupo_direccion.Controls.Add(this.etiq_piso);
			this.Grupo_direccion.Controls.Add(this.etiq_numero);
			this.Grupo_direccion.Controls.Add(this.etiq_calle);
			this.Grupo_direccion.Controls.Add(this.tex_dpto);
			this.Grupo_direccion.Controls.Add(this.tex_piso);
			this.Grupo_direccion.Controls.Add(this.tex_nro);
			this.Grupo_direccion.Controls.Add(this.tex_calle);
			this.Grupo_direccion.Location = new System.Drawing.Point(6, 19);
			this.Grupo_direccion.Name = "Grupo_direccion";
			this.Grupo_direccion.Size = new System.Drawing.Size(268, 97);
			this.Grupo_direccion.TabIndex = 0;
			this.Grupo_direccion.TabStop = false;
			this.Grupo_direccion.Text = "Dirección";
			// 
			// tex_torre
			// 
			this.tex_torre.Location = new System.Drawing.Point(55, 67);
			this.tex_torre.Name = "tex_torre";
			this.tex_torre.Size = new System.Drawing.Size(32, 20);
			this.tex_torre.TabIndex = 3;
			// 
			// etiq_torre
			// 
			this.etiq_torre.Location = new System.Drawing.Point(6, 64);
			this.etiq_torre.Name = "etiq_torre";
			this.etiq_torre.Size = new System.Drawing.Size(44, 23);
			this.etiq_torre.TabIndex = 2;
			this.etiq_torre.Text = "Torre:";
			this.etiq_torre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// etiq_depto
			// 
			this.etiq_depto.Location = new System.Drawing.Point(173, 65);
			this.etiq_depto.Name = "etiq_depto";
			this.etiq_depto.Size = new System.Drawing.Size(43, 23);
			this.etiq_depto.TabIndex = 1;
			this.etiq_depto.Text = "Depto.:";
			this.etiq_depto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// etiq_piso
			// 
			this.etiq_piso.Location = new System.Drawing.Point(79, 65);
			this.etiq_piso.Name = "etiq_piso";
			this.etiq_piso.Size = new System.Drawing.Size(43, 23);
			this.etiq_piso.TabIndex = 1;
			this.etiq_piso.Text = "Piso:";
			this.etiq_piso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// etiq_numero
			// 
			this.etiq_numero.Location = new System.Drawing.Point(6, 39);
			this.etiq_numero.Name = "etiq_numero";
			this.etiq_numero.Size = new System.Drawing.Size(43, 23);
			this.etiq_numero.TabIndex = 1;
			this.etiq_numero.Text = "Nro:";
			this.etiq_numero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// etiq_calle
			// 
			this.etiq_calle.Location = new System.Drawing.Point(6, 17);
			this.etiq_calle.Name = "etiq_calle";
			this.etiq_calle.Size = new System.Drawing.Size(43, 23);
			this.etiq_calle.TabIndex = 1;
			this.etiq_calle.Text = "Calle:";
			this.etiq_calle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tex_dpto
			// 
			this.tex_dpto.Location = new System.Drawing.Point(222, 67);
			this.tex_dpto.Name = "tex_dpto";
			this.tex_dpto.Size = new System.Drawing.Size(36, 20);
			this.tex_dpto.TabIndex = 0;
			// 
			// tex_piso
			// 
			this.tex_piso.Location = new System.Drawing.Point(128, 68);
			this.tex_piso.Name = "tex_piso";
			this.tex_piso.Size = new System.Drawing.Size(39, 20);
			this.tex_piso.TabIndex = 0;
			// 
			// tex_nro
			// 
			this.tex_nro.Location = new System.Drawing.Point(55, 42);
			this.tex_nro.Name = "tex_nro";
			this.tex_nro.Size = new System.Drawing.Size(39, 20);
			this.tex_nro.TabIndex = 0;
			// 
			// tex_calle
			// 
			this.tex_calle.Location = new System.Drawing.Point(55, 19);
			this.tex_calle.Name = "tex_calle";
			this.tex_calle.Size = new System.Drawing.Size(203, 20);
			this.tex_calle.TabIndex = 0;
			// 
			// Bot_volver
			// 
			this.Bot_volver.Location = new System.Drawing.Point(501, 350);
			this.Bot_volver.Name = "Bot_volver";
			this.Bot_volver.Size = new System.Drawing.Size(55, 39);
			this.Bot_volver.TabIndex = 4;
			this.Bot_volver.Text = "volver";
			this.Bot_volver.UseVisualStyleBackColor = true;
			this.Bot_volver.Click += new System.EventHandler(this.Bot_volverClick);
			// 
			// Bot_registrar
			// 
			this.Bot_registrar.Location = new System.Drawing.Point(422, 350);
			this.Bot_registrar.Name = "Bot_registrar";
			this.Bot_registrar.Size = new System.Drawing.Size(63, 39);
			this.Bot_registrar.TabIndex = 3;
			this.Bot_registrar.Text = "Registrar!";
			this.Bot_registrar.UseVisualStyleBackColor = true;
			this.Bot_registrar.Click += new System.EventHandler(this.Bot_registrarClick);
			// 
			// Grupo_datos_tarjeta
			// 
			this.Grupo_datos_tarjeta.Controls.Add(this.etiq_apellido_titular_tarjeta);
			this.Grupo_datos_tarjeta.Controls.Add(this.etiq_nombre_titular_tarjeta);
			this.Grupo_datos_tarjeta.Controls.Add(this.tex_codigo_seguridad);
			this.Grupo_datos_tarjeta.Controls.Add(this.etiq_codigo_seguridad);
			this.Grupo_datos_tarjeta.Controls.Add(this.etiq_numero_tarjeta);
			this.Grupo_datos_tarjeta.Controls.Add(this.etiq_empresa);
			this.Grupo_datos_tarjeta.Controls.Add(this.tex_numero_tarjeta);
			this.Grupo_datos_tarjeta.Controls.Add(this.tex_apellido_titular_tarjeta);
			this.Grupo_datos_tarjeta.Controls.Add(this.tex_nombre_titular_tarjeta);
			this.Grupo_datos_tarjeta.Controls.Add(this.Combo_nombre_empresa);
			this.Grupo_datos_tarjeta.Location = new System.Drawing.Point(12, 345);
			this.Grupo_datos_tarjeta.Name = "Grupo_datos_tarjeta";
			this.Grupo_datos_tarjeta.Size = new System.Drawing.Size(398, 117);
			this.Grupo_datos_tarjeta.TabIndex = 2;
			this.Grupo_datos_tarjeta.TabStop = false;
			this.Grupo_datos_tarjeta.Text = "Tarjeta de crédito";
			// 
			// etiq_apellido_titular_tarjeta
			// 
			this.etiq_apellido_titular_tarjeta.Location = new System.Drawing.Point(204, 21);
			this.etiq_apellido_titular_tarjeta.Name = "etiq_apellido_titular_tarjeta";
			this.etiq_apellido_titular_tarjeta.Size = new System.Drawing.Size(57, 23);
			this.etiq_apellido_titular_tarjeta.TabIndex = 6;
			this.etiq_apellido_titular_tarjeta.Text = "Apellido:";
			this.etiq_apellido_titular_tarjeta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// etiq_nombre_titular_tarjeta
			// 
			this.etiq_nombre_titular_tarjeta.Location = new System.Drawing.Point(53, 21);
			this.etiq_nombre_titular_tarjeta.Name = "etiq_nombre_titular_tarjeta";
			this.etiq_nombre_titular_tarjeta.Size = new System.Drawing.Size(51, 23);
			this.etiq_nombre_titular_tarjeta.TabIndex = 6;
			this.etiq_nombre_titular_tarjeta.Text = "Nombre:";
			this.etiq_nombre_titular_tarjeta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tex_codigo_seguridad
			// 
			this.tex_codigo_seguridad.Location = new System.Drawing.Point(326, 69);
			this.tex_codigo_seguridad.Name = "tex_codigo_seguridad";
			this.tex_codigo_seguridad.Size = new System.Drawing.Size(44, 20);
			this.tex_codigo_seguridad.TabIndex = 3;
			// 
			// etiq_codigo_seguridad
			// 
			this.etiq_codigo_seguridad.Location = new System.Drawing.Point(213, 72);
			this.etiq_codigo_seguridad.Name = "etiq_codigo_seguridad";
			this.etiq_codigo_seguridad.Size = new System.Drawing.Size(107, 23);
			this.etiq_codigo_seguridad.TabIndex = 5;
			this.etiq_codigo_seguridad.Text = "Código de seguridad:";
			// 
			// etiq_numero_tarjeta
			// 
			this.etiq_numero_tarjeta.Location = new System.Drawing.Point(5, 67);
			this.etiq_numero_tarjeta.Name = "etiq_numero_tarjeta";
			this.etiq_numero_tarjeta.Size = new System.Drawing.Size(99, 23);
			this.etiq_numero_tarjeta.TabIndex = 4;
			this.etiq_numero_tarjeta.Text = "Número de tarjeta:";
			this.etiq_numero_tarjeta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// etiq_empresa
			// 
			this.etiq_empresa.Location = new System.Drawing.Point(5, 44);
			this.etiq_empresa.Name = "etiq_empresa";
			this.etiq_empresa.Size = new System.Drawing.Size(99, 23);
			this.etiq_empresa.TabIndex = 3;
			this.etiq_empresa.Text = "Empresa:";
			this.etiq_empresa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tex_numero_tarjeta
			// 
			this.tex_numero_tarjeta.Location = new System.Drawing.Point(107, 70);
			this.tex_numero_tarjeta.Name = "tex_numero_tarjeta";
			this.tex_numero_tarjeta.Size = new System.Drawing.Size(100, 20);
			this.tex_numero_tarjeta.TabIndex = 2;
			// 
			// tex_apellido_titular_tarjeta
			// 
			this.tex_apellido_titular_tarjeta.Location = new System.Drawing.Point(267, 24);
			this.tex_apellido_titular_tarjeta.Name = "tex_apellido_titular_tarjeta";
			this.tex_apellido_titular_tarjeta.Size = new System.Drawing.Size(100, 20);
			this.tex_apellido_titular_tarjeta.TabIndex = 1;
			// 
			// tex_nombre_titular_tarjeta
			// 
			this.tex_nombre_titular_tarjeta.Location = new System.Drawing.Point(107, 23);
			this.tex_nombre_titular_tarjeta.Name = "tex_nombre_titular_tarjeta";
			this.tex_nombre_titular_tarjeta.Size = new System.Drawing.Size(100, 20);
			this.tex_nombre_titular_tarjeta.TabIndex = 1;
			// 
			// Combo_nombre_empresa
			// 
			this.Combo_nombre_empresa.AutoCompleteCustomSource.AddRange(new string[] {
			"American Express",
			"Maestro",
			"MasterCard",
			"Naranja",
			"Nativa",
			"Visa"});
			this.Combo_nombre_empresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.Combo_nombre_empresa.FormattingEnabled = true;
			this.Combo_nombre_empresa.Items.AddRange(new object[] {
			"American Express",
			"Maestro",
			"MasterCard",
			"Naranja",
			"Nativa",
			"Visa"});
			this.Combo_nombre_empresa.Location = new System.Drawing.Point(107, 46);
			this.Combo_nombre_empresa.Name = "Combo_nombre_empresa";
			this.Combo_nombre_empresa.Size = new System.Drawing.Size(100, 21);
			this.Combo_nombre_empresa.TabIndex = 0;
			// 
			// Registro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(609, 466);
			this.Controls.Add(this.Bot_volver);
			this.Controls.Add(this.Grupo_datos_tarjeta);
			this.Controls.Add(this.Bot_registrar);
			this.Controls.Add(this.Grupo_datos_personales);
			this.Controls.Add(this.Grupo_datos_registro);
			this.Name = "Registro";
			this.Text = "Registro";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistroFormClosing);
			this.Grupo_datos_registro.ResumeLayout(false);
			this.Grupo_datos_registro.PerformLayout();
			this.Grupo_datos_personales.ResumeLayout(false);
			this.Grupo_datos_personales.PerformLayout();
			this.Grupo_fecha_de_nacimiento.ResumeLayout(false);
			this.Grupo_contacto.ResumeLayout(false);
			this.Grupo_contacto.PerformLayout();
			this.Grupo_direccion.ResumeLayout(false);
			this.Grupo_direccion.PerformLayout();
			this.Grupo_datos_tarjeta.ResumeLayout(false);
			this.Grupo_datos_tarjeta.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
