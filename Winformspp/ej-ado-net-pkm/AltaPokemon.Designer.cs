namespace ej_ado_net_pkm
{
		partial class frmAltaPokemon
		{
				/// <summary>
				/// Required designer variable.
				/// </summary>
				private System.ComponentModel.IContainer components = null;

				/// <summary>
				/// Clean up any resources being used.
				/// </summary>
				/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
				protected override void Dispose(bool disposing)
				{
						if (disposing && (components != null))
						{
								components.Dispose();
						}
						base.Dispose(disposing);
				}

				#region Windows Form Designer generated code

				/// <summary>
				/// Required method for Designer support - do not modify
				/// the contents of this method with the code editor.
				/// </summary>
				private void InitializeComponent()
				{
						this.lblNumero = new System.Windows.Forms.Label();
						this.lblNombre = new System.Windows.Forms.Label();
						this.lblDescripcion = new System.Windows.Forms.Label();
						this.txtNumero = new System.Windows.Forms.TextBox();
						this.txtDescripcion = new System.Windows.Forms.TextBox();
						this.txtNombre = new System.Windows.Forms.TextBox();
						this.btnAceptar = new System.Windows.Forms.Button();
						this.btnCancelar = new System.Windows.Forms.Button();
						this.lblDebilidad = new System.Windows.Forms.Label();
						this.lblTipo = new System.Windows.Forms.Label();
						this.cboTipo = new System.Windows.Forms.ComboBox();
						this.cboDebilidad = new System.Windows.Forms.ComboBox();
						this.txtImagen = new System.Windows.Forms.TextBox();
						this.lblImagen = new System.Windows.Forms.Label();
						this.pbxPokemon = new System.Windows.Forms.PictureBox();
						((System.ComponentModel.ISupportInitialize)(this.pbxPokemon)).BeginInit();
						this.SuspendLayout();
						// 
						// lblNumero
						// 
						this.lblNumero.AutoSize = true;
						this.lblNumero.Location = new System.Drawing.Point(13, 38);
						this.lblNumero.Name = "lblNumero";
						this.lblNumero.Size = new System.Drawing.Size(55, 16);
						this.lblNumero.TabIndex = 0;
						this.lblNumero.Text = "Numero";
						// 
						// lblNombre
						// 
						this.lblNombre.AutoSize = true;
						this.lblNombre.Location = new System.Drawing.Point(13, 84);
						this.lblNombre.Name = "lblNombre";
						this.lblNombre.Size = new System.Drawing.Size(56, 16);
						this.lblNombre.TabIndex = 1;
						this.lblNombre.Text = "Nombre";
						// 
						// lblDescripcion
						// 
						this.lblDescripcion.AutoSize = true;
						this.lblDescripcion.Location = new System.Drawing.Point(12, 128);
						this.lblDescripcion.Name = "lblDescripcion";
						this.lblDescripcion.Size = new System.Drawing.Size(79, 16);
						this.lblDescripcion.TabIndex = 2;
						this.lblDescripcion.Text = "Descripcion";
						// 
						// txtNumero
						// 
						this.txtNumero.Location = new System.Drawing.Point(98, 32);
						this.txtNumero.Name = "txtNumero";
						this.txtNumero.Size = new System.Drawing.Size(165, 22);
						this.txtNumero.TabIndex = 0;
						// 
						// txtDescripcion
						// 
						this.txtDescripcion.Location = new System.Drawing.Point(98, 122);
						this.txtDescripcion.Name = "txtDescripcion";
						this.txtDescripcion.Size = new System.Drawing.Size(165, 22);
						this.txtDescripcion.TabIndex = 2;
						// 
						// txtNombre
						// 
						this.txtNombre.Location = new System.Drawing.Point(98, 78);
						this.txtNombre.Name = "txtNombre";
						this.txtNombre.Size = new System.Drawing.Size(165, 22);
						this.txtNombre.TabIndex = 1;
						// 
						// btnAceptar
						// 
						this.btnAceptar.Location = new System.Drawing.Point(15, 331);
						this.btnAceptar.Name = "btnAceptar";
						this.btnAceptar.Size = new System.Drawing.Size(90, 37);
						this.btnAceptar.TabIndex = 6;
						this.btnAceptar.Text = "Aceptar";
						this.btnAceptar.UseVisualStyleBackColor = true;
						this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
						// 
						// btnCancelar
						// 
						this.btnCancelar.Location = new System.Drawing.Point(173, 331);
						this.btnCancelar.Name = "btnCancelar";
						this.btnCancelar.Size = new System.Drawing.Size(90, 37);
						this.btnCancelar.TabIndex = 7;
						this.btnCancelar.Text = "Cancelar";
						this.btnCancelar.UseVisualStyleBackColor = true;
						this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
						// 
						// lblDebilidad
						// 
						this.lblDebilidad.AutoSize = true;
						this.lblDebilidad.Location = new System.Drawing.Point(12, 266);
						this.lblDebilidad.Name = "lblDebilidad";
						this.lblDebilidad.Size = new System.Drawing.Size(66, 16);
						this.lblDebilidad.TabIndex = 8;
						this.lblDebilidad.Text = "Debilidad";
						// 
						// lblTipo
						// 
						this.lblTipo.AutoSize = true;
						this.lblTipo.Location = new System.Drawing.Point(13, 220);
						this.lblTipo.Name = "lblTipo";
						this.lblTipo.Size = new System.Drawing.Size(35, 16);
						this.lblTipo.TabIndex = 9;
						this.lblTipo.Text = "Tipo";
						// 
						// cboTipo
						// 
						this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
						this.cboTipo.FormattingEnabled = true;
						this.cboTipo.Location = new System.Drawing.Point(98, 212);
						this.cboTipo.Name = "cboTipo";
						this.cboTipo.Size = new System.Drawing.Size(165, 24);
						this.cboTipo.TabIndex = 4;
						// 
						// cboDebilidad
						// 
						this.cboDebilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
						this.cboDebilidad.FormattingEnabled = true;
						this.cboDebilidad.Location = new System.Drawing.Point(98, 258);
						this.cboDebilidad.Name = "cboDebilidad";
						this.cboDebilidad.Size = new System.Drawing.Size(165, 24);
						this.cboDebilidad.TabIndex = 5;
						// 
						// txtImagen
						// 
						this.txtImagen.Location = new System.Drawing.Point(98, 166);
						this.txtImagen.Name = "txtImagen";
						this.txtImagen.Size = new System.Drawing.Size(165, 22);
						this.txtImagen.TabIndex = 3;
						this.txtImagen.Leave += new System.EventHandler(this.txtImagen_Leave);
						// 
						// lblImagen
						// 
						this.lblImagen.AutoSize = true;
						this.lblImagen.Location = new System.Drawing.Point(12, 172);
						this.lblImagen.Name = "lblImagen";
						this.lblImagen.Size = new System.Drawing.Size(52, 16);
						this.lblImagen.TabIndex = 12;
						this.lblImagen.Text = "Imagen";
						// 
						// pbxPokemon
						// 
						this.pbxPokemon.Location = new System.Drawing.Point(270, 32);
						this.pbxPokemon.Name = "pbxPokemon";
						this.pbxPokemon.Size = new System.Drawing.Size(268, 250);
						this.pbxPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
						this.pbxPokemon.TabIndex = 14;
						this.pbxPokemon.TabStop = false;
						// 
						// frmAltaPokemon
						// 
						this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						this.ClientSize = new System.Drawing.Size(543, 382);
						this.Controls.Add(this.pbxPokemon);
						this.Controls.Add(this.txtImagen);
						this.Controls.Add(this.lblImagen);
						this.Controls.Add(this.cboDebilidad);
						this.Controls.Add(this.cboTipo);
						this.Controls.Add(this.lblTipo);
						this.Controls.Add(this.lblDebilidad);
						this.Controls.Add(this.btnCancelar);
						this.Controls.Add(this.btnAceptar);
						this.Controls.Add(this.txtNombre);
						this.Controls.Add(this.txtDescripcion);
						this.Controls.Add(this.txtNumero);
						this.Controls.Add(this.lblDescripcion);
						this.Controls.Add(this.lblNombre);
						this.Controls.Add(this.lblNumero);
						this.Name = "frmAltaPokemon";
						this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
						this.Text = "Nuevo Pokemon";
						this.Load += new System.EventHandler(this.frmAltaPokemon_Load);
						((System.ComponentModel.ISupportInitialize)(this.pbxPokemon)).EndInit();
						this.ResumeLayout(false);
						this.PerformLayout();

				}

				#endregion

				private System.Windows.Forms.Label lblNumero;
				private System.Windows.Forms.Label lblNombre;
				private System.Windows.Forms.Label lblDescripcion;
				private System.Windows.Forms.TextBox txtNumero;
				private System.Windows.Forms.TextBox txtDescripcion;
				private System.Windows.Forms.TextBox txtNombre;
				private System.Windows.Forms.Button btnAceptar;
				private System.Windows.Forms.Button btnCancelar;
				private System.Windows.Forms.Label lblDebilidad;
				private System.Windows.Forms.Label lblTipo;
				private System.Windows.Forms.ComboBox cboTipo;
				private System.Windows.Forms.ComboBox cboDebilidad;
				private System.Windows.Forms.TextBox txtImagen;
				private System.Windows.Forms.Label lblImagen;
				private System.Windows.Forms.PictureBox pbxPokemon;
		}
}