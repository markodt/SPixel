using AForge.Imaging.Filters;
using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace SPixel
{
    public partial class CannyDetectorForm : Form
    {
        private CannyEdgeDetector filter = new CannyEdgeDetector();
        private bool updating = false;

        public Bitmap Image
        {
            set { filterPreview.Image = value; }
        }

        public IFilter Filter
        {
            get { return filter; }
        }

        public CannyDetectorForm()
        {
            InitializeComponent();

            // set edit boxes
            sigmaBox.Text = filter.GaussianSigma.ToString(CultureInfo.InvariantCulture);
            lowThresholdBox.Text = filter.LowThreshold.ToString();
            highThresholdBox.Text = filter.HighThreshold.ToString();

            // set sliders
            sigmaTrackBar.Value = (int)((filter.GaussianSigma - 1.0) * 20);
            thresholdSlider.Min = filter.LowThreshold;
            thresholdSlider.Max = filter.HighThreshold;

            filterPreview.Filter = filter;
        }

        private void sigmaTrackBar_ValueChanged(object sender, EventArgs e)
        {
            if (!updating)
            {
                double v = (double)sigmaTrackBar.Value / 20 + 1.0;
                sigmaBox.Text = v.ToString(CultureInfo.InvariantCulture);
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

                filter.GaussianSigma = double.Parse(sigmaBox.Text, CultureInfo.InvariantCulture);

                updating = true;
                sigmaTrackBar.Value = (int)((filter.GaussianSigma - 1.0) * 20);
                updating = false;

                filterPreview.RefreshFilter();
            }
            catch (Exception)
            {
            }
        }

        private void lowThresholdBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                thresholdSlider.Min = int.Parse(lowThresholdBox.Text);

                filter.LowThreshold = byte.Parse(lowThresholdBox.Text);

                filterPreview.RefreshFilter();
            }
            catch (Exception)
            {
            }
        }

        private void highThresholdBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                thresholdSlider.Max = int.Parse(highThresholdBox.Text);

                filter.HighThreshold = byte.Parse(highThresholdBox.Text);

                filterPreview.RefreshFilter();
            }
            catch (Exception)
            {
            }
        }

        private void thresholdSlider_ValuesChanged(object sender, EventArgs e)
        {
            lowThresholdBox.Text = thresholdSlider.Min.ToString();
            highThresholdBox.Text = thresholdSlider.Max.ToString();
        }
    }
}
