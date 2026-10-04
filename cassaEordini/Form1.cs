using System.Diagnostics;

namespace cassaEordini
{
    public partial class Form1 : Form
    {
        string[] prodotti = new string[3];
        double[] prezzi = { 2.40, 1.50, 2.50 };
        double prezzoTot = 0;
        int quantita, indice;
        List<string> dati = new List<string>();
        List<double> prezziDati = new List<double>();
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < comboBoxProd.Items.Count; i++)
            {
                prodotti[i] = comboBoxProd.Items[i].ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxProd_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            indice = comboBoxProd.SelectedIndex;

            if (indice >= 0)
            {
                labelPrezzo.Text = prezzi[indice].ToString() + "€";
            }
        }

        private void buttonAggiungi_Click(object sender, EventArgs e)
        {
            quantita = (int)selezioneQ.Value;

            if (quantita != 0 && comboBoxProd.SelectedIndex != -1)
            {
                double prezzoRiga = prezzi[indice] * quantita;

                prezzoTot = prezzoTot + prezzoRiga;

                labelTot.Text = prezzoTot.ToString() + "€";

                listBoxArticoli.Items.Add("x" + quantita + " " + prodotti[indice] + "  " + prezzi[indice] + "€");


                dati.Add("x" + quantita + " " + prodotti[indice] + "  " + prezzi[indice] + "€");
                prezziDati.Add(prezzoRiga);
            }
            else
            {
                MessageBox.Show("Errore nella selezione dei prodotti o quantità");
            }
        }

        private void Aggiorna()
        {
            listBoxArticoli.Items.Clear();

            foreach (string s in dati)
            {
                listBoxArticoli.Items.Add(s);
            }
        }

        private void buttonRimuovi_Click(object sender, EventArgs e)
        {
            int indiceRim = listBoxArticoli.SelectedIndex;

            if (indiceRim != -1)
            {

                prezzoTot = prezzoTot - prezziDati[indiceRim];

                labelTot.Text = prezzoTot.ToString() + "€";

                dati.RemoveAt(indiceRim);
                prezziDati.RemoveAt(indiceRim);

                Aggiorna();

            }
            else
            {
                MessageBox.Show("Nessun elemento selezionato");
            }

        }

        private void buttonEmetti_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("scontrini.csv", true))
            {
                sw.WriteLine(DateTime.Now);
                
                for(int i = 0; i < dati.Count; i++)
                {
                    sw.WriteLine(dati[i]);
                }
            }
        }
    }
}
