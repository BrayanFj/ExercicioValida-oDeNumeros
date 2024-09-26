// See https://aka.ms/new-console-template for more information

/*Crie um programa para cadastro de CPF de clientes que recebe o CPF em um input box apenas com números.
Ex: 'Insira seu CPF (digite apenas números)'
Caso o usuário digite algo diferente de números ou digite menos de 11 caracteres 
(tamanho do CPF brasileiro), o programa deve exibir uma mensagem de "Digite seu CPF corretamente e digite apenas números" */

using System.Security.Cryptography;
using System.Linq;


Console.WriteLine("Insira seu cpf");
string cpf = Console.ReadLine();
bool cpfValido = cpf.All(char.IsDigit);


if (cpf.Length == 11 && cpfValido){
    Console.WriteLine("Seu cpf é: " + cpf);
} else { 
    while (cpf.Length != 11 || !cpf.All(char.IsDigit)) {
        Console.WriteLine("Insira um CPF válido (digite apenas números):");
        cpf = Console.ReadLine();  
    }
    Console.WriteLine("Seu CPF é: " + cpf); 
}





Console.WriteLine("Segundo exercicio");



//faça o mesmo exercicio mas agora será uma validação de telefone

Console.WriteLine("insira seu telefone");
 string telefone = Console.ReadLine();
 bool telefoneValido = telefone.All(char.IsDigit); // esse comando serve para verificar se todos os carcteres são digitos

 if (telefone.Length == 11 && telefoneValido) {

    Console.WriteLine("Seu telefone é" + telefone);
 } else { while(telefone.Length != 11 || telefone.All(char.IsDigit) ) {

    Console.WriteLine("Insira um telefone válido");
    telefone = Console.ReadLine();
 }

Console.WriteLine("Seu telefone é" + " " + telefone);
 }


Console.WriteLine("Seu cpf é: " + cpf + " " + "Seu telefone é:" + telefone );