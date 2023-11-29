using Microsoft.EntityFrameworkCore;
using System;

namespace BootcampNetCore;

public class CursoDbContext : DbContext
{
    public CursoDbContext(DbContextOptions<CursoDbContext> options) : base(options)
    {
    }

    private const string connectionString = @"Data Source=DESKTOP-RL96SQL;Initial Catalog=CursosOnline;Integrated Security=True; TrustServerCertificate=True";

    public DbSet<Curso> Cursos { get; set; }



    // "ConnectionStrings": {
    //     "ConnectionRestAPI": "Data Source=DESKTOP-RL96SQL;Initial Catalog=RestAPI;Integrated Security=True; TrustServerCertificate=True"
    //   },




}

