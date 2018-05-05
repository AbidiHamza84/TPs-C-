using System;
namespace TP4
{
	public delegate bool Compare(int a, int b);
	public class Point
	{
		private int x;
		private int y;

        public Point(){
            y = 1;
        }

		public Point(int x, int y)
		{
			this.x = x;
			this.y = y;
		}

		public int X{
			get { return x; }
			set { this.x = value; }
		}

		new public String ToString()
		{
			return "ce point a pour cordonnées: x = "+x+" , y = "+y;
		}

		public static bool XInf(int x , int a){
			return x < a;
		}

		public static bool YInf(int y , int a){
			return y < a;
		}

		public static bool XSup(int x , int a){
			return x > a;
		} 

		public static bool YSup(int y , int a){
			return y > a;
		}

		public void Display(Compare comparaison,int v){
			if (comparaison (this.x,v))
				Console.WriteLine (ToString ());
		}

	}
}