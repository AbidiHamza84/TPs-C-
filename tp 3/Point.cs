using System;
namespace TP3
{
	public class Point :ICloneable
	{
		private int x;
		private int y;
		private Point hist;

		public Point(int x, int y)
		{
			Console.WriteLine("création d'une nouvelle instance Point");
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

		public void sauv(){
			hist = (Point)this.Clone();
		}

		public void restaure(){
			if (hist != null) {
				this.X = hist.X;
			}
		}

		public Object Clone()
		{
			return this.MemberwiseClone();
		}

	}
}