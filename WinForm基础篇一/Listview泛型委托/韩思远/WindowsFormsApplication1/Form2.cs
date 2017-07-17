using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
  

    public partial class Form2 : Form
    {

       // public Action<string> Afterchange(string str);


  
       //public delegate string After(string text);

        public Form2()
        {
            InitializeComponent();
        }




        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void SetTextValue(object sender, EventArgs e)
        {
            this.textBox1.Text = "12324";
          //  this.textBox1.Text = e.ToString();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public string SetText(string str)
        {
            //this.textBox1.Text = "12324";
            this.textBox1.Text = str;
            return "";
        }
        
    }

   
}
