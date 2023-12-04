using System;
namespace BootcampNetCore;

public class Comentario
{
    public int ComentarioId { get; set; }
    public string Aluno { get; set; }
    public int Pontuacao { get; set; }
    public string? ComentarioTexto { get; set; }
    public int CursoId { get; set; }

    //Relação de Comentario e Cursos (1 -- N)
    public Curso? Curso { get; set; }
}
