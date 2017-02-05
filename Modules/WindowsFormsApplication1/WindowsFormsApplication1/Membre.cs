using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fonctions
{
    class Membre
    {
        protected double m_resultat;

        public Membre()
        {
            m_resultat = 0;
        }

        public Membre(double valeur)
        {
            m_resultat = valeur;
        }

        public void Set(double valeur)
        {
            m_resultat = valeur;
        }

        public double Resultat()
        {
            return m_resultat;
        }
    }
}
