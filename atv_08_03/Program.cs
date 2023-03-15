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
            Console.WriteLine("ID: " + c1.getId() + "\nNome: " + (c1.getName()) + "\nTelefone: " + MascaraTelefone(c1.getTelefone()));
            Console.WriteLine("CEP: " + MascaraCEP(e1.getCep()) + "\nRua: " + e1.getRua() + "\nNúmero: " + e1.getNumero() + "\nBairro: " + e1.getBairro() + "\nCidade: " + e1.getCidade() + "\n");

            c1.setName("Alberto de Alcântara");
            c1.setTelefone("16998076556");

            Console.WriteLine("Nome: " + (c1.getName()) + "\nTelefone: " + MascaraTelefone(c1.getTelefone()) + "\n");
        }
        private static string MascaraTelefone(string strNumero)
        {
            string strMascara = "{0:(00)0000-0000}";
            long lngNumero = Convert.ToInt64(strNumero);

            if (strNumero.Length == 11)
                strMascara = "{0:(00)00000-0000}";

            return string.Format(strMascara, lngNumero);
        }
        private static string MascaraCEP(string strNumero1)
        {
            string strMascaraCep = "{0:00000-000}";
            long lngNumero1 = Convert.ToInt64(strNumero1);

            if (strNumero1.Length == 8)
                strMascaraCep = "{0:00000-000}";

            return string.Format(strMascaraCep, lngNumero1);
        }
    }   
}
