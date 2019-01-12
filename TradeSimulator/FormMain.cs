using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradeSimulator
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDo_Click(object sender, EventArgs e)
        {
            var yahoo = new YahooFinanceDbContext();
            var code = yahoo.CodeLists;
            MessageBox.Show(string.Format($"{code.FirstOrDefault().code}"));
        }
    }
}
