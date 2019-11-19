using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankamatik
{
    public class BusinessLogicLayer
    {
        DataAccessLayer dl;
        SqlDataReader reader;

        public string TC;

        public BusinessLogicLayer()
        {
            dl = new DataAccessLayer();
        }

        public int Kullanici_Giris(string TC,string Sifre)
        {
            if (!string.IsNullOrEmpty(TC) && !string.IsNullOrEmpty(Sifre))
            {
                Musteri musteri = new Musteri();
                musteri.TC = TC;
                musteri.Sifre = Sifre;
                return dl.Kullanici_Kontrol(musteri);
            }
            else
            {
                return 0;
            }
        }


        internal Musteri Musteri_KayitGetir(string TC)
        {
            Musteri M= new Musteri();
            try
            {
                reader = dl.Musteri_Bilgileri(TC);
                while (reader.Read())
                {

                   // string t  =reader.GetString(0);
                    M.TC = reader["TC"].ToString();
                    M.Sifre = reader["Sifre"].ToString();
                    M.Isim = reader["Isim"].ToString();
                    M.Soyisim = reader["Soyisim"].ToString();
                    M.Telefon = reader["Telefon"].ToString();
                    M.Email = reader["Email"].ToString();
                    M.Adres = reader["Adres"].ToString();
                    M.Bakiye = reader["Bakiye"].ToString();
                    M.HesapNo = reader["HesapNo"].ToString();
                    M.IBAN = reader["IBAN"].ToString();


                }
                reader.Close();
            }
            catch (Exception)
            {
                
            }
            finally
            {
                dl.BaglantiAyarla();
            }
            return M;

        }

        public int Para_Cekim(string TC, double para)
        {
            if (!string.IsNullOrEmpty(TC) && para>0)
            {
                return dl.Para_Cekim(TC,para);
            }
            return -1;
           
        }

        public int IBAN_ARA(string IBAN)
        {
            if (!string.IsNullOrEmpty(IBAN))
            {
                return dl.IBAN_ARA(IBAN);
            }
            else
            {
                return -1;
            }
           
        }
        public int IBAN_YATIR(string IBAN,float para)
        {
            if (!string.IsNullOrEmpty(IBAN) && para > 0 )
            {
                return dl.IBAN_YATIR(IBAN,para);
            }
            else
            {
                return -1;
            }
            
            
        }



        public int HESAP_ARA(string HESAP)
        {
            if (!string.IsNullOrEmpty(HESAP))
            {
                return dl.HESAP_ARA(HESAP);
            }
            else
            {
                return -1;
            }

        }
        public int HESAP_YATIR(string HESAP, float para)
        {
            if (!string.IsNullOrEmpty(HESAP) && para > 0)
            {
                return dl.HESAP_YATIR(HESAP, para);
            }
            else
            {
                return -1;
            }


        }
        public int Sifre_Guncelle(string TC,string Sifre)
        {
            if (!string.IsNullOrEmpty(TC) && !string.IsNullOrEmpty(Sifre))
            {
                return dl.SIFRE_GUNCELLE(TC, Sifre);
            }
            else
            {
                return -1;
            }

        }
        public int Mail_Guncelle(string TC, string Mail)
        {
            if (!string.IsNullOrEmpty(TC) && !string.IsNullOrEmpty(Mail))
            {
                return dl.MAIL_GUNCELLE(TC, Mail);
            }
            else
            {
                return -1;
            }

        }
        public int TELEFON_Guncelle(string TC, string TELEFON)
        {
            if (!string.IsNullOrEmpty(TC) && !string.IsNullOrEmpty(TELEFON))
            {
                return dl.TELEFON_GUNCELLE(TC, TELEFON);
            }
            else
            {
                return -1;
            }

        }
        public int Musteri_Ekle(string TC, string Isim, string Soyisim, string Telefon, string Email, string Adres, string Sifre, double Bakiye, string HesapNo, string IBAN)
        {
            if (!string.IsNullOrEmpty(TC) && !string.IsNullOrEmpty(Isim))
            {
                return dl.MUSTERI_EKLE( TC,  Isim,  Soyisim,  Telefon,  Email,  Adres,  Sifre,  Bakiye,  HesapNo,  IBAN);
            }
            else
            {
                return -1;
            }

        }






    }
}
