using AForge;
using AForge.Controls;
using AForge.Imaging;
using AForge.Imaging.Filters;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SPixel
{
    public partial class ColorFilteringForm : Form
    {
        private ColorFiltering filter = new ColorFiltering();
        private IntRange red = new IntRange(0, 255);
        private IntRange green = new IntRange(0, 255);
        private IntRange blue = new IntRange(0, 255);
        private byte fillR = 0, fillG = 0, fillB = 0;
        private bool updating = false;

        public Bitmap Image
        {
            set { filterPreview.Image = value; }
        }

        public IFilter Filter
        {
            get { return filter; }
        }

        public ColorFilteringForm()
        {
            InitializeComponent();

            minRBox.Text = red.Min.ToString();
            maxRBox.Text = red.Max.ToString();
            fillRBox.Text = fillR.ToString();

            minGBox.Text = green.Min.ToString();
            maxGBox.Text = green.Max.ToString();
            fillGBox.Text = fillG.ToString();

            minBBox.Text = blue.Min.ToString();
            maxBBox.Text = blue.Max.ToString();
            fillBBox.Text = fillB.ToString();

            fillTypeCombo.SelectedIndex = 0;

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

        private void minGBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                greenSlider.Min = green.Min = Math.Min(green.Max, byte.Parse(minGBox.Text));
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

        private void fillRBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                fillR = byte.Parse(fillRBox.Text);
                if (!updating)
                {
                    UpdateColorBox();
                    UpdateFillColor();
                }
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
                if (!updating)
                {
                    UpdateColorBox();
                    UpdateFillColor();
                }
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
                if (!updating)
                {
                    UpdateColorBox();
                    UpdateFillColor();
                }
            }
            catch (Exception)
            {
            }
        }

        private void UpdateFillColor()
        {
            redSlider.FillColor = greenSlider.FillColor = blueSlider.FillColor = Color.FromArgb(fillR, fillG, fillB);
            filter.FillColor = new RGB(fillR, fillG, fillB);
            filterPreview.RefreshFilter();
        }

        private void UpdateColorBox()
        {
            colorBox.BackColor = colorBox.FlatAppearance.MouseDownBackColor
                = colorBox.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, fillR, fillG, fillB);
            colorBox.Refresh();
        }

        private void colorBox_Click(object sender, EventArgs e)
        {
            this.ActiveControl = fillRBox;

            ColorDialog dialog = new ColorDialog();
            dialog.FullOpen = true;
            dialog.ShowHelp = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                colorBox.BackColor = colorBox.FlatAppearance.MouseDownBackColor
                    = colorBox.FlatAppearance.MouseOverBackColor = dialog.Color;
                updating = true;
                fillRBox.Text = dialog.Color.R.ToString();
                fillGBox.Text = dialog.Color.G.ToString();
                fillBBox.Text = dialog.Color.B.ToString();
                redSlider.FillColor = greenSlider.FillColor = blueSlider.FillColor = Color.FromArgb(dialog.Color.R, dialog.Color.G, dialog.Color.B);
                filter.FillColor = new RGB(dialog.Color.R, dialog.Color.G, dialog.Color.B);
                filterPreview.RefreshFilter();
                updating = false;
            }
        }

        private void colorBox_MouseMove(object sender, MouseEventArgs e)
        {
            colorBox.Cursor = new Cursor(new System.IO.MemoryStream(SPixel.Properties.Resources.colorpicker));
        }

        private void colorBox_MouseDown(object sender, MouseEventArgs e)
        {
            colorBox.FlatAppearance.BorderSize = 0;
            colorBox.Size = new Size(68, 18);
            colorBox.Location = new Point(106, 50);
        }

        private void colorBox_MouseUp(object sender, MouseEventArgs e)
        {
            colorBox.Size = new Size(70, 20);
            colorBox.Location = new Point(105, 49);
            colorBox.FlatAppearance.BorderSize = 1;
        }

        private void colorBox_MouseClick(object sender, MouseEventArgs e)
        {
            colorBox.FlatAppearance.BorderSize = 1;
        }

        private void fillTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ColorSlider.ColorSliderType[] types = new ColorSlider.ColorSliderType[] { ColorSlider.ColorSliderType.InnerGradient, ColorSlider.ColorSliderType.OuterGradient };
            ColorSlider.ColorSliderType type = types[fillTypeCombo.SelectedIndex];

            redSlider.Type = type;
            greenSlider.Type = type;
            blueSlider.Type = type;

            filter.FillOutsideRange = (fillTypeCombo.SelectedIndex == 0);
            filterPreview.RefreshFilter();
        }
    }
}
