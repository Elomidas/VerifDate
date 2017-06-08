using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetOVE
{
    public class Produit
    {
        public int m_ref, m_qtt;
        public string m_lib;
        public int d, m, a;
        public double m_prix;

        public Produit(int r, string lib, int qtt, double prix, int vd, int vm, int va)
        {
            m_ref = r;
            m_lib = lib;
            m_qtt = qtt;
            m_prix = prix;
            d = vd;
            m = vm;
            a = va;
        }

        public bool Date(int pj, int pm, int pa)
        {
            return ((pj == d) && (pm == m) && (pa == a));
        }

        public bool Eq(int pr, int pa, int pm, int pj)
        {
            return ((pr == m_ref) && Date(pj, pm, pa));
        }
    }
}
