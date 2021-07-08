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
    public partial class productCard : UserControl
    {
       
        public productCard(object source)
        {
            InitializeComponent();
            label1.DataBindings.Add("Text", source, "Product");
            pictureBox1.DataBindings.Add("ImageLocation",source, "Picture");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            panel1.BackgroundImageLayout = ImageLayout.Center;
        }

       
    }
}
