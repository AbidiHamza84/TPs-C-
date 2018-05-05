using System;
namespace TP2
{
    public class Bouton : ComposantGraphique
    {
        private static int numero = 0;
        public Bouton() : base()
        {
            Bouton.numero++;
            this.id = "Bt" + Bouton.numero;
        }

        public Bouton(Couleur couleur)
        {
            this.couleur = couleur;
            Bouton.numero++;
            this.id = "Bt" + Bouton.numero;
        }

        new public void Affiche()
        {
            Console.WriteLine("ID: "+this.id);
            base.Affiche();
        }

        override public void Activer()
        {
            if (this.actif == false)
            {
                Console.WriteLine("Exécution de l’action du bouton" + this.id);
                base.Activer();
            }        
        }
    }
}
