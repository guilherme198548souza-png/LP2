using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PVendas01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double[,] data = new double[3, 4];
            String auxiliar = "";
            String saida = "";
            double soma = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    auxiliar = Interaction.InputBox($"Digite o valor {j + 1} do Mês {i + 1}", "Entrada de Dados");
                    if (data[i, j] < 0)
                    {
                        MessageBox.Show("Dado Inválido");
                    }
                    else
                    {
                        soma = data[i,j] + soma;

                    }
                }
                saida += $"";

                Convert.ToString(soma);
       
                lstbxTotal.Items.Add($"Total do Mês {i + 1}: semana:{soma}");
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lstbxTotal.ClearSelected(); 
        }
    }
}
