using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcDB.Models;
using System.Data.SqlClient;
using System.Globalization;
using System.Data;

namespace CalcDB.Repositories
{
    public class OperResultRepository : BaseRepository<OperationResult>
    {
        public IList<OperationResult> GetByOperation(long Id)
        {
            return null;
        }
    }







    //private string connectionString 
    //    = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Калькулятор\Calc\CalcApplication\CalcDB\AppData\CalcDB.mdf;Integrated Security=True";
    //public void Delete(long id)
    //{
    //    string queryString =
    //           "DELETE FROM [dbo].[OperationResult]" +
    //           $"WHERE Id = {id};";
    //    using (SqlConnection connection = new SqlConnection(connectionString))
    //    {
    //        SqlCommand command = new SqlCommand(queryString, connection);
    //        connection.Open();

    //        SqlDataReader reader = command.ExecuteReader();
    //    }
    //}

    //public OperationResult Get(long id)
    //{

    //    string queryString =
    //        "SELECT Id, OperationId, Args, Result, Error, ExecutionTime, CreationDate " +
    //        "FROM [dbo].[OperationResult]" +
    //        $"WHERE Id = {id};";// +
    //                            //$"VALUES({opResult.OperationId}, N'{opResult.Args}', {opResult.Result}, N'{opResult.Error}', {opResult.ExecutionTime}, {opResult.CreationDate} ";

    //    OperationResult opResult = null; 

    //    using (SqlConnection connection =new SqlConnection(connectionString))
    //    {
    //        SqlCommand command = new SqlCommand(queryString, connection);
    //        connection.Open();

    //        SqlDataReader reader = command.ExecuteReader();


    //        try
    //        {
    //            // Call Read before accessing data.
    //            if (reader.Read())
    //            //while (reader.Read())
    //            {
    //                opResult = new OperationResult()
    //                {
    //                    OperationId = (long)reader[1],
    //                    Args = reader[2] as string,
    //                    Result = (double?)reader[3],
    //                    Error = reader[4] as string,
    //                    ExecutionTime = (long)reader[5],
    //                    CreationDate = (DateTime)reader[6]
    //                };
    //                //ReadSingleRow((IDataRecord)reader);
    //            }
    //        }
    //        finally
    //        {
    //            // Call Close when done reading.
    //            reader.Close();
    //        }
    //    }

    //    return opResult;
    //}

    //public IList<OperationResult> GetAll()
    //{

    //    string queryString =
    //        "SELECT Id, OperationId, Args, Result, Error, ExecutionTime, CreationDate " +
    //        "FROM [dbo].[OperationResult]";

    //    IList<OperationResult> listOpResult = new List<OperationResult>();

    //    using (SqlConnection connection = new SqlConnection(connectionString))
    //    {
    //        SqlCommand command =
    //            new SqlCommand(queryString, connection);
    //        connection.Open();

    //        SqlDataReader reader = command.ExecuteReader();


    //        try
    //        {
    //            // Call Read before accessing data.
    //            while (reader.Read())
    //            {
    //                OperationResult opResult = new OperationResult()
    //                {
    //                    OperationId = (long)reader[1],
    //                    Args = reader[2] as string,
    //                    Result = (double?)reader[3],
    //                    Error = reader[4] as string,
    //                    ExecutionTime = (long)reader[5],
    //                    CreationDate = (DateTime)reader[6]
    //                };
    //                listOpResult.Add(opResult);
    //            }
    //        }
    //        finally
    //        {
    //            // Call Close when done reading.
    //            reader.Close();
    //        }
    //    }

    //    return listOpResult;


    //    throw new NotImplementedException();
    //    //Маппер
    //}

    //public IList<OperationResult> GetByOperation(long id)
    //{
    //    string queryString =
    //        "SELECT Id, OperationId, Args, Result, Error, ExecutionTime, CreationDate " +
    //        "FROM [dbo].[OperationResult]" +
    //        $"WHERE OperationId = {id};";// +

    //    IList<OperationResult> listOpResult = new List<OperationResult>(); 

    //    using (SqlConnection connection = new SqlConnection(connectionString))
    //    {
    //        SqlCommand command =
    //            new SqlCommand(queryString, connection);
    //        connection.Open();

    //        SqlDataReader reader = command.ExecuteReader();


    //        try
    //        {
    //            // Call Read before accessing data.
    //            while (reader.Read())
    //            {
    //                OperationResult opResult = new OperationResult()
    //                {
    //                    OperationId = (long)reader[1],
    //                    Args = reader[2] as string,
    //                    Result = (double?)reader[3],
    //                    Error = reader[4] as string,
    //                    ExecutionTime = (long)reader[5],
    //                    CreationDate = (DateTime)reader[6]
    //                };
    //                listOpResult.Add(opResult);
    //            }
    //        }
    //        finally
    //        {
    //            // Call Close when done reading.
    //            reader.Close();
    //        }
    //    }

    //    return listOpResult;
    //}

    //public void Save(OperationResult result)
    //{
    //    string queryString =
    //        "INSERT INTO [dbo].[OperationResult] " +
    //        "(OperationId, [Args], [Result], [Error], [ExecutionTime], [CreationDate]) " +
    //        $"VALUES({result.OperationId}, N'{result.Args}', {result.Result?.ToString(CultureInfo.InvariantCulture)}, N'{result.Error}', {result.ExecutionTime}, GETDATE()); ";

    //    using (var connection = new SqlConnection(connectionString))
    //    {
    //        var command = new SqlCommand(queryString, connection);
    //        connection.Open();

    //        var count = command.ExecuteNonQuery();
    //    }
    //}
}

