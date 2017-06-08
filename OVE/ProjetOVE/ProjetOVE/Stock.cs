using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ProjetOVE
{
    public class Stock
    {
        ArrayList m_prod;

        public Stock()
        {
            m_prod = new ArrayList();
        }

        public void Add(Produit p)
        {
            m_prod.Add(p);
        }

        public void Add(int r, string lib, int qtt, double prix, int d, int m, int a)
        {
            m_prod.Add(new Produit(r, lib, qtt, prix, d, m, a));
        }

        public Produit get(int i)
        {
            return (Produit)m_prod[i];
        }

        public Produit getRef(int r, int j, int m, int a)
        {
            for(int i = 0; i < m_prod.Count; i++)
            {
                if (((Produit)m_prod[i]).Eq(r, a, m, j))
                    return (Produit)m_prod[i];
            }
            return (Produit)m_prod[0];
        }

        public int Vente(int r, int j, int m, int a, int qtt)
        {
            int i;
            for (i = 0; (i < m_prod.Count); i++) ;
            if (i < m_prod.Count)
            {
                if(((Produit)m_prod[i]).Eq(r, a, m, j))
                {
                    ((Produit)m_prod[i]).m_qtt -= qtt;
                    if (((Produit)m_prod[i]).m_qtt < 0)
                        ((Produit)m_prod[i]).m_qtt = 0;
                    i = m_prod.Count;
                }
                return (i + 1);
            }
            return 0;
        }

        public int Size()
        {
            return m_prod.Count;
        }

        public void App(int pr, int pa, int pm, int pj, int qtt)
        {
            int i;
            for(i = 0; i < m_prod.Count; i++)
            {
                if (((Produit)m_prod[i]).Eq(pr, pa, pm, pj))
                {
                    ((Produit)m_prod[i]).m_qtt += qtt;
                    i = m_prod.Count + 2;
                }
            }
        }
    }
}
