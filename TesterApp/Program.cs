using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Processor proc = new Processor();
            proc.RunLongThing();
            proc.RunShorterThingForLoops();
        }
    }
    public class Processor
    {
        private string _connectionString = "Data Source=(local);Initial Catalog=Database1;Integrated Security=True";
        public void RunLongThing()
        {

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("Procedure1", connection))
                {
                    cmd.CommandTimeout = 0;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void RunShorterThingForLoops()
        {
            int current = 0;
            bool flag = false;//flag this when complete from proc result
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("Procedure2", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter param = new SqlParameter()
                    {
                        ParameterName = "@current",
                        Value = 0,
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.InputOutput //in theory i would think this keeps @currentRow flowing out and in of the proc
                    };
                    SqlParameter returnval = new SqlParameter()
                    {
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.ReturnValue
                    };
                    cmd.Parameters.Add(param);
                    cmd.Parameters.Add(returnval);
                    while (!flag)
                    {
                        
                        cmd.ExecuteNonQuery();//have the proc RETURN something that can convert to bool (1/0) return 1 when it's the last row. yo know it's the last row because the batch was smaller than max batch size (all determined in the proc)
                        current = (int)param.Value;
                        flag = Convert.ToBoolean((int)returnval.Value);
                        Console.WriteLine($"flag: {flag} @current {current}");
                    }
                }
            }
        }
    }
}
