using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ErickAula1
{
    public partial class CadastroProduto : Form
    {
        private string Produto;
        private int index = 1;
        public CadastroProduto()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panelGradient1_Paint(object sender, PaintEventArgs e)
        {
            panelGradient1.Width = ClientSize.Width;
            panelGradient1.Height = ClientSize.Height;
        }

        private void Content_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void But_Enviar_Click(object sender, EventArgs e)
        {
            Produto = Input_Produto.Text + "." + index;
            Content.Text += Produto;
            Content.Text += System.Environment.NewLine;
            Content.Text += "____________________________" + System.Environment.NewLine;
            index++;
            Input_Produto.Text = "";
        }
    }
}
