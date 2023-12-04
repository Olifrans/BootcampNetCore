namespace BootcampNetCore;

public class Preco
{
    public int PrecoId { get; set; }
    public decimal PrecoAtual { get; set; }
    public decimal Promocao { get; set; }

    public int CursoId { get; set; }

    //Relação de Preços e Cursos
    public Curso? Curso { get; set; }
}

