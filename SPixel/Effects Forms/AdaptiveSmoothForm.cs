using AForge.Imaging.Filters;
using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace SPixel
{
    public partial class AdaptiveSmoothForm : Form
    {
        private AdaptiveSmoothing filter = new AdaptiveSmoothing(1.0);
        private double factor = 1.0;
        private bool updating = false;

        public Bitmap Image
        {
            set { filterPreview.Image = value; }
        }

        public IFilter Filter
        {
            get { return filter; }
        }

        public AdaptiveSmoothForm()
        {
            InitializeComponent();

            factorBox.Text = factor.ToString(CultureInfo.InvariantCulture);
            trackBar.Value = (int)factor * 10;

            filterPreview.Filter = filter;
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

                factor = Math.Max(0.1f, Math.Min(10.0f, double.Parse(factorBox.Text, CultureInfo.InvariantCulture)));

                updating = true;
                trackBar.Value = (int)(factor * 10);
                updating = false;

                filter.Factor = factor;
                filterPreview.RefreshFilter();
            }
            catch (Exception)
            {
            }
        }

        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            if (!updating)
                factorBox.Text = ((double)trackBar.Value / 10).ToString(CultureInfo.InvariantCulture);
        }
    }
}
