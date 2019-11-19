using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankamatik
{
    public class DataAccessLayer
    {
        SqlConnection connect;
        SqlCommand command;
        SqlDataReader reader;
        int sonuc = 0;

        public DataAccessLayer()
        {
            connect = new SqlConnection();
            connect.ConnectionString = ConfigurationManager.ConnectionStrings["SQL"].ConnectionString;
        }

        public void BaglantiAyarla()
        {
            if (connect.State == ConnectionState.Closed)
                connect.Open();
            else
                connect.Close();
        }

        public int Kullanici_Kontrol(Musteri M)
        {
            try
            {
                command = new SqlCommand("Sp_Kullanici_Kontrol", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@TC", SqlDbType.NVarChar).Value = M.TC;
                command.Parameters.Add("@Sifre", SqlDbType.NVarChar).Value = M.Sifre;
                BaglantiAyarla();
                sonuc = (int)command.ExecuteScalar();
            }
            catch (Exception)
            {


            }
            finally
            {
                BaglantiAyarla();
            }
            return sonuc;
        }

        public SqlDataReader Musteri_Bilgileri(string TC)
        {
            command = new SqlCommand("Sp_Musteri_Bilgileri_Getir", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@TC", SqlDbType.NVarChar).Value = TC;
            BaglantiAyarla();
            return command.ExecuteReader();
        }

        public int Para_Cekim(string TC, double para)
        {
            try
            {
                command = new SqlCommand("Sp_Para_Cekim", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@TC", SqlDbType.NVarChar).Value = TC;
                command.Parameters.Add("@CekilenPara", SqlDbType.Float).Value = para;
                BaglantiAyarla();
                return command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                
            }
            finally
            {
                BaglantiAyarla();
            }
            return command.ExecuteNonQuery();

        }
        public int IBAN_ARA(string IBAN)
        {
            try
            {
                command = new SqlCommand("SP_IBAN_ARA", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@IBAN_NO", SqlDbType.NVarChar).Value = IBAN;
                BaglantiAyarla();

                return (int)command.ExecuteScalar();
            }

            catch (Exception)
            {


            }
            finally
            {
                BaglantiAyarla();
            }
            return -1;
        }
        public int IBAN_YATIR(string IBAN, float para)
        {
            command = new SqlCommand("SP_PARA_TRANSFER_IBAN", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@IBAN_NO ", SqlDbType.NVarChar).Value = IBAN;
            command.Parameters.Add("@Para", SqlDbType.Float).Value = para;
            BaglantiAyarla();

            return command.ExecuteNonQuery();
        }



        public int HESAP_ARA(string HESAP)
        {
            try
            {
                command = new SqlCommand("SP_HESAP_ARA", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@HESAP_NO", SqlDbType.NVarChar).Value = HESAP;
                BaglantiAyarla();

                return (int)command.ExecuteScalar();
            }

            catch (Exception)
            {


            }
            finally
            {
                BaglantiAyarla();
            }
            return -1;
        }
        public int HESAP_YATIR(string HESAP, float para)
        {
            command = new SqlCommand("SP_PARA_TRANSFER_HESAP", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@HESAP_NO ", SqlDbType.NVarChar).Value = HESAP.Trim();
            command.Parameters.Add("@Para", SqlDbType.Float).Value = para;
            BaglantiAyarla();

            return command.ExecuteNonQuery();
        }

        public int SIFRE_GUNCELLE(string TC, string Sifre)
        {
            command = new SqlCommand("Sp_Sifre_Guncelle", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@TC ", SqlDbType.NVarChar).Value = TC;
            command.Parameters.Add("@Sifre", SqlDbType.NVarChar).Value = Sifre;
            BaglantiAyarla();

            return command.ExecuteNonQuery();
        }
        public int MAIL_GUNCELLE(string TC, string Mail)
        {
            command = new SqlCommand("Sp_Mail_Guncelle", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@TC ", SqlDbType.NVarChar).Value = TC;
            command.Parameters.Add("@Mail", SqlDbType.NVarChar).Value = Mail;
            BaglantiAyarla();

            return command.ExecuteNonQuery();
        }
        public int TELEFON_GUNCELLE(string TC, string Telefon)
        {
            command = new SqlCommand("Sp_Telefon_Guncelle", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@TC ", SqlDbType.NVarChar).Value = TC;
            command.Parameters.Add("@Telefon", SqlDbType.NVarChar).Value = Telefon.Trim();
            BaglantiAyarla();

            return command.ExecuteNonQuery();
        }
        public int MUSTERI_EKLE(string TC,string Isim,string Soyisim,string Telefon,string Email, string Adres, string Sifre, double Bakiye, string HesapNo, string IBAN)
        {
            command = new SqlCommand("Sp_Musteri_Ekle", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@TC ", SqlDbType.NVarChar).Value = TC;
            command.Parameters.Add("@Isim", SqlDbType.NVarChar).Value = Isim;
            command.Parameters.Add("@Soyisim ", SqlDbType.NVarChar).Value = Soyisim;
            command.Parameters.Add("@Telefon", SqlDbType.NVarChar).Value = Telefon;
            command.Parameters.Add("@Email ", SqlDbType.NVarChar).Value = Email;
            command.Parameters.Add("@Adres", SqlDbType.NVarChar).Value = Adres;
            command.Parameters.Add("@Sifre ", SqlDbType.NVarChar).Value = Sifre;
            command.Parameters.Add("@Bakiye", SqlDbType.Float).Value = Bakiye;
            command.Parameters.Add("@HesapNo ", SqlDbType.NVarChar).Value = HesapNo;
            command.Parameters.Add("@IBAN", SqlDbType.NVarChar).Value = IBAN;
            BaglantiAyarla();

            return command.ExecuteNonQuery();
        }
    }
}
