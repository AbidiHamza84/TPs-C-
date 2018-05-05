using System;
namespace TP2
{
    public class ComposantGraphique
    {
        protected Couleur couleur ;
        protected String id;
        protected bool actif;

        public ComposantGraphique()
        {
            actif = true;
            this.couleur = Couleur.NOIR;
        }

        public Couleur Couleur
        {
            get { return couleur; }
            set { couleur = value; }
        }

        public String Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public bool Actif
        {
            get { return actif; }
        }

        virtual public void Activer()
        {
            actif = true;
        }

        public void Desactiver()
        {
            actif = false;
        }

        virtual public void Affiche()
        {
            Console.WriteLine("Sa couleur est " + this.couleur);
        }
    }
}
