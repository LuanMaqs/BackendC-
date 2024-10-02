using DesafioFundamentos.Models;
using System.Globalization;
using AulasBackEndDIO.models;
// using Newtonsoft.Json;


Console.OutputEncoding = System.Text.Encoding.UTF8;

// decimal precoInicial = 0;
// decimal precoPorHora = 0;

// Console.WriteLine("Seja bem-vindo ao sistema de estacionamento!\n" +
//                   "Digite o preço inicial:");
// while (!decimal.TryParse(Console.ReadLine(), out precoInicial) || precoInicial < 0)
// {
//     Console.WriteLine("Por favor, insira um valor numérico válido para o preço inicial (não negativo):");
// }

// Console.WriteLine("Agora digite o preço por hora:");
// while (!decimal.TryParse(Console.ReadLine(), out precoPorHora) || precoPorHora < 0)
// {
//     Console.WriteLine("Por favor, insira um valor numérico válido para o preço por hora (não negativo):");
// }


// Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

// string opcao = string.Empty;
// bool exibirMenu = true;


// while (exibirMenu)
// {
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção:");
//     Console.WriteLine("1 - Cadastrar veículo");
//     Console.WriteLine("2 - Remover veículo");
//     Console.WriteLine("3 - Listar veículos");
//     Console.WriteLine("4 - Encerrar");

//     string input = Console.ReadLine();
//     switch (input)
//     {
//         case "1":
//             es.AdicionarVeiculo();
//             break;

//         case "2":
//             es.RemoverVeiculo();
//             break;

//         case "3":
//             es.ListarVeiculos();
//             break;

//         case "4":
//             exibirMenu = false;
//             break;

//         default:
//             Console.WriteLine("Opção inválida");
//             break;
//     }

//     Console.WriteLine("Pressione uma tecla para continuar");
//     Console.ReadKey();  
// }

// Console.WriteLine("O programa se encerrou");

Pessoa p1 = new Pessoa();
p1.Nome = "Luan";
p1.Sobrenome = "Marques";
p1.Idade = 18;
p1.Apresentar();