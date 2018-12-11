using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Игра_ЗС
{
    class SingleTon
    {
        private static SingleTon instance;
        public Players Players { get; private set; }

        protected SingleTon(Players players)
        {
            this.Players = players;
        }

        public static SingleTon getInstanse(Players players)
        {
            if (instance == null)
            {
                instance = new SingleTon(players);
                instance.AddBD();
            }

            return instance;
        }

        public void AddBD()
        {
            string connection =
                @"Data Source=DENISPANFILOV;Initial Catalog=Game;Integrated Security=True";
            var sqlExp = "sp_GetUsers";
            var sqlExp1 = "sp_GetUsers1";
            var sqlExp2 = "sp_UpdateUsers";
            var sqlExp3 = "sp_InsertUsers";

            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                for (int i = 0; i < Players.Length(); i++)
                {
                    SqlCommand command = new SqlCommand(sqlExp, con) { CommandType = CommandType.StoredProcedure };
                    SqlParameter nameParameter = new SqlParameter
                    {
                        ParameterName = "@name",
                        Value = Players[i].Name
                    };
                    command.Parameters.Add(nameParameter);
                    SqlDataReader a = command.ExecuteReader();

                    if (a.HasRows)
                    {
                        a.Close();
                        SqlCommand command1 = new SqlCommand(sqlExp1, con) { CommandType = CommandType.StoredProcedure };
                        SqlParameter nameParameter1 = new SqlParameter
                        {
                            ParameterName = "@name",
                            Value = Players[i].Name
                        };
                        command1.Parameters.Add(nameParameter1);
                        var schet = Convert.ToInt32(command1.ExecuteScalar());
                        var sum = schet + Players[i].Sum;
                        SqlCommand command2 = new SqlCommand(sqlExp2, con) { CommandType = CommandType.StoredProcedure };
                        SqlParameter parameterSum = new SqlParameter
                        {
                            ParameterName = "@sum",
                            Value = sum
                        };
                        command2.Parameters.Add(parameterSum);
                        SqlParameter nameParameter2 = new SqlParameter
                        {
                            ParameterName = "@name",
                            Value = Players[i].Name
                        };
                        command2.Parameters.Add(nameParameter2);
                        command2.ExecuteNonQuery();
                    }
                    else
                    {
                        a.Close();
                        SqlCommand command1 = new SqlCommand(sqlExp3, con) { CommandType = CommandType.StoredProcedure };
                        SqlParameter nameParameter1 = new SqlParameter
                        {
                            ParameterName = "@name",
                            Value = Players[i].Name
                        };
                        command1.Parameters.Add(nameParameter1);
                        SqlParameter parameterSum = new SqlParameter
                        {
                            ParameterName = "@schet",
                            Value = Players[i].Sum
                        };
                        command1.Parameters.Add(parameterSum);
                        command1.ExecuteNonQuery();
                    }
                }
                con.Close();
            }


        }
    }
}
