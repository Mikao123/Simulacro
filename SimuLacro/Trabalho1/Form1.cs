using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Trabalho1
{

    public partial class Form1 : Form
    {
        double indiceIndividual = 0.0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox5.MaxLength = 15;
            
            List<string> estados = new List<string>();
            cidades.Items.Clear();


            for (int i = 0; i < 4; i++)
            {

                estados.Add("estado" + 1);


            }


        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            try
            {



            }
            catch
            {


            }





            try
            {
                
                double valorImovel = double.Parse(textBox1.Text.Replace(",", "."));


                double valorSeguroCasa = 0;


                valorSeguroCasa = (valorImovel / 12) * indiceIndividual;



                if (checkBox2.Checked)
                {

                    valorSeguroCasa += valorSeguroCasa * 0.05;

                }

                if (checkBox1.Checked)
                {
                    double valorBensFisicos = double.Parse(textBox2.Text);

                    if (checkBox3.Checked)
                    {

                        valorSeguroCasa += valorBensFisicos * 0.01;


                    }
                    else
                    {

                        valorSeguroCasa += valorBensFisicos * 0.02;


                    }




                }
                

                label9.Text = Math.Round(valorSeguroCasa, 2).ToString();

                label10.Text = Math.Round(valorSeguroCasa * 10, 2).ToString();

            }
            catch
            {
                MessageBox.Show("Digite apenas números");
            }



        

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

            label8.Visible = !label8.Visible;
            textBox2.Visible = ! textBox2.Visible;
            label6.Visible = !label6.Visible;
            checkBox3.Visible = !checkBox3.Visible;
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cidades.Items.Clear();
            

            if (estado.Text == "Estado1")
            {

                cidades.Items.Add("Cidade1");


            }

            if (estado.Text == "Estado2")
            {

                cidades.Items.Add("Cidade2");


            }

            if (estado.Text == "Estado3")
            {

                cidades.Items.Add("Cidade3");


            }

            if (estado.Text == "Estado4")
            {

                cidades.Items.Add("Cidade4");


            }

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Cidades_SelectedIndexChanged(object sender, EventArgs e)
        {

            

            if (cidades.Text == "Cidade1")
            {


                indiceIndividual = 0.0052;


            }
            else if (cidades.Text == "Cidade2")
            {

                indiceIndividual = 0.0046;



            }
            else if (cidades.Text == "Cidade3")
            {

                indiceIndividual = 0.0058;



            }
            else if (cidades.Text == "Cidade4")
            {

                indiceIndividual = 0.0051;



            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
