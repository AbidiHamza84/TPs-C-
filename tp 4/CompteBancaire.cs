using System;

namespace TP4
{
	public class CompteBancaire
	{
		public delegate void decouvertEventHandler(object sender , EventArgs e);
		public event decouvertEventHandler decouvert;
		private int solde ;
		private CompteEpargne CompteEpargne ;

		public CompteBancaire (int solde)
		{
			this.solde = solde ;
			CompteEpargne = new CompteEpargne (10);
		}

		public void Debit(int montant){
			solde -= montant ;
            if(solde < 0)
                solde = CompteEpargne.debit();
		}

		public void Credit(int montant){
			solde += montant ;
		}

		public void RaiseEvent(){
			if (decouvert != null && solde <= 0)
				decouvert (this,EventArgs.Empty);
		}

	}
}

