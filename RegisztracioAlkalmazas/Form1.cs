using System;
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
            hobbiLista.Items.Add("Uszás");
            hobbiLista.Items.Add("Horgászat");
            hobbiLista.Items.Add("Futás");
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            if (!txt_nev.Text.Equals("") && 
                !szul_datum.Text.Equals("") && 
                (F.Checked || N.Checked)
                && hobbiLista.SelectedItem != null)
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
                    if (!hobbiLista.Items.Contains(txt_ujhobbi.Text))
                    {
                        hobbiLista.Items.Add(txt_ujhobbi.Text);
                        txt_ujhobbi.Text = "";
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!txt_ujhobbi.Text.Trim().Equals(""))
            {
                if (!hobbiLista.Items.Contains(txt_ujhobbi.Text))
                {
                    hobbiLista.Items.Add(txt_ujhobbi.Text);
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
                    sw.WriteLine(txt_nev.Text);
                    sw.WriteLine(szul_datum.Text);
                    if (F.Checked)
                    {
                        sw.WriteLine("F");
                    }
                    if (N.Checked)
                    {
                        sw.WriteLine("N");
                    }
                    sw.WriteLine(hobbiLista.SelectedItem);
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
                    hobbiLista.Items.Clear();
                    hobbiLista.Items.Add("Uszás");
                    hobbiLista.Items.Add("Horgászat");
                    hobbiLista.Items.Add("Futás");
                    txt_nev.Text = sr.ReadLine();
                    szul_datum.Text = sr.ReadLine();
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
                    if (hobbiLista.Items.Contains(kedvencHobbi))
                    {
                        hobbiLista.SelectedItem = kedvencHobbi;
                    }
                    else
                    {
                        hobbiLista.Items.Add(kedvencHobbi);
                        hobbiLista.SelectedItem = kedvencHobbi;
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
