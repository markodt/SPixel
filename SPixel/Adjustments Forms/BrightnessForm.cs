using AForge.Imaging.Filters;
using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace SPixel
{
    public partial class BrightnessForm : Form
    {
        private BrightnessCorrection filter = new BrightnessCorrection();
        private bool updating = false;

        public Bitmap Image
        {
            set { filterPreview.Image = value; }
        }

        public IFilter Filter
        {
            get { return filter; }
        }

        public BrightnessForm()
        {
            InitializeComponent();

            brightnessBox.Text = filter.AdjustValue.ToString(CultureInfo.InvariantCulture);
            brightnessTrackBar.Value = (int)(filter.AdjustValue * 1000);

            filterPreview.Filter = filter;
        }

        private void brightnessTrackBar_ValueChanged(object sender, EventArgs e)
        {
            if (!updating)
                brightnessBox.Text = ((double)brightnessTrackBar.Value / 1000).ToString(CultureInfo.InvariantCulture);
        }

        private void brightnessBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.brightnessBox.Text.Contains(','))
                {
                    MessageBox.Show(this, "Incorrect decimal separator, use dot ( . ) instead of comma ( , )!", "SPixel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                filter.AdjustValue = double.Parse(brightnessBox.Text, CultureInfo.InvariantCulture);

                updating = true;
                brightnessTrackBar.Value = (int)(filter.AdjustValue * 1000);
                updating = false;

                filterPreview.RefreshFilter();
            }
            catch (Exception)
            {
            }
        }
    }
}
