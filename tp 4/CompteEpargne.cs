using System;

namespace TP4
{
	public class CompteEpargne
	{
		private int solde ;
		public CompteEpargne (int solde)
		{
			this.solde = solde;
		}

		public int debit(){
			int montant = 5;
			if (solde - montant >= 0) {
				solde -= montant;
                Console.WriteLine("alimentation de "+montant+"€");
				return montant; 
			} else {
				throw new Exception ("Le compte d'epargne est vide !");
			}
		}
	}
}

