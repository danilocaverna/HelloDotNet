using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace TaCertoForms.Models{
    public class DisciplinaProfessor{
       [Key]
       int IdDisciplinaProfessor { get; set; }
       int IdDisciplina { get; set; }
       Disciplina Disciplina { get; set; }
       int IdPessoa { get; set; }
       Pessoa Pessoa { get; set; }
    }
}