using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CabSystem
{
    public class ButtonClicks
    {
        public static void CloseButton_Click(object sender, EventArgs e, Form form)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Function to minimize windows using button clicks
        public static void MinimizeBtn_Click(object sender, EventArgs e, Form form)
        {
            form.WindowState = FormWindowState.Minimized;
        }
    }
}
