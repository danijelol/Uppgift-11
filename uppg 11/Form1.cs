using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppg_11
{
    public partial class Form1 : Form
    {
       
        int total;
        Random slump = new Random();
        

        public Form1()
        {
           
            InitializeComponent();
            
        }

        private void btnGenerera_Click(object sender, EventArgs e)
        {


            int hemmaseger = int.Parse(txtBoxHemmaseger.Text);
            int oavgjort = int.Parse(txtBoxOavgjort.Text);
            int bortaseger = int.Parse(txtBoxBortaseger.Text);

            listBoxTipsradNumrering.Items.Clear();
            listBoxTipsradSvar.Items.Clear();

            total = hemmaseger + oavgjort + bortaseger;
            if (total < 100 || total > 100)

            {
                MessageBox.Show("Sannolikheterna måste uppnå till 100%!");
            }

           for (int i = 1; i <= 13; i++) //Numrerar tipsraderna

           {
                 
               listBoxTipsradNumrering.Items.Add(i + ":");

           }

           for (int i = 1; i <= 13; i++) // För att få 13 tipsrader
           {

               int slumprad = slump.Next(1, 101);   
           
               if (slumprad <= hemmaseger) //1
               {
                   listBoxTipsradSvar.Items.Add("1");
               }
               
               else if (slumprad >= 100-oavgjort) //X

               {
                   
                   listBoxTipsradSvar.Items.Add("X");
               }
               
               else 
               {
                   listBoxTipsradSvar.Items.Add("2"); //2
               }
           }
        }

        private void btnRensa_Click(object sender, EventArgs e)
        {
            txtBoxHemmaseger.Clear();
            txtBoxOavgjort.Clear();
            txtBoxBortaseger.Clear();
            listBoxTipsradNumrering.Items.Clear();
            listBoxTipsradSvar.Items.Clear();
        }

        private void btnAvsluta_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBoxTipsrad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
