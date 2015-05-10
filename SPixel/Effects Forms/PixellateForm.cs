using AForge.Imaging.Filters;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SPixel
{
    public partial class PixellateForm : Form
    {
        private Pixellate filter = new Pixellate(8);

        public Bitmap Image
        {
            set { filterPreview.Image = value; }
        }

        public IFilter Filter
        {
            get { return filter; }
        }

        public PixellateForm()
        {
            InitializeComponent();

            widthBox.Text = filter.PixelWidth.ToString();
            heightBox.Text = filter.PixelHeight.ToString();

            widthTrackBar.Value = filter.PixelWidth;
            heightTrackBar.Value = filter.PixelHeight;

            filterPreview.Filter = filter;
        }

        private void widthBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                filter.PixelWidth = int.Parse(widthBox.Text);
                filterPreview.RefreshFilter();
            }
            catch (Exception)
            {
            }
        }

        private void widthTrackBar_Scroll(object sender, EventArgs e)
        {
            widthBox.Text = widthTrackBar.Value.ToString();
            if (syncCheck.Checked)
            {
                heightTrackBar.Value = widthTrackBar.Value;
                heightBox.Text = widthBox.Text;
            }
        }

        private void heightBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                filter.PixelHeight = int.Parse(heightBox.Text);
                filterPreview.RefreshFilter();
            }
            catch (Exception)
            {
            }
        }

        private void heightTrackBar_Scroll(object sender, EventArgs e)
        {
            heightBox.Text = heightTrackBar.Value.ToString();
            if (syncCheck.Checked)
            {
                widthTrackBar.Value = heightTrackBar.Value;
                widthBox.Text = heightBox.Text;
            }
        }
    }
}
