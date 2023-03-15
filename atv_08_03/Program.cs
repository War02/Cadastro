using System;
namespace atv_08_03
{
    class Program
    {
        static void Main(string[] args) 
        {

            Cliente c1 = new Cliente(1, "Mateus Barreto Santos", "16991277079");
            Endereco e1 = new Endereco(1, "15990630", "Av. 15 de Novembro", 114, "Nova Matão", "Matão-SP");

            Console.WriteLine("\t---------- Cadastro ----------");
            Console.WriteLine("ID: " + c1.getId() + "\nNome: " + (c1.getName()) + "\nTelefone: " + (c1.getTelefone()));
            Console.WriteLine("CEP: " + (e1.getCep()) + "\nRua: " + e1.getRua() + "\nNúmero: " + e1.getNumero() + "\nBairro: " + e1.getBairro() + "\nCidade: " + e1.getCidade() + "\n");

            c1.setName("Alberto de Alcântara");
            c1.setTelefone("16998076556");

            Console.WriteLine("Nome: " + (c1.getName()) + "\nTelefone: " + (c1.getTelefone()) + "\n");
        }
    }   
}
