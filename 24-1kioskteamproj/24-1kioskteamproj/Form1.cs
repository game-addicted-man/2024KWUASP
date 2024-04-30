using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_1kioskteamproj
{
    public partial class Form1 : Form
    {
        public bool packing = true;
        Form2 form2 = new Form2();
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            try
            {
                pictureBox1.Load(@"C:\Users\natha\gimbab.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            } catch (Exception e){
                Console.WriteLine(e.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            packing = false;

            form2.Owner = this;
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            packing = true;
            this.Hide();

            form2.Owner = this;
            form2.Show();
            this.Hide();
        }
    }
}
