using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AiBot
{
    public partial class IAChat: Form
    {
        Label labeltexto = new Label();
        RichTextBox chat = new RichTextBox();
        private async Task anima(Label lb, string texto, int tempo)
        {
            lb.Text = "";
            foreach (char i in texto.ToCharArray())
            {
                lb.Text += i;
                await Task.Delay(tempo);
            }
        }
        int i = 0;
        public IAChat()
        {
            InitializeComponent();
        }

        private void IAChat_Load(object sender, EventArgs e)
        {
            labeltexto.Location = new Point(193, 208);
            labeltexto.Size = new Size(415, 34);
            this.Controls.Add(labeltexto);
            anima(labeltexto, "No que você está pensando hoje?", 120);
            panel1Historico.Visible = false;

        }

        private void iABotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1Historico.Visible = true;
        }

        private void xToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1Historico.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void IAChat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Controls.Remove(labeltexto);
                this.Controls.Add(chat);
            }
        }
    }
}
