using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CabSystem
{
    public partial class CabSystem : Form
    {
        public CabSystem()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Enabled = true;
            progressBar.Increment(10);
            if(progressBar.Value == 100)
            {
                timer.Enabled = false;
                Login login = new Login();
                this.Hide();
                login.Show();
            }
        }
    }
}
