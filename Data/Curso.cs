using System.Security.AccessControl;

using System;
// using System.Collections.Generic;
using System.Collections.Generic;
using System.Collections.Generic;

namespace BootcampNetCore;

public class Curso
{
    public int CursoId{get; set;}   
    public string? Titulo{get; set;}
    public string? Descricao{get; set;}
    public System.DateTime? DataDePublicacao{get; set;}
    public byte[]? FotoDeCapa{get; set;}

    
    public Preco? PrecoPromocao{get; set;}
    public ICollection<Comentario?> ListaDeComentarios{get; set;}
}

