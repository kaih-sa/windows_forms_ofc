using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_windows_forms
{
    public partial class Form9 : Form
    {
        public string TextoPronto { get; private set; }
        public class TextosExistentes
        {
            public string TextoPronto { get; set; }

        }
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string conteudo = richTextBox1.Text;

            Form12 j12 = new Form12(conteudo);

            j12.Show();
        }
    }
}
