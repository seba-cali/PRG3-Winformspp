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
		public partial class frmAltaPokemon : Form
		{
				private Pokemon pokemon = null;
				public frmAltaPokemon()
				{
						InitializeComponent();
				}
				public frmAltaPokemon(Pokemon pokemon)
				{
						InitializeComponent();
						this.pokemon = pokemon;
						Text = "Modificar Pokemon";
				}


				private void btnCancelar_Click(object sender, EventArgs e)
				{
					this.Close();
				}

				private void btnAceptar_Click(object sender, EventArgs e)
				{
						//todo: Continuar video Modificar Pokemon @ 19 min
						Pokemon	poke = new Pokemon();
						PokemonNegocio negocio = new PokemonNegocio();

						try
						{
								poke.Numero = int.Parse(txtNumero.Text);
								poke.Nombre	= txtNombre.Text;
								poke.Descripcion = txtDescripcion.Text;
								//mapeo la imagen
								poke.UrlImagen	= txtImagen.Text;
								poke.Tipo = (Elemento)cboTipo.SelectedItem;
								poke.Debilidad = (Elemento)cboDebilidad.SelectedItem;

								negocio.agregar(poke);
								MessageBox.Show("Agregado exitosamente");
								Close();

						}
						catch (Exception ex)
						{
								MessageBox.Show(ex.ToString());
						}
				}

				private void frmAltaPokemon_Load(object sender, EventArgs e)
				{
						ElementoNegocio elementoNegocio = new ElementoNegocio();
						try
						{
								cboTipo.DataSource = elementoNegocio.listar();
								cboTipo.ValueMember = "Id";
								cboTipo.DisplayMember = "Descripcion";
								cboDebilidad.DataSource = elementoNegocio.listar();
								cboDebilidad.ValueMember = "Id";
								cboDebilidad.DisplayMember = "Descripcion";


								//preselecciono valores
								if(pokemon != null)
								{
										txtNumero.Text = pokemon.Numero.ToString();
										txtNombre.Text = pokemon.Nombre;
										txtDescripcion.Text = pokemon.Descripcion;
										txtImagen.Text = pokemon.UrlImagen;
										cargarImagen(pokemon.UrlImagen);
										cboTipo.SelectedValue = pokemon.Tipo.Id;
										cboDebilidad.SelectedValue = pokemon.Debilidad.Id;


								}
					

						}
						catch (Exception ex)
						{

								MessageBox.Show(ex.ToString());
						}
				}

				private void txtImagen_Leave(object sender, EventArgs e)
				{
						cargarImagen(txtImagen.Text);
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
