// See https://aka.ms/new-console-template for more information
using System;

namespace Sist_Contr_Cli_Senai
{
    class Program
    {
        static void Main (string[] args)
        {
            float val_pag;
            
            Console.WriteLine("Informar Nome: ");
            string var_nome = Console.ReadLine();
            
            Console.WriteLine("Informar endereço: ");
            string var_endereco = Console.ReadLine();

            Console.WriteLine("Informar Pessoa Física (F) ou Jurídica (J)");
            string var_tipo = Console.ReadLine();
            
            if (var_tipo == "f")
            {
                Pessoa_Fisica pf = new Pessoa_Fisica();
                pf.nome = var_nome;
                pf.endereco = var_endereco;

                Console.WriteLine("Informar CPF: ");
                pf.CPF = Console.ReadLine();

                Console.WriteLine("Informar RG: ");
                pf.RG = Console.ReadLine();

                Console.WriteLine("Informar Valor da compra: ");
                val_pag = float.Parse(Console.ReadLine());              
                pf.Pagar_Imposto(val_pag);

                Console.WriteLine("---- Pessoa Física ----");
                Console.WriteLine("Nome ........ " +  pf.nome);
                Console.WriteLine("Endereço ........ " +  pf.endereco);
                Console.WriteLine("CPF ........ " +  pf.CPF);
                Console.WriteLine("RG ........ " +  pf.RG);
                Console.WriteLine("Valor de Compra ........" +  pf.valor.ToString("C"));
                Console.WriteLine("Imposto ........ " +  pf.valor_imposto.ToString("C"));
                Console.WriteLine("Total a pagar ........ " +  pf.total.ToString("C"));
            }
            if (var_tipo == "j")
            {
                 Pessoa_Juridica  pj = new Pessoa_Juridica();
                pj.nome = var_nome;
                pj.endereco = var_endereco;

                Console.WriteLine("Informar CNPJ: ");
                pj.CNPJ = Console.ReadLine();

                Console.WriteLine("Informar IE: ");
                pj.IE = Console.ReadLine();

                val_pag = float.Parse(Console.ReadLine());
                pj.Pagar_Imposto(val_pag);
                Console.WriteLine("---- Pessoa Juridica ----");
                Console.WriteLine("Nome ........"+  pj.nome);
                Console.WriteLine("Endereço ........"+  pj.endereco);
                Console.WriteLine("CNPJ ........"+  pj.CNPJ);
                Console.WriteLine("IE ........"+  pj.IE);
                Console.WriteLine("Valor de Compra ........"+  pj.valor.ToString("C"));
                Console.WriteLine("Imposto ........"+  pj.valor_imposto.ToString("C"));
                Console.WriteLine("Total a pagar ........"+  pj.total.ToString("C"));
            }




                        
        }
    }
}