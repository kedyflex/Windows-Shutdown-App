using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsShutdownApp
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void txtTimerMinute_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnAppClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTimerStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimerMinute.Text))
            {
                MessageBox.Show("First you must specify a duration!", "Windows Shutdown Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToInt32(txtTimerMinute.Text) <= 0)
            {
                MessageBox.Show("The entered minute must be greater than 0!", "Windows Shutdown Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int inputTime = Convert.ToInt32(txtTimerMinute.Text);
                int shutdownTime = inputTime * 60;
                Process.Start("shutdown.exe", "/s /f /t " + shutdownTime);
                txtTimerMinute.Text = string.Empty;
                ActiveControl = null;
                MessageBox.Show("Countdown to closing has begun!", "Windows Shutdown Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTimerStop_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown.exe", "/a");
            MessageBox.Show("Countdown to closing cancelled!", "Windows Shutdown Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        { //Its purpose is to prevent the user from writing different things with copy and paste.
            if (keyData == (Keys.Control | Keys.V))
            {
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }
    }
}
