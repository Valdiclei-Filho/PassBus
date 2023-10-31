using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passagem
{
    public class Servico
    {
        List<PassagemOnibus> Passagens = new List<PassagemOnibus>();
        public void Inserir(PassagemOnibus passagem)
        {
            Passagens.Add(passagem);
        }

        public void Deletar(string identificacao)
        {
            for (int i = 0; i < Passagens.Count; i++)
            {
                var item = Passagens[i];

                if (item.Cliente.Nome == identificacao || item.Cliente.Cpf == identificacao)
                {
                    Passagens.Remove(item);
                }
            }
        }

        public void Apresentar(string identificacao)
        {
            bool encontrou = false;

            foreach (var item in Passagens)
            {
                if (item.Cliente.Nome == identificacao || item.Cliente.Cpf == identificacao)
                {
                    Console.WriteLine(item.Cliente.Nome);
                    Console.WriteLine(item.Cliente.Idade);
                    Console.WriteLine(item.Cliente.Cpf);
                    Console.WriteLine(item.Destino);
                    Console.WriteLine(item.Poltrona);
                    Console.WriteLine(item.HorarioPartida);
                    Console.WriteLine(item.HorarioChegada);
                    Console.WriteLine(item.FormaPagamento);
                    Console.WriteLine(item.Valor);

                    encontrou = true;
                    break;
                }
            }
            if (!encontrou)
            {
                Console.WriteLine("Não Existe");
            }
        }

        public void Alterar(string identificacao, string nome, int idade, string cpf, double valor, string destino, DateTime horarioPartida,
                            DateTime horarioChegada, string formaPagamento, string poltrona)
        {
            bool encontrou = false;

            for (int i = 0; i < Passagens.Count; i++)
            {
                var item = Passagens[i];

                if (item.Cliente.Nome == identificacao || item.Cliente.Cpf == identificacao)
                {
                    item.Cliente.Nome = nome;
                    item.Cliente.Idade = idade;
                    item.Cliente.Cpf = cpf;
                    item.Destino = destino;
                    item.HorarioPartida = horarioPartida;
                    item.HorarioChegada = horarioChegada;
                    item.Poltrona = poltrona;
                    item.FormaPagamento = formaPagamento;
                    item.Valor = valor;

                    encontrou = true;
                }
            }
            if (!encontrou)
            {
                Console.WriteLine("Não Existe");
            }
        }
    }
}
