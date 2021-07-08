
namespace ModernUIPractice
{
    partial class Customers
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Firstname = new System.Windows.Forms.Label();
            this.Lastname = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(272, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(158, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(272, 168);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(158, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(272, 258);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(158, 22);
            this.textBox3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 317);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(17, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 255);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pictureBox1_LoadCompleted);
            // 
            // Firstname
            // 
            this.Firstname.AutoSize = true;
            this.Firstname.ForeColor = System.Drawing.Color.White;
            this.Firstname.Location = new System.Drawing.Point(269, 39);
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(70, 17);
            this.Firstname.TabIndex = 4;
            this.Firstname.Text = "Firstname";
            // 
            // Lastname
            // 
            this.Lastname.AutoSize = true;
            this.Lastname.ForeColor = System.Drawing.Color.White;
            this.Lastname.Location = new System.Drawing.Point(269, 124);
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(70, 17);
            this.Lastname.TabIndex = 5;
            this.Lastname.Text = "Lastname";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(269, 211);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(60, 17);
            this.Address.TabIndex = 6;
            this.Address.Text = "Address";
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Lastname);
            this.Controls.Add(this.Firstname);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Customers";
            this.Size = new System.Drawing.Size(517, 317);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Firstname;
        private System.Windows.Forms.Label Lastname;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
