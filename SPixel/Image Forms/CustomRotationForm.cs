using AForge.Imaging.Filters;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SPixel
{
    public partial class CustomRotationForm : Form
    {
        private BaseRotateFilter filter = null;
        private int redColor = 0;
        private int greenColor = 0;
        private int blueColor = 0;
        private bool updating = false;

        public IFilter Filter
        {
            get { return filter; }
        }

        public CustomRotationForm()
        {
            InitializeComponent();

            angleBox.Text = "45";
            redBox.Text = "0";
            greenBox.Text = "0";
            blueBox.Text = "0";

            UpdateFillColor();

            methodCombo.SelectedIndex = 1;
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
            colorBox.Location = new Point(67, 44);
        }

        private void colorBox_MouseUp(object sender, MouseEventArgs e)
        {
            colorBox.Size = new Size(70, 20);
            colorBox.Location = new Point(66, 43);
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
                // get rotation angle
                double angle = double.Parse(angleBox.Text);

                // create appropriate rotation filter
                switch (methodCombo.SelectedIndex)
                {
                    case 0:
                        filter = new RotateNearestNeighbor(angle);
                        break;
                    case 1:
                        filter = new RotateBilinear(angle);
                        break;
                    case 2:
                        filter = new RotateBicubic(angle);
                        break;
                }

                // fill color
                filter.FillColor = Color.FromArgb(
                    byte.Parse(redBox.Text),
                    byte.Parse(greenBox.Text),
                    byte.Parse(blueBox.Text));

                // keep size
                filter.KeepSize = keepSizeCheck.Checked;

                // close dialog
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Incorrect values are entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
