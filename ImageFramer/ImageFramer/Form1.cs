using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace ImageFramer
{
    public partial class Form1 : Form
    {
        //глобални променливи
        Bitmap originalImg;
        Bitmap grayScaleImg;
        Color frameColor = Color.Black;
        int frameSize;
        bool isGrayScale;
 

        public Form1()
        {
            InitializeComponent();
            //обработка всички бутони
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //извикване функция за стилизиране на всеки бутон
            StyleButtons(this);
        }

        //качване на изображения
        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.jpg;*.png;*.bmp";

            //ако качването е успешно
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                //default стойности
                originalImg = new Bitmap(dlg.FileName);
                grayScaleImg = null;
                isGrayScale = false;
                frameSize = 0;
                //визуализиране
                RebuildImage();
            }
        }

        //рамкиране изображението
        private void frameButton_Click(object sender, EventArgs e)
        {
            if (originalImg == null) return;
            frameSize = (int)sizeNumericUpDown.Value;
            //визуализиране
            RebuildImage();
        }

        //избора цвят за рамката
        private void colorButton_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                frameColor = dlg.Color;
                RebuildImage();
            }
        }

        //бутон за щерно-бял филтър
        private void grayscaleButton_Click(object sender, EventArgs e)
        {
            if (originalImg == null) return;
            if (grayScaleImg == null)
                grayScaleImg = MakeGrayscale();
            isGrayScale = !isGrayScale;//toggle функция
            RebuildImage();
        }

        //запазване на изображението
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (PictureBox.Image == null) return;
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "JPEG Image|*.jpg|PNG Image|*.png|Bitmap Image|*.bmp";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                PictureBox.Image.Save(dlg.FileName);
                MessageBox.Show("Снимката бе запазена");
            }
        }

        //визуализиране и "престрояване"
        private void RebuildImage()
        {
            if (originalImg == null) return;

            Bitmap baseImg;

            if (isGrayScale && grayScaleImg != null)
                baseImg = new Bitmap(grayScaleImg);
            else
                baseImg = new Bitmap(originalImg);

            Bitmap finalImg = ApplyFrame(baseImg);

            PictureBox.Image = finalImg;
        }

        //функция за рамкиране
        private Bitmap ApplyFrame(Bitmap img)
        {
            if (frameSize <= 0) return new Bitmap(img);
            Bitmap framed = new Bitmap(img.Width + frameSize * 2, img.Height + frameSize * 2);//битмап с размер снимката + рамката


            //обрисуване на битмапа
            using (Graphics g = Graphics.FromImage(framed))
            {
                g.Clear(frameColor);//оцвеятване всичко в цвета на рамката
                g.DrawImage(img, frameSize, frameSize);// поставяне на снимката по средата
            }
            return framed;
        }

        //функция черно-бял филтър
        private Bitmap MakeGrayscale()
        {
            Bitmap bmp = new Bitmap(originalImg.Width, originalImg.Height);
            //създаване на ColorMatrix матрица
            using (Graphics g = Graphics.FromImage(bmp))
            {
                ColorMatrix matrix = new ColorMatrix(new float[][]
                {
                    new float[] {.3f, .3f, .3f, 0, 0},//r
                    new float[] {.59f, .59f, .59f, 0, 0},//g
                    new float[] {.11f, .11f, .11f, 0, 0},//b
                    new float[] {0,0,0,1,0},//amber
                    new float[] {0,0,0,0,1}//white
                });
                ImageAttributes attr = new ImageAttributes();
                attr.SetColorMatrix(matrix);
                //промяна пикселите
                g.DrawImage(originalImg, new Rectangle(0,0,originalImg.Width,originalImg.Height),
                    0,0,originalImg.Width,originalImg.Height, GraphicsUnit.Pixel, attr);
            }
            return bmp;
        }

        //стил бутони
        private void StyleButtons(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;

                    btn.BackColor = Color.FromArgb(189, 43, 152);  
                    btn.ForeColor = Color.White;

                    btn.Height = 30;
                    btn.Width = 110;

                    btn.Cursor = Cursors.Hand;

                    btn.FlatAppearance.MouseOverBackColor = 
                        Color.FromArgb(128, 29, 102);
                    btn.FlatAppearance.MouseDownBackColor = 
                        Color.FromArgb(128, 29, 102);
                }
                else if (c is NumericUpDown nud)
                {
                    nud.BackColor = Color.FromArgb(189, 43, 152);
                    nud.ForeColor = Color.White;
                    nud.Height = 30;
                    nud.Width = 50;
                }
                else
                {
                    StyleButtons(c);
                }
            }
        }

        private void label_Click(object sender, EventArgs e)
        {

        }
    }


}
