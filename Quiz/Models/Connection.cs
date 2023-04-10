﻿using System;
using System.IO;

namespace Models
{
    public static class Connection
    {
        private static string connectionString;

        public static string ConnectionString
        {
            get
            {
                if (String.IsNullOrEmpty(connectionString))
                    if (File.Exists("C:\\Configuracoes\\conexao.config"))
                        connectionString = File.ReadAllText("C:\\Configuracoes\\conexao.config");
                    else throw new Exception("Você precisa criar a conexão com o banco de dados") { Data = { { "Id", 1 } } };

                return connectionString;
            }
        }

    }
}
