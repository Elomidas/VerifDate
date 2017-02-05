using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbres_etc
{
    class Noeud
    {
        protected Noeud[] m_fils;

        public Noeud()
        {
            m_fils = new Noeud[0];
        }

        public Noeud(Noeud n)
        

            m_fils = new Noeud[0];
        }

        public Noeud[] GetFils()
        {
            return m_fils;
        }

        public Noeud GetFils(int index)
        {
            return ((index >= 0) && (index < m_fils.)
        }
    }
}
