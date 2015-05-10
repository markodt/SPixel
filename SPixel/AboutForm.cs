using System;
using System.Windows.Forms;

namespace SPixel
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();

            textLabel1.Text = "SPixel";
            label1.Text = "Version 2.0\n\nCopyright \u00A9 " + DateTime.Now.Year + "\nMarko Dominik Topić\n\nBased on AForge.NET Framework";
            linkLabel1.Text = "www.aforgenet.com/framework/";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.aforgenet.com/framework/");
            this.linkLabel1.LinkVisited = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
