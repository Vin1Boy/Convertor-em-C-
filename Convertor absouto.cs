using System;

namespace Convertor_Absoluto
{
	class Program
	{
		public static void Main(string[] args)
		{
		
			
			Console.WriteLine("______________________________________________________");
			Console.WriteLine("                   CONVERTOR ABSOLUTO                 ");
			Console.WriteLine("______________________________________________________");
			Console.WriteLine("");
			Console.WriteLine("Converter para Binário (B)");
			Console.WriteLine("Converter para Octal (O)");
			Console.WriteLine("Converter para Hexadecimal (H)");
			Console.WriteLine("");
			Console.WriteLine("______________________________________________________");
			Console.WriteLine("");
			
			
			Console.Write("Escolha o tipo de conversão (B/O/H): ");
			string TipoCon =(Console.ReadLine());
			
			if ((TipoCon != "B") && (TipoCon != "O") && (TipoCon != "H")) {
				
				Console.WriteLine("");
				Console.WriteLine("Você não selecionou nenhuma das opções");
				Console.ReadKey(true);
			}
			
			else {
				Console.Write("Escreva o número o decimal: ");
				int Z = int.Parse(Console.ReadLine());
				
				if (Z < 0) {
					Console.WriteLine("");
					Console.WriteLine("Número inválido!");
				}
				
				else{
					
					if (TipoCon == "B") {
						
						string x = "";
						int Y = Z;
						
						while (Z > 0) {
							switch(Z % 2) {
								case 0:
									x = "0" + x;
									break;
								case 1:
									x = "1" + x;
									break;
							}
							
							Z = Z / 2;
							
						}
						Console.WriteLine("");
						Console.WriteLine("A representação binaria de "+ Y + " é " + x + "!");
					}
					
					else if (TipoCon == "O") {
						
						string x = "";
						int Y = Z;
						
						
						while (Z > 0) {
							switch(Z % 8) {
								case 0:
									x = "0" + x;
									break;
								case 1:
									x = "1" + x;
									break;
								case 2:
									x = "2" + x;
									break;
								case 3:
									x = "3" + x;
									break;
								case 4:
									x = "4" + x;
									break;
								case 5:
									x = "5" + x;
									break;
								case 6:
									x = "6" + x;
									break;
								case 7:
									x = "7" + x;
									break;
							}
							
							Z = Z / 8;
							
						}
						Console.WriteLine("");
						Console.WriteLine("A representação binaria de "+ Y + " é " + x + "!");
					}
					
					else if (TipoCon == "H") {
						
						string x = "";
						int Y = Z;
						
						while (Z > 0) {
							switch(Z % 16) {
								case 0:
									x = "0" + x;
									break;
								case 1:
									x = "1" + x;
									break;
								case 2:
									x = "2" + x;
									break;
								case 3:
									x = "3" + x;
									break;
								case 4:
									x = "4" + x;
									break;
								case 5:
									x = "5" + x;
									break;
								case 6:
									x = "6" + x;
									break;
								case 7:
									x = "7" + x;
									break;
								case 8:
									x = "8" + x;
									break;
								case 9:
									x = "9" + x;
									break;
								case 10:
									x = "A" + x;
									break;
								case 11:
									x = "B" + x;
									break;
								case 12:
									x = "C" + x;
									break;
								case 13:
									x = "D" + x;
									break;
								case 14:
									x = "E" + x;
									break;
								case 15:
									x = "F" + x;
									break;	
							}
							
							Z = Z / 16;
							
						}
						Console.WriteLine("");
						Console.WriteLine("A representação binaria de "+ Y + " é " + x + "!");
					}
				 }
			  }
			
			Console.ReadKey(true);
		}
	}
}
