using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAngeda_Identity.Models
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Phone Telephone { get; set; }

        public override string ToString()
        {
            return $"Nome: {this.Name}\nE-mail: {this.Email}\nTelefone: {this.Telephone.Telphone}\nCelular:{this.Telephone.Mobile}";
        }
    }
}
