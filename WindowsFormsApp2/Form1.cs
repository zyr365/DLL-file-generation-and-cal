using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevComponents.DotNetBar;
using process;

namespace test1
{
    public partial class Form1 : DevComponents.DotNetBar.Office2007Form
    {
        public Form1()
        {

            this.EnableGlass = false;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        
        private void buttonX1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("这只是一个测试");
            // DataProcess dp = new DataProcess();
            int s = DataProcess.SumData(10, 20);

            MessageBox.Show(s.ToString());

        }
    }
}
