using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace TaCertoForms.Models{
    public class Perfil{
       [Key]
       int IdPerfil { get; set; }
       string Nome { get; set; }
       string Descricao { get; set; }
    }
}