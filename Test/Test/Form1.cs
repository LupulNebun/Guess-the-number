using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        int nr, ran;
        bool check_nr = true;

        public Form1()
        {
            InitializeComponent();

            Reset();
        }

        private int Ran()
        {
            Random rnd = new Random();
            ran = rnd.Next(0, 100);

            return ran;
        }

        private void Check(int nr, int ran)
        {
            if(nr < ran)
            {
                LBL_Numar.Text = "Higher";
            }
            else if(nr > ran)
            {
                LBL_Numar.Text = "Lower";
            }
            else if(nr == ran)
            {
                LBL_Numar.Text = "You got it!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            check_nr = true ;

            try
            {
                nr = int.Parse(TB_Numar.Text);
            }
            catch (FormatException ex)
            {
                check_nr = false;
            }

            if(check_nr == true)
            {
                Check(nr, ran);
            }
            else if(check_nr == false)
            {
                LBL_Numar.Text = "Please insert a number!";
            }
             
        }

        private void Reset()
        {
            ran = Ran();
            LBL_Numar.Text = "Please insert a number!";
            TB_Numar.Text = "";
            //LBL_Test.Text = ran.ToString();
        }

        private void LBL_Reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
