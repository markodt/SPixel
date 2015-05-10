using System.Windows.Forms;

namespace SPixel
{
    public partial class DoubleBufferDisplay : UserControl
    {
        public DoubleBufferDisplay()
        {
            this.DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        protected override bool IsInputKey(Keys keyData)
        {
            if (keyData == Keys.Right)
            {
                return true;
            }
            else if (keyData == Keys.Left)
            {
                return true;
            }
            if (keyData == Keys.Up)
            {
                return true;
            }
            else if (keyData == Keys.Down)
            {
                return true;
            }
            else
            {
                return base.IsInputKey(keyData);
            }
        }
    }
}
