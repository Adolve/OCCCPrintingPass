using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OCCCPrintingPass
{
    public partial class PrintingPass : Form
    {
        public PrintingPass()
        {
            InitializeComponent();
        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            long id;
            long.TryParse(tbStudentId.Text, out id);
            int todayDay = DateTime.Today.Day;
            int todayMonth = DateTime.Today.Month;
            int todayYear = DateTime.Today.Year;

            lbPass.Text= ((id + todayMonth) * todayDay + (id + todayYear) * (id % todayDay + 1)).ToString("X");
        }
    }
}
