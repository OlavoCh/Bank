using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Banco.Bank;

namespace Pessoa.Entities
{
    public class Person : Bank
    {
        public Person(string name, int age){
            Name = name;  
            Age = age;
        }
        public string Name { get; private set; }
        public int Age { get; private set;}
        public string PassWord { get; private set; }   

        public void ShowPerson()
        {
            Console.WriteLine($" ----Nome: {Name}, idade {Age}, ID {HashCode.Combine(Name)}---- ");
        }


    }
}