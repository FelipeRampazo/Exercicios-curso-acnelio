using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExeListFic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> lista = new List<Funcionario>(); 
            Console.WriteLine("quantos empregados vão ser registrados ?  ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++){
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("NOME: ");
                string nome = Console.ReadLine();
                Console.Write("SALARIO: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                lista.Add(new Funcionario(id, nome, salario));          
            
            }

            Console.Write("Entre com o id do funcionario que tera o salario almentado: ");
            int idAlmento = int.Parse(Console.ReadLine());

            Funcionario funcioarioParaAlterar = lista.Find(x => x.Id == idAlmento);

            if (funcioarioParaAlterar != null)
            {
                Console.Write("entre com a porcentagem : ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                funcioarioParaAlterar.IncrementarSalario(porcentagem);

            }

            else {
                Console.WriteLine("este id nao existe");           
            }







            foreach (Funcionario func in lista) {
                Console.WriteLine(func.ToString());
            }
        }
    }
}
