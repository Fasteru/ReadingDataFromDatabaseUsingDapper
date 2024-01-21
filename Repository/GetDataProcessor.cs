using Dapper;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class GetDataProcessor : IGetData
    {
        private readonly IDbConnectionFactory _connectionFactory;

        public GetDataProcessor(IDbConnectionFactory dbConnectionFactory)
        {
                _connectionFactory = dbConnectionFactory;
        }
        public IEnumerable<PatientModel> GetData()
        {
            IEnumerable<PatientModel>? patients = null;

            var connection = _connectionFactory.GetConnection();
            patients = connection.Query<PatientModel>("Select * from Student_table");

            return patients;
        }
    }
}
