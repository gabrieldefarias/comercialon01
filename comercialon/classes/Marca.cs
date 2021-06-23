﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comercialon.classes
{
    public class Marca
    { // declaração de propriedades
        public int Id { get; set; }
        public String Nome { get; set; }
        public string Sigla { get; set; }

        //======================================================================================== // gerando os construtores
        public Marca()
        { }
        
        public Marca(int id, string nome, string sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }

        public Marca(string nome, string sigla)
        {
            Nome = nome;
            Sigla = sigla;
        }

        //======================================================================================== // métodos da classe
        public void Inserir() // INSERIR - INICIO
        {
            var cmd = Banco.Abrir();
            if (cmd.Connection.State == System.Data.ConnectionState.Open)
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "insert " +
                    "marcas(nome, sigla) " +
                    "values('"+Nome+"', '"+Sigla+"');";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "select @@identity";
                Id = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
    }
}
