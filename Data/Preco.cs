namespace BootcampNetCore;

public class Preco
{
    public int PrecoId { get; set; }
    public decimal PrecoAtual { get; set; }
    public decimal Promocao { get; set; }

    public int CursoId { get; set; }

    //Relação de Preços e Cursos (1--1)
    public Curso? Curso { get; set; }
}

