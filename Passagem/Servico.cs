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

        public void Deletar(TipoIdentificacao identificacao)
        {
            for (int i = 0; i < Passagens.Count; i++)
            {
                var item = Passagens[i];

                switch (identificacao) 
                {
                    case TipoIdentificacao.Nome:
                        Passagens.Remove(item);
                    break;

                    case TipoIdentificacao.Cpf:
                        Passagens.Remove(item);
                    break;
                }
            }
        }

        public void Apresentar(TipoIdentificacao identificacao)
        {
            bool encontrou = false;

            foreach (var item in Passagens)
            {
                switch (identificacao)
                {
                    case TipoIdentificacao.Nome:

                        Console.WriteLine(item.Cliente.Nome);
                        Console.WriteLine(item.Cliente.Idade);
                        Console.WriteLine(item.Cliente.Cpf);
                        Console.WriteLine(item.Poltrona);
                        Console.WriteLine(item.HorarioPartida);
                        Console.WriteLine(item.HorarioChegada);
                        Console.WriteLine(item.FormaPagamento);
                        Console.WriteLine(item.Valor);

                        encontrou = true;
                    break;

                    case TipoIdentificacao.Cpf:

                        Console.WriteLine(item.Cliente.Nome);
                        Console.WriteLine(item.Cliente.Idade);
                        Console.WriteLine(item.Cliente.Cpf);
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

        public void Alterar(TipoIdentificacao identificacao, string nome, int idade, string cpf, double valor, DateTime horarioPartida,
                            DateTime horarioChegada, string formaPagamento, string poltrona)
        {
            bool encontrou = false;

            for (int i = 0; i < Passagens.Count; i++)
            {
                var item = Passagens[i];

                switch (identificacao)
                {
                    case TipoIdentificacao.Nome:

                        item.Cliente.Nome = nome;
                        item.Cliente.Idade = idade;
                        item.Cliente.Cpf = cpf;
                        item.HorarioPartida = horarioPartida;
                        item.HorarioChegada = horarioChegada;
                        item.Poltrona = poltrona;
                        item.FormaPagamento = formaPagamento;
                        item.Valor = valor;

                        encontrou = true;
                    break;

                    case TipoIdentificacao.Cpf:

                        item.Cliente.Nome = nome;
                        item.Cliente.Idade = idade;
                        item.Cliente.Cpf = cpf;
                        item.HorarioPartida = horarioPartida;
                        item.HorarioChegada = horarioChegada;
                        item.Poltrona = poltrona;
                        item.FormaPagamento = formaPagamento;
                        item.Valor = valor;

                        encontrou = true;
                    break;
                }
            }
            if (!encontrou)
            {
                Console.WriteLine("Não Existe");
            }
        }
    }
}
