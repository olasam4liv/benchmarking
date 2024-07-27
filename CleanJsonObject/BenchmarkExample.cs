using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    using System;
using System.Data.SqlClient;


namespace CleanJsonObject
{
    [MemoryDiagnoser(false)]
    public class BenchmarkExample
    {
        [Benchmark]
        public int FindMaxNumberMethodOne()
        {
            var numbers = new int [1000];

            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = i;

            var maxNumber = numbers.OrderByDescending(x => x).FirstOrDefault();

            return maxNumber;
        }
        [Benchmark]
        public int FindMaxNumberMethodTwo()
        {
            var numbers = new int[1000];

            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = i;

            var maxNumber = numbers.MaxBy(x => x);

            return maxNumber;
        }

        [Benchmark]
        public int FindMaxNumberMethodThree()
        {
            var numbers = new int[1000];

            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = i;

            var maxNumber = numbers.Max(x => x);

            return maxNumber;
        }







        public async Task HandleFileStream()
        {
            // Correct way to handle file streams
            using (FileStream fs = new FileStream("example.txt", FileMode.OpenOrCreate))
            {
                // Perform file operations
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    writer.WriteLine("Hello, world!");
                }
            } // FileStream and StreamWriter are automatically disposed of here
        }




        


    }
     

public class DatabaseExample
{
    public void FetchData()
    {
        string connectionString = "YourConnectionStringHere";
        
        // Using 'using' to ensure the connection is properly disposed of
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            
            string query = "SELECT * FROM YourTable";
            
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"Column1: {reader[0]}, Column2: {reader[1]}");
                    }
                }
            }
        } // SqlConnection, SqlCommand, and SqlDataReader are automatically disposed of here
    }
}


}
