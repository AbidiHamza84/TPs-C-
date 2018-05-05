using System;
namespace TP4
{
	public delegate bool Comparaison(int a,int b);
	class MainClass
	{
		public static void Main (string[] args)
		{
			//exo1A ();

			//exo1B ();

			//exo34 ();
		}
        public static bool superieur(int a, int b)
        {
            return a > b;
        }

        public static bool inferieur(int a, int b)
        {
            return a < b;
        }

		public static void exo1A(){
			Console.WriteLine ("1) Les valeurs superieurs a 3\t\t2) Les valeurs inferieurs a 3");
			string choix = Console.ReadLine ();
			Comparaison comparaison;
			if (choix == "1")
				comparaison = new Comparaison(superieur);
			else
				comparaison = new Comparaison(inferieur);

			int[] tab = new int[4];
			tab [0] = 2;
			tab [1] = 1;
			tab [2] = 6;
			tab [3] = 5;

			for (int i = 0; i < 4; i++) {
				if (comparaison (tab [i], 3))
					Console.WriteLine (tab[i]);
			}
		}

		public static void exo1B(){
			Point p = new Point(2,3);
			p.Display (Point.XInf,3);

            Point[] points = new Point[5];
            points[0] = new Point(2, 1);
            points[1] = new Point(3, 1);;
            points[2] = new Point(5, 1);;
            points[3] = new Point(1, 1);;
            points[4] = new Point(0, 1);;

            displayArray(points,Point.XInf,3);

		}

		public static void exo34(){
			CompteBancaire cb = new CompteBancaire (10);
			cb.decouvert += ProblemeCompte;
			cb.Debit (11);
            cb.Debit(4);
            cb.Debit(4);
            cb.Debit(4);
            cb.Debit(4);
            cb.RaiseEvent();
		}


		private static void ProblemeCompte(object sender, EventArgs e){
			Console.WriteLine ("Compte a decouvert");
		}

        public static void displayArray(Point[] points , Compare compare , int v){
            for (int i = 0; i < points.Length; i++){
                points[i].Display(compare,v);
            }
        }
	}
}
