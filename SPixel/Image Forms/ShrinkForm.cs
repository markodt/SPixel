using AForge.Imaging.Filters;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SPixel
{
    public partial class ShrinkForm : Form
    {
        private Shrink filter = new Shrink();
        private bool updating = false;
        private int redColor = 0, greenColor = 0, blueColor = 0;

        public IFilter Filter
        {
            get { return filter; }
        }

        public ShrinkForm()
        {
            InitializeComponent();

            redBox.Text = "0";
            greenBox.Text = "0";
            blueBox.Text = "0";

            UpdateFillColor();
        }

        private void UpdateFillColor()
        {
            try
            {
                colorBox.BackColor = colorBox.FlatAppearance.MouseDownBackColor
                    = colorBox.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, redColor, greenColor, blueColor);
                colorBox.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SPixel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool CheckRGBValue(int color)
        {
            if (color >= 0 && color <= 255)
            {
                return true;
            }
            else
            {
                MessageBox.Show(this, "Incorrect RGB value entered, must be 0-255!", "SPixel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        private void redBox_TextChanged(object sender, EventArgs e)
        {
            redColor = int.Parse(redBox.Text);
            if (!updating && CheckRGBValue(redColor))
                UpdateFillColor();
        }

        private void greenBox_TextChanged(object sender, EventArgs e)
        {
            greenColor = int.Parse(greenBox.Text);
            if (!updating && CheckRGBValue(greenColor))
                UpdateFillColor();
        }

        private void blueBox_TextChanged(object sender, EventArgs e)
        {
            blueColor = int.Parse(blueBox.Text);
            if (!updating && CheckRGBValue(blueColor))
                UpdateFillColor();
        }

        private void colorBox_MouseMove(object sender, MouseEventArgs e)
        {
            colorBox.Cursor = new Cursor(new System.IO.MemoryStream(SPixel.Properties.Resources.colorpicker));
        }

        private void colorBox_MouseDown(object sender, MouseEventArgs e)
        {
            colorBox.FlatAppearance.BorderSize = 0;
            colorBox.Size = new Size(68, 18);
            colorBox.Location = new Point(91, 52);
        }

        private void colorBox_MouseUp(object sender, MouseEventArgs e)
        {
            colorBox.Size = new Size(70, 20);
            colorBox.Location = new Point(90, 51);
            colorBox.FlatAppearance.BorderSize = 1;
        }

        private void colorBox_Click(object sender, EventArgs e)
        {
            this.ActiveControl = redBox;

            ColorDialog dialog = new ColorDialog();
            dialog.FullOpen = true;
            dialog.ShowHelp = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                colorBox.BackColor = colorBox.FlatAppearance.MouseDownBackColor
                    = colorBox.FlatAppearance.MouseOverBackColor = dialog.Color;
                updating = true;
                redBox.Text = dialog.Color.R.ToString();
                greenBox.Text = dialog.Color.G.ToString();
                blueBox.Text = dialog.Color.B.ToString();
                updating = false;
            }
        }

        private void colorBox_MouseClick(object sender, MouseEventArgs e)
        {
            colorBox.FlatAppearance.BorderSize = 1;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                filter.ColorToRemove = Color.FromArgb(
                    byte.Parse(redBox.Text),
                    byte.Parse(greenBox.Text),
                    byte.Parse(blueBox.Text));
            }
            catch (Exception)
            {
            }
        }
    }
}
