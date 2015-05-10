using AForge;
using AForge.Controls;
using AForge.Imaging.Filters;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SPixel
{
    public partial class ChannelFilteringForm : Form
    {
        private ChannelFiltering filter = new ChannelFiltering();
        private IntRange red = new IntRange(0, 255);
        private IntRange green = new IntRange(0, 255);
        private IntRange blue = new IntRange(0, 255);
        private byte fillR = 0, fillG = 0, fillB = 0;

        public Bitmap Image
        {
            set { filterPreview.Image = value; }
        }

        public IFilter Filter
        {
            get { return filter; }
        }

        public ChannelFilteringForm()
        {
            InitializeComponent();

            minRBox.Text = red.Min.ToString();
            maxRBox.Text = red.Max.ToString();
            fillRBox.Text = fillR.ToString();
            //
            minGBox.Text = green.Min.ToString();
            maxGBox.Text = green.Max.ToString();
            fillGBox.Text = fillG.ToString();
            //
            minBBox.Text = blue.Min.ToString();
            maxBBox.Text = blue.Max.ToString();
            fillBBox.Text = fillB.ToString();

            redFillTypeCombo.SelectedIndex = 0;
            greenFillTypeCombo.SelectedIndex = 0;
            blueFillTypeCombo.SelectedIndex = 0;

            filterPreview.Filter = filter;
        }

        private void UpdateFilter()
        {
            filter.Red = red;
            filter.Green = green;
            filter.Blue = blue;
            filterPreview.RefreshFilter();
        }

        private void minRBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                redSlider.Min = red.Min = Math.Min(red.Max, byte.Parse(minRBox.Text));
                UpdateFilter();
            }
            catch (Exception)
            {
            }
        }

        private void maxRBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                redSlider.Max = red.Max = Math.Max(red.Min, byte.Parse(maxRBox.Text));
                UpdateFilter();
            }
            catch (Exception)
            {
            }
        }

        private void fillRBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                fillR = byte.Parse(fillRBox.Text);
                filter.FillRed = fillR;
                redSlider.FillColor = Color.FromArgb(fillR, 0, 0);
                filterPreview.RefreshFilter();
            }
            catch (Exception)
            {
            }
        }

        private void minGBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                greenSlider.Min = green.Min = (byte)Math.Min(green.Max, byte.Parse(minGBox.Text));
                UpdateFilter();
            }
            catch (Exception)
            {
            }
        }

        private void maxGBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                greenSlider.Max = green.Max = Math.Max(green.Min, byte.Parse(maxGBox.Text));
                UpdateFilter();
            }
            catch (Exception)
            {
            }
        }

        private void fillGBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                fillG = byte.Parse(fillGBox.Text);
                filter.FillGreen = fillG;
                greenSlider.FillColor = Color.FromArgb(0, fillG, 0);
                filterPreview.RefreshFilter();
            }
            catch (Exception)
            {
            }
        }

        private void minBBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                blueSlider.Min = blue.Min = Math.Min(blue.Max, byte.Parse(minBBox.Text));
                UpdateFilter();
            }
            catch (Exception)
            {
            }
        }

        private void maxBBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                blueSlider.Max = blue.Max = Math.Max(blue.Min, byte.Parse(maxBBox.Text));
                UpdateFilter();
            }
            catch (Exception)
            {
            }
        }

        private void fillBBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                fillB = byte.Parse(fillBBox.Text);
                filter.FillBlue = fillB;
                blueSlider.FillColor = Color.FromArgb(0, 0, fillB);
                filterPreview.RefreshFilter();
            }
            catch (Exception)
            {
            }
        }

        private void redSlider_ValuesChanged(object sender, EventArgs e)
        {
            minRBox.Text = redSlider.Min.ToString();
            maxRBox.Text = redSlider.Max.ToString();
        }

        private void greenSlider_ValuesChanged(object sender, EventArgs e)
        {
            minGBox.Text = greenSlider.Min.ToString();
            maxGBox.Text = greenSlider.Max.ToString();
        }

        private void blueSlider_ValuesChanged(object sender, EventArgs e)
        {
            minBBox.Text = blueSlider.Min.ToString();
            maxBBox.Text = blueSlider.Max.ToString();
        }

        private void redFillTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            redSlider.Type = (redFillTypeCombo.SelectedIndex == 0) ? ColorSlider.ColorSliderType.InnerGradient : ColorSlider.ColorSliderType.OuterGradient;
            filter.RedFillOutsideRange = (redFillTypeCombo.SelectedIndex == 0);
            filterPreview.RefreshFilter();
        }

        private void greenFillTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            greenSlider.Type = (greenFillTypeCombo.SelectedIndex == 0) ? ColorSlider.ColorSliderType.InnerGradient : ColorSlider.ColorSliderType.OuterGradient;
            filter.GreenFillOutsideRange = (greenFillTypeCombo.SelectedIndex == 0);
            filterPreview.RefreshFilter();
        }

        private void blueFillTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            blueSlider.Type = (blueFillTypeCombo.SelectedIndex == 0) ? ColorSlider.ColorSliderType.InnerGradient : ColorSlider.ColorSliderType.OuterGradient;
            filter.BlueFillOutsideRange = blueFillTypeCombo.SelectedIndex == 0;
            filterPreview.RefreshFilter();
        }
    }
}
