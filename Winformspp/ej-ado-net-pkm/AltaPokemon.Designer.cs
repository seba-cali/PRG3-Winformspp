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
						this.SuspendLayout();
						// 
						// lblNumero
						// 
						this.lblNumero.AutoSize = true;
						this.lblNumero.Location = new System.Drawing.Point(13, 47);
						this.lblNumero.Name = "lblNumero";
						this.lblNumero.Size = new System.Drawing.Size(55, 16);
						this.lblNumero.TabIndex = 0;
						this.lblNumero.Text = "Numero";
						// 
						// lblNombre
						// 
						this.lblNombre.AutoSize = true;
						this.lblNombre.Location = new System.Drawing.Point(13, 93);
						this.lblNombre.Name = "lblNombre";
						this.lblNombre.Size = new System.Drawing.Size(56, 16);
						this.lblNombre.TabIndex = 1;
						this.lblNombre.Text = "Nombre";
						// 
						// lblDescripcion
						// 
						this.lblDescripcion.AutoSize = true;
						this.lblDescripcion.Location = new System.Drawing.Point(13, 137);
						this.lblDescripcion.Name = "lblDescripcion";
						this.lblDescripcion.Size = new System.Drawing.Size(79, 16);
						this.lblDescripcion.TabIndex = 2;
						this.lblDescripcion.Text = "Descripcion";
						// 
						// txtNumero
						// 
						this.txtNumero.Location = new System.Drawing.Point(98, 41);
						this.txtNumero.Name = "txtNumero";
						this.txtNumero.Size = new System.Drawing.Size(165, 22);
						this.txtNumero.TabIndex = 3;
						// 
						// txtDescripcion
						// 
						this.txtDescripcion.Location = new System.Drawing.Point(98, 131);
						this.txtDescripcion.Name = "txtDescripcion";
						this.txtDescripcion.Size = new System.Drawing.Size(165, 22);
						this.txtDescripcion.TabIndex = 4;
						// 
						// txtNombre
						// 
						this.txtNombre.Location = new System.Drawing.Point(98, 87);
						this.txtNombre.Name = "txtNombre";
						this.txtNombre.Size = new System.Drawing.Size(165, 22);
						this.txtNombre.TabIndex = 5;
						// 
						// btnAceptar
						// 
						this.btnAceptar.Location = new System.Drawing.Point(16, 210);
						this.btnAceptar.Name = "btnAceptar";
						this.btnAceptar.Size = new System.Drawing.Size(90, 37);
						this.btnAceptar.TabIndex = 6;
						this.btnAceptar.Text = "Agregar";
						this.btnAceptar.UseVisualStyleBackColor = true;
						this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
						// 
						// btnCancelar
						// 
						this.btnCancelar.Location = new System.Drawing.Point(173, 210);
						this.btnCancelar.Name = "btnCancelar";
						this.btnCancelar.Size = new System.Drawing.Size(90, 37);
						this.btnCancelar.TabIndex = 7;
						this.btnCancelar.Text = "Cancelar";
						this.btnCancelar.UseVisualStyleBackColor = true;
						this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
						// 
						// frmAltaPokemon
						// 
						this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						this.ClientSize = new System.Drawing.Size(283, 298);
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
						this.Text = "NuevoPokemon";
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
		}
}