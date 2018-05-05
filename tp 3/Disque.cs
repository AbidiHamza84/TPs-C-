using System;
namespace TP3
{
	public class Disque : ICloneable
	{
		private Point centre;
		private int rayon;
		private Disque hist;

		public Disque(int x , int y, int rayon)
		{
			centre = new Point(x, y);
			this.rayon = rayon;
		}

		public Disque(Point centre , int rayon)
		{
			this.centre = centre;
			this.rayon = rayon;
		}

		public override string ToString()
		{
			return "Disque: \n\t"+centre.ToString()+"\n\trayon = "+rayon;
		}

		public Point Centre
		{
			get { return centre; }    
		}

		public void sauv()
		{
			hist = (Disque)this.Clone();
		}

		public void restaure()
		{
			if (hist != null) {
				this.Centre.X = hist.Centre.X;
			}
		}

		public object Clone()
		{
			Disque d = (Disque)this.MemberwiseClone ();
			d.centre = (Point)this.centre.Clone();
			return d;
		}
	}
}