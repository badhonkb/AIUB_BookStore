using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        int startpos;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpos += 10;
            progressBarStart.Value = startpos;
            //labelpercent.Text = startpos + "%";
            if (progressBarStart.Value == 100)
            {
                progressBarStart.Value = 0;
                timer1.Stop();
                Home h = new Home();
                h.Show();
                this.Hide();
            }
        }

        private void Start_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void progressBarStart_Click(object sender, EventArgs e)
        {

        }

        private void labelLoading_Click(object sender, EventArgs e)
        {

        }
    }
}
