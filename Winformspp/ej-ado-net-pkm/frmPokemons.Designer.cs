namespace ej_ado_net_pkm
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
			this.btnEliminarFisico = new System.Windows.Forms.Button();
			this.btnEliminarLogico = new System.Windows.Forms.Button();
			this.lblFiltro = new System.Windows.Forms.Label();
			this.txtFiltro = new System.Windows.Forms.TextBox();
			this.btnFiltro = new System.Windows.Forms.Button();
			this.lblCampo = new System.Windows.Forms.Label();
			this.cboCampo = new System.Windows.Forms.ComboBox();
			this.lblCriterio = new System.Windows.Forms.Label();
			this.cboCriterio = new System.Windows.Forms.ComboBox();
			this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
			this.lblFiltroAvanzado = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvPokemons)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxPokemon)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvPokemons
			// 
			this.dgvPokemons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPokemons.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvPokemons.Location = new System.Drawing.Point(12, 82);
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
			this.pbxPokemon.Location = new System.Drawing.Point(651, 82);
			this.pbxPokemon.Name = "pbxPokemon";
			this.pbxPokemon.Size = new System.Drawing.Size(270, 220);
			this.pbxPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbxPokemon.TabIndex = 1;
			this.pbxPokemon.TabStop = false;
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(12, 308);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(84, 26);
			this.btnAgregar.TabIndex = 2;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// btnModificar
			// 
			this.btnModificar.Location = new System.Drawing.Point(102, 308);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(86, 26);
			this.btnModificar.TabIndex = 3;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// btnEliminarFisico
			// 
			this.btnEliminarFisico.Location = new System.Drawing.Point(194, 308);
			this.btnEliminarFisico.Name = "btnEliminarFisico";
			this.btnEliminarFisico.Size = new System.Drawing.Size(121, 26);
			this.btnEliminarFisico.TabIndex = 4;
			this.btnEliminarFisico.Text = "Eliminar Fisico";
			this.btnEliminarFisico.UseVisualStyleBackColor = true;
			this.btnEliminarFisico.Click += new System.EventHandler(this.btnEliminarFisico_Click);
			// 
			// btnEliminarLogico
			// 
			this.btnEliminarLogico.Location = new System.Drawing.Point(321, 308);
			this.btnEliminarLogico.Name = "btnEliminarLogico";
			this.btnEliminarLogico.Size = new System.Drawing.Size(121, 26);
			this.btnEliminarLogico.TabIndex = 5;
			this.btnEliminarLogico.Text = "Eliminar Logico";
			this.btnEliminarLogico.UseVisualStyleBackColor = true;
			this.btnEliminarLogico.Click += new System.EventHandler(this.btnEliminarLogico_Click);
			// 
			// lblFiltro
			// 
			this.lblFiltro.AutoSize = true;
			this.lblFiltro.Location = new System.Drawing.Point(13, 32);
			this.lblFiltro.Name = "lblFiltro";
			this.lblFiltro.Size = new System.Drawing.Size(42, 16);
			this.lblFiltro.TabIndex = 6;
			this.lblFiltro.Text = "Filtro: ";
			// 
			// txtFiltro
			// 
			this.txtFiltro.Location = new System.Drawing.Point(61, 30);
			this.txtFiltro.Name = "txtFiltro";
			this.txtFiltro.Size = new System.Drawing.Size(172, 22);
			this.txtFiltro.TabIndex = 7;
			this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
			this.txtFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltro_KeyPress);
			// 
			// btnFiltro
			// 
			this.btnFiltro.Location = new System.Drawing.Point(744, 379);
			this.btnFiltro.Name = "btnFiltro";
			this.btnFiltro.Size = new System.Drawing.Size(161, 22);
			this.btnFiltro.TabIndex = 8;
			this.btnFiltro.Text = "Buscar";
			this.btnFiltro.UseVisualStyleBackColor = true;
			this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
			// 
			// lblCampo
			// 
			this.lblCampo.AutoSize = true;
			this.lblCampo.Location = new System.Drawing.Point(13, 385);
			this.lblCampo.Name = "lblCampo";
			this.lblCampo.Size = new System.Drawing.Size(51, 16);
			this.lblCampo.TabIndex = 9;
			this.lblCampo.Text = "Campo";
			// 
			// cboCampo
			// 
			this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboCampo.FormattingEnabled = true;
			this.cboCampo.Location = new System.Drawing.Point(76, 377);
			this.cboCampo.Name = "cboCampo";
			this.cboCampo.Size = new System.Drawing.Size(161, 24);
			this.cboCampo.TabIndex = 10;
			this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged_1);
			// 
			// lblCriterio
			// 
			this.lblCriterio.AutoSize = true;
			this.lblCriterio.Location = new System.Drawing.Point(256, 385);
			this.lblCriterio.Name = "lblCriterio";
			this.lblCriterio.Size = new System.Drawing.Size(49, 16);
			this.lblCriterio.TabIndex = 11;
			this.lblCriterio.Text = "Criterio";
			// 
			// cboCriterio
			// 
			this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboCriterio.FormattingEnabled = true;
			this.cboCriterio.Location = new System.Drawing.Point(319, 377);
			this.cboCriterio.Name = "cboCriterio";
			this.cboCriterio.Size = new System.Drawing.Size(161, 24);
			this.cboCriterio.TabIndex = 12;
			// 
			// txtFiltroAvanzado
			// 
			this.txtFiltroAvanzado.Location = new System.Drawing.Point(564, 379);
			this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
			this.txtFiltroAvanzado.Size = new System.Drawing.Size(161, 22);
			this.txtFiltroAvanzado.TabIndex = 13;
			// 
			// lblFiltroAvanzado
			// 
			this.lblFiltroAvanzado.AutoSize = true;
			this.lblFiltroAvanzado.Location = new System.Drawing.Point(505, 385);
			this.lblFiltroAvanzado.Name = "lblFiltroAvanzado";
			this.lblFiltroAvanzado.Size = new System.Drawing.Size(36, 16);
			this.lblFiltroAvanzado.TabIndex = 14;
			this.lblFiltroAvanzado.Text = "Filtro";
			// 
			// frmPokemons
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(945, 443);
			this.Controls.Add(this.lblFiltroAvanzado);
			this.Controls.Add(this.txtFiltroAvanzado);
			this.Controls.Add(this.cboCriterio);
			this.Controls.Add(this.lblCriterio);
			this.Controls.Add(this.cboCampo);
			this.Controls.Add(this.lblCampo);
			this.Controls.Add(this.btnFiltro);
			this.Controls.Add(this.txtFiltro);
			this.Controls.Add(this.lblFiltro);
			this.Controls.Add(this.btnEliminarLogico);
			this.Controls.Add(this.btnEliminarFisico);
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
			this.PerformLayout();

				}

				#endregion

				private System.Windows.Forms.DataGridView dgvPokemons;
				private System.Windows.Forms.PictureBox pbxPokemon;
				private System.Windows.Forms.Button btnAgregar;
				private System.Windows.Forms.Button btnModificar;
				private System.Windows.Forms.Button btnEliminarFisico;
		private System.Windows.Forms.Button btnEliminarLogico;
		private System.Windows.Forms.Label lblFiltro;
		private System.Windows.Forms.TextBox txtFiltro;
		private System.Windows.Forms.Button btnFiltro;
		private System.Windows.Forms.Label lblCampo;
		private System.Windows.Forms.ComboBox cboCampo;
		private System.Windows.Forms.Label lblCriterio;
		private System.Windows.Forms.ComboBox cboCriterio;
		private System.Windows.Forms.TextBox txtFiltroAvanzado;
		private System.Windows.Forms.Label lblFiltroAvanzado;
	}
}

