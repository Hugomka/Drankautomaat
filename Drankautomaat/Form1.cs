using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Drankautomaat
{
    public partial class Form1 : Form
    {
        private readonly string studentnaam = "Hugo Mkandawire";
        private Voorraad voorraad = new Voorraad();
        private decimal inworp = 0;

        public Form1()
        {
            InitializeComponent();
            this.Text = this.Text.Replace("NAAM STUDENT", studentnaam);

            btnInworpEenVijfdeEuro.Click += new EventHandler(btnInworp_Click);
            btnInworpHalveEuro.Click += new EventHandler(btnInworp_Click);
            btnInworpEenEuro.Click += new EventHandler(btnInworp_Click);
            btnInworpTweeEuro.Click += new EventHandler(btnInworp_Click);
        }

        private void btnDrankToevoegen_Click(object sender, EventArgs e)
        {
            Drank drank = null;
            switch (cbDrankSoort.Text)
            {
                case "Koffie":
                    drank = new Koffie(tbDrankNaam.Text, nudDrankPrijs.Value, 
                        (Int32)nudDrankMilliliter.Value, (Int32)nudDrankVoedingswaarde.Value);
                    break;
                case "Frisdrank":
                    drank = new Frisdrank(tbDrankNaam.Text, nudDrankPrijs.Value,
                        (Int32)nudDrankMilliliter.Value, (Int32)nudDrankVoedingswaarde.Value);
                    break;
                case "Soep":
                    drank = new Soep(tbDrankNaam.Text, nudDrankPrijs.Value,
                        (Int32)nudDrankMilliliter.Value);
                    break;
            }
            if (drank != null)
            {
                voorraad.NieuwProduct(drank);
                VoorraadListBoxVerversen();
            }
        }

        private void btnVoorraadToevoegen_Click(object sender, EventArgs e)
        {
            try
            {
                int i = lbVoorraad.SelectedIndex;
                voorraad.VulBij(voorraad.BeschikbareProducten()[i], (Int32)nudVoorraadAantal.Value);
                VoorraadListBoxVerversen();
            }
            catch (Exception)
            {
                MessageBox.Show("Er is geen product geselecteerd.", "Algemeen Exception", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBekerToevoegen_Click(object sender, EventArgs e)
        {
            voorraad.NieuwProduct(new Beker(tbBekerNaam.Text, (Int32)nudBekerMilliliter.Value,
                chkBekerWarmeDrank.Checked));
            VoorraadListBoxVerversen();
        }

        public void VoorraadListBoxVerversen()
        {
            lbVoorraad.Items.Clear();
            lbDranken.Items.Clear();
            foreach (var item in voorraad.BeschikbareProducten())
            {
                lbVoorraad.Items.Add(item);

                if(item.Voorraad > 0 && item is Drank)
                {
                    lbDranken.Items.Add(item);
                }
            }
        }

        private void btnInworp_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            inworp += Convert.ToDecimal(b.Text.Substring(2));
            SetInworp(inworp);
        }

        private void SetInworp(decimal i)
        {
            inworp = i;
            lblInworp.Text = inworp.ToString("N2");
        }

        private void btnKoopDrank_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbDranken.SelectedItem != null)
                {
                    int i = lbVoorraad.Items.IndexOf(lbDranken.SelectedItem);
                    Drank d = (Drank)voorraad.BeschikbareProducten()[i];
                    if (voorraad.KoopDrank(d, inworp))
                    {
                        SetInworp(0);
                        voorraad.VerkochteProduct(d);
                        MessageBox.Show("Er wordt een beker " + d.Naam + " klaargemaakt.");
                    }
                }
                else
                {
                    throw new Exception("Er is geen drank geselecteerd.");
                }

                VoorraadListBoxVerversen();
            }
            catch (OnvoldoendeBekersException OBE)
            {
                SetInworp(0);
                MessageBox.Show(OBE.Message + "\r\nGeld wordt teruggestort.", 
                    "Onvoldoende Bekers Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                SetInworp(0);
                MessageBox.Show(ex.Message + "\r\nGeld wordt teruggestort.", 
                    "Algemeen Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExporteerLogbestand_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "DefaultOutputName.txt";
            save.Filter = "Text File | *.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.OpenFile());
                foreach (Verkoop item in voorraad.VerkochteProducten())
                {
                    writer.WriteLine(item.ToString());
                }
                writer.Dispose();
                writer.Close();
            }
        }
    }
}
