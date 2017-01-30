using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCADONETSample1.Models;
using System.Data.SqlClient;

namespace MVCADONETSample1.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DoSearchAdd(CustomerModel c, string command)
        {
            SqlConnection cn = new SqlConnection("user id=sa; password=sa; database=MVC; data source=NURUL-PC\\SQLEXPRESS");

            SqlCommand cmd = new SqlCommand();

            switch(command)
            {
                case "Save":
                    cmd.CommandText = "INSERT INTO CUSTOMER VALUES(@ACCNO, @NAME, @BAL)";
                    cmd.Connection = cn;

                    cmd.Parameters.AddWithValue("@ACCNO", c.AcctNo);
                    cmd.Parameters.AddWithValue("@NAME", c.AcctHolderName);
                    cmd.Parameters.AddWithValue("@BAL", c.AcctBalance);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    ViewBag.Message = "Customer Info Saved";
                    break;
                case "Search":
                    cmd.CommandText = "SELECT * FROM CUSTOMER WHERE ACCTNO=@ACTNO";
                    cmd.Connection = cn;

                    cmd.Parameters.AddWithValue("@ACTNO", c.AcctNo);
                    cn.Open();

                    SqlDataReader dr = cmd.ExecuteReader();

                    if(dr.Read())
                    { //Account numbe found
                        ViewBag.AcctNo = dr["AcctNo"].ToString();
                        ViewBag.AcctHolderName = dr["AcctHolderName"].ToString();
                        ViewBag.AcctBalance = dr["AcctBal"].ToString();

                    }
                    else
                    {//Account Number Not Found
                        ViewBag.Message = "Account Number Not Found";
                    }
                    break;
            }
            return View("Index");

           
        }

        public ActionResult Index1()
        {
            return View();
        }

        public ActionResult DoSearchAdds(CustomerModel c, string command)
        {
            SqlConnection cn = new SqlConnection("user id=sa; password=sa; database=MVC; data source=NURUL-PC\\SQLEXPRESS");

            SqlCommand cmd = new SqlCommand();

            switch (command)
            {
                case "Save":
                    cmd.CommandText = "INSERT INTO CUSTOMER VALUES(@ACCNO, @NAME, @BAL)";
                    cmd.Connection = cn;

                    cmd.Parameters.AddWithValue("@ACCNO", c.AcctNo);
                    cmd.Parameters.AddWithValue("@NAME", c.AcctHolderName);
                    cmd.Parameters.AddWithValue("@BAL", c.AcctBalance);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    ViewBag.Message = "Customer Info Saved";
                    break;
                case "Search":
                    cmd.CommandText = "SELECT * FROM CUSTOMER WHERE ACCTNO=@ACTNO";
                    cmd.Connection = cn;

                    cmd.Parameters.AddWithValue("@ACTNO", c.AcctNo);
                    cn.Open();

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    { //Account numbe found

                        c.AcctNo = (int) dr["AcctNo"];
                        c.AcctHolderName = dr["AcctHolderName"].ToString();
                        c.AcctBalance = (int) dr["AcctBal"];

                    }
                    else
                    {//Account Number Not Found
                        ViewBag.Message = "Account Number Not Found";
                    }
                    break;
            }
            return View("Index1",c);


        }

    }
}