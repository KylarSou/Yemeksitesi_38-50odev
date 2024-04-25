using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AspNetYemekTarifiSitesi
{
    public class sqlsinif
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=emir\SQLEXPRESS;Initial Catalog=Dbo_yemektarifi;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}