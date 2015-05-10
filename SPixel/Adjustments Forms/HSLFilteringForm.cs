using AForge;
using AForge.Controls;
using AForge.Imaging;
using AForge.Imaging.Filters;
using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace SPixel
{
    public partial class HSLFilteringForm : Form
    {
        private HSLFiltering filter = new HSLFiltering();
        private IntRange hue = new IntRange(0, 359);
        private DoubleRange saturation = new DoubleRange(0, 1);
        private DoubleRange luminance = new DoubleRange(0, 1);
        private int fillH = 0;
        private double fillS = 0, fillL = 0;

        public Bitmap Image
        {
            set { filterPreview.Image = value; }
        }

        public IFilter Filter
        {
            get { return filter; }
        }

        public HSLFilteringForm()
        {
            InitializeComponent();

            minHBox.Text = hue.Min.ToString();
            maxHBox.Text = hue.Max.ToString();
            fillHBox.Text = fillH.ToString();

            minSBox.Text = saturation.Min.ToString("F3", CultureInfo.InvariantCulture);
            maxSBox.Text = saturation.Max.ToString("F3", CultureInfo.InvariantCulture);
            fillSBox.Text = fillS.ToString("F3", CultureInfo.InvariantCulture);

            minLBox.Text = luminance.Min.ToString("F3", CultureInfo.InvariantCulture);
            maxLBox.Text = luminance.Max.ToString("F3", CultureInfo.InvariantCulture);
            fillLBox.Text = fillL.ToString("F3", CultureInfo.InvariantCulture);

            fillTypeCombo.SelectedIndex = 0;

            filterPreview.Filter = filter;
        }

        private void UpdateFilter()
        {
            filter.Hue = hue;
            filter.Saturation = saturation;
            filter.Luminance = luminance;
            filterPreview.RefreshFilter();
        }

        private void minHBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                huePicker.Min = hue.Min = Math.Max(0, Math.Min(359, int.Parse(minHBox.Text)));
                UpdateFilter();
            }
            catch (Exception)
            {
            }
        }

        private void maxHBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                huePicker.Max = hue.Max = Math.Max(0, Math.Min(359, int.Parse(maxHBox.Text)));
                UpdateFilter();
            }
            catch (Exception)
            {
            }
        }

        private void minSBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.minSBox.Text.Contains(','))
                {
                    MessageBox.Show(this, "Incorrect decimal separator, use dot ( . ) instead of comma ( , )!", "SPixel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                saturation.Min = double.Parse(minSBox.Text, CultureInfo.InvariantCulture);
                saturationSlider.Min = (int)(saturation.Min * 255);
                UpdateFilter();
            }
            catch (Exception)
            {
            }
        }

        private void maxSBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.maxSBox.Text.Contains(','))
                {
                    MessageBox.Show(this, "Incorrect decimal separator, use dot ( . ) instead of comma ( , )!", "SPixel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                saturation.Max = double.Parse(maxSBox.Text, CultureInfo.InvariantCulture);
                saturationSlider.Max = (int)(saturation.Max * 255);
                UpdateFilter();
            }
            catch (Exception)
            {
            }
        }

        private void minLBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.minLBox.Text.Contains(','))
                {
                    MessageBox.Show(this, "Incorrect decimal separator, use dot ( . ) instead of comma ( , )!", "SPixel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                luminance.Min = double.Parse(minLBox.Text, CultureInfo.InvariantCulture);
                luminanceSlider.Min = (int)(luminance.Min * 255);
                UpdateFilter();
            }
            catch (Exception)
            {
            }
        }

        private void maxLBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.maxLBox.Text.Contains(','))
                {
                    MessageBox.Show(this, "Incorrect decimal separator, use dot ( . ) instead of comma ( , )!", "SPixel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                luminance.Max = double.Parse(maxLBox.Text, CultureInfo.InvariantCulture);
                luminanceSlider.Max = (int)(luminance.Max * 255);
                UpdateFilter();
            }
            catch (Exception)
            {
            }
        }

        private void huePicker_ValuesChanged(object sender, EventArgs e)
        {
            minHBox.Text = huePicker.Min.ToString();
            maxHBox.Text = huePicker.Max.ToString();
        }

        private void saturationSlider_ValuesChanged(object sender, EventArgs e)
        {
            minSBox.Text = ((double)saturationSlider.Min / 255).ToString("F3", CultureInfo.InvariantCulture);
            maxSBox.Text = ((double)saturationSlider.Max / 255).ToString("F3", CultureInfo.InvariantCulture);
        }

        private void luminanceSlider_ValuesChanged(object sender, EventArgs e)
        {
            minLBox.Text = ((double)luminanceSlider.Min / 255).ToString("F3", CultureInfo.InvariantCulture);
            maxLBox.Text = ((double)luminanceSlider.Max / 255).ToString("F3", CultureInfo.InvariantCulture);
        }

        private void fillHBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                fillH = int.Parse(fillHBox.Text);
                UpdateFillColor();
            }
            catch (Exception)
            {
            }
        }

        private void fillSBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.fillSBox.Text.Contains(','))
                {
                    MessageBox.Show(this, "Incorrect decimal separator, use dot ( . ) instead of comma ( , )!", "SPixel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                fillS = double.Parse(fillSBox.Text, CultureInfo.InvariantCulture);
                UpdateFillColor();
            }
            catch (Exception)
            {
            }
        }

        private void fillLBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.fillLBox.Text.Contains(','))
                {
                    MessageBox.Show(this, "Incorrect decimal separator, use dot ( . ) instead of comma ( , )!", "SPixel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                fillL = double.Parse(fillLBox.Text, CultureInfo.InvariantCulture);
                UpdateFillColor();
            }
            catch (Exception)
            {
            }
        }
        private void UpdateFillColor()
        {
            int v;

            v = (int)(fillS * 255);
            saturationSlider.FillColor = Color.FromArgb(v, v, v);
            v = (int)(fillL * 255);
            luminanceSlider.FillColor = Color.FromArgb(v, v, v);


            filter.FillColor = new HSL(fillH, fillS, fillL);
            filterPreview.RefreshFilter();
        }

        private void updateHCheck_CheckedChanged(object sender, EventArgs e)
        {
            filter.UpdateHue = updateHCheck.Checked;
            filterPreview.RefreshFilter();
        }

        private void updateSCheck_CheckedChanged(object sender, EventArgs e)
        {
            filter.UpdateSaturation = updateSCheck.Checked;
            filterPreview.RefreshFilter();
        }

        private void updateLCheck_CheckedChanged(object sender, EventArgs e)
        {
            filter.UpdateLuminance = updateLCheck.Checked;
            filterPreview.RefreshFilter();
        }

        private void fillTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ColorSlider.ColorSliderType[] types = new ColorSlider.ColorSliderType[] { ColorSlider.ColorSliderType.InnerGradient, ColorSlider.ColorSliderType.OuterGradient };
            ColorSlider.ColorSliderType type = types[fillTypeCombo.SelectedIndex];

            saturationSlider.Type = type;
            luminanceSlider.Type = type;

            filter.FillOutsideRange = (fillTypeCombo.SelectedIndex == 0);
            filterPreview.RefreshFilter();
        }
    }
}
