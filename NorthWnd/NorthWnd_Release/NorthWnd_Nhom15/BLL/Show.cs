using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace NorthWnd_Nhom15
{
    class BLLShow
    {
        private DAL dataProvider;
        public BLLShow()
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
    }
}
