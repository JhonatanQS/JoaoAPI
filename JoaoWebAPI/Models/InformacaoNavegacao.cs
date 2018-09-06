using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JoaoWebAPI
{
    public class InformacaoNavegacao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string _event { get;set; } //event é uma Key word 
        public DateTime timestamp { get; set; }
    }
}
