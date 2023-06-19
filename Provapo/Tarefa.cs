using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Provapo
{
    public partial class Tarefa : Form
    {
        public Tarefa()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double valor;
            double limpeza = 50;
            double troca = 200;
            double formatação = 100;
            //pix = 10. cartao = 0


            if (box_pagamento.Text == "Dinheiro" && box_servico.Text == "Formatação")
            {
                valor = 100 - (100 * 0.20);
                lb_diferentes.Text = $"{valor}";
            }
            if (box_pagamento.Text == "Dinheiro" && box_servico.Text == "Limpeza")
            {
                valor = 50 - (50 * 0.20);
                lb_diferentes.Text = $"{valor}";
            }
            if (box_pagamento.Text == "Dinheiro" && box_servico.Text == "Troca de peças")
            {
                valor = 200 - (200 * 0.20);
                lb_diferentes.Text = $"{valor}";
            }
            if (box_pagamento.Text == "Pix" && box_servico.Text == "Formatação")
            {
                valor = 100 - (100 * 0.10);
                lb_diferentes.Text = $"{valor}";
            }
            if (box_pagamento.Text == "Pix" && box_servico.Text == "Limpeza")
            {
                valor = 50 - (50 * 0.10);
                lb_diferentes.Text = $"{valor}";
            }
            if (box_pagamento.Text == "Pix" && box_servico.Text == "Troca de peças")
            {
                valor = 200 - (200 * 0.10);
                lb_diferentes.Text = $"{valor}";
            }
            if (box_pagamento.Text == "Cartao" && box_servico.Text == "Formatação")
            {
                valor = 100;
                lb_diferentes.Text = $"{valor}";
            }
            if (box_pagamento.Text == "Cartao" && box_servico.Text == "Limpeza")
            {
                valor = 50;
                lb_diferentes.Text = $"{valor}";
            }
            if (box_pagamento.Text == "Cartao" && box_servico.Text == "Troca de peças")
            {
                valor = 200;

                lb_diferentes.Text = $"{valor}";
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            tx_computador.Clear();
            tx_cliente.Clear();
            box_servico.ResetText();
            box_pagamento.ResetText();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
