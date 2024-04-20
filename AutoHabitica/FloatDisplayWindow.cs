using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace AutoHabitica
{
    public partial class FloatDisplayWindow : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_EX_NOACTIVATE = 0x08000000;
                //const int WS_CHILD = 0x40000000;
                CreateParams cp = base.CreateParams;
                //cp.Style |= WS_CHILD;
                cp.ExStyle |= WS_EX_NOACTIVATE;
                return cp;
            }
        }

        public FloatDisplayWindow()
        {
            InitializeComponent();
            this.Left = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            this.Top = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
        }
        public void UpdateDisplay(string taskName, TimeSpan t1, TimeSpan t2)
        {
            taskLabel.Text = taskName;
            taskProgressBar.Value = (int)(t1 / t2 * 100);
        }

        private async void FloatDisplayWindow_MouseEnter(object sender, EventArgs e)
        {
            Hide();
            await System.Threading.Tasks.Task.Run(() =>
            {
                Thread.Sleep(5000);

            });
            Show();
        }
    }
}
