using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoHabitica
{
    public partial class PasswordWindow : Form
    {
        public string userId;//must be public
        public string apiKey;//must be public
        public PasswordWindow()
        {
            InitializeComponent();

        }

        private void HabiticaLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer.exe",
                "https://habitica.com/user/settings/siteData");
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            //Check the information and return.
            if (!string.IsNullOrEmpty(userIdTextBox.Text)
                && !string.IsNullOrEmpty(apiKeyTextBox.Text))
            {
                DialogResult = DialogResult.OK;
                userId = userIdTextBox.Text;
                apiKey = apiKeyTextBox.Text;
                FileHelper.SaveCredential(userId, apiKey);
                Close();
            }


        }
    }
}
