using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace NorthWnd_Nhom15
{
    class BLLEdit
    {
        private DAL dataProvider;
        public BLLEdit()
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
        public int Edit(List<string> data)
        {
            if (data.Count < 11) return 0;

            try
            {
                // prepare string update
                string sqlUpdate = "UPDATE Suppliers " +
                    "SET CompanyName = @companyName, " +
                    "ContactName = @contactName, " +
                    "ContactTitle = @contactTitle, " +
                    "Address = @address, " +
                    "City = @city, " +
                    "Region = @region, " +
                    "PostalCode = @postalCode, " +
                    "Country = @country, " +
                    "Phone = @phone, " +
                    "Fax = @fax, " +
                    "HomePage = @homePage " +
                    "WHERE SupplierID = @id";

                // prepare params
                string txtID = data[0];
                string txtCompanyName = data[1];
                string txtContactName = data[2];
                string txtContactTitle = data[3];
                string txtAddress = data[4];
                string txtCity = data[5];
                string txtRegion = data[6];
                string txtPostalCode = data[7];
                string txtCountry = data[8];
                string txtPhone = data[9];
                string txtFax = data[10];
                string txtHomePage = data[11];

                int row = dataProvider.ExecuteNonQuery(CommandType.Text, 
                    sqlUpdate, 
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
                    new SqlParameter { ParameterName = "@homePage", Value = txtHomePage },
                    new SqlParameter { ParameterName = "@id", Value = txtID }
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
