using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication161
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            for (int i = 0; i < listBox6.Items.Count ; i++)
            {
                if (listBox5.Items[i].ToString() ==comboBox1.Text )
                {
                    comboBox2.Items.Add(listBox6.Items[i].ToString());
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            for (int i = 0; i < listBox5.Items.Count ; i++)
            {
                comboBox1.Items.Add(listBox5.Items[i].ToString());
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.Items.Clear();
            if (comboBox3.Text == "BAY")
            {
                for (int i = 40; i < 45; i++)
                {
                    comboBox4.Items.Add(i.ToString());
                }
            }
           else  if (comboBox3.Text == "BAYAN")
            {
                for (int i = 36; i < 41; i++)
                {
                    comboBox4.Items.Add(i.ToString());
                }
            }

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox9.Items.Count ; i++)
            {
                if ((listBox5.Items[i].ToString ()==comboBox1.Text )&&(listBox6.Items[i].ToString ()==comboBox2.Text )&&(listBox7.Items[i].ToString ()==comboBox3.Text )&&(listBox8.Items[i].ToString ()==comboBox4.Text ))
                {
                    textBox1.Text = listBox9.Items[i].ToString();
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            try
            {
                textBox3.Text = (int.Parse(textBox1.Text) * int.Parse(textBox2.Text)).ToString();
            }
            catch (Exception)
            {
                
               
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.Text =="Kredi Kartı")
            {
                groupBox2.Visible = false ; groupBox3.Visible = false ;
                groupBox2.Visible = true; groupBox3.Visible = true; textBox6.Text = textBox3.Text;
            }
            else if (comboBox5.Text == "Nakit")
            {
                groupBox2.Visible = false; groupBox3.Visible = false;
                groupBox3.Visible = true; textBox6.Text = (double.Parse(textBox3.Text) * 0.95).ToString(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yenistok = 0;
            int deger = 0;
            //Satış
            listBox1.Items.Add(comboBox1.Text);
            listBox2.Items.Add(comboBox2.Text);
            listBox3.Items.Add(comboBox3.Text + " " + comboBox4.Text + " " + textBox2.Text);
            listBox4.Items.Add(textBox4.Text);
            if (groupBox2.Visible == true)
            {
                listBox11.Items.Add("Kredi Kartı " + DateTime.Now.ToString());
            }
            else { listBox11.Items.Add("Nakit " + DateTime.Now.ToString()); }

            //Stok 

            for (int i = 0; i < listBox5.Items.Count ; i++)
            {
                if ((listBox5.Items[i].ToString ()==comboBox1.Text)&&(listBox6.Items[i].ToString ()==comboBox2.Text)&&(listBox7.Items[i].ToString ()==comboBox3.Text)&& (listBox8.Items[i].ToString ()==comboBox4.Text))
                {
                    deger = i;
                }
                
                
            }
            yenistok = int.Parse(listBox10.Items[deger ].ToString());
            yenistok--;

            listBox5.Items.Add(listBox5.Items[deger].ToString());
            listBox6.Items.Add(listBox6.Items[deger].ToString());
            listBox7.Items.Add(listBox7.Items[deger].ToString());
            listBox8.Items.Add(listBox8.Items[deger].ToString());
            listBox9.Items.Add(listBox9.Items[deger].ToString());
            listBox10.Items.Add(yenistok .ToString ());
            
            listBox5.Items.RemoveAt(deger);
            listBox6.Items.RemoveAt(deger);
            listBox7.Items.RemoveAt(deger);
            listBox8.Items.RemoveAt(deger);
            listBox9.Items.RemoveAt(deger);
            listBox10.Items.RemoveAt(deger);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox5.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int tutar = 0;
            for (int i = 0; i < listBox4.Items.Count ; i++)
            {
                tutar = tutar + int.Parse(listBox4.Items[i].ToString());
            }
            textBox8.Text = tutar.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            groupBox5.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
           
            int secim=-2;
            
             if (listBox5.SelectedIndex != -1)
            { secim = listBox5.SelectedIndex; }
            else if (listBox6.SelectedIndex != -1)
            { secim = listBox6.SelectedIndex; }
            else if (listBox7.SelectedIndex != -1)
            { secim = listBox7.SelectedIndex; }
            else if (listBox8.SelectedIndex != -1)
            { secim = listBox8.SelectedIndex; }
            else if (listBox9.SelectedIndex != -1)
            { secim = listBox9.SelectedIndex; }
            else if (listBox10.SelectedIndex != -1)
            { secim = listBox10.SelectedIndex; }
            if (secim == -2)
            {
                MessageBox.Show("Lütfen Seçim Yapınız"); 
            }
            else
            {
                listBox5.Items.Add(listBox5.Items[secim].ToString());
                listBox6.Items.Add(listBox6.Items[secim].ToString());
                listBox7.Items.Add(listBox7.Items[secim].ToString());
                listBox8.Items.Add(listBox8.Items[secim].ToString());
                listBox9.Items.Add(listBox9.Items[secim].ToString());
                listBox10.Items.Add(textBox9.Text);

                listBox5.Items.RemoveAt(secim);
                listBox6.Items.RemoveAt(secim);
                listBox7.Items.RemoveAt(secim);
                listBox8.Items.RemoveAt(secim);
                listBox9.Items.RemoveAt(secim);
                listBox10.Items.RemoveAt(secim);
            }

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            button11.Enabled = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            groupBox6.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int secim = -2;
            
            if (listBox5.SelectedIndex != -1)
            { secim = listBox5.SelectedIndex; }
            else if (listBox6.SelectedIndex != -1)
            { secim = listBox6.SelectedIndex; }
            else if (listBox7.SelectedIndex != -1)
            { secim = listBox7.SelectedIndex; }
            else if (listBox8.SelectedIndex != -1)
            { secim = listBox8.SelectedIndex; }
            else if (listBox9.SelectedIndex != -1)
            { secim = listBox9.SelectedIndex; }
            else if (listBox10.SelectedIndex != -1)
            { secim = listBox10.SelectedIndex; }
            if (secim == -2)
            {
MessageBox.Show("Lütfen Seçim Yapınız"); 
            }
            else
            {
                listBox5.Items.RemoveAt(secim);
                listBox6.Items.RemoveAt(secim);
                listBox7.Items.RemoveAt(secim);
                listBox8.Items.RemoveAt(secim);
                listBox9.Items.RemoveAt(secim);
                listBox10.Items.RemoveAt(secim);
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            int secim = -2;
            if (listBox5.SelectedIndex == -1 || listBox6.SelectedIndex == -1 || listBox7.SelectedIndex == -1 || listBox8.SelectedIndex == -1 || listBox9.SelectedIndex == -1 || listBox10.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Seçim Yapınız"); textBox10.Focus(); button14.Enabled = false;
            }
            else if (listBox5.SelectedIndex != -1)
            { secim = listBox5.SelectedIndex; }
            else if (listBox6.SelectedIndex != -1)
            { secim = listBox6.SelectedIndex; }
            else if (listBox7.SelectedIndex != -1)
            { secim = listBox7.SelectedIndex; }
            else if (listBox8.SelectedIndex != -1)
            { secim = listBox8.SelectedIndex; }
            else if (listBox9.SelectedIndex != -1)
            { secim = listBox9.SelectedIndex; }
            else if (listBox10.SelectedIndex != -1)
            { secim = listBox10.SelectedIndex; }
            if (secim == -2)
            {

            }
            else
            {
                listBox5.Items.Add(listBox5.Items[secim].ToString());
                listBox6.Items.Add(listBox6.Items[secim].ToString());
                listBox7.Items.Add(listBox7.Items[secim].ToString());
                listBox8.Items.Add(listBox8.Items[secim].ToString());
                listBox9.Items.Add(textBox10.Text);
                listBox10.Items.Add(listBox10.Items[secim].ToString());

                listBox5.Items.RemoveAt(secim);
                listBox6.Items.RemoveAt(secim);
                listBox7.Items.RemoveAt(secim);
                listBox8.Items.RemoveAt(secim);
                listBox9.Items.RemoveAt(secim);
                listBox10.Items.RemoveAt(secim);
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            groupBox7.Visible = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            groupBox7.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            groupBox6.Visible = true;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.TextLength <11)
            {
                MessageBox.Show("Hatalı TC girişi");
                textBox5.Focus();
            }
        }
    }
}
