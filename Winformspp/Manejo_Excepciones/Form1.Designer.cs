namespace Manejo_Excepciones
{
		partial class Form1
		{
				/// <summary>
				/// Variable del diseñador necesaria.
				/// </summary>
				private System.ComponentModel.IContainer components = null;

				/// <summary>
				/// Limpiar los recursos que se estén usando.
				/// </summary>
				/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
				protected override void Dispose(bool disposing)
				{
						if (disposing && (components != null))
						{
								components.Dispose();
						}
						base.Dispose(disposing);
				}

				#region Código generado por el Diseñador de Windows Forms

				/// <summary>
				/// Método necesario para admitir el Diseñador. No se puede modificar
				/// el contenido de este método con el editor de código.
				/// </summary>
				private void InitializeComponent()
				{
						this.txtNumero1 = new System.Windows.Forms.TextBox();
						this.txtNumero2 = new System.Windows.Forms.TextBox();
						this.btnCalcular = new System.Windows.Forms.Button();
						this.lblResultado = new System.Windows.Forms.Label();
						this.SuspendLayout();
						// 
						// txtNumero1
						// 
						this.txtNumero1.Location = new System.Drawing.Point(164, 49);
						this.txtNumero1.Name = "txtNumero1";
						this.txtNumero1.Size = new System.Drawing.Size(162, 22);
						this.txtNumero1.TabIndex = 0;
						// 
						// txtNumero2
						// 
						this.txtNumero2.Location = new System.Drawing.Point(164, 136);
						this.txtNumero2.Name = "txtNumero2";
						this.txtNumero2.Size = new System.Drawing.Size(162, 22);
						this.txtNumero2.TabIndex = 1;
						// 
						// btnCalcular
						// 
						this.btnCalcular.Location = new System.Drawing.Point(191, 214);
						this.btnCalcular.Name = "btnCalcular";
						this.btnCalcular.Size = new System.Drawing.Size(102, 46);
						this.btnCalcular.TabIndex = 2;
						this.btnCalcular.Text = "Calcular";
						this.btnCalcular.UseVisualStyleBackColor = true;
						this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
						// 
						// lblResultado
						// 
						this.lblResultado.AutoSize = true;
						this.lblResultado.Location = new System.Drawing.Point(191, 267);
						this.lblResultado.Name = "lblResultado";
						this.lblResultado.Size = new System.Drawing.Size(14, 16);
						this.lblResultado.TabIndex = 3;
						this.lblResultado.Text = "=";
						// 
						// Form1
						// 
						this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						this.ClientSize = new System.Drawing.Size(478, 466);
						this.Controls.Add(this.lblResultado);
						this.Controls.Add(this.btnCalcular);
						this.Controls.Add(this.txtNumero2);
						this.Controls.Add(this.txtNumero1);
						this.Name = "Form1";
						this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
						this.Text = "Form1";
						this.ResumeLayout(false);
						this.PerformLayout();

				}

				#endregion

				private System.Windows.Forms.TextBox txtNumero1;
				private System.Windows.Forms.TextBox txtNumero2;
				private System.Windows.Forms.Button btnCalcular;
				private System.Windows.Forms.Label lblResultado;
		}
}

