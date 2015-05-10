using AForge.Imaging.Filters;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SPixel
{
    public partial class HueModifierForm : Form
    {
        private HueModifier filter = new HueModifier();

        public Bitmap Image
        {
            set { filterPreview.Image = value; }
        }

        public IFilter Filter
        {
            get { return filter; }
        }

        public HueModifierForm()
        {
            InitializeComponent();

            hueBox.Text = filter.Hue.ToString();
            huePicker.Min = filter.Hue;

            filterPreview.Filter = filter;
        }

        private void huePicker_ValuesChanged(object sender, EventArgs e)
        {
            hueBox.Text = huePicker.Min.ToString();
        }

        private void hueBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                huePicker.Min = filter.Hue = int.Parse(hueBox.Text);
                filterPreview.RefreshFilter();
            }
            catch (Exception)
            {
            }
        }
    }
}
