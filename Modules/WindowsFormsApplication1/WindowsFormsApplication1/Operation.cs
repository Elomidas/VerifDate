using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fonctions
{

    class Operation : Membre
    {
        protected bool m_calcule;
        protected Operation m_gauche;
        protected Operation m_droite;

        public Operation() : base()
        {
            m_calcule = true;
        }

        public Operation(String s)
        {
            int index = 0;
            int nbParentheses = 0;
            bool trouve = false;
            for(int i = 0; i < s.Length; i++)
            {
                if(s[i] == '(')
                {
                    trouve = true;
                    nbParentheses++;
                }
                else if(s[i] == ')')
                {
                    nbParentheses--;
                    if (nbParentheses == 0)
                        index = i + 1;
                }
            }
        }
    }
}
