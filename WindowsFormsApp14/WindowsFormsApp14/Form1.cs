using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        bool DrawingMode { set; get; }
        Pen drawingPen;
        Color currentColor;
        Point clickPoint;
        Point scrollbars;
        Size windowSize;
        String pathOfImage = null;
        Bitmap currentImage = null;
        public Form1()
        {
            InitializeComponent();
            currentColor = Color.Red;
            windowSize = this.Size;
            drawingPen = new Pen(currentColor, 2);
        }

        private void ShowImage(Bitmap newImage)
        {
            SuspendLayout();
            pictureBox1.Size = panel1.Size;
            if (newImage.Size.Width < panel1.Width && newImage.Size.Height < panel1.Height)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                if (checkBox1.Checked)
                {
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            else
            {
                if (checkBox2.Checked)
                {
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                }
            }

            Bitmap oldImage = currentImage;
            pictureBox1.Image = currentImage = newImage;

            if (currentImage != oldImage&&oldImage!=null)
            {
                oldImage.Dispose();
                oldImage = null;
            }

            
            lblSize.Text = "Size : " + currentImage.Size.Width + "x" + currentImage.Size.Height;
            tbName.Text = pathOfImage.Remove(0, pathOfImage.LastIndexOf('\\') + 1);
            ResumeLayout();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                Bitmap newImage = null;
                try
                {
                    newImage = new Bitmap(openFileDialog1.FileName);
                }catch(Exception exp)
                {
                    MessageBox.Show("Can't open file. Error!");
                    if (newImage != null)
                    {
                        newImage.Dispose();
                        newImage = null;
                    }
                }

                if (newImage != null)
                {
                    panel1.HorizontalScroll.Value = 0;
                    panel1.VerticalScroll.Value = 0;
                    pathOfImage = openFileDialog1.FileName;
                    ShowImage(newImage);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (currentImage != null)
            {
                ShowImage(currentImage);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            panel1.HorizontalScroll.Value = 0;
            panel1.VerticalScroll.Value = 0;
            if (currentImage != null)
            {
                ShowImage(currentImage);
            }

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.Size.Width != 0 && this.Size.Height != 0)
            {
                Size newWindowSize = this.Size;
                int offsetX = newWindowSize.Width - windowSize.Width;
                int offsetY = newWindowSize.Height - windowSize.Height;
                Size toAdd = new Size(offsetX, offsetY);
                    panel1.Size += toAdd;
                    tbName.Size += new Size(toAdd.Width, 0);
                    pictureBox1.Size += toAdd;
                windowSize = newWindowSize;
                if (currentImage != null)
                {
                    ShowImage(currentImage);
                }
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            clickPoint = e.Location;
            if (!DrawingMode)
            {
                this.Cursor = Cursors.Hand;
                scrollbars = panel1.AutoScrollPosition;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (!DrawingMode)
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Point previousPoint = clickPoint;
            Point currentLocation = e.Location;
            if (!DrawingMode)
            {
                if (e.Button == MouseButtons.Left)
                {
                    this.SuspendLayout();
                    scrollbars += (Size)clickPoint - (Size)currentLocation;
                    if (scrollbars.X < 0)
                        scrollbars.X = 0;
                    if (scrollbars.Y < 0)
                        scrollbars.Y = 0;
                    if (scrollbars.X > pictureBox1.Width)
                        scrollbars.X = pictureBox1.Width;
                    if (scrollbars.Y > pictureBox1.Height)
                        scrollbars.Y = pictureBox1.Height;
                    panel1.AutoScrollPosition = scrollbars;
                    this.ResumeLayout();
                }
            }
            else
            {
                if (e.Button == MouseButtons.Left)
                {
                    Graphics graphics;
                    if (pictureBox1.Image != null)
                    {
                        graphics = Graphics.FromImage(pictureBox1.Image);
                        graphics.DrawLine(drawingPen, previousPoint, currentLocation);
                    }
                    clickPoint = currentLocation;
                }
                pictureBox1.Refresh();
            }
        }

        private void btnColorPicker_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() != DialogResult.Cancel)
            {
                currentColor = color.Color;
            }
            if (drawingPen != null)
            {
                drawingPen.Dispose();
                drawingPen = null;
            }

            drawingPen = new Pen(currentColor, (float)nudWidth.Value);
        }

        private void nudWidth_ValueChanged(object sender, EventArgs e)
        {
            if (drawingPen != null)
            {
                drawingPen.Dispose();
                drawingPen = null;
            }

            drawingPen = new Pen(currentColor, (float)nudWidth.Value);
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Saving picture...";
            if (pictureBox1.Image != null)
            {
                    saveFileDialog1.FileName = pathOfImage;
                if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
                {
                    try
                    {
                        pictureBox1.Image.Save(saveFileDialog1.FileName);
                    }catch(Exception exp)
                    {
                        MessageBox.Show("Failed to save");
                    }
                 }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!DrawingMode)
            {
                DrawingMode = true;
                button2.Text = "Drawing mode - On";
                btnColorPicker.Enabled = true;
                nudWidth.Enabled = true;
                checkBox1.Visible = false;
                checkBox2.Visible = false;
            }
            else
            {
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                DrawingMode = false;
                btnColorPicker.Enabled = false;
                nudWidth.Enabled = false;
                button2.Text = "Drawing mode - Off";
            }
        }

        private void btnGrayscale_Click(object sender, EventArgs e)
        {
            

            if (pictureBox1.Image != null)
            {
                this.Cursor = Cursors.WaitCursor;
                for (int i = 0; i < currentImage.Width; i++)
                {
                    for (int j = 0; j < currentImage.Height; j++)
                    {
                        Color color = currentImage.GetPixel(i, j);
                        int value = (21 * color.R + 71 * color.G + 8 * color.B) / 100;
                        currentImage.SetPixel(i, j, Color.FromArgb(value, value, value));
                    }
                }
                pictureBox1.Refresh();
                this.Cursor = Cursors.Default;
            }


            
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            Array a = (Array)e.Data.GetData(DataFormats.FileDrop);
            if (a != null)
            {
                pathOfImage = a.GetValue(0).ToString();
                Bitmap newImage = new Bitmap(pathOfImage);
                ShowImage(newImage);
            }
        }
    }
}
