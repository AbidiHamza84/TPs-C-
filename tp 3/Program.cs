using System;

namespace TP3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			

			Console.WriteLine ("Exercice 2 :\n");
            Point p = new Point(1, 2);
            p.sauv();
			p.X = 5;
			Console.WriteLine("p avant restaure (apres modification):\n"+p.ToString());
			p.restaure ();
			Console.WriteLine("apres restaure :\n"+p.ToString());


			Console.WriteLine ("\n\n\nExercice 3 :\n");
            Disque disque = new Disque(1, 2, 3);
            disque.sauv();


			Console.WriteLine("disque :\n"+disque.ToString());

			disque.Centre.X = 5;
			Console.WriteLine ("****************************************");
			Console.WriteLine("disque avant restaure (apres modification):\n"+disque.ToString());
			disque.restaure ();
			Console.WriteLine ("****************************************");
			Console.WriteLine("disque apres restaure :\n"+disque.ToString());

        }
    }
}
