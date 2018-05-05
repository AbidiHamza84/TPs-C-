using System;
namespace TP2
{
    public class Menu : ComposantGraphique
    {
        private static int numero = 0;
        public Menu() : base()
        {
            Menu.numero++;
            this.id = "Mn" + Menu.numero;
        }

        public Menu(Couleur couleur)
        {
            Menu.numero++;
            this.id = "Mn" + Menu.numero;
            this.couleur = couleur;
        }

        override public void Affiche()
        {
            Console.WriteLine("ID: "+this.id);
            base.Affiche();
        }
    }
}
