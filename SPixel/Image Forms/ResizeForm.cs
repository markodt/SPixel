using AForge.Imaging.Filters;
using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace SPixel
{
    public partial class ResizeForm : Form
    {
        private Size originalSize;
        private BaseResizeFilter filter = null;
        private bool updating = false;

        public Size OriginalSize
        {
            get { return originalSize; }
            set { originalSize = value; }
        }

        public IFilter Filter
        {
            get { return filter; }
        }

        public ResizeForm(Size bitmapSize)
        {
            InitializeComponent();

            originalSize = bitmapSize;

            // default resize factor
            factorBox.Text = "1.00";

            // width and height
            widthBox.Text = originalSize.Width.ToString();
            heightBox.Text = originalSize.Height.ToString();

            methodCombo.SelectedIndex = 1;
        }

        private void sizeButton_CheckedChanged(object sender, EventArgs e)
        {
            bool enable = sizeButton.Checked;

            widthBox.Enabled = enable;
            heightBox.Enabled = enable;
            ratioCheck.Enabled = enable;
        }

        private void factorButton_CheckedChanged(object sender, EventArgs e)
        {
            factorBox.Enabled = factorButton.Checked;
            resizeTrackBar.Enabled = factorButton.Checked;
        }

        private void factorBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.factorBox.Text.Contains(','))
                {
                    MessageBox.Show(this, "Incorrect decimal separator, use dot ( . ) instead of comma ( , )!", "SPixel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                float factor = float.Parse(factorBox.Text, CultureInfo.InvariantCulture);

                updating = true;
                resizeTrackBar.Value = (int)(factor * 100);
                widthBox.Text = Math.Max(1, Math.Min(5000, (int)(factor * originalSize.Width))).ToString();
                heightBox.Text = Math.Max(1, Math.Min(5000, (int)(factor * originalSize.Height))).ToString();
                updating = false;
            }
            catch (Exception)
            {
            }
        }

        private void resizeTrackBar_ValueChanged(object sender, EventArgs e)
        {
            if (!updating)
                factorBox.Text = ((float)resizeTrackBar.Value / 100).ToString("0.00", CultureInfo.InvariantCulture);
        }

        private void widthBox_TextChanged(object sender, EventArgs e)
        {
            if ((!updating) && (ratioCheck.Checked))
            {
                try
                {
                    int width = int.Parse(widthBox.Text);

                    updating = true;
                    heightBox.Text = Math.Max(1, Math.Min(5000, (int)(width * originalSize.Height / originalSize.Width))).ToString();
                    updating = false;
                }
                catch (Exception)
                {
                }
            }
        }

        private void heightBox_TextChanged(object sender, EventArgs e)
        {
            if ((!updating) && (ratioCheck.Checked))
            {
                try
                {
                    int height = int.Parse(heightBox.Text);

                    updating = true;
                    widthBox.Text = Math.Max(1, Math.Min(5000, (int)(height * originalSize.Width / originalSize.Height))).ToString();
                    updating = false;
                }
                catch (Exception)
                {
                }
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                // get new image size
                int width = Math.Max(1, Math.Min(5000, int.Parse(widthBox.Text)));
                int height = Math.Max(1, Math.Min(5000, int.Parse(heightBox.Text)));

                // create appropriate filter
                switch (methodCombo.SelectedIndex)
                {
                    case 0:
                        filter = new ResizeNearestNeighbor(width, height);
                        break;
                    case 1:
                        filter = new ResizeBilinear(width, height);
                        break;
                    case 2:
                        filter = new ResizeBicubic(width, height);
                        break;
                }

                // close the dialog
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Incorrect values are entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
