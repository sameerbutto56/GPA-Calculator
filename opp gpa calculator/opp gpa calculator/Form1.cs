using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opp_gpa_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GPA_Click(object sender, EventArgs e)
        {
            if (OOP.Text == "" || DLD.Text == "" || DS.Text == "" || PB.Text == "" || PS.Text == "" || ISL.Text == "" || OOPCH.Text == "" || DLDCH.Text == "" || DSCH.Text == "" || PBCH.Text == "" || PSCH.Text == "" || ISLCH.Text == "")
            {
                MessageBox.Show("All Entries Should Be Filled");
            }
            else
            {
                float[] arr = new float[6];
                int[] arr1 = new int[6];
                float[] mul = new float[6];
                float suma = 0;
                int sum = 0;
                float gpa1 = 0;
                int a;
                string c;

                arr[0] = Int32.Parse(OOP.Text);
                arr[1] = Int32.Parse(DLD.Text);
                arr[2] = Int32.Parse(DS.Text);
                arr[3] = Int32.Parse(PB.Text);
                arr[4] = Int32.Parse(PS.Text);
                arr[5] = Int32.Parse(ISL.Text);
                for (int i = 0; i <= 5; i++)
                {
                    if (arr[i] > 100 || arr[i] < 0)
                    {
                        MessageBox.Show("Marks Should be from 0-100");
                    }
                }
                arr1[0] = Int32.Parse(OOP.Text);
                arr1[1] = Int32.Parse(DLDCH.Text);
                arr1[2] = Int32.Parse(DSCH.Text);
                arr1[3] = Int32.Parse(PBCH.Text);
                arr1[4] = Int32.Parse(PSCH.Text);
                arr1[5] = Int32.Parse(ISLCH.Text);

                if (checkBox1.Checked)
                {
                    arr[0] = 0;
                    arr1[0] = 0;
                }
                if (checkBox2.Checked)
                {
                    arr[1] = 0;
                    arr1[1] = 0;
                }
                if (checkBox3.Checked)
                {
                    arr[2] = 0;
                    arr1[2] = 0;
                }
                if (checkBox4.Checked)
                {
                    arr[3] = 0;
                    arr1[3] = 0;
                }
                if (checkBox5.Checked)
                {
                    arr[4] = 0;
                    arr1[4] = 0;
                }
                if (checkBox6.Checked)
                {
                    arr[5] = 0;
                    arr1[5] = 0;
                }
                if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && checkBox4.Checked && checkBox5.Checked && checkBox6.Checked)
                {
                    GPA.Text = "Not Enrolled In Any Course";
                }
                else
                {
                    for (int i = 0; i <= 5; i++)
                    {
                        mul[i] = arr[i] * arr1[i];
                        suma += mul[i];
                    }
                    sum = arr1[0] + arr1[1] + arr1[2] + arr1[3] + arr1[4] + arr1[5];
                    gpa1 = suma / sum;
                    if (gpa1 >= 90 && gpa1 <= 100)
                    {
                        ans.Text = "Your GPA = " + "4.0 (A+)";
                    }
                    else if (gpa1 < 90 && gpa1 >= 80)
                    {
                        ans.Text = "Your GPA = " + "4.0 (A)";
                    }
                    else if (gpa1 < 80 && gpa1 >= 70)
                    {
                       ans.Text = "Your GPA = " + "3.0 (B)";
                    }
                    else if (gpa1 < 70 && gpa1 >= 60)
                    {
                        ans.Text = "Your GPA = " + "2.0 (C)";
                    }
                    else if (gpa1 < 60 && gpa1 >= 50)
                    {
                        ans.Text = "Your GPA = " + "1.0 (D)";
                    }
                    else if (gpa1 < 50 && gpa1 >= 0)
                    {
                        ans.Text = "Your GPA = " + "0.0 (F)";
                    }
                }

            }

        }

        private void DS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
