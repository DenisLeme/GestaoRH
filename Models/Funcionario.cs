using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FuncionarioCadastro.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }

        public bool Java { get; set; }
        public bool Csharp { get; set; }
        public bool React { get; set; }

        [Display(Name = "Data de Entrada")]
        [DataType(DataType.Date)]
        public DateTime DataEntrada { get; set; }
        
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Salário { get; set; }
    }
}