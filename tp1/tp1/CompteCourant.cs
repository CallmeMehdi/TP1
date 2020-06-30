using System;
class CompteCourant : Compte
{
    private double decouvert;

    public CompteCourant(string proprio, double solde, double decouvert) : base(proprio, solde)
    {
        this.decouvert = decouvert;
    }

    public new void Resume()
    {
        base.Resume();
        Console.WriteLine("Le découvert autorisé est: " + decouvert);
    }
}