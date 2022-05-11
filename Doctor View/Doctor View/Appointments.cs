using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doctor_View
{
    public partial class Appointments : Form
    {
        public Appointments()
        {
            InitializeComponent();
        }

        private void Appointments_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patient_File f4 = new Patient_File();
            f4.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Appointments f2 = new Appointments();
            f2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Previous_Visits f3 = new Previous_Visits();
            f3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Return_Home f5 = new Return_Home();
            f5.Show();
        }
    }
}
