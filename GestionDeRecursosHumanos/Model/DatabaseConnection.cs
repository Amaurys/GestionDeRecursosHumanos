using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace GestionDeRecursosHumanos.Model
{
    class DatabaseConnection
    {
        /*static void Main(string[] args) {
            using (SqlConnection conn = new SqlConnection())
            {
                try
                {
                    conn.ConnectionString = "Server=28FZCH2;Database=recursosHumanos;Trusted_Connection=true";
                    conn.Open();

                   SqlCommand comand = new SqlCommand("select * from idiomas", conn);

                    using (SqlDataReader reader = comand.ExecuteReader())
                    {
                        Console.WriteLine("id\t name\t description\t");
                        while (reader.Read())
                        {
                            Console.WriteLine(String.Format("{0} \t | {1} \t | {2}",
                                reader[0], reader[1], reader[2]));
                        }
                        Console.ReadLine();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }             
            }
        }*/

        public void connect() {
            
           /* using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Server=28FZCH2;Database=recursosHumanos;Trusted_Connection=true";
                conn.Open();

                /*SqlCommand comand = new SqlCommand("select * from idiomas", conn);

                using (SqlDataReader reader = comand.ExecuteReader())
                {
                    Console.WriteLine("id\t name\t description\t");
                    while (reader.Read())
                    {
                        Console.WriteLine(String.Format("{0} \t | {1} \t | {2}",
                            reader[0], reader[1], reader[2]));
                    }
                }*/

            }
        }
        }
    

