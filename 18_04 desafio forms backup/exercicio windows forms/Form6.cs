using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace exercicio_windows_forms
{
    public partial class Form6 : Form
    {
        public static Loginesenha x = new Loginesenha();

        public Form6()
        {
            InitializeComponent();
        }

        
        public class Loginesenha
        {
            private string Login;
            private string Senha;


            public string getLogin()
            {
               
                return Login;
            }

            public string getSenha()
            {
                return Senha;
            }

            public void setLogin(string a)
            {
                this.Login = a;
            }

            public void setSenha(string b)
            {
                this.Senha = b;
            }

        }

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string senha = textBox3.Text;
            Console.WriteLine("text1 e dois" + login + senha);
            x.setLogin(login);
            x.setSenha(senha);
            

        }
     
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }
    }

       
    }

        
    

