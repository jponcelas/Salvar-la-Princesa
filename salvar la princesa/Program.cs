using System;

namespace ArmesEnBatalla
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] ar = new string[]
            {
                "Llança", "Casc", "Espasa", "Escut", "Armadura"
            };

            var nw = new SalvarPrincesa();
            var result = nw.CalcularResultats(ar);
            
            int[] results = nw.CalcularResultats(ar);
            nw.MostrarResultats(results);
        }
    }

    public class SalvarPrincesa
    {
        public int[] CalcularResultats(string[] armes)
        {
            int Llança = 0, Casc = 0, Espasa = 0, Escut = 0, Armadura = 0;
            int pagesos = 0, soldats = 0, cavallers = 0;

            foreach (string arma in armes)
            {
                switch (arma)
                {
                    case "Llança":
                        Llança++;
                        break;
                    case "Casc":
                        Casc++;
                        break;
                    case "Espasa":
                        Espasa++;
                        break;
                    case "Escut":
                        Escut++;
                        break;
                    case "Armadura":
                        Armadura++;
                        break;
                }
            }

            while (Casc >= 1 && Llança >= 1 && Armadura >= 1 && Escut >= 1)
            {
                cavallers++;
                Casc--;
                Llança--;
                Armadura--;
                Escut--;
            }

            while (Casc >= 1 && Espasa >= 1 && Escut >= 1)
            {
                soldats++;
                Casc--;
                Espasa--;
                Escut--;
            }

            while (Llança >= 1)
            {
                pagesos++;
                Llança--;
            }

            return new int[] { pagesos, soldats, cavallers };
        }

        public void MostrarResultats(int[] results)
        {
            Console.WriteLine("Es pot enviar:");
            Console.WriteLine($"Pagesos: {results[0]}");
            Console.WriteLine($"Soldats: {results[1]}");
            Console.WriteLine($"Cavallers: {results[2]}");
        }
    }
}
