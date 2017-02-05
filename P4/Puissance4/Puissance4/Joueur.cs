using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puissance4
{
    public class Joueur
    {
        protected String m_nom;
        protected char m_pion;
        
        public Joueur()
        {
            m_nom = "Albert";
            m_pion = 'X';
        }

        public Joueur(String nom, char pion)
        {
            m_nom = (nom != "") ? nom : "Albert";
            m_pion = (pion != ' ') ? pion : 'X';
            Console.WriteLine("Joueur " + m_nom + ", " + m_pion + " créé");
        }

        public char Pion()
        {
            return m_pion;
        }

        public void Pion(char p)
        {
            m_pion = (p != ' ') ? p : m_pion;
        }

        public String Nom()
        {
            return m_nom;
        }

        public void Nom(String n)
        {
            m_nom = (n != "") ? n : m_nom;
        }
    }
}
