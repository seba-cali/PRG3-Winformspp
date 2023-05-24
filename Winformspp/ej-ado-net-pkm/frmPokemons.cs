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
			cboCampo.Items.Add("Numero");
			cboCampo.Items.Add("Nombre");
			cboCampo.Items.Add("Descripción");
		}

		private void cargar()
		{
			PokemonNegocio negocio = new PokemonNegocio();
			try
			{
				listaPokemon = negocio.listar();
				dgvPokemons.DataSource = listaPokemon;
				ocultarColumnas();
				cargarImagen(listaPokemon[0].UrlImagen);

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.ToString());
			}
		}

		private void ocultarColumnas()
		{
			dgvPokemons.Columns["UrlImagen"].Visible = false;//oculta la url de la imagen
			dgvPokemons.Columns["Id"].Visible = false;//oculta la url de la imagen
		}

		private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
		{

			if (dgvPokemons.CurrentRow != null)
			{
				Pokemon seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
				cargarImagen(seleccionado.UrlImagen);
			}

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
			eliminar();
		}
		//ELMINIACION FISICA DE UN POKEMON - FIN//

		private void btnEliminarLogico_Click(object sender, EventArgs e)
		{
			eliminar(true);
		}

		private void eliminar(bool logico = false) // hace que este valor sea opcional, por defecto toma false
		{
			PokemonNegocio negocio = new PokemonNegocio();
			Pokemon seleccionado;

			try
			{
				DialogResult respuesta = MessageBox.Show("Seguro que desea eliminar el Pokemon?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if (respuesta == DialogResult.Yes)
				{
					seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;

					if (logico)
						negocio.eliminarLogico(seleccionado.Id);
					else
						negocio.eliminar(seleccionado.Id);

					cargar();
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.ToString());
			}
		}

		private bool validarFiltro()
		{
			if(cboCampo.SelectedIndex < 0)
			{
				MessageBox.Show("Seleccione un campo para filtrar");
				return true;

			}
			if (cboCriterio.SelectedIndex < 0)
			{
				MessageBox.Show("Seleccione un criterio para filtrar");
				return true;
			}
			if(cboCampo.SelectedItem.ToString() == "Numero")
			{
				if(string.IsNullOrEmpty(txtFiltroAvanzado.Text))
				{
					MessageBox.Show("Ingrese un numero para filtrar");
					return true;
				}
				if (!(soloNumeros(txtFiltroAvanzado.Text)))
				{
					MessageBox.Show("Ingrese solo numeros para campos numericos");
					return true;
				}
			}
			return false;
		}

		private bool soloNumeros(string cadena)
		{
			foreach (char c in cadena)
			{
				if ((!char.IsNumber(c)))
					return false;
			}
			return true;
		}


		//Filtro rapido que trabaja sobre lista, pero no en DB
		private void btnFiltro_Click(object sender, EventArgs e)
		{
			PokemonNegocio negocio = new PokemonNegocio();
			try
			{
				if (validarFiltro())
				{
					return;
				}
				string campo = cboCampo.SelectedItem.ToString();
				string criterio = cboCriterio.SelectedItem.ToString();
				string filtro = txtFiltroAvanzado.Text;
				dgvPokemons.DataSource = negocio.filtrar(campo, criterio, filtro);

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				
			}

		}

		private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
		{
		}

		private void txtFiltro_TextChanged(object sender, EventArgs e)
		{
			List<Pokemon> listaFiltrada;
			string filtro = txtFiltro.Text;

			if (filtro != "")
			{
				listaFiltrada = listaPokemon.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Tipo.Descripcion.ToUpper().Contains(filtro.ToUpper()));// lambda expresion

			}
			else
			{
				listaFiltrada = listaPokemon;
			}
			dgvPokemons.DataSource = null;//limpieza xq no lo puede pisar
			dgvPokemons.DataSource = listaFiltrada;
			ocultarColumnas();
		}

		private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

		private void cboCampo_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			string opcion = cboCampo.SelectedItem.ToString();
			if (opcion == "Numero")
			{
				cboCriterio.Items.Clear();
				cboCriterio.Items.Add("Mayor a");
				cboCriterio.Items.Add("Menor a");
				cboCriterio.Items.Add("Igual a");
			}
			else
			{
				cboCriterio.Items.Clear();
				cboCriterio.Items.Add("Comienza con");
				cboCriterio.Items.Add("Termina con");
				cboCriterio.Items.Add("Contiene");
			}
		}
	}
}
