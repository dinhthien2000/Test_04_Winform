using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_04.Entities;

namespace Test_04.DAO
{
    public class KhachHangDAO
    {
        public static string SELECT = "Select * from SL_tblCustomerList";
        public static string CREATE = "insert into SL_tblCustomerList(CustomerID ,CustomerName ,TaxCode ,IsCustomer ,IsVendor ,IsPersonal ,Mobile ,Email ,Address ,ContactPerson ,DebtLimit ,NumberDayLimit) " +
                                        "values (@CustomerID, @CustomerName, @TaxCode, @IsCustomer, @IsVendor, @IsPersonal, @Mobile, @Email, @Address, @ContactPerson, @DebtLimit, @NumberDayLimit)";
        public static string UPDATE = "update SL_tblCustomerList " +
                                        "set CustomerName = @CustomerName,TaxCode =@TaxCode, IsCustomer = @IsCustomer, " +
                                            "IsVendor = @IsVendor, IsPersonal = @IsPersonal, Mobile = @Mobile, Email = @Email ,Address = @Address, " +
                                            "ContactPerson = @ContactPerson, DebtLimit = @DebtLimit, NumberDayLimit =@NumberDayLimit where CustomerID =@CustomerID";
        public static string DELETE = "delete from SL_tblCustomerList where CustomerID =@CustomerID";

        SqlConnection conn;

        public KhachHangDAO()
        {
            conn = Connect.Connect.getConnection();
        }

        public List<KhachHang> getAll()
        {
            List<KhachHang> list = new List<KhachHang>();
            KhachHang kh = null;
            try
            {
                conn.Open();

                Debug.WriteLine("Connected successful");

                SqlCommand command = new SqlCommand(SELECT, conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        kh = new KhachHang(
                            reader.GetString("CustomerID"),
                            reader.GetString("CustomerName"),
                            reader.GetString("TaxCode"),
                            reader.GetBoolean("IsCustomer"),
                            reader.GetBoolean("IsVendor"),
                            reader.GetBoolean("IsPersonal"),
                            reader.GetString("Mobile"),
                            reader.GetString("Email"),
                            reader.GetString("Address"),
                            reader.GetString("ContactPerson"),
                            reader.GetDecimal("DebtLimit"),
                            reader.GetInt32("NumberDayLimit")
                            );

                        list.Add(kh);
                    }
                }


            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return list;
        }

        public KhachHang create(KhachHang kh)
        {
            KhachHang recieve = null;
            try
            {
                conn.Open();

                Debug.WriteLine("Connected successful");

                SqlCommand command = new SqlCommand(CREATE, conn);

                command.Parameters.AddWithValue("CustomerID", kh.CustomerID);
                command.Parameters.AddWithValue("CustomerName", kh.CustomerName);
                command.Parameters.AddWithValue("TaxCode", kh.TaxCode);
                command.Parameters.AddWithValue("IsCustomer", kh.IsCustomer);
                command.Parameters.AddWithValue("IsVendor", kh.IsVendor);
                command.Parameters.AddWithValue("IsPersonal", kh.IsPersonal);
                command.Parameters.AddWithValue("Mobile", kh.Mobile);
                command.Parameters.AddWithValue("Email", kh.Email);
                command.Parameters.AddWithValue("Address", kh.Address);
                command.Parameters.AddWithValue("ContactPerson", kh.ContactPerson);
                command.Parameters.AddWithValue("DebtLimit", kh.DebtLimit);
                command.Parameters.AddWithValue("NumberDayLimit", kh.NumberDayLimit);


                SqlDataReader reader = command.ExecuteReader();


                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        recieve = new KhachHang(
                            reader.GetString("CustomerID"),
                            reader.GetString("CustomerName"),
                            reader.GetString("TaxCode"),
                            reader.GetBoolean("IsCustomer"),
                            reader.GetBoolean("IsVendor"),
                            reader.GetBoolean("IsPersonal"),
                            reader.GetString("Mobile"),
                            reader.GetString("Email"),
                            reader.GetString("Address"),
                            reader.GetString("ContactPerson"),
                            reader.GetDecimal("DebtLimit"),
                            reader.GetInt32("NumberDayLimit")
                            );


                    }
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return recieve;
        }


        public KhachHang update(KhachHang kh)
        {
            KhachHang recieve = null;
            try
            {
                conn.Open();

                Debug.WriteLine("Connected successful");

                SqlCommand command = new SqlCommand(UPDATE, conn);

                command.Parameters.AddWithValue("CustomerID", kh.CustomerID);
                command.Parameters.AddWithValue("CustomerName", kh.CustomerName);
                command.Parameters.AddWithValue("TaxCode", kh.TaxCode);
                command.Parameters.AddWithValue("IsCustomer", kh.IsCustomer);
                command.Parameters.AddWithValue("IsVendor", kh.IsVendor);
                command.Parameters.AddWithValue("IsPersonal", kh.IsPersonal);
                command.Parameters.AddWithValue("Mobile", kh.Mobile);
                command.Parameters.AddWithValue("Email", kh.Email);
                command.Parameters.AddWithValue("Address", kh.Address);
                command.Parameters.AddWithValue("ContactPerson", kh.ContactPerson);
                command.Parameters.AddWithValue("DebtLimit", kh.DebtLimit);
                command.Parameters.AddWithValue("NumberDayLimit", kh.NumberDayLimit);

                int reader = command.ExecuteNonQuery();

                if (reader != 0)
                {

                    recieve = kh;
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return recieve;
        }

        public int deleteByCustomerID(string customerID)
        {
            int result = 0;
            try
            {
                conn.Open();

                Debug.WriteLine("Connected successful");

                SqlCommand command = new SqlCommand(DELETE, conn);

                command.Parameters.AddWithValue("CustomerID", customerID);


                int reader = command.ExecuteNonQuery();

                if (reader != 0)
                {

                    result = reader;
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
    }
}
