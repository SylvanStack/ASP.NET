using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chap6Demo
{
    public partial class Form2 : Form
    {
        public Action Ac {get ;set ; }
        public List<CE> Ce { get; set; }
        public Del MyDel { get; set; }

        public string SelectedID { get; set; }

        public Form2(List<CE> ce , Del myDel,string selectedID )
        {
            InitializeComponent();
            Ce = ce;
            MyDel = myDel;
            SelectedID = selectedID;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty (SelectedID) )
            {
                textBox1.Enabled = false;

                CE myce = Ce.FirstOrDefault(c => c.ID == SelectedID);

                CE Myce = new CE();

                foreach (CE item in Ce)
                {
                    if(item.ID==SelectedID)
                    {
                        Myce = item;
                    }
                }


                if(myce!=null)
                {
                    textBox1.Text = Myce.ID;
                    textBox2.Text = Myce.Name;
                    textBox3.Text = Myce.Evaluation ;
                    textBox4.Text = Myce.Score.ToString();

                }
            }
        }
    }
}
