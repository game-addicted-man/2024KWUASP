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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            try
            {
                pictureBox1.Load(@"C:\Users\natha\gimbab.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
