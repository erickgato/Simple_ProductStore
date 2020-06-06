namespace ErickAula1
{
    partial class CadastroProduto
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroProduto));
            this.panelGradient1 = new Gradient.PanelGradient();
            this.But_Delete = new Gradient.Gradient_Button();
            this.L_Content = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.But_Enviar = new Gradient.Gradient_Button();
            this.Input_Produto = new System.Windows.Forms.TextBox();
            this.Texto1 = new System.Windows.Forms.Label();
            this.panelGradient1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGradient1
            // 
            this.panelGradient1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelGradient1.Controls.Add(this.But_Delete);
            this.panelGradient1.Controls.Add(this.L_Content);
            this.panelGradient1.Controls.Add(this.label1);
            this.panelGradient1.Controls.Add(this.But_Enviar);
            this.panelGradient1.Controls.Add(this.Input_Produto);
            this.panelGradient1.Controls.Add(this.Texto1);
            this.panelGradient1.CorBaixo = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(11)))), ((int)(((byte)(54)))));
            this.panelGradient1.CorCima = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(20)))), ((int)(((byte)(50)))));
            this.panelGradient1.Location = new System.Drawing.Point(0, -3);
            this.panelGradient1.Name = "panelGradient1";
            this.panelGradient1.Size = new System.Drawing.Size(805, 464);
            this.panelGradient1.TabIndex = 0;
            this.panelGradient1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGradient1_Paint);
            // 
            // But_Delete
            // 
            this.But_Delete.AutoSize = true;
            this.But_Delete.BackColor = System.Drawing.Color.Transparent;
            this.But_Delete.CorBaixo = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(138)))), ((int)(((byte)(229)))));
            this.But_Delete.CorCima = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.But_Delete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.But_Delete.FlatAppearance.BorderSize = 3;
            this.But_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_Delete.Font = new System.Drawing.Font("NSimSun", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_Delete.ForeColor = System.Drawing.Color.Transparent;
            this.But_Delete.Location = new System.Drawing.Point(390, 95);
            this.But_Delete.Name = "But_Delete";
            this.But_Delete.Size = new System.Drawing.Size(146, 39);
            this.But_Delete.TabIndex = 9;
            this.But_Delete.Text = "Delete";
            this.But_Delete.UseVisualStyleBackColor = false;
            this.But_Delete.Click += new System.EventHandler(this.But_Delete_Click);
            // 
            // L_Content
            // 
            this.L_Content.BackColor = System.Drawing.SystemColors.Menu;
            this.L_Content.Font = new System.Drawing.Font("NSimSun", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Content.FormattingEnabled = true;
            this.L_Content.ItemHeight = 19;
            this.L_Content.Items.AddRange(new object[] {
            " "});
            this.L_Content.Location = new System.Drawing.Point(19, 95);
            this.L_Content.Name = "L_Content";
            this.L_Content.Size = new System.Drawing.Size(365, 232);
            this.L_Content.TabIndex = 7;
            this.L_Content.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("NSimSun", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(557, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "By: Erick Gato";
            // 
            // But_Enviar
            // 
            this.But_Enviar.AutoSize = true;
            this.But_Enviar.BackColor = System.Drawing.Color.Transparent;
            this.But_Enviar.CorBaixo = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(138)))), ((int)(((byte)(229)))));
            this.But_Enviar.CorCima = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.But_Enviar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.But_Enviar.FlatAppearance.BorderSize = 3;
            this.But_Enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_Enviar.Font = new System.Drawing.Font("NSimSun", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_Enviar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.But_Enviar.Location = new System.Drawing.Point(499, 29);
            this.But_Enviar.Name = "But_Enviar";
            this.But_Enviar.Size = new System.Drawing.Size(146, 39);
            this.But_Enviar.TabIndex = 4;
            this.But_Enviar.Text = "Send";
            this.But_Enviar.UseVisualStyleBackColor = false;
            this.But_Enviar.Click += new System.EventHandler(this.But_Enviar_Click);
            // 
            // Input_Produto
            // 
            this.Input_Produto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Input_Produto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Input_Produto.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_Produto.Location = new System.Drawing.Point(207, 29);
            this.Input_Produto.Multiline = true;
            this.Input_Produto.Name = "Input_Produto";
            this.Input_Produto.Size = new System.Drawing.Size(242, 37);
            this.Input_Produto.TabIndex = 2;
            // 
            // Texto1
            // 
            this.Texto1.AutoSize = true;
            this.Texto1.BackColor = System.Drawing.Color.Transparent;
            this.Texto1.Font = new System.Drawing.Font("NSimSun", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Texto1.ForeColor = System.Drawing.Color.Snow;
            this.Texto1.Location = new System.Drawing.Point(12, 31);
            this.Texto1.Name = "Texto1";
            this.Texto1.Size = new System.Drawing.Size(188, 37);
            this.Texto1.TabIndex = 1;
            this.Texto1.Text = "Product: ";
            // 
            // CadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 361);
            this.Controls.Add(this.panelGradient1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CadastroProduto";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Store Products";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelGradient1.ResumeLayout(false);
            this.panelGradient1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Gradient.PanelGradient panelGradient1;
        private System.Windows.Forms.Label Texto1;
        private System.Windows.Forms.TextBox Input_Produto;
        private Gradient.Gradient_Button But_Enviar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox L_Content;
        private Gradient.Gradient_Button But_Delete;
    }
}

