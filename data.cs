using System;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Data;
using System.IO;
namespace bookLibrary
{
    

    internal class data
    {

        // public static string _server = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=libSysDB.mdb";
         public static string _server = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\OneDrive\Desktop\myProject\bin\Debug\source\libSysDB.mdf;Integrated Security=True;Connect Timeout=30";

        public static string _report = @"REPORT\";
       
        // retunrn data table
        public static DataTable GetDataTable(String query)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection conn = new SqlConnection(_server);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, " - Error - getDataTable"); }
            return dt;
        }
        // execute db query
        public bool cmd(String cmdType, String query, String location, bool msg)
        {
            bool res = false;
            try
            {
                SqlConnection conn = new SqlConnection(data._server);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                if(msg)
                    MessageBox.Show("Data Saved...");
                res = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), $"Error - Save Data - {cmdType} - {location}");
            }
            return res;
        }
        public bool chekLogin(String uN, String p)
        {
           
            bool result = false;
            String query = $"SELECT * FROM tbUser WHERE userName = '{uN}'";
            try
            {
                SqlConnection conn = new SqlConnection(_server);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows) 
                {
                    while (reader.Read())
                    {
                        String pass = Decode(reader[2].ToString());
                        if (p == pass) { conn.Close(); return true; }
                        else { MessageBox.Show("Incorrect Password..."); conn.Close(); return false; }
                    }
                }
                else { MessageBox.Show("No User Found"); conn.Close(); return false; }
                conn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Check User"); }
            return result;
        }
        public void myWeb()
        {
            
        }

        public static string Encode(String password)
        {
            try
            {
                byte[] encData = new byte[password.Length];
                encData = Encoding.UTF8.GetBytes(password);
                String encDataString = Convert.ToBase64String(encData);
                return encDataString;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return null;
        }
        public static string Decode(String encData)
        {
            UTF8Encoding encoder = new UTF8Encoding();
            Decoder Decode = encoder.GetDecoder();
            byte[] todecodeByte = Convert.FromBase64String(encData);
            int charCount = Decode.GetCharCount(todecodeByte, 0, todecodeByte.Length);
            char[] decodeChar = new char[charCount];
            Decode.GetChars(todecodeByte, 0, todecodeByte.Length, decodeChar, 0);
            String result = new string(decodeChar);
            return result;
        }
        public void addItemsCombobox(ComboBox cb, String tbName, String fieldName)
        {
            try
            {
                SqlConnection conn = new SqlConnection(_server);
                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT {fieldName} FROM {tbName};", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cb.Items.Add(reader[0].ToString());
                }
                conn.Close();
            }
            catch (Exception ex){
                cb.Items.Clear();
                cb.Items.Add("-- Error --");
            }
        }

    }
}
