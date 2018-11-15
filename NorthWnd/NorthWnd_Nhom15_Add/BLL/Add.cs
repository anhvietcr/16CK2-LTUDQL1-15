using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace NorthWnd_Nhom15
{
    class BLLAdd
    {
        private DAL dataProvider;
        public BLLAdd()
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

        public int Add(List<string> data)
        {
            if (data.Count < 11) return 0;

            try
            {
                // prepare string Add
                string sqlAdd = "INSERT INTO Suppliers VALUES (@companyName,@contactName,@contactTitle,@address,@city,@region,@postalCode,@country,@phone,@fax,@homePage)";

                // prepare params
                string txtCompanyName = data[0];
                string txtContactName = data[1];
                string txtContactTitle = data[2];
                string txtAddress = data[3];
                string txtCity = data[4];
                string txtRegion = data[5];
                string txtPostalCode = data[6];
                string txtCountry = data[7];
                string txtPhone = data[8];
                string txtFax = data[9];
                string txtHomePage = data[10];

                int row = dataProvider.ExecuteNonQuery(CommandType.Text,
                    sqlAdd,
                    new SqlParameter { ParameterName = "@companyName", Value = txtCompanyName },
                    new SqlParameter { ParameterName = "@contactName", Value = txtContactName },
                    new SqlParameter { ParameterName = "@contactTitle", Value = txtContactTitle },
                    new SqlParameter { ParameterName = "@address", Value = txtAddress },
                    new SqlParameter { ParameterName = "@city", Value = txtCity },
                    new SqlParameter { ParameterName = "@region", Value = txtRegion },
                    new SqlParameter { ParameterName = "@postalCode", Value = txtPostalCode },
                    new SqlParameter { ParameterName = "@country", Value = txtCountry },
                    new SqlParameter { ParameterName = "@phone", Value = txtPhone },
                    new SqlParameter { ParameterName = "@fax", Value = txtFax },
                    new SqlParameter { ParameterName = "@homePage", Value = txtHomePage }
                    );
                return row;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}