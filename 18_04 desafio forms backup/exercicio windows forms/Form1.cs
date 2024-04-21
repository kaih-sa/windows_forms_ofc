using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using static exercicio_windows_forms.Form6;

namespace exercicio_windows_forms
{
    public partial class Form1 : Form
    {
        Loginesenha x = new Loginesenha();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private string Tornar_hash(string senha)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytesSenha = Encoding.UTF8.GetBytes(senha);
                byte[] hash = sha256.ComputeHash(bytesSenha);
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            string log = textBox1.Text;
            string senh = textBox2.Text;

            string cadlog = Form6.x.getLogin();
            string cadsenh = Form6.x.getSenha();

            string hashSenhacad = Tornar_hash(cadsenh);
            string hashSenha = Tornar_hash(senh);

            if (cadlog == log && hashSenhacad == hashSenha)
            {
                Form2 j2 = new Form2();
                j2.Show();
            }
            else
            {
               MessageBox.Show("Seu nome de usuário ou senha estão incorretos.");
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
     

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            Form6 j6 = new Form6();
            j6.Show();
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            

        }
    }
}
