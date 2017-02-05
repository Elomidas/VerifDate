using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puissance4
{
    public partial class Form1 : Form
    {
        protected Label[,] m_tb;
        protected Button[] m_but;
        protected Plateau m_plateau;
        protected Joueur[] m_joueur;
        protected TextBox[,] m_t;
        protected Label[,] m_l;
        protected Button m_b;
        protected int[] m_index;
        protected Label m_gagnant;
        protected int m_tour;
        protected bool m_fin;

        protected const int m_dim = 80;

        public Form1()
        {
            InitializeComponent();

            this.Size = new Size(7 * m_dim, 9 * m_dim);
            this.Resize += Taille;

            //Informations sur les joueurs
            m_t = new TextBox[2, 2];
            m_t[0, 0] = new TextBox();
            m_t[0, 0].Parent = this;
            m_t[0, 0].Text = "J1";
            m_t[0, 0].Location = new Point((this.Width / 3) - (m_t[0, 0].Width / 2), (this.Height / 4) + (m_t[0, 0].Height + 4));
            m_t[0, 1] = new TextBox();
            m_t[0, 1].Parent = this;
            m_t[0, 1].Text = "J2";
            m_t[0, 1].Location = new Point((this.Width * 2 / 3) - (m_t[0, 1].Width / 2), (this.Height / 4) + (m_t[0, 1].Height + 4));
            m_t[1, 0] = new TextBox();
            m_t[1, 0].Parent = this;
            m_t[1, 0].MaxLength = 1;
            m_t[1, 0].Text = "O";
            m_t[1, 0].Location = new Point((this.Width / 3) - (m_t[1, 0].Width / 2), (this.Height / 2) + (m_t[1, 0].Height + 4));
            m_t[1, 1] = new TextBox();
            m_t[1, 1].Parent = this;
            m_t[1, 1].MaxLength = 1;
            m_t[1, 1].Text = "X";
            m_t[1, 1].Location = new Point((this.Width * 2 / 3) - (m_t[1, 1].Width / 2), (this.Height / 2) + (m_t[1, 1].Height + 4));

            m_l = new Label[2, 2];
            m_l[0, 0] = new Label();
            m_l[0, 0].Parent = this;
            m_l[0, 0].Text = "Nom du joueur 1";
            m_l[0, 0].Location = new Point((this.Width / 3) - (m_l[0, 0].Width / 2), (this.Height / 4) - 4);
            m_l[0, 1] = new Label();
            m_l[0, 1].Parent = this;
            m_l[0, 1].Text = "Nom du joueur 2";
            m_l[0, 1].Location = new Point((this.Width * 2 / 3) - (m_l[0, 1].Width / 2), (this.Height / 4) - 4);
            m_l[1, 0] = new Label();
            m_l[1, 0].Parent = this;
            m_l[1, 0].Text = "Symbole du joueur 1";
            m_l[1, 0].Location = new Point((this.Width / 3) - (m_l[1, 0].Width / 2), (this.Height / 2) - 4);
            m_l[1, 1] = new Label();
            m_l[1, 1].Parent = this;
            m_l[1, 1].Text = "Symbole du joueur 2";
            m_l[1, 1].Location = new Point((this.Width * 2 / 3) - (m_l[1, 1].Width / 2), (this.Height / 2) - 4);

            m_b = new Button();
            m_b.Parent = this;
            m_b.Click += Action;
            m_b.Text = "Valider";
            m_b.Location = new Point((this.Width - m_b.Width) / 2, 3 * this.Height / 4);

            Button val = new Button();
        }

        protected void Taille(Object sender, EventArgs e)
        {
            this.Size = new Size(7 * m_dim, 9 * m_dim);
        }

        public void Action(Object sender, EventArgs e)
        {
            //Event du boutton
            if ((m_t[0, 0].Text != "")
                && (m_t[0, 1].Text != "")
                && (m_t[0, 1].Text != m_t[0, 0].Text)
                && (m_t[1, 0].Text != "")
                && (m_t[1, 0].Text != " ")
                && (m_t[1, 1].Text != "")
                && (m_t[1, 1].Text != " ")
                && (m_t[1, 1].Text != m_t[1, 0].Text))
            {
                m_joueur = new Joueur[2];
                m_joueur[0] = new Joueur(m_t[0, 0].Text, m_t[1, 0].Text[0]);
                m_joueur[1] = new Joueur(m_t[0, 1].Text, m_t[1, 1].Text[0]);
                m_b.Visible = false;
                m_t[0, 0].Visible = false;
                m_t[0, 1].Visible = false;
                m_t[1, 0].Visible = false;
                m_t[1, 1].Visible = false;
                m_l[0, 0].Visible = false;
                m_l[0, 1].Visible = false;
                m_l[1, 0].Visible = false;
                m_l[1, 1].Visible = false;
                m_tour = 1;
                Jeu();
            }
        }

        public void Jeu()
        {
            //Interface de Jeu
            m_fin = false;
            m_tb = new Label[7, 7];
            m_but = new Button[7];
            m_plateau = new Plateau();
            m_tour = 1;
            Random r = new Random();
            int n = (r.Next() >= 0.5) ? 1 : 0;
            m_index = new int[] { n, n };
            for (int i = 0; i < 7; i++)
            {
                m_but[i] = new Button();
                m_but[i].Parent = this;
                m_but[i].Click += Jouer;
                m_but[i].TabIndex = i;
                m_but[i].Text = "Colonne" + (i + 1);
                m_but[i].Location = new Point((i * m_dim) + ((m_dim - m_but[i].Width) / 2), (m_dim - m_but[i].Height) / 2);
                for (int j = 0; j < 7; j++)
                {
                    m_tb[i, j] = new Label();
                    m_tb[i, j].Parent = this;
                    m_tb[i, j].Size = new Size(60, 60);
                    m_tb[i, j].Text = " ";
                    m_tb[i, j].Font = new Font("Arial", 35, FontStyle.Bold);
                    m_tb[i, j].Location = new Point((i * m_dim) + ((m_dim - m_tb[i, j].Width) / 2), ((j + 1) * m_dim) + ((m_dim - m_tb[i, j].Height) / 2));
                }
            }
        }

        protected void Jouer(Object sender, EventArgs e)
        {
            int c = ((Button)sender).TabIndex;
            if (!m_fin && m_plateau.Dispo(c))
            {
                //On joue
                int i = m_plateau.Jouer(c, m_joueur[m_index[0]].Pion());
                m_tb[c, i].Text = "" + m_joueur[m_index[0]].Pion();
                //On regarde si le jeu est fini
                if (!m_plateau.Dispo(c))
                    ((Button)sender).Enabled = false;
                //On regarde si un joueur a gagné
                char g = m_plateau.Gagnant();
                if (g != ' ')
                    Fin(true);
                bool test = false;
                for (int j = 0; (j < 7) && !test; j++)
                    test |= ((Button)sender).Enabled;
                if (!test)
                    Fin(false);

                //On passe au tour suivant
                m_index[0] = 1 - m_index[0];
                if (m_index[0] == m_index[1])
                    m_tour++;
            }
        }

        protected void Fin(bool b)
        {
            m_gagnant = new Label();
            m_gagnant.Parent = this;
            if (b)
                m_gagnant.Text = "Fin du jeu : bravo " + m_joueur[m_index[0]].Nom();
            else m_gagnant.Text = "Fin du jeu : aucun gagnant";
            m_gagnant.Location = new Point((this.Width - m_gagnant.Width) / 2, (8 * m_dim) + (m_dim - m_gagnant.Height) / 2);
        }
    }
}
