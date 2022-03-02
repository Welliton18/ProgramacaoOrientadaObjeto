using System;

public class atividadeArray {
	public void atividade_1(){
		int[] aArray = new int[5];
		aArray[0] = 10;
		aArray[1] = 34;
		aArray[2] = 21;
		aArray[3] = 45;
		aArray[4] = 15;

		foreach (int iNumero in aArray) {
			Console.WriteLine(iNumero);
        }
	}

	public void atividade_2() {
		string[] aArray = {
			"Cliente 1 email: cliente1@yahoo.com.br",
			"Cliente 2 email: cliente2@yahoo.com.br",
			"Cliente 3 email: cliente3@yahoo.com.br",
			"Cliente 4 email: cliente4@yahoo.com.br",
			"Cliente 5 email: cliente5@yahoo.com.br"
		};

		foreach(string sCliente in aArray) {
			Console.WriteLine(sCliente);
		}
	}

	public void atividade_3() {
		int[,] aMatriz = { { 1, 6, 7 }, { 2, 5, 1 }, { 2, 4, 1 } };
		int iNumero = 1;

		for(int iIndice = 0; iIndice < aMatriz.GetLength(0); iIndice++) {
            for(int iIndice2 = 0; iIndice2 < aMatriz.GetLength(0); iIndice2++) {
				Console.WriteLine("Número "+ iNumero++ + ": " + aMatriz[iIndice, iIndice2]);
			}
		}
	}
}
