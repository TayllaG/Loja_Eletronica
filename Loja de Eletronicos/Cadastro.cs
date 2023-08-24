﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_de_Eletronicos
{
    internal class Cadastro
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public string DataFabr { get; set; }
        public int Quantidade { get; set; }
        public Cadastro(int id, string nome, double valor, string dataFabr, int quantidade)
        {
            Id = id;
            Nome = nome;
            Valor = valor;
            DataFabr = dataFabr;
            Quantidade = quantidade;
        }
        public Cadastro()
        {

        }
    }
}
