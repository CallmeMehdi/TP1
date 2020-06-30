using System;

class Program
{
    static void Main(string[] args)
    {
        CompteCourant a = new CompteCourant("Nicolas", 0, 2000);
        CompteEpargneEntreprise a1 = new CompteEpargneEntreprise("Nicolas", 0, 0.02);
        CompteCourant b = new CompteCourant("Jeremy", 0, 500);
        a.Debiter(100);
        a.Crediter(50);
        a1.Debiter(a, 20);
        a1.Debiter(100);
        a1.Crediter(a, 20);
        b.Crediter(500);
        b.Crediter(a, 200);
        Console.WriteLine("Solde compte courant de Nicolas :" + a.getSolde());
        Console.WriteLine("Solde compte epargne de Nicolas :" + a1.getSolde());
        Console.WriteLine("Solde compte courant de Jeremie :" + b.getSolde());
        Console.WriteLine("**********************************");
        Console.WriteLine("Résumé du compte de Nicolas");
        Console.WriteLine("**********************************");
        a.Resume();
        Console.WriteLine("**********************************");
        Console.WriteLine("Résumé du compte épargne de Nicolas");
        Console.WriteLine("##################################");
        a1.Resume();
        Console.WriteLine("##################################");
    }
}

