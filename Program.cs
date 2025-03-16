using Pessoa.Entities;
using Banco.Bank;
    

Console.Write(" ----Digite seu nome: ");
string nome = Console.ReadLine();
Console.Write(" ----Digite sua idade: ");
int age = int.Parse(Console.ReadLine());
Person person1 = new Person(nome, age);       


while(true){
    Console.WriteLine("O que deseja fazer?");
    Console.WriteLine(" 1. Trabalhar \n 2. Ver sua conta \n 3. Ver suas Credenciais \n 4. Sair");
    int num = int.Parse(Console.ReadLine());
    if (num == 1){
        person1.Trabalhando();
    }
    else if (num == 2){
        person1.Conta();
    }
    else if (num == 3){
        person1.ShowPerson();
    }
    else if(num == 4){
        break;
    }
    else {
        Console.WriteLine(" ----Numero invalido.---- ");
    }
}
