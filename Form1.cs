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
        private List<string> Produtos = new List<string>();
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
        void SelectProdutos(List<string> Produto)
        {
            for (int index = 0; index < Produto.Count; index++)
            {
                L_Content.Items.Add(Produto[index] + ":" +  index);
            }
        }
        private void But_Enviar_Click(object sender, EventArgs e)
        {
            if (Input_Produto.Text == "")
                return;
            L_Content.Items.Clear();
            Produtos.Add(Input_Produto.Text);
            SelectProdutos(Produtos);
            Input_Produto.Text = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        
        private void But_Delete_Click(object sender, EventArgs e)
        {
            Produtos.RemoveAt(L_Content.SelectedIndex);
            L_Content.Items.Clear();
            SelectProdutos(Produtos);
        }
    }
}
