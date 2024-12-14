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

namespace MazeGameSample
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer start = new System.Media.SoundPlayer(); //Your starting point music please write your path here.
        System.Media.SoundPlayer finish = new System.Media.SoundPlayer();
        public Form1()
        {
            InitializeComponent();
            Startagain(); //We have to use Startagain method to start our initial point.
        }

        private void Finishlabel_Click(object sender, EventArgs e)
        {

        }

        private void Finishlabel_MouseEnter(object sender, EventArgs e)
        {
            finish.Play();
            MessageBox.Show("Well Done");
            Close();
        }

        private void Startagain()
        {
            start.Play();
            Point startingpoint = panel1.Location; //We're talking about the top left of the form.
            startingpoint.Offset(10,10);  //Offset means choose location to start your mice.
            Cursor.Position = PointToScreen(startingpoint);
        }

        private void wall_Mouse(object sender, EventArgs e) // MouseEnter = It carries its meaning when we move the mouse cursor over it.
        {
            Startagain();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}
