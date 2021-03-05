using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressTestApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(() =>
            {
                label1.Text = "시작";
                for (int i = 0; i <= 100; i++)
                {
                    progressBar1.Value = i;
                    Thread.Sleep(100);
                }
                label1.Text = "종료";
            });
            th.IsBackground = false; // 백그라운드 허용 (default)
            th.IsBackground = true; // 백그라운드 허용 안함
            th.Start();
            // th.Join();

        }
    }
}
