﻿using System;
namespace TP3
{
	public class Historique
	{
		private static int size = 5 ;
		private static int[] var = new int[size];
		private static int index = 0;


		public static void Sauvegarde(int valeur)
		{
			if (index < size - 1) 
			{
				index++;
				var [index] = valeur;
			} 
			else
			{
				index = 0;
				var [index] = valeur;
			}
		}

		public static int DerniereSauvegarde(){
			return var [index];
		}
	}
}