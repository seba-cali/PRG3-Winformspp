﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ej_ado_net_pkm
{
		public partial class frmPokemons : Form
		{

				private List<Pokemon> listaPokemon;
				public frmPokemons()
				{
						InitializeComponent();
				}

				private void frmPokemons_Load(object sender, EventArgs e)
				{
						PokemonNegocio	negocio = new PokemonNegocio();
						listaPokemon = negocio.listar();
						dgvPokemons.DataSource = listaPokemon;
						dgvPokemons.Columns["UrlImagen"].Visible = false;//oculta la url de la imagen
					 cargarImagen(listaPokemon[0].UrlImagen);
				}

				private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
				{
						Pokemon seleccionado=(Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
						cargarImagen(seleccionado.UrlImagen);

				}

				private void cargarImagen(string imagen)
				{
						try
						{
								pbxPokemon.Load(imagen);
						}
						catch (Exception ex)
						{
								pbxPokemon.Load("https://png.pngtree.com/png-vector/20210604/ourmid/pngtree-gray-network-placeholder-png-image_3416659.jpg");
						}
				}
		}
}
