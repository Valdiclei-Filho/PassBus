﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passagem
{
    public class PassagemOnibus
    {
        public Guid Id { get; set; }
        public double Valor { get; set; }
        public string Destino { get; set; }
        public DateTime HorarioPartida { get; set; }
        public DateTime HorarioChegada { get; set; }
        public string FormaPagamento { get; set; }
        public string Poltrona { get; set; }
        public Cliente Cliente { get; set; }

        public PassagemOnibus(double valor, string destino, DateTime horarioPartida, DateTime horarioChegada, string formaPagamento, string poltrona, Cliente cliente)
        {
            Id = Guid.NewGuid();
            Valor = valor;
            Destino = destino;
            HorarioPartida = horarioPartida;
            HorarioChegada = horarioChegada;
            FormaPagamento = formaPagamento;
            Poltrona = poltrona;
            Cliente = cliente;
        }
    }
}
