﻿namespace ej_ado_net_pkm
{
		partial class frmPokemons
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
						this.dgvPokemons = new System.Windows.Forms.DataGridView();
						((System.ComponentModel.ISupportInitialize)(this.dgvPokemons)).BeginInit();
						this.SuspendLayout();
						// 
						// dgvPokemons
						// 
						this.dgvPokemons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
						this.dgvPokemons.Location = new System.Drawing.Point(34, 78);
						this.dgvPokemons.Name = "dgvPokemons";
						this.dgvPokemons.RowHeadersWidth = 51;
						this.dgvPokemons.RowTemplate.Height = 24;
						this.dgvPokemons.Size = new System.Drawing.Size(448, 150);
						this.dgvPokemons.TabIndex = 0;
						// 
						// frmPokemons
						// 
						this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						this.ClientSize = new System.Drawing.Size(521, 492);
						this.Controls.Add(this.dgvPokemons);
						this.Name = "frmPokemons";
						this.Text = "Form1";
						this.Load += new System.EventHandler(this.frmPokemons_Load);
						((System.ComponentModel.ISupportInitialize)(this.dgvPokemons)).EndInit();
						this.ResumeLayout(false);

				}

				#endregion

				private System.Windows.Forms.DataGridView dgvPokemons;
		}
}

