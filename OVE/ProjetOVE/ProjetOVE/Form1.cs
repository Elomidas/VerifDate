using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetOVE
{
    public partial class Form1 : Form
    {
        private Stock m_stock;
        private ArrayList m_vente;
        private Form2 m_f;
        private double m_prix;
        private string m_date;
        protected int m_onglet;
        protected Connexion m_co;

        public Form1()
        {
            m_vente = new ArrayList();
            m_stock = new Stock();
            m_date = DateTime.UtcNow.Date.ToString("yyyy/MM/dd");
            m_prix = 0;
            m_onglet = 0;
            InitializeComponent();
            RemplissageStock();
            Aff();
            int port = 1342;
            Console.WriteLine("Port : " + port);
            m_co = new Connexion(port);
            m_co.Reception += new Connexion.ReceptionHandler(Flashing);
        }

        public void RemplissageStock()
        {
            //Ref - Lib - Qtt - Prix - DLC
            
            m_stock.Add(15895, "Tomates origine France", 11, 5, 3, 6, 2017);
            m_stock.Add(15895, "Tomates origine France", 194, 5, 2, 10, 2017);
            m_stock.Add(35986, "Kinder Bueno x5", 42, 3.50, 31, 12, 2017);
            m_stock.Add(94581, "Riz 10kg", 762, 52, 7, 11, 2018);
            m_stock.Add(65983, "Frites au four", 25, 5.90, 13, 7, 2017);
            m_stock.Add(78654, "Cuiraçao", 62, 24.50, 0, 0, 0);
            m_stock.Add(85214, "Foie de veau", 3, 5.70, 01, 05, 2017);
            
            /*
            m_stock.Add(15895, "Doliprane", 11, 5, 3, 6, 2017);
            m_stock.Add(15896, "Ibuprofène", 194, 5, 2, 10, 2017);
            m_stock.Add(35986, "Smecta", 42, 3.50, 31, 12, 2017);
            m_stock.Add(94581, "Crème solaire", 762, 52, 7, 11, 2018);
            m_stock.Add(65983, "Spasfon", 25, 5.90, 13, 7, 2017);
            m_stock.Add(78654, "Lisopaïne", 62, 24.50, 0, 0, 0);
            m_stock.Add(85214, "Dafalgan", 3, 5.70, 01, 05, 2017);
            */
        }

        public static string Form(double i)
        {
            int a = (int)i;
            i -= a;
            int b = (int)(i * 100);
            string sb = ((b < 10) ? "0" : "") + b;
            return "" + a + "," + sb;
        }
        
        public string Form(Produit p)
        {
            string str = "Non Périssable";
            if(p.d != 0)
                str = "" + p.a + "/" + ((p.m < 10) ? "0" : "") + p.m + "/" + ((p.d < 10) ? "0" : "") + p.d;
            return str;
        }

        public void Aff(int i)
        {
            AddStock(m_stock.get(i), i);
        }

        public void Aff()
        {
            for(int i = 0; i < m_stock.Size(); i++)
                AddStock(m_stock.get(i), i);
        }

        public void Minus(int r, int j, int m, int a, int qtt)
        {
            int i = m_stock.Vente(r, j, m, a, qtt);
            Aff(i - 1);
        }

        public void AddVente(Produit p)
        {
            int index = m_vente.Count;
            int i = 0;
            for (; i < index; i++)
            {
                if(((Produit)m_vente[i]).m_ref == p.m_ref)
                {
                    ((Produit)m_vente[i]).m_qtt += p.m_qtt;
                    i = index + 1;
                }
            }
            if(i == index)
                m_vente.Add(p);
            AffVente(i);
            m_prix += p.m_prix * p.m_qtt;
            m_total.Text = "Total : " + Form(m_prix);
        }

        public void Scan(Boolean b)
        {
            m_ajout.Enabled = b;
        }

        public void AffVente(int i)
        {
            Produit p = (Produit)m_vente[i];
            if (i == m_dgv.RowCount)
                m_dgv.Rows.Add();
            m_dgv.Rows[i].Cells[0].Value = p.m_ref;
            m_dgv.Rows[i].Cells[1].Value = p.m_lib;
            m_dgv.Rows[i].Cells[2].Value = p.m_qtt;
            m_dgv.Rows[i].Cells[3].Value = Form(p.m_prix);
            m_dgv.Rows[i].Cells[4].Value = Form(p);
            string date = Form(p);
            int test = String.Compare(date, m_date);
            if (test > 0)
                m_dgv.Rows[i].DefaultCellStyle.BackColor = Color.Green;
            else if (test == 0)
                m_dgv.Rows[i].DefaultCellStyle.BackColor = Color.White;
            else m_dgv.Rows[i].DefaultCellStyle.BackColor = Color.Red;
        }

        public void AddStock(Produit p, int i)
        {
            if(i == dataGridView1.RowCount)
                dataGridView1.Rows.Add();
            dataGridView1.Rows[i].Cells[0].Value = p.m_ref;
            dataGridView1.Rows[i].Cells[1].Value = p.m_lib;
            dataGridView1.Rows[i].Cells[2].Value = p.m_qtt;
            dataGridView1.Rows[i].Cells[3].Value = Form(p.m_prix);
            dataGridView1.Rows[i].Cells[4].Value = Form(p);
            string date = Form(p);
            int test = String.Compare(date, m_date);
            if(test > 0)
                dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
            else if(test == 0)
                dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
            else dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
        }

        private void m_ajout_Click(object sender, EventArgs e)
        {
            Scan(false);
            m_f = new Form2(this);
            m_f.Afficher(m_stock);
        }

        private void m_val_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < m_vente.Count; i++)
            {
                Produit p = ((Produit)m_vente[i]);
                Minus(p.m_ref, p.d, p.m, p.a, p.m_qtt);
            }
            m_vente = new ArrayList();
            m_dgv.Rows.Clear();
            m_total.Text = "Total : 0";
            m_prix = 0;
        }

        protected void setCaisse(object sender, EventArgs e)
        {
            m_onglet = 0;
        }

        protected void setStock(object sender, EventArgs e)
        {
            m_onglet = 1;
        }

        protected void Flashing(object sender, EventArgs e)
        {
            string[] strs = m_co.getMsgs();
            char[] sep = { '-' };
            for(int i = strs.Length - 1; i > 0;)
            {
                i--;
                string[] str = strs[i].Split(sep);
                for (int j = 0; j < str.Length; j++)
                    Flashing(int.Parse(str[0]), int.Parse(str[1]), int.Parse(str[2]), int.Parse(str[3]), int.Parse(str[4]));
            }
        }

        protected void Flashing(int annee, int mois, int jour, int reference, int qtt)
        {
            switch(m_onglet)
            {
                case 0:
                    Produit prod = m_stock.getRef(reference, jour, mois, annee);
                    AddVente(prod);
                    break;

                case 1:
                    m_stock.App(reference, annee, mois, jour, qtt);
                    break;
            }
        }
    }
}
