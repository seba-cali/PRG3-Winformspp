using System;
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
	public partial class frmPokemons : Form
	{

		private List<Pokemon> listaPokemon;
		public frmPokemons()
		{
			InitializeComponent();
		}

		private void frmPokemons_Load(object sender, EventArgs e)
		{
			cargar();
		}

		private void cargar()
		{
			PokemonNegocio negocio = new PokemonNegocio();
			try
			{
				listaPokemon = negocio.listar();
				dgvPokemons.DataSource = listaPokemon;
				dgvPokemons.Columns["UrlImagen"].Visible = false;//oculta la url de la imagen
				dgvPokemons.Columns["Id"].Visible = false;//oculta la url de la imagen
				cargarImagen(listaPokemon[0].UrlImagen);

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.ToString());
			}
		}

		private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
		{
			Pokemon seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
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

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			frmAltaPokemon alta = new frmAltaPokemon();
			alta.ShowDialog();
			//actualizar carga
			cargar();
		}

		//MODIFICAR//
		private void btnModificar_Click(object sender, EventArgs e)
		{
			Pokemon seleccionado;
			seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
			frmAltaPokemon modificar = new frmAltaPokemon(seleccionado);
			modificar.ShowDialog();
			//actualizar carga
			cargar();
		}
		//ELMINIACION FISICA DE UN POKEMON - INICIO//
		private void btnEliminarFisico_Click(object sender, EventArgs e)
		{
			PokemonNegocio negocio = new PokemonNegocio();
			Pokemon seleccionado;
			
			try
			{
				DialogResult respuesta = MessageBox.Show("Seguro que desea eliminar el Pokemon?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if (respuesta == DialogResult.Yes)
				{
					seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
					negocio.eliminar(seleccionado.Id);
					cargar();
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.ToString());
			}
		}
		//ELMINIACION FISICA DE UN POKEMON - FIN//
	}
}
