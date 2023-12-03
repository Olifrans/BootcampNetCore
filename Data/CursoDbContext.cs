using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.SqlServer;



namespace BootcampNetCore;

public class CursoDbContext : DbContext
{
    // private const string connectionString = @"Data Source=DESKTOP-RL96SQL;Initial Catalog=CursosOnline;Integrated Security=True;";
    private const string connectionString = @"Server=DESKTOP-RL96SQL;Database=CursosOnline;Integrated Security=SSPI;TrustServerCertificate=True";
    // private const string connectionString = @"Data Source=DESKTOP-RL96SQL;Database=CursosOnline;Integrated Security=SSPI;TrustServerCertificate=True";
    // private const string connString = "Server=.\\SQLEXPRESS;Database=Blog;Integrated Security=SSPI;TrustServerCertificate=True";


    // "ConnectionStrings": {
    //     "ConnectionRestAPI": "Data Source=DESKTOP-RL96SQL;Initial Catalog=RestAPI;Integrated Security=True; TrustServerCertificate=True"
    //   },

    // private const string connectionString = @"Data Source=DESKTOP-RL96SQL;Initial Catalog=CursosOnline;Integrated Security=True; TrustServerCertificate=True";
    // public CursoDbContext(DbContextOptions<CursoDbContext> options) : base(options)
    // {
    // }

    // public DbSet<Curso> Cursos { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connectionString);
        // base.OnConfiguring(optionsBuilder);
    }
    public DbSet<Curso> Curso { get; set; }


}

