using System;

namespace TP2
{
    class Test
    {
        public static void Main(string[] args)
        {
            //******* exercice 1 ********
            // Partie A
            //A();

            // Partie B et C
            //BC();

            //******* exercice 2 ********
            // Partie D
            D();


        }

        public static void A(){
            Bouton bouton1 = new Bouton();
            Bouton bouton2 = new Bouton(Couleur.ROUGE);

            bouton1.Affiche();
            bouton2.Affiche();
        }

        public static void BC(){
            ComposantGraphique[] composantGraphique = new ComposantGraphique[5];

            composantGraphique[0] = new Bouton();
            composantGraphique[1] = new Menu();
            composantGraphique[2] = new Bouton(Couleur.VERT);
            composantGraphique[3] = new Menu(Couleur.BLANC);
            composantGraphique[4] = new Bouton(Couleur.NOIR);

            foreach (ComposantGraphique cg in composantGraphique)
            {
                
                    cg.Affiche();

                Console.WriteLine("***********************");
            }

        }

        public static void D(){
            ComposantGraphique[] composantGraphique = new ComposantGraphique[5];

            composantGraphique[0] = new Bouton();
            composantGraphique[0].Desactiver();

            composantGraphique[1] = new Menu();
            composantGraphique[2] = new Bouton(Couleur.VERT);
            composantGraphique[3] = new Menu(Couleur.BLANC);

            composantGraphique[4] = new Bouton(Couleur.NOIR);
            composantGraphique[4].Desactiver();

            foreach (ComposantGraphique cg in composantGraphique)
            {
                Menu menu = cg as Menu;
                if (menu != null)
                {
                    menu.Affiche();
                }
                else
                {
                    cg.Activer();
                }
            }
        }
    }
}
