﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaCertoForms.Models{
    [Table("DisciplinaTurma")]
    public class DisciplinaTurma {
        [Key]
        public int IdDisciplinaTurma { get; set; }
        public int IdDisciplina { get; set; }
        public int IdTurma { get; set; }


        //NAVIGATION PROPERTY
        public Disciplina Disciplina { get; set; }
        public Turma Turma { get; set; }
    }
}