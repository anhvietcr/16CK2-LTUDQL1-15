using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTUDQL1_DULIEU
{
    public class DAO_KhachHang
    {
        public DataTable LayDSKhachHang()
        {
            //Tạo kết nối
            SqlConnection sqlConnection = DataProvider.ConnectDatabase();
            
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "Select * from Customers";
            sqlCommand.CommandType = CommandType.Text;

            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);

            DataProvider.CloseConnection(sqlConnection);

            return dataTable;

        }

        public void CapNhatBangKhachHang(DataTable dtKhachHang)
        {
            //Tạo kết nối
            SqlConnection sqlConnection = DataProvider.ConnectDatabase();

            String sqlQuery = "Select * from Customers";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery,sqlConnection);
            
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            //sqlDataAdapter.SelectCommand = sqlCommand;
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            // sqlDataAdapter = sqlCommandBuilder.DataAdapter;
            //DataTable dt = new DataTable();
            //sqlDataAdapter.Fill(dt);
            
            sqlDataAdapter.Update(dtKhachHang);

            DataProvider.CloseConnection(sqlConnection);
        }
        //public string 
    }
}
