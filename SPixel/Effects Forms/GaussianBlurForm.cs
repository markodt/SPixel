using AForge.Imaging.Filters;
using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace SPixel
{
    public partial class GaussianBlurForm : Form
    {
        private GaussianBlur filter = new GaussianBlur();
        private bool updating = false;

        public Bitmap Image
        {
            set { filterPreview.Image = value; }
        }

        public IFilter Filter
        {
            get { return filter; }
        }

        public GaussianBlurForm()
        {
            InitializeComponent();

            // set edit boxes
            sigmaBox.Text = filter.Sigma.ToString(CultureInfo.InvariantCulture);
            sizeBox.Text = filter.Size.ToString();

            // set sliders
            sigmaTrackBar.Value = (int)((filter.Sigma - 0.5) * 20);
            sizeTrackBar.Value = (filter.Size - 3) / 2;

            filterPreview.Filter = filter;
        }

        private void sigmaTrackBar_ValueChanged(object sender, EventArgs e)
        {
            if (!updating)
            {
                double v = (double)sigmaTrackBar.Value / 20 + 0.5;
                sigmaBox.Text = v.ToString(CultureInfo.InvariantCulture);
            }
        }

        private void sizeTrackBar_ValueChanged(object sender, EventArgs e)
        {
            if (!updating)
            {
                int v = sizeTrackBar.Value * 2 + 3;
                sizeBox.Text = v.ToString();
            }
        }

        private void sigmaBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.sigmaBox.Text.Contains(','))
                {
                    MessageBox.Show(this, "Incorrect decimal separator, use dot ( . ) instead of comma ( , )!", "SPixel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                filter.Sigma = double.Parse(sigmaBox.Text, CultureInfo.InvariantCulture);

                updating = true;
                sigmaTrackBar.Value = (int)((filter.Sigma - 0.5) * 20);
                updating = false;

                filterPreview.RefreshFilter();
            }
            catch (Exception)
            {
            }
        }

        private void sizeBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                filter.Size = int.Parse(sizeBox.Text);

                updating = true;
                sizeTrackBar.Value = (filter.Size - 3) / 2;
                updating = false;

                filterPreview.RefreshFilter();
            }
            catch (Exception)
            {
            }
        }
    }
}
