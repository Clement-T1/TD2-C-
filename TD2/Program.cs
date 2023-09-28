using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choisissez une option :");
        Console.WriteLine("1. Lister les noms des 12 mois.");
        Console.WriteLine("2. Lister les noms des 12 mois avec les mois contenant un 'R'.");
        Console.WriteLine("3. Lister les 12 mois avec leur numéro.");

        int choix = int.Parse(Console.ReadLine());

        string[] mois = { "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre" };

        switch (choix)
        {
            case 1:
                foreach (string m in mois)
                {
                    Console.WriteLine(m);
                }
                break;

            case 2:
                foreach (string m in mois)
                {
                    if (m.ToLower().Contains("r"))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.WriteLine(m);
                    Console.ResetColor();
                }
                break;

            case 3:
                for (int i = 0; i < mois.Length; i++)
                {
                    Console.WriteLine($"{i + 1} {mois[i]}");
                }
                break;

            default:
                Console.WriteLine("Option invalide.");
                break;
        }

        Console.ReadLine();    
    }

}
