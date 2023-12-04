
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

    //// Código para obter dados da tabela curso
    // var cursos = db.Curso.AsNoTracking(); //Array IQueryable -> de objetos
    // foreach (var curso in cursos)
    // {
    //     Console.WriteLine(curso.Titulo + "-------------"+ curso.Descricao + "-------------"+ curso.DataDePublicacao);
    // }


    ////Código para obter dados da tabela curso e preço
    // var cursos = db.Curso.Include(f => f.PrecoPromocao).AsNoTracking();
    // foreach (var curso in cursos)
    // {
    //     Console.WriteLine(curso.Titulo + "-------------" + curso.Descricao + "-------------" + curso.DataDePublicacao + "-------------" + curso.PrecoPromocao?.PrecoAtual);
    // }



    //Código para obter dados da tabela curso e comentario
    var cursos = db.Curso.Include(c => c.ListaDeComentarios).AsNoTracking();
    foreach (var curso in cursos)
    {
        // Console.WriteLine(curso.Titulo);
        Console.WriteLine(curso.Titulo + "-------------" + curso.Descricao + "-------------" + curso.DataDePublicacao + "-------------" + curso.PrecoPromocao?.PrecoAtual);     
        foreach (var comentario in curso.ListaDeComentarios){
            Console.WriteLine("-------------" + comentario.ComentarioTexto );           
        }
    }
}

