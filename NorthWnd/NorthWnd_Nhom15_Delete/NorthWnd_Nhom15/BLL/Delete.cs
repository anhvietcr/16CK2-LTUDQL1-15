using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace NorthWnd_Nhom15
{
    class BLLDelete
    {
        private DAL dataProvider;
        public BLLDelete()
        {
            dataProvider = new DAL();
            dataProvider.Connect();
        }

        //data table
        public DataTable getDataTable()
        {
            try
            {
                string sqlSelect = "SELECT * FROM Suppliers";
                DataTable dt = dataProvider.SelectAll(CommandType.Text, sqlSelect);

                dataProvider.DisConnected();
                return dt;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // check valid data and call DAL for update
        public int Delete(List<string> data)
        {
            if (data.Count < 11) return 0;

            try
            {
                string sqldropconstraint = "ALTER TABLE Products DROP CONSTRAINT FK_Products_Suppliers";
                int t = dataProvider.ExecuteNonQuery(CommandType.Text,sqldropconstraint);
                // prepare string delete
                string sqlDelete = "DELETE FROM Suppliers " +
                    "WHERE SupplierID = @id";

                // prepare params
                string txtID = data[0];
                

                int row = dataProvider.ExecuteNonQuery(CommandType.Text, 
                    sqlDelete, 
                    new SqlParameter { ParameterName = "@id", Value = txtID }
                    );
                string sqladdconstraint = "alter table dbo.Products WITH NOCHECK ADD constraint FK_Products_Suppliers foreign key(SupplierID) references dbo.Suppliers(SupplierID)";
                int tt = dataProvider.ExecuteNonQuery(CommandType.Text, sqladdconstraint);
                return row;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
