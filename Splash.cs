using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthSystem
{
    public partial class Splash : System.Windows.Forms.Form
    {

        public Splash()
        {
            InitializeComponent();
        }

        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            Myprogressbar.Value = startpoint;
            if (Myprogressbar.Value == 30)
            {
                Myprogressbar.Value = 0;
                timer1.Stop();

                FormLoad login = new FormLoad();
                login.Show();
                this.Hide();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void Myprogressbar_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
