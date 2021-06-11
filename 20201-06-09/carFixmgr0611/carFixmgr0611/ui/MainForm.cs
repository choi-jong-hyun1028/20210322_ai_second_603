using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carFixmgr0611
{
    // :meteriaform 상속
    public partial class MainForm : MaterialForm
    {
        //생성자
        public MainForm()
        {
            InitializeComponent();
        }

        private void mainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void custFixAdd_Click(object sender, EventArgs e)
        {

        }

        private void custFixview_Click(object sender, EventArgs e)
        {

        }

        private void custFixAdmin_Click(object sender, EventArgs e)
        {

        }

        private void custFixRandData_Click(object sender, EventArgs e)
        {

        }

        private void custFixinfo_Click(object sender, EventArgs e)
        {

        }
    }
}
