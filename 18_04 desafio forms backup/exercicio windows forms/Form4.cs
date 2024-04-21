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
    public partial class Form4 : Form
    {
        public int limite = 0;
        Musicas[] lista_musicas = new Musicas[5];
        public Form4()
        {
            InitializeComponent();
        }
        public class Musicas
        {
            private string Titulo;
            private string Autor;
            private string Nota;

            public string getNota()
            {
                return Nota;
            }
            public void setNota(string d)
            {
                this.Nota = d;
            }
            public string getTitulo()
            {

                return Titulo;
            }

            public string getAutor()
            {
                return Autor;
            }

            public void setTitulo(string a)
            {
                this.Titulo = a;
            }

            public void setAutor(string b)
            {
                this.Autor = b;
            }
        
        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            
            Musicas x = new Musicas();
            
            //kai
            
            x.setTitulo(textBox1.Text);
            x.setAutor(textBox2.Text);
            x.setNota(textBox3.Text);
            lista_musicas[limite] = x;
            limite++;
           

            for (int i = 0; i < limite; i++)
            {

                Console.WriteLine($"Música: {lista_musicas[i].getTitulo()} \n Cantor: {lista_musicas[i].getAutor()}\n Nota: {lista_musicas[i].getNota()}");
            }

           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
