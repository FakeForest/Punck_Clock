using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public static string messageout = "";
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

            string o = "out";

            string d = "Did not Swipein";

            string query1 = "select convert(varchar(100), CardNumber) from [dbo].[TableEmployee] where convert(varchar(100), CardNumber) = ('" + cardno + "')";

            string query2 = "select convert(varchar(100), Name) from [dbo].[TableEmployee] where convert(varchar(100), CardNumber) = ('" + cardno + "')";

            string query3 = "select convert(varchar(100), Time) from [dbo].[problem] where convert(varchar(100), CardNumber) = ('" + cardno + "') and datediff(day, ('" + t + "'), Time) = 0 and status = 'in'";

            con.Open();
            //Check if cardnumber exist in the TableEmployee.
            SqlCommand cidcmd = new SqlCommand(query1, con);
            string cid = (string)cidcmd.ExecuteScalar();
            con.Close();

            if (cid == cardno)
            {
                con.Open();
                //if the cardnumber exist, check if there is any record of same person swipe in the same day.
                SqlCommand incmd = new SqlCommand(query3, con);
                string imd = (string)incmd.ExecuteScalar();
                //Get the name of the employee by the corresponding cardnumber.
                SqlCommand lidcmd = new SqlCommand(query2, con);
                string lid = (string)lidcmd.ExecuteScalar();
                con.Close();
                
                if (imd == null)
                {
                    con.Open();
                    //if there's no record, means the employee did not swipe in earlier in the day.
                    messageout = string.Format("Hello {0}! You did not clock in earlier in the day! \n Your clock in time will be set as your clock out time, \n please tell the manager to change your real clock in time \n Your clock out time: {1}", lid, t);
                    SqlCommand ins = new SqlCommand("insert into TimeReport (CardNumber, Name, statusin, Timein, statusout, Timeout) values ('" + cardno + "', '" + lid + "', '" + d + "', '" + t + "', '" + o + "', '" + t + "')", con);
                    ins.ExecuteNonQuery();
                    con.Close();
                    //send email to punchcard@multilinefasteners.com
                    MailMessage mail = new MailMessage();
                    SmtpClient smtp = new SmtpClient("smtp.bellnet.ca");
                    mail.From = new MailAddress("donotreply@multilinefasteners.com");
                    mail.To.Add("punchcard@multilinefasteners.com");
                    mail.Subject = "Employee did not swipe in";
                    mail.Body = string.Format("Here is the info for employee NO.{0} who fogets to swipe in: Name: {1} Swipeout Time: {2}", cardno, lid, t);
                    smtp.Port = 25;
                    smtp.EnableSsl = false;
                    smtp.Send(mail);
                    status = "update";
                }
                else
                {
                    con.Open();
                    //if there is record in table problem, hence update the info in TimeReport and delete the record in table problem.
                    SqlCommand icmd = new SqlCommand("Update TimeReport" +
                                                     " set Timeout = '" + t + "', statusout = '" + o + "'" +
                                                     " where (CardNumber = '" + cardno + "' and datediff(day, '" + t + "', Timeout) = 0 and statusout = 'Did not Swipeout')", con);
                    icmd.ExecuteNonQuery();
                    SqlCommand deli = new SqlCommand("delete from problem where CardNumber = ('"+ cardno +"') and datediff(day, ('"+ t +"'), Time) = 0", con);
                    deli.ExecuteNonQuery();
                    messageout = string.Format("Hello {0}! Time to go! Info uploaded! \n Clock out time: {1} \n Please wait until this page disappears before continuing!", lid, dateTimePicker1.Text);
                    con.Close();
                    status = "update";
                }
            }
            else
            {
                //if the cardnumber does not exist in TableEmployee means it is a wrong card.
                messageout = "Wrong Card! Please try it again! \n Please wait until this page disappears before continuing!";
                status = "update";
            }
            #endregion

            Form5 f5 = new Form5();
            f5.Show();
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

        private void Form3_Load(object sender, EventArgs e)
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
