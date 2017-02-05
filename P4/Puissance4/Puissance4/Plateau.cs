using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puissance4
{
    public class Plateau
    {
        protected char[,] m_tab;

        public Plateau()
        {
            m_tab = new char[7, 7];
            Init();
        }

        public void Init()
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                    m_tab[i, j] = ' ';
            }
        }

        public int Jouer(int colonne, char pion)
        {
            if ((colonne < 0) || (colonne > 6) || (m_tab[0, colonne] != ' '))
                throw new IndexOutOfRangeException();
            int i;
            for (i = 0; (i < 7) && (m_tab[i, colonne] == ' '); i++);
            m_tab[i - 1, colonne] = pion;
            return i - 1;
        }

        public char Get(int ligne, int colonne)
        {
            if ((ligne < 0) || (ligne > 6) || (colonne < 0) || (colonne > 6))
                throw new IndexOutOfRangeException();
            return m_tab[ligne, colonne];
        }

        public char Gagnant()
        {
            for(int i = 6; i >= 0; i--)
            {
                for(int j = 0; j < 7; j++)
                {
                    if(m_tab[i, j] != ' ')
                    {
                        char c = m_tab[i, j];
                        if(j <= 3)
                        {
                            //On teste la ligne à droite
                            if ((m_tab[i, j + 1] == c) && (m_tab[i, j + 2] == c) && (m_tab[i, j + 3] == c))
                                return c;
                            if(i >= 3)
                            {
                                //On teste la diagonale en haut à droite
                                if ((m_tab[i - 1, j + 1] == c) && (m_tab[i - 2, j + 2] == c) && (m_tab[i - 3, j + 3] == c))
                                    return c;
                            }
                            if(i <= 3)
                            {
                                //On teste la diagonnale en bas à droite
                                if ((m_tab[i + 1, j + 1] == c) && (m_tab[i + 1, j + 2] == c) && (m_tab[i + 1, j + 3] == c))
                                    return c;
                            }
                        }
                        if (i > 3)
                        {
                            //On teste la colonne au dessus
                            if ((m_tab[i - 1, j] == c) && (m_tab[i - 2, j] == c) && (m_tab[i - 3, j] == c))
                                return c;
                        }
                    }
                }
            }
            return ' ';
        }

        public bool Dispo(int c)
        {
            return (Get(0, c) == ' ');
        }
    }
}
