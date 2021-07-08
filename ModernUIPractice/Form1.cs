
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernUIPractice
{
    public partial class Form1 : Form
    {
        Button currentbtn;
        Random random;
        public static Customer currentcustomer;
        int index;
        public Form1()
        {
            InitializeComponent();
            currentcustomer = new Customer();
            random = new Random();
            this.Text = string.Empty;
            this.ControlBox = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button5.Enabled = false;
        }
        #region Menu Buttons Click event
        private void button1_Click(object sender, EventArgs e)
        {
            childernform.Controls.Clear();
            Changecolor(sender);
            Openchildform(new childernForm.ProductsForm());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            childernform.Controls.Clear();
            Changecolor(sender);
            Openchildform(new childernForm.Orders());
            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            childernform.Controls.Clear();
            Changecolor(sender);
            Openchildform(new childernForm.CustomersForm());
        }

      

        private void button5_Click(object sender, EventArgs e)
        {
            childernform.Controls.Clear();
            Changecolor(sender);
            Openchildform(new childernForm.NotificationForm());


        }
        #endregion

        #region Color Change method
        private void Deactivatecolor()
        {
            foreach(Control previoisbtn in panel1.Controls)
            {
                if(previoisbtn.GetType()==typeof(Button))
                {previoisbtn.BackColor= SystemColors.ControlDarkDark;
                }
            }

        }
        private void Changecolor(object sender)
        {
            if (currentbtn != (Button)sender)
            {
                Deactivatecolor();
                index = random.Next(0, colors.colorList.Count);
                string selectedcolor = colors.colorList[2];
                currentbtn = (Button)sender;
                currentbtn.BackColor = ColorTranslator.FromHtml(selectedcolor);
                panel3.BackColor = ColorTranslator.FromHtml(selectedcolor);
                Home.ForeColor = Color.White;
            }


        }
        #endregion

        #region open childform method
        private void Openchildform(Form childform )
        {
            childform.TopLevel = false;
            childform.Dock = DockStyle.Fill;
            childform.FormBorderStyle= FormBorderStyle.None;
            this.childernform.Controls.Add(childform);
            this.childernform.Tag = childform;
            childform.BringToFront();
            childform.Show();
            Home.Text = childform.Text;
          
        }

        #endregion

        #region setting currrentUser && submit btn event 
        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button5.Enabled = true;
            using (ShoppingEntities db = new ShoppingEntities())
            {
                int input = Convert.ToInt32(textBox1.Text);
                var list = db.Customers.Where(c => c.Id == input).ToList();
                foreach (var customer in list)
                {
                    currentcustomer = customer;
                    
                }
            }
            
            button3_Click(button3,e);
        }
        #endregion

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
