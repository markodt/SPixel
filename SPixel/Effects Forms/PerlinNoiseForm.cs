using AForge.Imaging.Filters;
using AForge.Imaging.Textures;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SPixel
{
    public partial class PerlinNoiseForm : Form
    {
        private IFilter filter = null;

        private int imageWidth;
        private int imageHeight;

        public Bitmap Image
        {
            set
            {
                filterPreview.Image = value;
                imageWidth = value.Width;
                imageHeight = value.Height;
            }
        }

        public IFilter Filter
        {
            get { return filter; }
        }

        public PerlinNoiseForm()
        {
            InitializeComponent();

            effectComboBox.SelectedIndex = 0;
        }

        private void effectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (effectComboBox.SelectedIndex)
            {
                case 0:			// Marble effect
                    filter = new Texturer(new MarbleTexture(imageWidth / 96, imageHeight / 48), 0.7f, 0.3f);
                    break;
                case 1:			// Wood effect
                    filter = new Texturer(new WoodTexture(), 0.7f, 0.3f);
                    break;
                case 2:			// Clouds
                    filter = new Texturer(new CloudsTexture(), 0.7f, 0.3f);
                    break;
                case 3:			// Labyrinth
                    filter = new Texturer(new LabyrinthTexture(), 0.7f, 0.3f);
                    break;
                case 4:			// Textile
                    filter = new Texturer(new TextileTexture(), 0.7f, 0.3f);
                    break;
                case 5:			// Dirty
                    TexturedFilter f = new TexturedFilter(new CloudsTexture(), new Sepia());

                    f.PreserveLevel = 0.30f;
                    f.FilterLevel = 0.90f;

                    filter = f;

                    break;
                case 6:			// Rusty
                    filter = new TexturedFilter(new CloudsTexture(), new Sepia(), new GrayscaleBT709());

                    break;
            }

            filterPreview.Filter = filter;
        }
    }
}
