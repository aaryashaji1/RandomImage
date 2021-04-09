using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomImage
{
    public partial class Form1 : Form
    {

        int count = 0;
        Timer t = new Timer();


        public Form1()
        {
            InitializeComponent();
            t.Interval = 3000;
            t.Tick += new EventHandler(timer1_Tick);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            count++;
            string[] paths = Directory.GetFiles("C:\\Users\\ASUS\\Desktop\\Images");
            List<string> images = paths.ToList();
            Random random = new Random();
            pictureBox1.ImageLocation = paths[random.Next(0, images.Count - 0)];
        }


        private void btnRotate_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            Bitmap bitmap = new Bitmap(pictureBox1.Image);
            bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
            pictureBox1.Image = bitmap;
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {

            t.Start();
            pictureBox1.Visible = true;


        }

       
    }
}
