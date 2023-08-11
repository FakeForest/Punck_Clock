﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;

namespace Combined
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static string messagein = "";
        public static string status = "";

        private void button1_Click(object sender, EventArgs e)
        {
            (this.Owner as Form1).btnin.Enabled = true;
            (this.Owner as Form1).btnout.Enabled = true;
            axOPOSMSR1.Close();
            this.Close();
        }

        private void axOPOSMSR1_DataEvent(object sender, AxOposMSR_CCO._IOPOSMSREvents_DataEventEvent e)
        {
            #region DataUpload
            string ConnectionString = "Server=192.168.1.190,1435;User ID=Office; Password=BCpr001!;Initial Catalog=multiline_db";

            SqlConnection con = new SqlConnection(ConnectionString);

            string t = dateTimePicker1.Value.ToString();

            string cardno = axOPOSMSR1.Track2Data;

            string i = "in";

            string o = "Did not Swipeout";

            string query1 = "select convert(varchar(100), CardNumber) from [dbo].[TableEmployee] where convert(varchar(100), CardNumber) = ('" + cardno + "')";

            string query2 = "select convert(varchar(100), Name) from [dbo].[TableEmployee] where convert(varchar(100), CardNumber) = ('" + cardno + "')";

            string query3 = "select convert(varchar(100), Time) from [dbo].[problem] where convert(varchar(100), CardNumber) = ('"+ cardno +"') and datediff(day, ('"+ t +"'), Time) != 0";

            string query4 = "select convert(varchar(100), Time) from [dbo].[problem] where convert(varchar(100), CardNumber) = ('"+ cardno +"') and datediff(day, ('"+ t +"'), Time) = 0";
            
            con.Open();
            //Check if cardnumber exist in the TableEmployee.
            SqlCommand cidcmd = new SqlCommand(query1, con);
            string cid = (string)cidcmd.ExecuteScalar();
            con.Close();


            if (cid == cardno)
            {
                con.Open();
                //if exist, check if there is any swipe in record in table problem with different date.
                SqlCommand cmd3 = new SqlCommand(query3, con);
                string res1 = (string)cmd3.ExecuteScalar();
                //check if there is ant swipe in record in table problem with same date. (Will use these to find multiple times swipe in on the same day.)
                SqlCommand cmd4 = new SqlCommand(query4, con);
                string res2 = (string)cmd4.ExecuteScalar();
                con.Close();

                if (res1 != null)
                {
                    MessageBox.Show("There's some day you did not swipe out but swipe in, \n Your clock out time will be set as your clock in time, \n please tell the manager to change your real clock out time!");
                    //send Email to punchcard@multilinefasteners.com
                    MailMessage mail = new MailMessage();
                    SmtpClient smtp = new SmtpClient("smtp.bellnet.ca");
                    mail.From = new MailAddress("donotreply@multilinefasteners.com");
                    mail.To.Add("punchcard@multilinefasteners.com");
                    mail.Subject = "Employee did not swipe out";
                    mail.Body = string.Format("Here is the info for employee NO.{0} who fogets to swipe out: Swipein Time: {1}", cardno, res1);
                    smtp.Port = 25;
                    smtp.EnableSsl = false;
                    smtp.Send(mail);
                    con.Open();
                    //After the email has sent, the record can be deleted.
                    SqlCommand delr = new SqlCommand("delete from problem where CardNumber = ('" + cardno + "') and datediff(day, Time, ('"+ t +"')) != 0", con);
                    delr.ExecuteNonQuery();
                    con.Close();
                }

                if (res2 == null)
                {
                    con.Open();
                    //if it is not multiple times swipe in, will inser the relative info into TimeReport
                    SqlCommand lidcmd = new SqlCommand(query2, con);
                    string lid = (string)lidcmd.ExecuteScalar();
                    SqlCommand ins = new SqlCommand("insert into TimeReport (CardNumber, Name, statusin, Timein, statusout, Timeout) values ('" + cardno + "', '" + lid + "', '" + i + "', '" + t + "', '" + o + "', '" + t + "')", con);
                    ins.ExecuteNonQuery();
                    //At the same time, also insert the record into table problelm.
                    SqlCommand insp = new SqlCommand("insert into problem (CardNumber, Name, Time, status) values ('" + cardno + "', '" + lid + "', '" + t + "', '" + i + "')", con);
                    insp.ExecuteNonQuery();
                    messagein = string.Format("Hello {0}! You are in! Info uploaded! \n Clock in time: {1} \n Please wait until this page disappears before continuing!", lid, t);
                    status = "update";
                    con.Close();
                }
                else if (res2.Substring(0, 11) == t.Substring(0, 11))
                {
                    //if multiple times swipe in found by several times swipe in in the same day in a row.
                    messagein = "You have alraedy swiped in today! \n Please wait until this page disappears before continuing!";
                    status = "update";
                }
            }
            else
            {
                //if the cardnumber does not exist in TableEmployee means it is a wrong card.
                messagein = "Wrong Card! Please try it again! \n Please wait until this page disappears before continuing!";
                status = "update";
            }
            #endregion
            Form4 f4 = new Form4();
            f4.Show();
            //axOPOSMSR1.DataEventEnabled = true;
            if (status == "update")
            {
                status = "";
                (this.Owner as Form1).btnin.Enabled = true;
                (this.Owner as Form1).btnout.Enabled = true;
                axOPOSMSR1.Close();
                this.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (axOPOSMSR1.Open("IDTechMiniMagII") == 0 /* OPOS_SUCCESS */)
            {
                axOPOSMSR1.ClaimDevice(100);
                axOPOSMSR1.DeviceEnabled = true;
                axOPOSMSR1.DataEventEnabled = true;
            }
        }
    }
}
