using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ErickAula1.AlterProduct;
namespace ErickAula1
{
    public partial class CadastroProduto : Form
    {
        private List<string> Produtos = new List<string>();
        protected bool Alter = false;
        public Alter ActualAlter;
        public CadastroProduto()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Input_Produto.Focus();
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
        void Enviar()
        {
            if (Input_Produto.Text == "")
                return;

            if (!Alter)
                Produtos.Add(Input_Produto.Text);
            else
            {
                if (L_Content.SelectedIndex < 0)
                {
                    Alter = false;
                    return;
                }
                ActualAlter = new Alter(L_Content.SelectedIndex, Input_Produto.Text);
                Produtos[ActualAlter.GetIndex] = ActualAlter.GetProduct;
                Alter = false;
            }
            L_Content.Items.Clear();
            SelectProdutos(Produtos);
            Input_Produto.Text = "";
            Input_Produto.Focus();
        }
        private void But_Enviar_Click(object sender, EventArgs e)
        {
            Enviar();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        
        private void But_Delete_Click(object sender, EventArgs e)
        {
            if (L_Content.SelectedIndex < 0)
                return;
            Produtos.RemoveAt(L_Content.SelectedIndex);
            L_Content.Items.Clear();
            SelectProdutos(Produtos);
        }

        private void But_Alterar_Click(object sender, EventArgs e)
        {
            if (L_Content.SelectedIndex < 0)
                return;
            Input_Produto.Text = Produtos[L_Content.SelectedIndex];
            Alter = true;
            Input_Produto.Focus();

        }

        private void But_Enviar_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void Input_Produto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Enviar();
            }
        }
    }
}
