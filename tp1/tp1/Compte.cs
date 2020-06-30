using System;
using System.Collections.Generic;
class Compte
{
    protected double solde;

    public string proprietaire;

    private List<string> operations = new List<string>();

    public Compte(string proprietaire, double solde)
    {
        this.proprietaire = proprietaire;
        this.solde = solde;
    }

    public double getSolde()
    {
        return (this.solde);
    }

    public void setSolde(double solde)
    {
        this.solde = solde;
    }

    public void addOperation(string op)
    {
        this.operations.Add(op);
    }

    public void Crediter(double somme)
    {
        this.solde -= somme;
        this.addOperation("- " + somme);
    }

    public void Crediter(Compte c, double somme)
    {
        this.solde -= somme;
        c.Debiter(somme);
        this.addOperation("- " + somme);
    }

    public virtual void Debiter(double somme)
    {
        this.solde += somme;
        this.addOperation("+ " + somme);
    }

    public void Debiter(Compte compte, double somme)
    {
        this.solde += somme;
        this.addOperation("+ " + somme);
        compte.Crediter(somme);
    }

    public void Resume()
    {
        Console.WriteLine("Propriétaire : " + proprietaire);
        Console.WriteLine("Solde : " + solde);
        Console.WriteLine("Opérations : ");
        foreach (string item in operations)
        {
            Console.WriteLine(item);
        }
    }
}