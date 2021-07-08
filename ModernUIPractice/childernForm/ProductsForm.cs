using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernUIPractice.childernForm
{
    public partial class ProductsForm : Form
    {
        int row=0;
        public ProductsForm()
        {
            InitializeComponent(); 
            databinding();
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.RowStyles.Clear();
            
           

        }


        void databinding()
        {
            using (ShoppingEntities db = new ShoppingEntities())
            {
                var list = db.Orders.Where(c => c.CustomerId == Form1.currentcustomer.Id).ToList();
                foreach(var pro in list)
                {
                    productCard product = new productCard(pro);
                    //product.Name = pro.Product;
                    product.Dock = DockStyle.Fill;
                    product.Anchor = AnchorStyles.Top;
                    tableLayoutPanel1.Controls.Add(product,0,row);
                    tableLayoutPanel1.RowCount++;
                    row++;    

                }
                

            }


        }
    }
}
