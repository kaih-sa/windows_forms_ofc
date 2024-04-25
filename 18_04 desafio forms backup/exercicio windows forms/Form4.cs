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
        //public int limite = 0;
        //public List<string> cantores = new List<string>();
        

       /* List<string> musicas = new List<string>();
        List<string> notas = new List<string>();*/

        public static List<string> cantores = new List<string>();

        public void AdicionarItem(string a)
        {
            cantores.Add(a);
        }

        public List<string> ObterLista()
        {
            return cantores;
        }
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

            //Musicas x = new Musicas();


            AdicionarItem(textBox2.Text);
            /*musicas.Add(textBox1.Text);
            notas.Add(textBox3.Text);*/

            Console.WriteLine("Cantores1: ");
            foreach (string x in cantores)
            {
                Console.WriteLine(x);
            }

            /*
            x.setTitulo(textBox1.Text);
            x.setAutor(textBox2.Text);
            x.setNota(textBox3.Text);
            */

            /*
             Mostrar se ta armazenando:
              lista_musicas[limite] = x;
            limite++;
           

            for (int i = 0; i < limite; i++)
            {

                Console.WriteLine($"Música: {lista_musicas[i].getTitulo()} \n Cantor: {lista_musicas[i].getAutor()}\n Nota: {lista_musicas[i].getNota()}");
            }
            */


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

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.View = View.List; // Exibir os itens em uma lista
            foreach (string item in cantores)
            {
                listView1.Items.Add(item);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
