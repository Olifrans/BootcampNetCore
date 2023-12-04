
using BootcampNetCore;
using Microsoft.EntityFrameworkCore;


// //Injection Dependency ConnectionString Sql Server.
// var conection = builder.Configuration.GetConnectionString("ConnectionCodeFirst");
// builder.Services.AddDbContext<CursoDbContext>(option =>
// 	option.UseSqlServer(conection,
// 	//Nome do assembly onde as migraçoes estão definidas
// 	f => f.MigrationsAssembly(typeof(CursoDbContext).Assembly.FullName)));


using (var db = new CursoDbContext())
{
    var cursos = db.Curso.AsNoTracking(); //Array IQueryable -> de objetos
    foreach (var curso in cursos)
    {
        Console.WriteLine(curso.Titulo + "-------------"+ curso.Descricao + "-------------"+ curso.DataDePublicacao);
    }
}

