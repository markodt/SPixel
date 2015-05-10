using System;
using System.Windows.Forms;

namespace SPixel
{
    public partial class ImageProperties : Form
    {
        public ImageProperties(string[] properties)
        {
            InitializeComponent();

            fileNameBox.Text = properties[0];
            directoryBox.Text = properties[1];
            compressionBox.Text = properties[2];
            resolutionBox.Text = properties[3];
            originalSizeBox.Text = properties[4];
            currentSizeBox.Text = properties[5];
            originalColorsBox.Text = properties[6];
            currentColorsBox.Text = properties[7];
            diskSizeBox.Text = properties[8];
            memorySizeBox.Text = properties[9];
            directoryIndexBox.Text = properties[10];
            fileDateTimeBox.Text = properties[11];
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
