using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pessoa.Entities;

namespace Banco.Bank
{
    public class Bank
    {
        public int Saldo{get; private set;} = 0;

        public void Trabalhando(){  
            Console.Write(" ----Deseja trabalhar quantas vezes? ");
            int n1 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n1; i++){
            Saldo += 1;
            } 
        }
        public void Conta(){
            Console.WriteLine($" ----Seu saldo é de R${Saldo}---- ");
        }
    }

    
}