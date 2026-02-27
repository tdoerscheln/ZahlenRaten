using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZahlenRaten
{
    public partial class Form1 : Form
    {
        int zahl;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setzeZahl();
        }

        private void setzeZahl()
        {
            zahl = (new Random()).Next(100);
        }

        private void starten_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxEingabe.Text, out int eingabeZahl))
            {
                MessageBox.Show("Das ist keine Zahl!");
                textBoxEingabe.Text = "";
                return;
            }

            if (eingabeZahl == zahl)
            {
                labelErgebnis.Text = "TREFFER!";
            }
            else if (eingabeZahl > zahl)
            {
                labelErgebnis.Text = "niedriger";
            }
            else
            {
                labelErgebnis.Text = "höher";
            }
        }
    }
}
