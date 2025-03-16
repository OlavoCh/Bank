using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pessoa.Entities;

namespace Banco.Bank
{
    public class Bank
    {
        public int Saldo{get; private set;}
        public int Trabalhar{get; private set;} 

        public void Trabalhando(){  
            Saldo = 0;    
            Console.WriteLine(" ----Deseja trabalhar quantas vezes?---- ");
            int n1 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n1; i++){
              Saldo++;
            } 
        }
        public void Conta(){
            Console.WriteLine($" ----Seu saldo é de R${Saldo}---- ");
        }
    }

    
}