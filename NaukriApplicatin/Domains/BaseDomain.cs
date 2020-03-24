using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaukriApplicatin.Domains
{
    public abstract class BaseDomain
    {
        public BaseDomain()
        {
            this.SqlConnection = new SqlConnection("Data Source=Parth\\SQLEXPRESS;Initial Catalog=NaukriAppDb;Integrated Security=True");
            this.SqlConnection.Open();
        }

        public SqlDataReader GetReader(string commandText)
        {
            this.SqlCommand = new SqlCommand(commandText, this.SqlConnection);
            return this.SqlCommand.ExecuteReader();
        }

        public void ExecuteNonQuery(string commandText)
        {
            this.SqlCommand = new SqlCommand(commandText, this.SqlConnection);
            this.SqlCommand.ExecuteNonQuery();
        }

        public void CloseConnection()
        {
            this.SqlConnection.Close();
        }

        protected SqlCommand SqlCommand { get; set; }
        private SqlConnection SqlConnection { get; set; }

    }
}
