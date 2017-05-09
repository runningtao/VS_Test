using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTest
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();

            this.btnTest.Click += BtnTest_Click;
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
            
        }
    }
}
