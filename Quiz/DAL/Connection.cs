using System;
using System.IO;

namespace DAL
{
    public static class Connection
    {
        private static string connectionString;

        public static string ConnectionString
        {
            get
            {
                if (String.IsNullOrEmpty(connectionString))
                    if (File.Exists("C:\\Configuracoes\\quizConnection.config"))
                        connectionString = File.ReadAllText("C:\\Configuracoes\\quizConnection.config");
                    else throw new Exception("Você precisa criar a conexão com o banco de dados") { Data = { { "Id", 1 } } };

                return connectionString;
            }
        }

    }
}
