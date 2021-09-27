using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioPadrao
{
    public partial class Form1 : Form
    {

        int id = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            textBox3.Visible = false;
            dateTimePicker1.Visible = false;

            textBox1.Enabled = false;
            textBox1.Text = Convert.ToString(id);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //Pessoa Fisica

            label3.Visible = false;
            label5.Visible = false;

            label4.Visible = true;//cpf
            label6.Visible = true;//nascimento
            textBox3.Visible = true;//cpf ou cnpj
            dateTimePicker1.Visible = true;//calendario
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //Pessoa Juridica

            label4.Visible = false;
            label6.Visible = false;

            label3.Visible = true;//cnpj
            label5.Visible = true;//abertura
            textBox3.Visible = true;//cpf ou cnpj
            dateTimePicker1.Visible = true;//calendario


        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (textBox2.TextLength < 3) // validar comprimento nome
            {
                MessageBox.Show("ERRO: Digite um nome valido");
            }
            else // else da validação do nome, se não colocar ele adiciona sem a validação
            {
                if (radioButton1.Checked && textBox3.Text.Length != 11) // validar cpf
                {
                    MessageBox.Show("ERRO: Digite um CPF Valido com 11 digitos, Somente Números");
                }
                else //else validação CPF

                    if (radioButton2.Checked && textBox3.Text.Length != 14) // validar CNPJ
                {
                    MessageBox.Show("ERRO: Digite um CNPJ Valido com 14 digitos, Somente Números");
                }
                else //else validação CNPJ
                {
                    if (textBox2.Text != string.Empty && textBox3.Text != string.Empty && comboBox1.Text != string.Empty) // validar campos se não for vazio
                    {

                        //Cadastro
                        textBox4.AppendText("ID: " + textBox1.Text + " - Nome: " + textBox2.Text + " - CPF / CNPJ: " + textBox3.Text + " - Nasc:  " + dateTimePicker1.Value.Date.ToString("dd/MM/yyyy") + " - Cidade: " + comboBox1.SelectedItem + "\r\n");
                        
                        id++;
                        textBox1.Text = Convert.ToString(id);

                        textBox2.Text = string.Empty;                        
                        textBox3.Text = string.Empty;
                        comboBox1.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("ERRO: Preencha todos os campos.");
                    }
                }
            }

        }
    }
}
