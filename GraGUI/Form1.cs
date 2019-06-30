using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelGry;

namespace GraGUI
{
    public partial class Form1 : Form
    {
        public static Gra g;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNowaGra_Click(object sender, EventArgs e)
        {
            grpBoxLosowanie.Visible = true;
            btnNowaGra.Enabled = false;
            textBoxOd.Enabled = true;
            textBoxDo.Enabled = true;
            btnLosuj.Enabled = true;
            button_poddaj.Enabled = true;
            SprawdzButton.Enabled = true;
            textBox_Zgaduj.Enabled = true;
            label_wynik.Text = "";
            try
            {
                label_ruchy.Text = g.LicznikRuchow.ToString();
            } catch { }
        }

        private void btnLosuj_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                a = int.Parse(textBoxOd.Text);
                b = int.Parse(textBoxDo.Text);
            }
            catch
            {
                a = 1;
                b = 100;
            }
            g = new Gra(a, b);
            button_historia.Enabled = true;
            textBoxOd.Enabled = false;
            textBoxDo.Enabled = false;
            btnLosuj.Enabled = false;
            Zgaduj.Visible = true;
        }

        private void SprawdzButton_Click(object sender, EventArgs e)
        {
            int zgadywana = 0;
            Gra.Odpowiedz odp;
            try
            {
                zgadywana = int.Parse(textBox_Zgaduj.Text);
            }
            catch
            {
            }

            odp = g.Ocena(zgadywana);

            label_ruchy.Text = g.LicznikRuchow.ToString();

            switch (odp)
            {
                case Gra.Odpowiedz.ZaMalo:
                    label_wynik.Text = "Za mało";
                    break;
                case Gra.Odpowiedz.Trafiono:
                    label_wynik.Text = "Trafiono";

                    break;
                case Gra.Odpowiedz.ZaDuzo:
                    label_wynik.Text = "Za dużo";
                    break;
            }
            
            if (g.Stan == Gra.StanGry.Odgadnieta)
            {
                DialogResult wygrana = MessageBox.Show($"           Brawo !!!\nWylosowana liczba to {g.Wylosowana}", "Brawo !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                button_poddaj.Enabled = false;
                SprawdzButton.Enabled = false;
                textBox_Zgaduj.Enabled = false;

                if (wygrana == DialogResult.OK)
                {
                    Zgaduj.Visible = false;
                    grpBoxLosowanie.Visible = false;
                    btnNowaGra.Enabled = true;
                    g.Resetuj_licznik();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_poddaj_Click(object sender, EventArgs e)
        {
            g.Poddaj();    

            if (g.Stan == Gra.StanGry.Poddana)
            {
                DialogResult poddanie = MessageBox.Show("Poddałeś się", "Poddanie", MessageBoxButtons.OK, MessageBoxIcon.Information);

                button_poddaj.Enabled = false;
                SprawdzButton.Enabled = false;
                textBox_Zgaduj.Enabled = false;

                if (poddanie == DialogResult.OK)
                {
                    Zgaduj.Visible = false;
                    grpBoxLosowanie.Visible = false;
                    btnNowaGra.Enabled = true;
                    g.Resetuj_licznik();
                }
            }

        }

        private void button_historia_Click(object sender, EventArgs e)
        {
            Form_historia historiaF = new Form_historia();
            historiaF.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox_Zgaduj_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SprawdzButton_Click(this, new EventArgs());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
