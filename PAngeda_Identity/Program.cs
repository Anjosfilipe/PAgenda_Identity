using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAngeda_Identity.Context;
using PAngeda_Identity.Models;

namespace PAngeda_Identity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new PersonContext())
            {
                //INSERT
                Person People = new Person();
                People.Name = "Baratao";
                People.Email = "-------@-------";
                People.Telephone.Telphone = "97070";
                People.Telephone.Mobile = "1698080";

                context.People.Add(People);
                context.SaveChanges();


               // LISTAR TUDO
                var people = new PersonContext().People.ToList();
                foreach (var item in people)
                {
                    Console.WriteLine(item.ToString());
                    Console.WriteLine("\n");
                }
                Console.WriteLine("Dados Listados!\n\nDigite enter para continuar.");
                Console.ReadKey();
               

                // BUSCAR ESPECIFICO
                Console.WriteLine("Digite o nome para busca: ");
                string n = Console.ReadLine();
                Person find = new PersonContext().People.FirstOrDefault(f => f.Name == n);
                if (find != null)
                    Console.WriteLine(find.ToString());
                Console.WriteLine("Digite enter para continuar.");
                Console.ReadKey();
               

               //REMOVE
                Console.WriteLine("Digite o nome que deseja remover: ");
                string nome = Console.ReadLine();
                Person name = new PersonContext().People.FirstOrDefault(f => f.Name == nome);
                context.Entry(name).State = EntityState.Deleted;
                context.People.Remove(name);
                context.SaveChanges();
                Console.WriteLine("Dados Removidos!\n\nDigite enter para continuar.");
                Console.ReadKey();
              

              //UPDATE
                Console.WriteLine("Digite o nome para alterar: ");
                string y = Console.ReadLine();
                Person findx = new PersonContext().People.FirstOrDefault(f => f.Name == y);

                if (findx != null)
                {
                    context.Entry(findx).State = EntityState.Modified;
                    findx.Name = "Valdomiro";
                    context.SaveChanges();
                }
                Console.WriteLine("Dado alteraido!\n\n enter para continuar.");
                Console.ReadKey();
            

            }

        }
    }
}
