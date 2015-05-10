using AForge.Imaging.Filters;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SPixel
{
    public partial class OilPaintingForm : Form
    {
        private OilPainting filter = new OilPainting(7);

        public Bitmap Image
        {
            set { filterPreview.Image = value; }
        }

        public IFilter Filter
        {
            get { return filter; }
        }

        public OilPaintingForm()
        {
            InitializeComponent();

            trackBar.Value = (filter.BrushSize - 3) / 2;

            filterPreview.Filter = filter;
        }

        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            int v = trackBar.Value * 2 + 3;
            sizeBox.Text = v.ToString();
        }

        private void sizeBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                filter.BrushSize = int.Parse(sizeBox.Text);
                filterPreview.RefreshFilter();
            }
            catch (Exception)
            {
            }
        }
    }
}
