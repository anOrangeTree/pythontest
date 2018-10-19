using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pythonTest
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var oHelper = new PythonHelper(@"X:\D\study2\Python\pythonTest\test.py");
            var result = oHelper.CallFun("Test1", 3, 4);
            txtMain.Text = Convert.ToString(result);
        }

        private void btnCallFun2_Click(object sender, EventArgs e)
        {
            var oHelper = new PythonHelper(@"X:\D\study2\Python\pythonTest\test.py");
            oHelper.CallFun("Test2");
        }
    }
}
