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

namespace ModernUIPractice
{
    public partial class Customers : UserControl
    {


        public Customers(object bindingsource)
        {
            InitializeComponent();
            textBox1.DataBindings.Add("Text", bindingsource, "Firstname");
            textBox2.DataBindings.Add("Text", bindingsource, "Lastname");
            textBox3.DataBindings.Add("Text", bindingsource, "Address");
            pictureBox1.DataBindings.Add("ImageLocation", bindingsource, "Picture");

        }

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                Debug.WriteLine(e.Error);

            }
        }
    }
}
