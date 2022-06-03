using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bent.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Pais { get; set; }

        public string Estado { get; set; }

        public string Municipio { get; set; }

        public string Cep { get; set; }

        public string Rua { get; set; }

        public int Numero { get; set; }

        public string complemento { get; set; }

        public string Cpf { get; set; }

        public string Pis { get; set; }

        public string Senha { get; set; }

    }
}
