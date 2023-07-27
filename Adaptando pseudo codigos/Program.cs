using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptando_pseudo_codigos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            salario_mensal = input('Qual é o seu salário mensal?')
            //horas_trabalhadas_por_mes = input('Quantas horas trabalha por mes?')
            //valor_hora = int(salario_mensal) / int(horas_trabalhadas_por_mes)
            //print(valor_hora)

            
            string Salario_mensal = Input("Qual seu salario?");
            string Horas_trabalhadas = Input("Quantas horas vc trabalha por mes?");
            int Valor_hora = int.Parse(Salario_mensal) /int.Parse(Horas_trabalhadas);
            Console.WriteLine(Valor_hora);

        }
        static string Input(string Mensagem)
        {       
            Console.WriteLine(Mensagem);
            return Console.ReadLine();
        }
    }
}

