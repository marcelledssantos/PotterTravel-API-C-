using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PotterTravel.Model
{
    [Table("clientes")]
    public class Cliente
    {


        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;

        [Required]
        public string Cpf { get; set; }  = string.Empty;

        public string Telefone { get; set; }  = string.Empty;

        public string Email { get; set; }  = string.Empty;

        public string Senha { get; set; }  = string.Empty;
    }
}