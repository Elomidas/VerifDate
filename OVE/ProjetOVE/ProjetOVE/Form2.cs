using System;
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
    public partial class Form2 : Form
    {
        protected Stock m_s;
        protected Produit m_p;
        protected int m_q;
        protected Form1 m_form;

        public Form2(Form1 f)
        {
            InitializeComponent();
            m_q = 1;
            m_form = f;
        }

        public void Afficher(Stock s)
        {
            m_s = s;
            for (int i = 0; i < m_s.Size(); i++)
            {
                m_ref.Items.Add(m_s.get(i).m_ref + " - " + m_s.get(i).m_lib);
            }
            this.Show();
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
            if (p.d != 0)
                str = "" + p.a + "/" + ((p.m < 10) ? "0" : "") + p.m + "/" + ((p.d < 10) ? "0" : "") + p.d;
            return str;
        }

        
        private void m_ref_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tref = m_ref.SelectedIndex;
            Produit p = m_s.get(tref);
            m_p = new Produit(p.m_ref, p.m_lib, p.m_qtt, p.m_prix, p.d, p.m, p.a);
            m_prix.Text = "Prix : " + Form(m_p.m_prix) + "€";
            m_date.Text = "DLC : " + Form(m_p);
            m_lib.Text = m_p.m_lib;
        }
        

        private void m_qtt_TextChanged(object sender, EventArgs e)
        {
            m_q = (m_qtt.Text != "") ? int.Parse(m_qtt.Text) : 0;
        }

        private void m_val_Click(object sender, EventArgs e)
        {
            m_p.m_qtt = m_q;
            m_form.AddVente(m_p);
            this.Close();
        }

        private void Form2_Close(object sender, FormClosedEventArgs e)
        {
            m_form.Scan(true);
        }
    }
}
