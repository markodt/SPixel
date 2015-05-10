using AForge.Imaging.Filters;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SPixel
{
    public partial class EuclideanColorFilteringForm : Form
    {
        private EuclideanColorFiltering filter = new EuclideanColorFiltering();
        private byte red = 255, green = 255, blue = 255;
        private byte fillR = 0, fillG = 0, fillB = 0;
        private short radius = 100;
        private bool updating = false;

        public Bitmap Image
        {
            set { filterPreview.Image = value; }
        }

        public IFilter Filter
        {
            get { return filter; }
        }

        public EuclideanColorFilteringForm()
        {
            InitializeComponent();

            redBox.Text = red.ToString();
            greenBox.Text = green.ToString();
            blueBox.Text = blue.ToString();

            radiusBox.Text = radius.ToString();

            fillRBox.Text = fillR.ToString();
            fillGBox.Text = fillG.ToString();
            fillBBox.Text = fillB.ToString();

            fillTypeCombo.SelectedIndex = 0;

            filterPreview.Filter = filter;
        }

        private void redBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                red = byte.Parse(redBox.Text);
                redSlider.Min = red;
                UpdateCenterColor();
            }
            catch (Exception)
            {
            }
        }

        private void greenBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                green = byte.Parse(greenBox.Text);
                greenSlider.Min = green;
                UpdateCenterColor();
            }
            catch (Exception)
            {
            }
        }

        private void blueBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                blue = byte.Parse(blueBox.Text);
                blueSlider.Min = blue;
                UpdateCenterColor();
            }
            catch (Exception)
            {
            }
        }

        private void redSlider_ValuesChanged(object sender, EventArgs e)
        {
            redBox.Text = redSlider.Min.ToString();
        }

        private void greenSlider_ValuesChanged(object sender, EventArgs e)
        {
            greenBox.Text = greenSlider.Min.ToString();
        }

        private void blueSlider_ValuesChanged(object sender, EventArgs e)
        {
            blueBox.Text = blueSlider.Min.ToString();
        }

        private void UpdateCenterColor()
        {
            // update slider colors
            redSlider.StartColor = Color.FromArgb(0, green, blue);
            redSlider.EndColor = Color.FromArgb(255, green, blue);
            greenSlider.StartColor = Color.FromArgb(red, 0, blue);
            greenSlider.EndColor = Color.FromArgb(red, 255, blue);
            blueSlider.StartColor = Color.FromArgb(red, green, 0);
            blueSlider.EndColor = Color.FromArgb(red, green, 255);

            // update filter
            filter.CenterColor = Color.FromArgb(red, green, blue);
            filterPreview.RefreshFilter();
        }

        private void radiusBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                radius = Math.Max((short)1, Math.Min((short)450, short.Parse(radiusBox.Text)));

                radiusTrackBar.Value = filter.Radius = radius;
                filterPreview.RefreshFilter();
            }
            catch (Exception)
            {
            }
        }

        private void radiusTrackBar_Scroll(object sender, EventArgs e)
        {
            radiusBox.Text = radiusTrackBar.Value.ToString();
        }

        private void fillTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter.FillOutside = (fillTypeCombo.SelectedIndex == 0);
            filterPreview.RefreshFilter();
        }

        private void fillBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                fillR = byte.Parse(fillRBox.Text);
                fillG = byte.Parse(fillGBox.Text);
                fillB = byte.Parse(fillBBox.Text);

                if (!updating)
                {
                    colorBox.BackColor = colorBox.FlatAppearance.MouseDownBackColor
                        = colorBox.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, fillR, fillG, fillB);
                    colorBox.Refresh();

                    filter.FillColor = Color.FromArgb(fillR, fillG, fillB);
                    filterPreview.RefreshFilter();
                }
            }
            catch (Exception)
            {
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
                filter.FillColor = Color.FromArgb(dialog.Color.R, dialog.Color.G, dialog.Color.B);
                filterPreview.RefreshFilter();
                updating = false;
            }
        }

        private void colorBox_MouseClick(object sender, MouseEventArgs e)
        {
            colorBox.FlatAppearance.BorderSize = 1;
        }
    }
}
