class Gebruiker
{
    public int Id {get;set;}
    public string Email{get;set;}
    
    public Gebruiker(string Email)
    {
        this.Email = Email;
    }
}

class Gast : Gebruiker
{
    // public int Credits{get;set;}
    // public List<Reserveringen> Reserveringen {get;set;}
    // public DateTime EersteBezoek{get;set;}
    // public GastInfo GastInfo{get;set;}
    // public int GastInfoIf {get;set;}
    // public Gast? Gebeleidt {get;set;}


    public Gast(string Email) : base(Email)
    {
    }
}
class Medewerker : Gebruiker
{
    public Medewerker(string Email) : base(Email)
    {
    }
}