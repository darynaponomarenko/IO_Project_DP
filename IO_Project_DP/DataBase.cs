using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace IO_Project_DP
{
    public class DataBase
    {
        private static int userID;

        public DataBase()
        {
        }
        public static bool CheckPassword(string userName, string password)
        {
            bool returnValue = false;
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J7CUSB6\SQLEXPRESS;Initial Catalog=LoginDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand($"SELECT UserID FROM[LoginDB].[dbo].[tblUser] WHERE UserName = '{userName}' and Password = '{password}'", con);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                userID = Convert.ToInt32(reader.GetValue(0));
                returnValue = true;
            }
            else
            {
                returnValue = false;
            }
            reader.Close();
            cmd.Dispose();
            con.Close();
            return returnValue;
        }
        public void ConectAndShowFlights()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J7CUSB6\SQLEXPRESS;Initial Catalog=LoginDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand($"SELECT * FROM [LoginDB].[dbo].[tblFLIGHT] WHERE [Userid]={userID}", con);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var newFlight = new Flight(
                    Convert.ToInt32(reader.GetValue(0)),
                    Convert.ToInt32(reader.GetValue(1)),
                    reader.GetValue(2).ToString(),
                    reader.GetValue(3).ToString(),
                    reader.GetValue(4).ToString(),
                    reader.GetValue(5).ToString(),
                    Convert.ToDateTime(reader.GetValue(6)),
                    reader.GetValue(7).ToString(),
                    reader.GetValue(8).ToString());
                Flight.flightList.Add(newFlight);
            }

            reader.Close();
            cmd.Dispose();
            con.Close();
        }
        public void InsertNewFlight(string name, string surname, string from, string to, DateTime date, string seat, string clas)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J7CUSB6\SQLEXPRESS;Initial Catalog=LoginDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand($"INSERT INTO [dbo].[tblFLIGHT]([Userid],[name],[surname],[from],[to],[date],[seat],[clas])VALUES ({userID},'{name}', '{surname}', '{from}', '{to}', '{date}','{seat}', '{clas}');", con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void UpdateFlight(int id, string name, string surname, string from, string to, DateTime date, string seat, string clas)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J7CUSB6\SQLEXPRESS;Initial Catalog=LoginDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand($"UPDATE[dbo].[tblFLIGHT]SET [name]='{name}',[surname]='{surname}',[from]='{from}',[to]='{to}',[date]='{date}',[seat]='{seat}',[clas]='{clas}' WHERE[id]={id}", con);
            con.Open();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void DEleteFlight(int id)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J7CUSB6\SQLEXPRESS;Initial Catalog=LoginDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand($"DELETE FROM [dbo].[tblFLIGHT] WHERE [id] = {id}", con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
    }
}
