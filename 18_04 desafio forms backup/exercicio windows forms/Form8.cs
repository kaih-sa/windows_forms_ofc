using System;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static exercicio_windows_forms.Form4;
using System.Reflection.Emit;

namespace exercicio_windows_forms
{
    public partial class Form8 : Form
    {
       
        Form4 cantores = new Form4();

        public int limite = 0;
        public Form8()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            

            /*
            foreach (string x in cantores)
            {
                Console.WriteLine(x);
            }/*
            for (int i = 0; i < limite; i++)
            {

                Console.WriteLine($"Música: {lista_musicas[i].getTitulo()} \n Cantor: {lista_musicas[i].getAutor()}\n Nota: {lista_musicas[i].getNota()}");
            }*/
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
