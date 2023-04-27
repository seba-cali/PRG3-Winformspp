using System;
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
				public frmPokemons()
				{
						InitializeComponent();
				}

				private void frmPokemons_Load(object sender, EventArgs e)
				{
						PokemonNegocio	negocio = new PokemonNegocio();
						dgvPokemons.DataSource = negocio.listar();
				}
		}
}
