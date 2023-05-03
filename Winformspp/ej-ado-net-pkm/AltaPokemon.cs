﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace ej_ado_net_pkm
{
		public partial class frmAltaPokemon : Form
		{
				public frmAltaPokemon()
				{
						InitializeComponent();
				}

				private void btnCancelar_Click(object sender, EventArgs e)
				{
					this.Close();
				}

				private void btnAceptar_Click(object sender, EventArgs e)
				{
						Pokemon	poke = new Pokemon();
						PokemonNegocio negocio = new PokemonNegocio();

						try
						{
								poke.Numero = int.Parse(txtNumero.Text);
								poke.Nombre	= txtNombre.Text;
								poke.Descripcion = txtDescripcion.Text;

								negocio.agregar(poke);
								MessageBox.Show("Agregado exitosamente");
								Close();

						}
						catch (Exception ex)
						{
								MessageBox.Show(ex.ToString());
						}
				}
		}
}
