using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combined
{
    public partial class Form1 : Form
    {
        #region Initialize
        public Form1()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            panelCIOSubmenu.Visible = false;
        }
        #endregion

        #region Hide/Show
        private void hideSubMenu()
        {
            if (panelCIOSubmenu.Visible == true)
                panelCIOSubmenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        #endregion

        #region TimeWatch
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();
        }
        #endregion

        #region Clockin/outSubMenu

        private void btnCIO_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCIOSubmenu);
        }

        private void btnin_Click(object sender, EventArgs e)
        {
            btnin.Enabled = false;
            btnout.Enabled = false;
            Form2 f2 = new Form2();
            f2.Owner = this;
            openChildForm(f2);
            hideSubMenu();  
        }

        

        private void btnout_Click(object sender, EventArgs e)
        {
            btnin.Enabled = false;
            btnout.Enabled = false;
            Form3 f3 = new Form3();
            f3.Owner = this;
            openChildForm(f3);
            hideSubMenu();
        }
        #endregion

        #region ActivateForm
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion
    }
}
