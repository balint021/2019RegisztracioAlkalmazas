﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisztracioAlkalmazas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add("Uszás");
            listBox1.Items.Add("Horgászat");
            listBox1.Items.Add("Futás");
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals("") && 
                !dateTimePicker1.Text.Equals("") && 
                (F.Checked || N.Checked)
                && listBox1.SelectedItem != null)
            {
                saveFileDialog.Filter = "Text File (.txt)|*.txt";
                saveFileDialog.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nem hagyhatsz üresen mezőt.");
            }
        }

        private void txt_ujhobbi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!txt_ujhobbi.Text.Trim().Equals(""))
                {
                    if (!listBox1.Items.Contains(txt_ujhobbi.Text))
                    {
                        listBox1.Items.Add(txt_ujhobbi.Text);
                        txt_ujhobbi.Text = "";
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!txt_ujhobbi.Text.Trim().Equals(""))
            {
                if (!listBox1.Items.Contains(txt_ujhobbi.Text))
                {
                    listBox1.Items.Add(txt_ujhobbi.Text);
                    txt_ujhobbi.Text = "";
                }
                
            }
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                using (var sw = new StreamWriter(saveFileDialog.FileName))
                {
                    sw.WriteLine(textBox1.Text);
                    sw.WriteLine(dateTimePicker1.Text);
                    if (F.Checked)
                    {
                        sw.WriteLine("F");
                    }
                    if (N.Checked)
                    {
                        sw.WriteLine("N");
                    }
                    sw.WriteLine(listBox1.SelectedItem);
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Hiba");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Text File (.txt)|*.txt";
            openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                using (var sr = new StreamReader(openFileDialog.FileName))
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add("Uszás");
                    listBox1.Items.Add("Horgászat");
                    listBox1.Items.Add("Futás");
                    textBox1.Text = sr.ReadLine();
                    dateTimePicker1.Text = sr.ReadLine();
                    var nem = sr.ReadLine();
                    if (nem.Equals("F"))
                    {
                        N.Checked = false;
                        F.Checked = true;
                    }
                    if (nem.Equals("N"))
                    {
                        F.Checked = false;
                        N.Checked = true;
                    }
                    var kedvencHobbi = sr.ReadLine();
                    if (listBox1.Items.Contains(kedvencHobbi))
                    {
                        listBox1.SelectedItem = kedvencHobbi;
                    }
                    else
                    {
                        listBox1.Items.Add(kedvencHobbi);
                        listBox1.SelectedItem = kedvencHobbi;
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Hiba");
            }
        }
    }
}
