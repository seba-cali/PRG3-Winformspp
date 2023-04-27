using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejo_Excepciones
{
		public partial class Form1 : Form
		{
				public Form1()
				{
						InitializeComponent();
				}

				private void btnCalcular_Click(object sender, EventArgs e)
				{
						int a, b, r;
						try
						{
								a = int.Parse(txtNumero1.Text);
								b = int.Parse(txtNumero2.Text);
								r = a / b;
								lblResultado.Text = "= " + r;
						}
						catch (FormatException ex)//aca decidimos que hacer
						{
								MessageBox.Show("Por favor, cargar solo numeros.");
								//throw;
						}
						catch (DivideByZeroException ex)
						{
								MessageBox.Show("No se puede dividir por cero.");
						}
						catch (Exception ex)
						{
								MessageBox.Show("Error: " + ex.Message);//error generico
						}
				}
		}
}
