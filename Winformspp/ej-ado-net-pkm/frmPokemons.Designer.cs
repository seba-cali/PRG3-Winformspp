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
						this.pbxPokemon = new System.Windows.Forms.PictureBox();
						this.btnAgregar = new System.Windows.Forms.Button();
						this.btnModificar = new System.Windows.Forms.Button();
						((System.ComponentModel.ISupportInitialize)(this.dgvPokemons)).BeginInit();
						((System.ComponentModel.ISupportInitialize)(this.pbxPokemon)).BeginInit();
						this.SuspendLayout();
						// 
						// dgvPokemons
						// 
						this.dgvPokemons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
						this.dgvPokemons.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
						this.dgvPokemons.Location = new System.Drawing.Point(12, 12);
						this.dgvPokemons.MultiSelect = false;
						this.dgvPokemons.Name = "dgvPokemons";
						this.dgvPokemons.RowHeadersWidth = 51;
						this.dgvPokemons.RowTemplate.Height = 24;
						this.dgvPokemons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
						this.dgvPokemons.Size = new System.Drawing.Size(633, 220);
						this.dgvPokemons.TabIndex = 0;
						this.dgvPokemons.SelectionChanged += new System.EventHandler(this.dgvPokemons_SelectionChanged);
						// 
						// pbxPokemon
						// 
						this.pbxPokemon.Location = new System.Drawing.Point(651, 12);
						this.pbxPokemon.Name = "pbxPokemon";
						this.pbxPokemon.Size = new System.Drawing.Size(270, 220);
						this.pbxPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
						this.pbxPokemon.TabIndex = 1;
						this.pbxPokemon.TabStop = false;
						// 
						// btnAgregar
						// 
						this.btnAgregar.Location = new System.Drawing.Point(12, 238);
						this.btnAgregar.Name = "btnAgregar";
						this.btnAgregar.Size = new System.Drawing.Size(84, 26);
						this.btnAgregar.TabIndex = 2;
						this.btnAgregar.Text = "Agregar";
						this.btnAgregar.UseVisualStyleBackColor = true;
						this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
						// 
						// btnModificar
						// 
						this.btnModificar.Location = new System.Drawing.Point(102, 238);
						this.btnModificar.Name = "btnModificar";
						this.btnModificar.Size = new System.Drawing.Size(86, 26);
						this.btnModificar.TabIndex = 3;
						this.btnModificar.Text = "Modificar";
						this.btnModificar.UseVisualStyleBackColor = true;
						this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
						// 
						// frmPokemons
						// 
						this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						this.ClientSize = new System.Drawing.Size(929, 294);
						this.Controls.Add(this.btnModificar);
						this.Controls.Add(this.btnAgregar);
						this.Controls.Add(this.pbxPokemon);
						this.Controls.Add(this.dgvPokemons);
						this.Name = "frmPokemons";
						this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
						this.Text = "Form1";
						this.Load += new System.EventHandler(this.frmPokemons_Load);
						((System.ComponentModel.ISupportInitialize)(this.dgvPokemons)).EndInit();
						((System.ComponentModel.ISupportInitialize)(this.pbxPokemon)).EndInit();
						this.ResumeLayout(false);

				}

				#endregion

				private System.Windows.Forms.DataGridView dgvPokemons;
				private System.Windows.Forms.PictureBox pbxPokemon;
				private System.Windows.Forms.Button btnAgregar;
				private System.Windows.Forms.Button btnModificar;
		}
}

