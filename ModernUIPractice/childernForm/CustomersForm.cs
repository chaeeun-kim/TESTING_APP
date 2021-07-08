using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernUIPractice.childernForm
{
    public partial class CustomersForm : Form
    { int row = 0;
      
        public CustomersForm()
        {
            InitializeComponent();
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.AutoScroll = true;
            databinding();
        }
        public void databinding()
        {
            using (ShoppingEntities db = new ShoppingEntities())
            {
                var list = db.Customers.Where(c => c.Id == Form1.currentcustomer.Id).ToList();
          
                foreach (var customer in list)
                {
                   Customers customers = new Customers( customer);
                    customers.Dock = DockStyle.Fill;
                    customers.Anchor = AnchorStyles.Top;
               
                    tableLayoutPanel1.Controls.Add(customers, 0, row);
                    tableLayoutPanel1.RowCount++;
                    row++;
                }
            }

        }
            

        

        
          


        }
        
    }

