using System;
class CompteEpargneEntreprise : Compte
{
    private double tauxAbondement;

    public CompteEpargneEntreprise(string proprio, double solde, double tauxAbondement) : base(proprio, solde)
    {
        this.tauxAbondement = tauxAbondement;
    }

    public new void Resume()
    {
        base.Resume();
        Console.WriteLine("Abondement: " + tauxAbondement);
    }

    public override void Debiter(double somme)
    {
        this.setSolde(somme + (somme * this.tauxAbondement));
        this.addOperation("+ " + somme);
    }
}