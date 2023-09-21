class DatabaseContext : DbContext 
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Gebruiker>().ToTable("Gebruiker");
    }
    protected override void OnConfiguring(DbContextOptionsBuilder builder) 
    {
        //gebruik "dotnet ef database update" om de database te creeren en te updaten
        //anders is er geen database in de project folder of de folder van je keuze
        builder.UseSqlite("Data Source=../database.db");
    }

    public DbSet<Gebruiker>Gebruiker{get;set;}
    public DbSet<Gast>Gast{get;set;}
    public DbSet<Medewerker>Medewerker{get;set;}

}