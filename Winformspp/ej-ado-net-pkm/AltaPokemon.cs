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
								cboDebilidad.DataSource = elementoNegocio.listar();
					

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
