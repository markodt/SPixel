using AForge;
using AForge.Imaging;
using AForge.Imaging.Filters;
using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace SPixel
{
    public partial class MainForm : Form
    {
        #region Fields

        private string imageFile;                                       // name of the file we want to display
        private ArrayList imageFiles;                                   // list which contains all image files in the current folder
        private int currentFileIndex = -1;                              // index of the currently used file, if the value is -1 there is no open file                    
        private FileInfo imageFileInfo;                                 // image file information
        private Bitmap bitmap;                                          // bitmap object of the image file we want to display
        private Bitmap deletedBitmap;                                   // image cleared from the screen (can be reopened)
        private Bitmap undoBitmap;                                      // bitmap for storing the state of the image before the last change
        private Bitmap zoomBitmap;                                      // bitmap for zooming
        private PointF position;                                        // point from which the image is drawn
        private float zoom = 1.00F;                                     // current image zoom
        private float zoomFactor = 1.00F;                               // zoom factor, used when changing image dimensions
        private bool fitImagesToWindow;                                 // size image to fit the window dimensions
        private bool deleteImage;                                       // clear image from the window
        private bool isDeleted;                                         // image is deleted/cleared
        private bool toGrayscale;                                       // convert image to 8 bpp grayscale
        private bool cropping;                                          // image cropping
        private bool cropped;                                           // image cropped
        private bool dragging;                                          // mouse drag
        private bool fullScreen;                                        // image is in full screen mode
        private bool croppingState;                                     // cropping state
        private bool centerImagesState;                                 // image centering state
        private bool fitImagesState;                                    // fit images to window state
        private bool toolBarShowState;                                  // toolbar visibility state
        private bool statusBarShowState;                                // status bar visibility state
        private int formTop;                                            // window top position
        private int formLeft;                                           // window left position
        private int formWidth;                                          // window width
        private int formHeight;                                         // window height
        private FormWindowState formState = FormWindowState.Normal;     // window state
        private const string Filter =                                   // filter for Open and Save dialogs
                                "All Supported Formats|*.jpg;*.jpeg;*.bmp;*.gif;*.png;*.tif;*.tiff|"
                                + "JPEG - Joint Photographic Experts Group|*.jpg;*.jpeg|"
                                + "BMP - Windows Bitmap|*.bmp|"
                                + "GIF - CompuServe Graphics Interchange Format|*.gif|"
                                + "PNG - Portable Network Graphics|*.png|"
                                + "TIFF - Tagged Image File Format|*.tif;*.tiff|"
                                + "All Files (*.*)|*.*";
        private Point bitmapPoint;                                      // image coordinates (x,y)
        private Point displayStartPoint;                                // cropping start point on the display
        private Point displayEndPoint;                                  // cropping end point on the display
        private Point cropStartPoint;                                   // cropping start point on the image
        private Point cropEndPoint;                                     // cropping end point on the image
        private Rectangle selection;                                    // cropping selection rectangle

        #endregion

        #region Constructor

        public MainForm()
        {
            InitializeComponent();

            this.printPreviewDialog.TopLevelControl.Text = "Print Preview";
            StatusLabelDimensions.Text = "No file loaded (use File->Open)";
            imageDisplay.Select();
        }

        #endregion

        #region Methods

        private void ProcessDirectory()
        {
            ArrayList fileTypes = new ArrayList();
            fileTypes.Add("*.JPG");
            fileTypes.Add("*.JPEG");
            fileTypes.Add("*.BMP");
            fileTypes.Add("*.GIF");
            fileTypes.Add("*.PNG");
            fileTypes.Add("*.TIF");

            imageFiles = new ArrayList();
            string[] files;
            foreach (string type in fileTypes)
            {
                files = Directory.GetFiles(Directory.GetCurrentDirectory(), type); if (files.Length > 0) imageFiles.AddRange(files);
            }
            if (imageFiles.Count > 0)
            {
                imageFiles.Sort(); if (imageFile != "") currentFileIndex = imageFiles.IndexOf(imageFile);
            }
            else
                currentFileIndex = -1;
        }

        private void ShowPicture()
        {
            try
            {
                if (isDeleted)
                {
                    bitmap = (Bitmap)deletedBitmap.Clone();
                }
                else
                {
                    FileStream st = File.Open(GetFilePath(), FileMode.Open, FileAccess.Read, FileShare.Read);
                    byte[] b = new byte[st.Length];
                    st.Read(b, 0, b.Length); MemoryStream ms = new MemoryStream(b);
                    bitmap = (Bitmap)System.Drawing.Image.FromStream(ms, true);
                    zoomBitmap = new Bitmap(bitmap, new Size(bitmap.Width, bitmap.Height));
                    deletedBitmap = (Bitmap)bitmap.Clone();
                }

                printImage.DocumentName = Path.GetFileName(GetFilePath()); if (bitmap.Width > bitmap.Height) printImage.DefaultPageSettings.Landscape = true;
                else printImage.DefaultPageSettings.Landscape = false;
                printPreviewDialog.PrintPreviewControl.Document.DefaultPageSettings = printImage.DefaultPageSettings;

                SetMenuItems(true); zoomFactor = 1.00F; this.imageDisplay.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SPixel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetFilePath()
        {
            if (currentFileIndex > imageFiles.Count - 1)
                currentFileIndex = 0;
            return imageFiles[currentFileIndex].ToString();
        }

        private void SetMenuItems(bool enabledState)
        {
            this.MenuItemSave.Enabled = this.MenuItemSaveAs.Enabled = this.MenuItemPrint.Enabled = this.MenuItemPrintPreview.Enabled =
                this.MenuItemPageSetup.Enabled = this.MenuItemZoom.Enabled = this.MenuItemImageProperties.Enabled = this.MenuItemFullScreen.Enabled =
                this.MenuItemDelete.Enabled = this.MenuItemHistogram.Enabled = this.MenuItemImageStatistics.Enabled = this.MenuItemCut.Enabled = this.MenuItemCopy.Enabled = enabledState;

            this.MenuItemImage.Visible = this.MenuItemAdjustments.Visible = this.MenuItemEffects.Visible = enabledState;

            this.toolStripButtonSaveAs.Enabled = this.toolStripButtonDelete.Enabled = this.toolStripButtonPrintImage.Enabled = this.toolStripButtonCrop.Enabled =
                 this.toolStripButtonActualSize.Enabled = this.toolStripButtonFitImages.Enabled = this.toolStripButtonRotateLeft.Enabled = this.toolStripButtonRotateRight.Enabled =
                 this.toolStripButtonFullScreen.Enabled = this.toolStripButtonImageProperties.Enabled = enabledState;

            if (imageFiles.Count > 1)
            {
                this.MenuItemPreviousImage.Enabled = this.MenuItemNextImage.Enabled = this.MenuItemFirstImage.Enabled =
                    this.MenuItemLastImage.Enabled = this.MenuItemRandomImage.Enabled =
                this.toolStripButtonPreviousImage.Enabled = this.toolStripButtonNextImage.Enabled = enabledState;
            }

            this.MenuItemZoom.Enabled = this.toolStripButtonZoomIn.Enabled = this.toolStripButtonZoomOut.Enabled = enabledState;
        }

        private void ShowStatusBarInfo()
        {
            StatusLabelDepth.Available = StatusLabelFileIndex.Available = StatusLabelZoom.Available =
                    StatusLabelFileSize.Available = StatusLabelDateTime.Available = true;

            StatusLabelDimensions.Text = bitmap.Width.ToString() + " x " + bitmap.Height.ToString();
            StatusLabelDimensions.BorderSides = ToolStripStatusLabelBorderSides.Right;

            string pixFormat = bitmap.PixelFormat.ToString();
            string bitDepth = ReturnBitDepth(pixFormat);
            StatusLabelDepth.Text = bitDepth;
            StatusLabelDepth.BorderSides = ToolStripStatusLabelBorderSides.Right;

            StatusLabelFileIndex.Text = (currentFileIndex + 1).ToString() + "/" + imageFiles.Count.ToString();
            StatusLabelFileIndex.BorderSides = ToolStripStatusLabelBorderSides.Right;

            NumberFormatInfo numberFormat = NumberFormatInfo.InvariantInfo;
            float zoomPercent = zoom * 100;
            StatusLabelZoom.Text = zoomPercent.ToString("#.00", numberFormat) + " %";
            StatusLabelZoom.BorderSides = ToolStripStatusLabelBorderSides.Right;

            imageFileInfo = new FileInfo(imageFiles[currentFileIndex].ToString());
            long byteSize = imageFileInfo.Length;
            float kiloByteSize = (float)byteSize / 1024F;
            float megaByteSize = kiloByteSize / 1024F;
            StatusLabelFileSize.Text = (kiloByteSize >= 1024F ? megaByteSize.ToString("#.00", numberFormat) + " MB" : kiloByteSize.ToString("#.00", numberFormat) + " KB");
            StatusLabelFileSize.BorderSides = ToolStripStatusLabelBorderSides.Right;

            StatusLabelDateTime.Text = imageFileInfo.CreationTimeUtc.ToString();
            StatusLabelDateTime.BorderSides = ToolStripStatusLabelBorderSides.Right;
        }

        private string ReturnBitDepth(string pixFormat)
        {
            string bitDepth = "";
            switch (pixFormat)
            {
                case "Format1bppIndexed":
                    bitDepth = "1 BPP";
                    break;
                case "Format4bppIndexed":
                    bitDepth = "4 BPP";
                    break;
                case "Format8bppIndexed":
                    bitDepth = "8 BPP";
                    break;
                case "Format16bppGrayScale":
                case "Format16bppRgb555":
                case "Format16bppRgb565":
                case "Format16bppArgb1555":
                    bitDepth = "16 BPP";
                    break;
                case "Format24bppRgb":
                    bitDepth = "24 BPP";
                    break;
                case "Format32bppRgb":
                case "Format32bppArgb":
                case "Format32bppPArgb":
                    bitDepth = "32 BPP";
                    break;
                case "Format48bppRgb":
                    bitDepth = "48 BPP";
                    break;
                case "Format64bppArgb":
                case "Format64bppPArgb":
                    bitDepth = "64 BPP";
                    break;
                default:
                    bitDepth = "Unknown pixel format";
                    break;
            }
            return bitDepth;
        }

        private void ResetForm()
        {
            StatusLabelDepth.Available = StatusLabelFileIndex.Available = StatusLabelZoom.Available =
            StatusLabelFileSize.Available = StatusLabelDateTime.Available = false;
            StatusLabelDimensions.Text = "No file loaded (use File->Open)";
            StatusLabelDimensions.BorderSides = ToolStripStatusLabelBorderSides.None;
            this.Text = "SPixel";
            this.MenuItemReopen.Enabled = true;
            this.MenuItemUndo.Enabled = false;
            this.toolStripButtonUndo.Enabled = false;
            SetMenuItems(false);
        }

        private void CheckZoom()
        {
            zoom = zoomFactor;
            if (zoom < 0.09F || zoom > 5.01F)
            {
                MessageBox.Show("Image zoom must be between 10 and 500% !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (zoom < 0.09F)
                    zoomFactor += 0.10F;
                else
                    zoomFactor -= 0.10F;
                zoom = zoomFactor;
            }
        }

        private void SaveImage(string filePath)
        {
            if (filePath == null || filePath.Length == 0)
                throw new Exception("Unspecified file name.");

            if (File.Exists(filePath) && (File.GetAttributes(filePath) & FileAttributes.ReadOnly) != 0)
                throw new Exception("File exists and is read-only!");

            ImageFormat format = FormatFromExtension(filePath);
            if (format == null)
                throw new Exception("Unsupported image format.");

            MemoryStream mss = new MemoryStream();
            FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite);

            if (format == ImageFormat.Jpeg)
            {
                ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
                ImageCodecInfo ici = null;
                foreach (ImageCodecInfo codec in codecs)
                {
                    if (codec.MimeType == "image/jpeg")
                        ici = codec;
                }
                EncoderParameters ep = new EncoderParameters(1);
                ep.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, (long)85);
                bitmap.Save(mss, ici, ep);
            }
            else
                bitmap.Save(mss, format);
            byte[] array = mss.ToArray();
            fs.Write(array, 0, array.Length);

            mss.Close();
            fs.Close();
            mss.Dispose();
            fs.Dispose();

            Stream st = File.Open(GetFilePath(), FileMode.Open, FileAccess.Read, FileShare.Read);
            byte[] b = new byte[st.Length];
            st.Read(b, 0, b.Length);
            MemoryStream ms = new MemoryStream(b);
            deletedBitmap = (Bitmap)System.Drawing.Image.FromStream(ms, true);
        }

        private ImageFormat FormatFromExtension(string ext)
        {
            if (ext.IndexOf('.') > 0)
                ext = ext.Substring(ext.LastIndexOf('.') + 1);
            switch (ext.ToLower())
            {
                case "jpg":
                case "jpeg":
                    return ImageFormat.Jpeg;
                case "bmp":
                    return ImageFormat.Bmp;
                case "gif":
                    return ImageFormat.Gif;
                case "png":
                    return ImageFormat.Png;
                case "tif":
                case "tiff":
                    return ImageFormat.Tiff;
            }
            return null;
        }

        public static Bitmap ColorToGrayscale(Bitmap bmp)
        {
            int w = bmp.Width,
                h = bmp.Height,
                r, ic, oc, bmpStride, outputStride, bytesPerPixel;
            PixelFormat pfIn = bmp.PixelFormat;
            ColorPalette palette;
            Bitmap output;
            BitmapData bmpData, outputData;

            output = new Bitmap(w, h, PixelFormat.Format8bppIndexed);

            palette = output.Palette;
            for (int i = 0; i < 256; i++)
            {
                Color tmp = Color.FromArgb(255, i, i, i);
                palette.Entries[i] = Color.FromArgb(255, i, i, i);
            }
            output.Palette = palette;

            if (pfIn == PixelFormat.Format8bppIndexed)
            {
                output = (Bitmap)bmp.Clone();

                output.Palette = palette;

                return output;
            }

            switch (pfIn)
            {
                case PixelFormat.Format24bppRgb: bytesPerPixel = 3; break;
                case PixelFormat.Format32bppArgb: bytesPerPixel = 4; break;
                case PixelFormat.Format32bppRgb: bytesPerPixel = 4; break;
                default: throw new InvalidOperationException("Image format not supported");
            }

            bmpData = bmp.LockBits(new Rectangle(0, 0, w, h), ImageLockMode.ReadOnly, pfIn);
            outputData = output.LockBits(new Rectangle(0, 0, w, h), ImageLockMode.WriteOnly, PixelFormat.Format8bppIndexed);
            bmpStride = bmpData.Stride;
            outputStride = outputData.Stride;

            unsafe
            {
                byte* bmpPtr = (byte*)bmpData.Scan0.ToPointer(),
                outputPtr = (byte*)outputData.Scan0.ToPointer();

                if (bytesPerPixel == 3)
                {
                    for (r = 0; r < h; r++)
                        for (ic = oc = 0; oc < w; ic += 3, ++oc)
                            outputPtr[r * outputStride + oc] = (byte)(int)
                                (0.299f * bmpPtr[r * bmpStride + ic] +
                                 0.587f * bmpPtr[r * bmpStride + ic + 1] +
                                 0.114f * bmpPtr[r * bmpStride + ic + 2]);
                }
                else
                {
                    for (r = 0; r < h; r++)
                        for (ic = oc = 0; oc < w; ic += 4, ++oc)
                            outputPtr[r * outputStride + oc] = (byte)(int)
                                ((bmpPtr[r * bmpStride + ic] / 255.0f) *
                                (0.299f * bmpPtr[r * bmpStride + ic + 1] +
                                 0.587f * bmpPtr[r * bmpStride + ic + 2] +
                                 0.114f * bmpPtr[r * bmpStride + ic + 3]));
                }
            }

            bmp.UnlockBits(bmpData);
            output.UnlockBits(outputData);

            return output;
        }

        private void SetUndo()
        {
            if (undoBitmap != null)
                undoBitmap.Dispose();
            undoBitmap = (Bitmap)bitmap.Clone();
        }

        public void ApplyFilter(IFilter filter)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                SetUndo();

                Bitmap newBitmap = filter.Apply(bitmap);
                if (cropped)
                    newBitmap = filter.Apply(zoomBitmap);

                if (toGrayscale)
                {
                    Bitmap tempBitmap = ColorToGrayscale(newBitmap);
                    bitmap = (Bitmap)tempBitmap.Clone();
                    tempBitmap.Dispose();
                    toGrayscale = false;
                }
                else
                {
                    bitmap = new Bitmap(newBitmap.Size.Width, newBitmap.Size.Height, PixelFormat.Format24bppRgb);
                    Graphics g = Graphics.FromImage(bitmap);
                    g.DrawImage(newBitmap, new Point(0, 0));
                    g.Dispose();
                }
                newBitmap.Dispose();
                MenuItemUndo.Enabled = true;
                toolStripButtonUndo.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SPixel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
            this.imageDisplay.Invalidate();
        }

        public void ApplyFilterInPlace(IInPlaceFilter filter)
        {
            try
            {
                SetUndo();
                filter.ApplyInPlace(bitmap);
                MenuItemUndo.Enabled = true;
                toolStripButtonUndo.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SPixel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.imageDisplay.Invalidate();
        }

        private Point CalculateMouseOverImagePosition(int mouseX, int mouseY)
        {
            Point point = new Point();
            if (zoomBitmap.Width <= imageDisplay.Width && zoomBitmap.Height <= imageDisplay.Height)
            {
                point.X = mouseX - (int)position.X;
                point.Y = mouseY - (int)position.Y;
            }
            else
            {
                if (fitImagesToWindow)
                {
                    point.X = mouseX - (int)position.X;
                    point.Y = mouseY - (int)position.Y;
                }
                else
                {
                    point.X = imageDisplay.AutoScrollOffset.X + mouseX - (int)position.X;
                    point.Y = imageDisplay.AutoScrollOffset.Y + mouseY - (int)position.Y;
                }
            }
            return point;
        }

        private string ColorsFromPixelFormat(string pixelFormat)
        {
            string colors = "";
            switch (pixelFormat)
            {
                case "Format1bppIndexed":
                    colors = "2 (1 bit per pixel)";
                    break;
                case "Format4bppIndexed":
                    colors = "16 (4 bits per pixel)";
                    break;
                case "Format8bppIndexed":
                    colors = "256 (8 bits per pixel)";
                    break;
                case "Format16bppGrayScale":
                case "Format16bppRgb555":
                case "Format16bppRgb565":
                case "Format16bppArgb1555":
                    colors = "65536 (16 bits per pixel)";
                    break;
                case "Format24bppRgb":
                    colors = "16777216 (24 bits per pixel)";
                    break;
                case "Format32bppRgb":
                case "Format32bppArgb":
                case "Format32bppPArgb":
                    colors = "16777216 (32 bits per pixel)";
                    break;
                default:
                    colors = "Unknown";
                    break;
            }
            return colors;
        }

        private void ExitFullScreen()
        {
            fullScreen = false;
            if (croppingState)
                cropping = true;
            else
                cropping = false;
            if (centerImagesState)
                MenuItemCenterImages.Checked = true;
            else
                MenuItemCenterImages.Checked = false;
            if (fitImagesState)
            {
                fitImagesToWindow = true;
                MenuItemFitImages.Checked = true;
            }
            else
            {
                fitImagesToWindow = false;
                MenuItemFitImages.Checked = false;
            }
            this.BackColor = SystemColors.ControlDark;
            imageDisplay.BackColor = SystemColors.ControlDark;
            this.mainMenu.Visible = true;
            if (toolBarShowState)
            {
                MenuItemShowToolbar.Checked = true;
                this.toolBar.Visible = true;
            }
            else
            {
                MenuItemShowToolbar.Checked = false;
                this.toolBar.Visible = false;
            }
            if (statusBarShowState)
            {
                MenuItemShowStatusBar.Checked = true;
                this.statusBar.Visible = true;
            }
            else
            {
                MenuItemShowStatusBar.Checked = false;
                this.statusBar.Visible = false;
            }
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.Top = formTop;
            this.Left = formLeft;
            this.WindowState = formState;
            this.Width = formWidth;
            this.Height = formHeight;
        }

        #endregion

        #region imageDisplay Paint event handler

        private void imageDisplay_Paint(object sender, PaintEventArgs e)
        {
            if (deleteImage)
            {
                bitmap = null;
                if (this.imageDisplay.AutoScroll)
                {
                    this.imageDisplay.AutoScroll = false;
                }
                ResetForm();
                isDeleted = true; deleteImage = false; return;
            }

            if (bitmap != null)
            {
                try
                {
                    Graphics g = e.Graphics; g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    if (cropped)
                    {
                        zoomFactor = 1.0F;
                        cropped = false;
                    }

                    if (bitmap.Width * zoomFactor <= imageDisplay.Width && bitmap.Height * zoomFactor <= imageDisplay.Height)
                    {
                        CheckZoom(); this.imageDisplay.AutoScroll = false;
                        if (MenuItemCenterImages.Checked)
                        {
                            position.X = (imageDisplay.Width - bitmap.Width * zoomFactor) / 2;
                            position.Y = (imageDisplay.Height - bitmap.Height * zoomFactor) / 2;
                        }
                        else
                        {
                            position.X = 0;
                            position.Y = 0;
                        }

                        g.DrawImage(bitmap, new RectangleF(position.X, position.Y, bitmap.Width * zoomFactor, bitmap.Height * zoomFactor));

                        if (fullScreen)
                        {
                            string fileIndex = " [" + (currentFileIndex + 1).ToString() + "/" + imageFiles.Count.ToString() + "]";
                            g.DrawString(GetFilePath() + fileIndex, new Font("Segoe UI", 10, GraphicsUnit.Point), Brushes.Lime, new Point(2, 2));
                        }

                        zoomBitmap = new Bitmap(bitmap, new Size((int)(bitmap.Width * zoomFactor), (int)(bitmap.Height * zoomFactor)));

                        this.Text = Path.GetFileName(GetFilePath()) + " - SPixel";
                    }
                    else
                    {
                        if (fitImagesToWindow)
                        {
                            this.imageDisplay.AutoScroll = false;

                            int maxWidth = imageDisplay.Width, maxHeight = imageDisplay.Height; int width = bitmap.Width, height = bitmap.Height;
                            float ratio = (float)width / (float)height;
                            width = maxWidth;
                            height = (int)Math.Floor(maxWidth / ratio);

                            if (height > maxHeight)
                            {
                                height = maxHeight;
                                width = (int)Math.Floor(maxHeight * ratio);
                            }

                            position.X = 0;
                            position.Y = 0;
                            if (MenuItemCenterImages.Checked)
                            {
                                if (height < imageDisplay.Height)
                                {
                                    position.X = 0;
                                    position.Y = (imageDisplay.Height - height) / 2;
                                }
                                else
                                {
                                    position.X = (imageDisplay.Width - width) / 2;
                                    position.Y = 0;
                                }
                            }

                            g.DrawImage(bitmap, new RectangleF(position.X, position.Y, width, height));

                            if (fullScreen)
                            {
                                string fileIndex = " [" + (currentFileIndex + 1).ToString() + "/" + imageFiles.Count.ToString() + "]";
                                g.DrawString(GetFilePath() + fileIndex, new Font("Segoe UI", 10, GraphicsUnit.Point), Brushes.Lime, new Point(2, 2));
                            }

                            zoomBitmap = new Bitmap(bitmap, new Size(width, height));

                            zoom = (float)Math.Min((float)width / bitmap.Width, (float)height / bitmap.Height);

                            this.Text = Path.GetFileName(GetFilePath()) + " - SPixel (Zoom: " + width.ToString() + " x " + height.ToString() + ")";
                        }
                        else
                        {
                            CheckZoom();
                            this.imageDisplay.AutoScroll = true;

                            float zoomWidth = (float)bitmap.Width * zoomFactor;
                            float zoomHeight = (float)bitmap.Height * zoomFactor;
                            Size zoomSize = new Size((int)zoomWidth, (int)zoomHeight);

                            this.imageDisplay.AutoScrollMinSize = zoomSize;
                            position.X = imageDisplay.AutoScrollPosition.X;
                            position.Y = imageDisplay.AutoScrollPosition.Y;

                            if (MenuItemCenterImages.Checked && (zoomSize.Height < imageDisplay.Height || zoomSize.Width < imageDisplay.Width))
                            {
                                if (zoomSize.Height < imageDisplay.Height)
                                {
                                    position.X = imageDisplay.AutoScrollPosition.X;
                                    position.Y = (imageDisplay.Height - zoomSize.Height) / 2;
                                }
                                else
                                {
                                    position.X = (imageDisplay.Width - zoomSize.Width) / 2;
                                    position.Y = imageDisplay.AutoScrollPosition.Y;
                                }
                            }

                            g.DrawImage(bitmap, new RectangleF(position.X, position.Y, zoomSize.Width, zoomSize.Height));

                            zoomBitmap = new Bitmap(bitmap, new Size(zoomSize.Width, zoomSize.Height));

                            this.Text = Path.GetFileName(GetFilePath()) + " - SPixel";
                        }
                    }
                    if (dragging)
                    {
                        Pen pen = Pens.Lime;
                        g.DrawRectangle(pen, selection);
                    }
                    else
                    {
                        ShowStatusBarInfo();

                        MenuItemReopen.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "SPixel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #region imageDisplay Mouse and DoubleClick event handlers

        private void imageDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            if (bitmap != null)
            {
                bitmapPoint = CalculateMouseOverImagePosition(e.X, e.Y);
                int posX = bitmapPoint.X, posY = bitmapPoint.Y;

                if (zoomBitmap.Width <= imageDisplay.Width && zoomBitmap.Height <= imageDisplay.Height)
                {
                    if (posX < 0 || posY < 0 || posX >= zoomBitmap.Width || posY >= zoomBitmap.Height ||
                        e.X < position.X || e.X > position.X + zoomBitmap.Width || e.Y < position.Y || e.Y > position.Y + zoomBitmap.Height)
                    {
                        StatusLabelMousePosition.Visible = false;
                        StatusLabelRGB.Visible = false;
                        StatusLabelHSL.Visible = false;
                        this.Cursor = Cursors.Default;
                        return;
                    }
                }
                else
                {
                    if (fitImagesToWindow)
                    {
                        int maxWidth = imageDisplay.Width, maxHeight = imageDisplay.Height;
                        int width = bitmap.Width, height = bitmap.Height;

                        float ratio = (float)width / (float)height;

                        width = maxWidth;
                        height = (int)Math.Floor(maxWidth / ratio);

                        if (height > maxHeight)
                        {
                            height = maxHeight;
                            width = (int)Math.Floor(maxHeight * ratio);
                        }

                        if (posX < 0 || posY < 0 || posX >= width || posY >= height ||
                            e.X < position.X || e.X > position.X + width || e.Y < position.Y || e.Y > position.Y + height)
                        {
                            StatusLabelMousePosition.Visible = false;
                            StatusLabelRGB.Visible = false;
                            StatusLabelHSL.Visible = false;
                            this.Cursor = Cursors.Default;
                            return;
                        }
                    }
                    else
                    {
                        if (posX < 0 || posY < 0 || posX >= zoomBitmap.Width || posY >= zoomBitmap.Height ||
                            e.X < position.X || e.X > position.X + zoomBitmap.Width || e.Y < position.Y || e.Y > position.Y + zoomBitmap.Height)
                        {
                            StatusLabelMousePosition.Visible = false;
                            StatusLabelRGB.Visible = false;
                            StatusLabelHSL.Visible = false;
                            this.Cursor = Cursors.Default;
                            return;
                        }
                    }
                }

                Color color = zoomBitmap.GetPixel(posX, posY);
                RGB rgbColor = new RGB(color);
                HSL hslColor = HSL.FromRGB(rgbColor);

                StatusLabelMousePosition.Visible = true;
                StatusLabelMousePosition.Text = "X: " + posX.ToString() + " Y: " + posY.ToString();

                StatusLabelRGB.Visible = true;
                StatusLabelRGB.Text = "R: " + rgbColor.Red.ToString() + " G: " + rgbColor.Green.ToString() + " B: " + rgbColor.Blue.ToString();

                StatusLabelHSL.Visible = true;
                StatusLabelHSL.Text = "H: " + hslColor.Hue.ToString() + " S: " + hslColor.Saturation.ToString("0.000", CultureInfo.InvariantCulture) + " L: " + hslColor.Luminance.ToString("0.000", CultureInfo.InvariantCulture);

                if (cropping)
                {
                    this.Cursor = Cursors.Cross;
                    if (dragging)
                    {
                        displayEndPoint = e.Location;
                        cropEndPoint = bitmapPoint;

                        selection.Width = displayEndPoint.X - selection.X;
                        selection.Height = displayEndPoint.Y - selection.Y;

                        this.imageDisplay.Invalidate();
                    }
                }
            }
        }

        private void imageDisplay_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (cropping && this.Cursor == Cursors.Cross)
                {
                    dragging = true;

                    displayStartPoint = e.Location;
                    cropStartPoint = bitmapPoint;

                    selection = new Rectangle(new Point(displayStartPoint.X, displayStartPoint.Y), new Size());
                }
            }
        }

        private void imageDisplay_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (dragging)
                {
                    displayEndPoint = e.Location;

                    if (displayEndPoint.X > displayStartPoint.X && displayEndPoint.Y > displayStartPoint.Y)
                    {
                        cropped = true;
                        if (bitmap.PixelFormat == PixelFormat.Format8bppIndexed)
                            toGrayscale = true;
                        ApplyFilter(new Crop(new Rectangle(cropStartPoint.X, cropStartPoint.Y, cropEndPoint.X - cropStartPoint.X + 1, cropEndPoint.Y - cropStartPoint.Y + 1)));
                    }

                    cropping = dragging = false;
                    this.Cursor = Cursors.Default;
                    MenuItemCrop.Checked = toolStripButtonCrop.Checked = false;
                }
            }
        }

        private void imageDisplay_MouseLeave(object sender, EventArgs e)
        {
            StatusLabelMousePosition.Visible = false;
            StatusLabelRGB.Visible = false;
            StatusLabelHSL.Visible = false;
            this.Cursor = Cursors.Default;
        }

        private void imageDisplay_DoubleClick(object sender, EventArgs e)
        {
            if (fullScreen)
                ExitFullScreen();
            else
                MenuItemFullScreen_Click(sender, e);
        }

        #endregion

        #region printImage PrintPage event handler

        private void printImage_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                Graphics g = e.Graphics;
                Rectangle rcImage = new Rectangle(0, 0, 0, 0);

                if (bitmap.Width <= e.MarginBounds.Width && bitmap.Height <= e.MarginBounds.Height)
                {
                    rcImage.X = (int)(e.MarginBounds.Width / 2 - bitmap.Width / 2 + e.MarginBounds.X);
                    rcImage.Y = (int)(e.MarginBounds.Height / 2 - bitmap.Height / 2 + e.MarginBounds.Y);

                    rcImage.Width = bitmap.Width;
                    rcImage.Height = bitmap.Height;
                }
                else
                {
                    int maxWidth = e.MarginBounds.Width, maxHeight = e.MarginBounds.Height; int width = bitmap.Width, height = bitmap.Height;
                    float ratio = (float)width / (float)height;

                    width = maxWidth;
                    height = (int)Math.Floor(maxWidth / ratio);

                    if (height > maxHeight)
                    {
                        height = maxHeight;
                        width = (int)Math.Floor(maxHeight * ratio);
                    }

                    if (height < e.MarginBounds.Height)
                    {
                        rcImage.X = e.MarginBounds.X;
                        rcImage.Y = (int)(e.MarginBounds.Height / 2 - height / 2 + e.MarginBounds.Y);
                    }
                    else
                    {
                        rcImage.X = (int)(e.MarginBounds.Width / 2 - width / 2 + e.MarginBounds.X);
                        rcImage.Y = e.MarginBounds.Y;
                    }

                    rcImage.Width = width;
                    rcImage.Height = height;
                }

                g.DrawImage(bitmap, rcImage, 0, 0, bitmap.Width, bitmap.Height, GraphicsUnit.Pixel);

                e.HasMorePages = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SPixel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region MainForm Click event handlers

        private void MenuItemOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Open Image File";
            openFileDialog.Filter = Filter;
            openFileDialog.Multiselect = false;
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imageFile = openFileDialog.FileName; Directory.SetCurrentDirectory(Directory.GetParent(imageFile).FullName.ToString()); ProcessDirectory(); zoomFactor = 1.00F; isDeleted = false;
                    if (currentFileIndex != -1)
                        ShowPicture();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SPixel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MenuItemReopen_Click(object sender, EventArgs e)
        {
            ShowPicture();
            isDeleted = false;
        }

        private void MenuItemSave_Click(object sender, EventArgs e)
        {
            string filePath = GetFilePath(); try
            {
                SaveImage(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SPixel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MenuItemSaveAs_Click(object sender, EventArgs e)
        {
            string filePath = GetFilePath();
            string fileName = Path.GetFileName(filePath);

            saveFileDialog.Title = "Save Image As";
            saveFileDialog.Filter = Filter;
            saveFileDialog.FileName = fileName;
            saveFileDialog.OverwritePrompt = true;
            saveFileDialog.AddExtension = true;
            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = saveFileDialog.FileName;
                    filePath = Path.GetFullPath(fileName);

                    SaveImage(filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SPixel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MenuItemPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printImage.Print();
                }
            }
            catch (InvalidPrinterException ex)
            {
                MessageBox.Show(ex.Message, "SPixel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MenuItemPrintPreview_Click(object sender, EventArgs e)
        {
            printPreviewDialog.ShowDialog();
        }

        private void MenuItemPageSetup_Click(object sender, EventArgs e)
        {
            pageSetupDialog.ShowDialog();
        }

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuItemUndo_Click(object sender, EventArgs e)
        {
            if (undoBitmap != null)
            {
                bitmap = (Bitmap)undoBitmap.Clone();
                undoBitmap.Dispose();
                MenuItemUndo.Enabled = false;
                toolStripButtonUndo.Enabled = false;
                imageDisplay.Invalidate();
            }
        }

        private void MenuItemCut_Click(object sender, EventArgs e)
        {
            if (bitmap != null)
            {
                Clipboard.SetDataObject(bitmap, true);
                deleteImage = true;
                this.imageDisplay.Invalidate();
            }
            else
                MessageBox.Show(this, "There is no image to cut!", "SPixel", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MenuItemCopy_Click(object sender, EventArgs e)
        {
            if (bitmap != null)
            {
                Clipboard.SetDataObject(bitmap, true);
            }
            else
                MessageBox.Show(this, "There is no image to copy!", "SPixel", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MenuItemPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Bitmap))
            {
                if (bitmap != null)
                {
                    this.MenuItemPreviousImage.Enabled = this.MenuItemNextImage.Enabled = this.MenuItemFirstImage.Enabled =
                    this.MenuItemLastImage.Enabled = this.MenuItemRandomImage.Enabled =
                    this.toolStripButtonPreviousImage.Enabled = this.toolStripButtonNextImage.Enabled = false;
                }

                Bitmap newBitmap = (Bitmap)Clipboard.GetDataObject().GetData(DataFormats.Bitmap);
                bitmap = newBitmap.Clone(new Rectangle(0, 0, newBitmap.Width, newBitmap.Height), PixelFormat.Format24bppRgb);
                newBitmap.Dispose();

                string drive = Environment.GetEnvironmentVariable("SystemDrive");
                Directory.CreateDirectory(drive + "\\Temp");
                string filePath = drive + "\\Temp\\Clipboard.bmp";
                SaveImage(filePath);
                imageFile = filePath;
                Directory.SetCurrentDirectory(Directory.GetParent(imageFile).FullName.ToString());
                ProcessDirectory();
                zoomFactor = 1.00F;
                isDeleted = false;
                ShowPicture();
            }
            else
                MessageBox.Show(this, "There is no image to paste!", "SPixel", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MenuItemShowToolbar_Click(object sender, EventArgs e)
        {
            if (MenuItemShowToolbar.Checked)
                toolBar.Visible = true;
            else
                toolBar.Visible = false;
        }

        private void MenuItemShowStatusBar_Click(object sender, EventArgs e)
        {
            if (MenuItemShowStatusBar.Checked)
                statusBar.Visible = true;
            else
                statusBar.Visible = false;
        }

        private void MenuItemNextImage_Click(object sender, EventArgs e)
        {
            bitmap.Dispose(); deletedBitmap.Dispose();
            currentFileIndex++;
            if (currentFileIndex >= imageFiles.Count)
                currentFileIndex = 0;
            ShowPicture();
        }

        private void MenuItemPreviousImage_Click(object sender, EventArgs e)
        {
            bitmap.Dispose();
            deletedBitmap.Dispose();
            currentFileIndex--;
            if (currentFileIndex < 0)
                currentFileIndex = imageFiles.Count - 1;
            ShowPicture();
        }

        private void MenuItemFirstImage_Click(object sender, EventArgs e)
        {
            bitmap.Dispose();
            deletedBitmap.Dispose();
            currentFileIndex = 0;
            ShowPicture();
        }

        private void MenuItemLastImage_Click(object sender, EventArgs e)
        {
            bitmap.Dispose();
            deletedBitmap.Dispose();
            currentFileIndex = imageFiles.Count - 1;
            ShowPicture();
        }

        private void MenuItemRandomImage_Click(object sender, EventArgs e)
        {
            bitmap.Dispose();
            deletedBitmap.Dispose();
            Random random = new Random();
            currentFileIndex = random.Next(imageFiles.Count); ShowPicture();
        }

        private void MenuItemZoomIn_Click(object sender, EventArgs e)
        {
            zoomFactor += 0.10F;
            this.imageDisplay.Invalidate();
        }

        private void MenuItemZoomOut_Click(object sender, EventArgs e)
        {
            zoomFactor -= 0.10F;
            this.imageDisplay.Invalidate();
        }

        private void MenuItem10_Click(object sender, EventArgs e)
        {
            zoomFactor = 0.10F;
            this.imageDisplay.Invalidate();
        }

        private void MenuItem25_Click(object sender, EventArgs e)
        {
            zoomFactor = 0.25F;
            this.imageDisplay.Invalidate();
        }

        private void MenuItem50_Click(object sender, EventArgs e)
        {
            zoomFactor = 0.50F;
            this.imageDisplay.Invalidate();
        }

        private void MenuItem75_Click(object sender, EventArgs e)
        {
            zoomFactor = 0.75F;
            this.imageDisplay.Invalidate();
        }

        private void MenuItemActualSize_Click(object sender, EventArgs e)
        {
            zoomFactor = 1.00F;
            this.imageDisplay.Invalidate();
        }

        private void MenuItem150_Click(object sender, EventArgs e)
        {
            zoomFactor = 1.50F;
            this.imageDisplay.Invalidate();
        }

        private void MenuItem200_Click(object sender, EventArgs e)
        {
            zoomFactor = 2.00F;
            this.imageDisplay.Invalidate();
        }

        private void MenuItem400_Click(object sender, EventArgs e)
        {
            zoomFactor = 4.00F;
            this.imageDisplay.Invalidate();
        }

        private void MenuItem500_Click(object sender, EventArgs e)
        {
            zoomFactor = 5.00F;
            this.imageDisplay.Invalidate();
        }

        private void MenuItemFullScreen_Click(object sender, EventArgs e)
        {
            croppingState = cropping;
            centerImagesState = MenuItemCenterImages.Checked;
            fitImagesState = fitImagesToWindow;
            toolBarShowState = MenuItemShowToolbar.Checked;
            statusBarShowState = MenuItemShowStatusBar.Checked;
            formTop = this.Top;
            formLeft = this.Left;
            formWidth = this.Width;
            formHeight = this.Height;
            formState = this.WindowState;
            fullScreen = true;
            cropping = false;
            this.Cursor = Cursors.Default;
            MenuItemCenterImages.Checked = true;
            fitImagesToWindow = true;
            this.BackColor = Color.Black;
            imageDisplay.BackColor = Color.Black;
            this.mainMenu.Visible = false;
            this.toolBar.Visible = false;
            this.statusBar.Visible = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Top = 0;
            this.Left = 0;
            this.WindowState = FormWindowState.Normal;
            this.WindowState = FormWindowState.Maximized;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;
        }

        private void MenuItemDelete_Click(object sender, EventArgs e)
        {
            deleteImage = true;
            this.imageDisplay.Invalidate();
        }

        private void MenuItemCenterImages_Click(object sender, EventArgs e)
        {
            this.imageDisplay.Invalidate();
        }

        private void MenuItemFitImages_Click(object sender, EventArgs e)
        {
            if (fitImagesToWindow)
            {
                MenuItemFitImages.Checked = toolStripButtonFitImages.Checked = false;
                fitImagesToWindow = false;
            }
            else
            {
                MenuItemFitImages.Checked = toolStripButtonFitImages.Checked = true;
                fitImagesToWindow = true;
            }
            this.imageDisplay.Invalidate();
        }

        private void MenuItemImageProperties_Click(object sender, EventArgs e)
        {
            string filename = Path.GetFileName(GetFilePath());
            string directory = Directory.GetCurrentDirectory();

            ImageFormat imageFormat = FormatFromExtension(GetFilePath());
            string compression = "";
            switch (imageFormat.ToString())
            {
                case "Jpeg":
                    compression = "JPEG";
                    break;
                case "Bmp":
                case "Tiff":
                    compression = "None";
                    break;
                case "Gif":
                    compression = "GIF - LZW";
                    break;
                case "Png":
                    compression = "PNG - ZIP";
                    break;
                default:
                    compression = "Unknown";
                    break;
            }

            string resolution = bitmap.HorizontalResolution.ToString() + " x " + bitmap.VerticalResolution.ToString() + " DPI";
            string originalSize = deletedBitmap.Width.ToString() + " x " + deletedBitmap.Height.ToString() + " pixels";
            string currentSize = bitmap.Width.ToString() + " x " + bitmap.Height.ToString() + " pixels";

            PixelFormat pixelFormatOriginal = deletedBitmap.PixelFormat;
            PixelFormat pixelFormatCurrent = bitmap.PixelFormat;
            string originalColors = ColorsFromPixelFormat(pixelFormatOriginal.ToString());
            string currentColors = ColorsFromPixelFormat(pixelFormatCurrent.ToString());

            imageFileInfo = new FileInfo(imageFiles[currentFileIndex].ToString());
            long byteSize = imageFileInfo.Length;
            float kiloByteSize = (float)byteSize / 1024F;
            float megaByteSize = kiloByteSize / 1024F;
            string diskSize = (kiloByteSize >= 1024F ? megaByteSize.ToString("#.00", CultureInfo.InvariantCulture) + " MB" : kiloByteSize.ToString("#.00", CultureInfo.InvariantCulture) + " KB") + " (" + byteSize.ToString() + " bytes)";

            string pixelFormat = pixelFormatCurrent.ToString();
            string bpp = ReturnBitDepth(pixelFormat);
            float currentBitSize = (float)bitmap.Width * (float)bitmap.Height * (float)Int32.Parse(bpp.Remove(bpp.IndexOf(" ")));
            float currentByteSize = currentBitSize / 8F;
            float currentKiloByteSize = currentByteSize / 1024F;
            float currentMegaByteSize = currentKiloByteSize / 1024F;
            string currentMemorySize = (currentKiloByteSize >= 1024F ? currentMegaByteSize.ToString("#.00", CultureInfo.InvariantCulture) + " MB" : currentKiloByteSize.ToString("#.00", CultureInfo.InvariantCulture) + " KB") + " (" + currentByteSize.ToString() + " bytes)";

            string currentDirectoryIndex = (currentFileIndex + 1).ToString() + " / " + imageFiles.Count.ToString();
            string fileDateTime = imageFileInfo.CreationTimeUtc.ToString();

            string[] properties = new string[12];
            properties[0] = filename;
            properties[1] = directory;
            properties[2] = compression;
            properties[3] = resolution;
            properties[4] = originalSize;
            properties[5] = currentSize;
            properties[6] = originalColors;
            properties[7] = currentColors;
            properties[8] = diskSize;
            properties[9] = currentMemorySize;
            properties[10] = currentDirectoryIndex;
            properties[11] = fileDateTime;

            ImageProperties form = new ImageProperties(properties);
            form.ShowDialog();
        }

        private void MenuItemHistogram_Click(object sender, EventArgs e)
        {
            HistogramWindow histogramWin = new HistogramWindow();
            histogramWin.GatherStatistics(bitmap);
            histogramWin.ShowDialog();
        }

        private void MenuItemImageStatistics_Click(object sender, EventArgs e)
        {
            if (bitmap.PixelFormat != PixelFormat.Format24bppRgb)
            {
                MessageBox.Show("Image statistics is available for 24 bpp RGB images only!", "SPixel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            ImageStatisticsWindow statisticsWin = new ImageStatisticsWindow();
            statisticsWin.GatherStatistics(bitmap);
            statisticsWin.ShowDialog();
        }

        private void MenuItemRotateLeft_Click(object sender, EventArgs e)
        {
            SetUndo();
            bitmap.RotateFlip(RotateFlipType.Rotate270FlipNone);
            MenuItemUndo.Enabled = true;
            toolStripButtonUndo.Enabled = true;
            this.imageDisplay.Invalidate();
        }

        private void MenuItemRotateRight_Click(object sender, EventArgs e)
        {
            SetUndo();
            bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
            MenuItemUndo.Enabled = true;
            toolStripButtonUndo.Enabled = true;
            this.imageDisplay.Invalidate();
        }

        private void MenuItemCustomRotation_Click(object sender, EventArgs e)
        {
            CustomRotationForm form = new CustomRotationForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (bitmap.PixelFormat == PixelFormat.Format8bppIndexed)
                    toGrayscale = true;
                ApplyFilter(form.Filter);
            }
        }

        private void MenuItemHorizontalFlip_Click(object sender, EventArgs e)
        {
            SetUndo();
            bitmap.RotateFlip(RotateFlipType.RotateNoneFlipX);
            MenuItemUndo.Enabled = true;
            toolStripButtonUndo.Enabled = true;
            this.imageDisplay.Invalidate();
        }

        private void MenuItemVerticalFlip_Click(object sender, EventArgs e)
        {
            SetUndo();
            bitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);
            MenuItemUndo.Enabled = true;
            toolStripButtonUndo.Enabled = true;
            this.imageDisplay.Invalidate();
        }

        private void MenuItemResize_Click(object sender, EventArgs e)
        {
            Size bitmapSize = bitmap.Size;
            ResizeForm form = new ResizeForm(bitmapSize);

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (bitmap.PixelFormat == PixelFormat.Format8bppIndexed)
                    toGrayscale = true;
                ApplyFilter(form.Filter);
            }
        }

        private void MenuItemCrop_Click(object sender, EventArgs e)
        {
            if (cropping)
            {
                cropping = false;
                MenuItemCrop.Checked = toolStripButtonCrop.Checked = false;
                this.Cursor = Cursors.Default;
            }
            else
            {
                cropping = true;
                MenuItemCrop.Checked = toolStripButtonCrop.Checked = true;
            }
        }

        private void MenuItemShrink_Click(object sender, EventArgs e)
        {
            ShrinkForm form = new ShrinkForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (bitmap.PixelFormat == PixelFormat.Format8bppIndexed)
                    toGrayscale = true;
                ApplyFilter(form.Filter);
            }
        }

        private void MenuItemColorFiltering_Click(object sender, EventArgs e)
        {
            if (bitmap.PixelFormat != PixelFormat.Format24bppRgb)
            {
                MessageBox.Show("Color filtering can be applied to 24 bpp RGB images only!", "SPixel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ColorFilteringForm form = new ColorFilteringForm();
            form.Image = bitmap;

            if (form.ShowDialog() == DialogResult.OK)
            {
                ApplyFilter(form.Filter);
            }
        }

        private void MenuItemEucledianColorFiltering_Click(object sender, EventArgs e)
        {
            if (bitmap.PixelFormat != PixelFormat.Format24bppRgb)
            {
                MessageBox.Show("Euclidean color filtering can be applied to 24 bpp RGB images only!", "SPixel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            EuclideanColorFilteringForm form = new EuclideanColorFilteringForm();
            form.Image = bitmap;

            if (form.ShowDialog() == DialogResult.OK)
            {
                ApplyFilter(form.Filter);
            }
        }

        private void MenuItemChannelsFiltering_Click(object sender, EventArgs e)
        {
            if (bitmap.PixelFormat != PixelFormat.Format24bppRgb)
            {
                MessageBox.Show("Channels filtering can be applied to 24 bpp RGB images only!", "SPixel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ChannelFilteringForm form = new ChannelFilteringForm();
            form.Image = bitmap;

            if (form.ShowDialog() == DialogResult.OK)
            {
                ApplyFilter(form.Filter);
            }
        }

        private void MenuItemExtractRedChannel_Click(object sender, EventArgs e)
        {
            ApplyFilter(new ExtractChannel(RGB.R));
        }

        private void MenuItemExtractGreenChannel_Click(object sender, EventArgs e)
        {
            ApplyFilter(new ExtractChannel(RGB.G));
        }

        private void MenuItemExtractBlueChannel_Click(object sender, EventArgs e)
        {
            ApplyFilter(new ExtractChannel(RGB.B));
        }

        private void MenuItemBrightness_Click(object sender, EventArgs e)
        {
            if (bitmap.PixelFormat != PixelFormat.Format24bppRgb)
            {
                MessageBox.Show("Brightness adjustment using HSL color space is available for 24 bpp RGB images only!", "SPixel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            BrightnessForm form = new BrightnessForm();
            form.Image = bitmap;

            if (form.ShowDialog() == DialogResult.OK)
            {
                ApplyFilter(form.Filter);
            }
        }

        private void MenuItemContrast_Click(object sender, EventArgs e)
        {
            if (bitmap.PixelFormat != PixelFormat.Format24bppRgb)
            {
                MessageBox.Show("Contrast adjustment using HSL color space is available for 24 bpp RGB images only!", "SPixel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ContrastForm form = new ContrastForm();
            form.Image = bitmap;

            if (form.ShowDialog() == DialogResult.OK)
            {
                ApplyFilter(form.Filter);
            }
        }

        private void MenuItemSaturation_Click(object sender, EventArgs e)
        {
            if (bitmap.PixelFormat != PixelFormat.Format24bppRgb)
            {
                MessageBox.Show("Saturation adjustment using HSL color space is available for 24 bpp RGB images only!", "SPixel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            SaturationForm form = new SaturationForm();
            form.Image = bitmap;

            if (form.ShowDialog() == DialogResult.OK)
            {
                ApplyFilter(form.Filter);
            }
        }

        private void MenuItemGammaCorrection_Click(object sender, EventArgs e)
        {
            GammaCorrectionForm form = new GammaCorrectionForm();

            form.Image = bitmap;

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (bitmap.PixelFormat == PixelFormat.Format8bppIndexed)
                    toGrayscale = true;
                ApplyFilter(form.Filter);
            }
        }

        private void MenuItemHSLFiltering_Click(object sender, EventArgs e)
        {
            if (bitmap.PixelFormat != PixelFormat.Format24bppRgb)
            {
                MessageBox.Show("HSL filtering is available for 24 bpp RGB images only!", "SPixel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            HSLFilteringForm form = new HSLFilteringForm();
            form.Image = bitmap;

            if (form.ShowDialog() == DialogResult.OK)
            {
                ApplyFilter(form.Filter);
            }
        }

        private void MenuItemHueModifier_Click(object sender, EventArgs e)
        {
            if (bitmap.PixelFormat != PixelFormat.Format24bppRgb)
            {
                MessageBox.Show("Hue modifier is available for 24 bpp RGB images only!", "SPixel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            HueModifierForm form = new HueModifierForm();
            form.Image = bitmap;

            if (form.ShowDialog() == DialogResult.OK)
            {
                ApplyFilter(form.Filter);
            }
        }

        private void MenuItemGrayscale_Click(object sender, EventArgs e)
        {
            ImageFormat format = FormatFromExtension(GetFilePath());

            if (bitmap.PixelFormat == PixelFormat.Format8bppIndexed || bitmap.PixelFormat == PixelFormat.Format16bppGrayScale)
            {
                if (format == ImageFormat.Gif)
                {
                    MessageBox.Show("Source pixel format is not supported by the filter.", "SPixel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("The image is already grayscale!", "SPixel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            toGrayscale = true;
            ApplyFilter(new GrayscaleBT709());
        }

        private void MenuItemSepia_Click(object sender, EventArgs e)
        {
            ApplyFilterInPlace(new Sepia());
        }

        private void MenuItemNegative_Click(object sender, EventArgs e)
        {
            ApplyFilterInPlace(new Invert());
        }

        private void MenuItemBlur_Click(object sender, EventArgs e)
        {
            ApplyFilterInPlace(new Blur());
        }

        private void MenuItemSharpen_Click(object sender, EventArgs e)
        {
            ApplyFilterInPlace(new Sharpen());
        }

        private void MenuItemGaussianBlur_Click(object sender, EventArgs e)
        {
            GaussianBlurForm form = new GaussianBlurForm();

            form.Image = bitmap;

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (bitmap.PixelFormat == PixelFormat.Format8bppIndexed)
                    toGrayscale = true;
                ApplyFilter(form.Filter);
            }
        }

        private void MenuItemGaussianSharpen_Click(object sender, EventArgs e)
        {
            GaussianSharpenForm form = new GaussianSharpenForm();

            form.Image = bitmap;

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (bitmap.PixelFormat == PixelFormat.Format8bppIndexed)
                    toGrayscale = true;
                ApplyFilter(form.Filter);
            }
        }

        private void MenuItemRotateRGBChannels_Click(object sender, EventArgs e)
        {
            ApplyFilterInPlace(new RotateChannels());
        }

        private void MenuItemRed_Click(object sender, EventArgs e)
        {
            ApplyFilterInPlace(new ChannelFiltering(new AForge.IntRange(0, 255), new IntRange(0, 0), new IntRange(0, 0)));
        }

        private void MenuItemGreen_Click(object sender, EventArgs e)
        {
            ApplyFilterInPlace(new ChannelFiltering(new IntRange(0, 0), new IntRange(0, 255), new IntRange(0, 0)));
        }

        private void MenuItemBlue_Click(object sender, EventArgs e)
        {
            ApplyFilterInPlace(new ChannelFiltering(new IntRange(0, 0), new IntRange(0, 0), new IntRange(0, 255)));
        }

        private void MenuItemCyan_Click(object sender, EventArgs e)
        {
            ApplyFilterInPlace(new ChannelFiltering(new IntRange(0, 0), new IntRange(0, 255), new IntRange(0, 255)));
        }

        private void MenuItemMagenta_Click(object sender, EventArgs e)
        {
            ApplyFilterInPlace(new ChannelFiltering(new IntRange(0, 255), new IntRange(0, 0), new IntRange(0, 255)));
        }

        private void MenuItemYellow_Click(object sender, EventArgs e)
        {
            ApplyFilterInPlace(new ChannelFiltering(new IntRange(0, 255), new IntRange(0, 255), new IntRange(0, 0)));
        }

        private void MenuItemThreshold_Click(object sender, EventArgs e)
        {
            if (bitmap.PixelFormat != PixelFormat.Format8bppIndexed && bitmap.PixelFormat != PixelFormat.Format16bppGrayScale)
            {
                MessageBox.Show("The filter accepts only 8 and 16 bpp grayscale images for processing! You should first convert the image to grayscale using Effects->Grayscale.", "SPixel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            ThresholdForm form = new ThresholdForm();

            form.Image = bitmap;

            if (form.ShowDialog() == DialogResult.OK)
            {
                toGrayscale = true;
                ApplyFilter(form.Filter);
            }
        }

        private void MenuItemThresholdWithErrorCarry_Click(object sender, EventArgs e)
        {
            if (bitmap.PixelFormat != PixelFormat.Format8bppIndexed)
            {
                MessageBox.Show("The filter accepts only 8 bpp grayscale images for processing! You should first convert the image to grayscale using Effects->Grayscale.", "SPixel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            ApplyFilterInPlace(new ThresholdWithCarry());
        }

        private void MenuItemOrderedDither_Click(object sender, EventArgs e)
        {
            if (bitmap.PixelFormat != PixelFormat.Format8bppIndexed)
            {
                MessageBox.Show("The filter accepts only 8 bpp grayscale images for processing! You should first convert the image to grayscale using Effects->Grayscale.", "SPixel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            ApplyFilterInPlace(new OrderedDithering());
        }

        private void MenuItemFloydSteinberg_Click(object sender, EventArgs e)
        {
            if (bitmap.PixelFormat != PixelFormat.Format8bppIndexed)
            {
                MessageBox.Show("The filter accepts only 8 bpp grayscale images for processing! You should first convert the image to grayscale using Effects->Grayscale.", "SPixel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            ApplyFilterInPlace(new FloydSteinbergDithering());
        }

        private void MenuItemSISThreshold_Click(object sender, EventArgs e)
        {
            if (bitmap.PixelFormat != PixelFormat.Format8bppIndexed)
            {
                MessageBox.Show("The filter accepts only 8 bpp grayscale images for processing! You should first convert the image to grayscale using Effects->Grayscale.", "SPixel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            ApplyFilterInPlace(new SISThreshold());
        }

        private void MenuItemErosion_Click(object sender, EventArgs e)
        {
            ApplyFilterInPlace(new Erosion());
        }

        private void MenuItemDilatation_Click(object sender, EventArgs e)
        {
            ApplyFilterInPlace(new Dilatation());
        }

        private void MenuItemOpening_Click(object sender, EventArgs e)
        {
            ApplyFilterInPlace(new Opening());
        }

        private void MenuItemClosing_Click(object sender, EventArgs e)
        {
            ApplyFilterInPlace(new Closing());
        }

        private void MenuItemEdges_Click(object sender, EventArgs e)
        {
            ApplyFilterInPlace(new Edges());
        }

        private void MenuItemHomogenity_Click(object sender, EventArgs e)
        {
            if (bitmap.PixelFormat != PixelFormat.Format8bppIndexed)
            {
                MessageBox.Show("The filter accepts only 8 bpp grayscale images for processing! You should first convert the image to grayscale using Effects->Grayscale.", "SPixel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            ApplyFilterInPlace(new HomogenityEdgeDetector());
        }

        private void MenuItemDifference_Click(object sender, EventArgs e)
        {
            if (bitmap.PixelFormat != PixelFormat.Format8bppIndexed)
            {
                MessageBox.Show("The filter accepts only 8 bpp grayscale images for processing! You should first convert the image to grayscale using Effects->Grayscale.", "SPixel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            ApplyFilterInPlace(new DifferenceEdgeDetector());
        }

        private void MenuItemSobel_Click(object sender, EventArgs e)
        {
            if (bitmap.PixelFormat != PixelFormat.Format8bppIndexed)
            {
                MessageBox.Show("The filter accepts only 8 bpp grayscale images for processing! You should first convert the image to grayscale using Effects->Grayscale.", "SPixel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            ApplyFilterInPlace(new SobelEdgeDetector());
        }

        private void MenuItemCanny_Click(object sender, EventArgs e)
        {
            if (bitmap.PixelFormat != PixelFormat.Format8bppIndexed)
            {
                MessageBox.Show("The filter accepts only 8 bpp grayscale images for processing! You should first convert the image to grayscale using Effects->Grayscale.", "SPixel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            CannyDetectorForm form = new CannyDetectorForm();

            form.Image = bitmap;

            if (form.ShowDialog() == DialogResult.OK)
            {
                toGrayscale = true;
                ApplyFilter(form.Filter);
            }
        }

        private void MenuItemAdaptiveSmoothing_Click(object sender, EventArgs e)
        {
            AdaptiveSmoothForm form = new AdaptiveSmoothForm();

            form.Image = bitmap;

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (bitmap.PixelFormat == PixelFormat.Format8bppIndexed)
                    toGrayscale = true;
                ApplyFilter(form.Filter);
            }
        }

        private void MenuItemConservativeSmoothing_Click(object sender, EventArgs e)
        {
            ApplyFilterInPlace(new ConservativeSmoothing());
        }

        private void MenuItemPerlinNoise_Click(object sender, EventArgs e)
        {
            PerlinNoiseForm form = new PerlinNoiseForm();

            form.Image = bitmap;

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (bitmap.PixelFormat == PixelFormat.Format8bppIndexed)
                    toGrayscale = true;
                ApplyFilter(form.Filter);
            }
        }

        private void MenuItemOilPainting_Click(object sender, EventArgs e)
        {
            OilPaintingForm form = new OilPaintingForm();

            form.Image = bitmap;

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (bitmap.PixelFormat == PixelFormat.Format8bppIndexed)
                    toGrayscale = true;
                ApplyFilter(form.Filter);
            }
        }

        private void MenuItemJitter_Click(object sender, EventArgs e)
        {
            ApplyFilterInPlace(new Jitter(1));
        }

        private void MenuItemPixellate_Click(object sender, EventArgs e)
        {
            PixellateForm form = new PixellateForm();

            form.Image = bitmap;

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (bitmap.PixelFormat == PixelFormat.Format8bppIndexed)
                    toGrayscale = true;
                ApplyFilter(form.Filter);
            }
        }

        private void MenuItemMean_Click(object sender, EventArgs e)
        {
            ApplyFilterInPlace(new Mean());
        }

        private void MenuItemMedian_Click(object sender, EventArgs e)
        {
            ApplyFilterInPlace(new Median());
        }

        private void MenuItemOpenHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I'm sorry, but there's no Help!", "SPixel", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MenuItemAbout_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
        }

        #endregion

        #region MainForm KeyDown event handler

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

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Right:
                case Keys.Up:
                case Keys.Space:
                    MenuItemNextImage_Click(sender, e);
                    break;
                case Keys.Left:
                case Keys.Down:
                case Keys.Back:
                    MenuItemPreviousImage_Click(sender, e);
                    break;
                case Keys.Home:
                    MenuItemFirstImage_Click(sender, e);
                    break;
                case Keys.End:
                    MenuItemLastImage_Click(sender, e);
                    break;
                case Keys.Add:
                    MenuItemZoomIn_Click(sender, e);
                    break;
                case Keys.Subtract:
                    MenuItemZoomOut_Click(sender, e);
                    break;
                case Keys.Escape:
                    if (fullScreen)
                        ExitFullScreen();
                    else
                        MenuItemExit_Click(sender, e);
                    break;
                case Keys.Enter:
                    if (fullScreen)
                        ExitFullScreen();
                    else
                        MenuItemFullScreen_Click(sender, e);
                    break;
                case Keys.L:
                    MenuItemRotateLeft_Click(sender, e);
                    break;
                case Keys.R:
                    MenuItemRotateRight_Click(sender, e);
                    break;
            }
        }

        #endregion

        #region MainForm Drag&Drop event handlers

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            string fileName;
            string[] data = (string[])((IDataObject)e.Data).GetData("FileNameW");
            if (data != null)
            {
                if ((data.Length == 1) && (data.GetValue(0) is String))
                {
                    fileName = data[0].ToString();

                    ImageFormat format = FormatFromExtension(fileName);
                    if (format == ImageFormat.Jpeg || format == ImageFormat.Gif ||
                        format == ImageFormat.Bmp || format == ImageFormat.Png || format == ImageFormat.Tiff)
                    {
                        imageFile = fileName;
                        Directory.SetCurrentDirectory(Directory.GetParent(imageFile).FullName.ToString());
                        ProcessDirectory();
                        zoomFactor = 1.00F;
                        isDeleted = false;
                        ShowPicture();
                    }
                }
            }
        }

        #endregion
    }
}