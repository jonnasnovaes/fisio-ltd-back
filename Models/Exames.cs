using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fisio_ltd_back.Models
{
    public class Exames
    {
        [Key]
        public int Id { get; set; }
        public int DadosBasicosId { get; set; }
        public string? ExamesComplementares { get; set; }
        public string? ExameFisico { get; set; } 

    }
}
