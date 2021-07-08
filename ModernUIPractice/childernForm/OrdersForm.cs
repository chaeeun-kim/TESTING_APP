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
    public partial class Orders : Form
    {
        BindingSource source = new BindingSource();
        public Orders()
        {
            InitializeComponent();
            databinding();
            dataGridView1.Columns[2].HeaderText = "User ID";
        }
        

        void databinding()
        {
            using (ShoppingEntities db = new ShoppingEntities())
            {
                var list = db.Orders.Select(c => new { c.Product, c.OrderDate, c.CustomerId }).Where(c => c.CustomerId == Form1.currentcustomer.Id).ToList();
                source.DataSource = list;

            }
            dataGridView1.DataSource = source;
       


        }
    }
}
