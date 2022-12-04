using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace lab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ReDrawSquarePicture();
            ReDrawSnowPicture();
            ReDrawWatchPicture();

            CB = new ColorComboBox();
            CB.Location = new Point(800, 280);

            CB.Parent = this;
        }
        public int x, y, angle;
        Color myPenColor = Color.Red;
        ColorComboBox CB;

        bool autoReDrawSquare = true; 
        bool autoReDrawSnow = true;

        private void DrawSquarePicture(float a, int k)
        {
            var myPen = new Pen(myPenColor, 2f);
            inmormationSquare = $" ‚‡‰‡Ú, a={a}, k={k}";
            using (Graphics graphics = Graphics.FromImage(squarePictureBox.Image))
            {
                graphics.SmoothingMode = SmoothingMode.HighQuality;

                float centerX = squarePictureBox.Width / 2;
                float centerY = squarePictureBox.Height / 2;
                graphics.TranslateTransform(centerX, centerY);

                for (int i = 0; i < k; i++)
                {
                    graphics.DrawRectangle(myPen, 0.0f - a / 2, 0.0f - a / 2, a, a);
                    graphics.RotateTransform(45);

                    a = (float)(a * Math.Sqrt(2) / 2);
                }
            }
        }
        private void DrawSnowPicture(float R, float delta, int k, int m)
        {
            var myPen = new Pen(myPenColor, 2f);
            informationSnow = $"—ÌÂ„Ó‚ËÍ, R={R}, Delta={delta}, k={k}, m={m}";

            var colors = new List<Color>()
            {
                Color.FromArgb(255, 255, 204),
                Color.FromArgb(255, 255, 153),
                Color.FromArgb(255, 255, 102),
                Color.FromArgb(255, 255, 51),
                Color.FromArgb(255, 255, 0)
            };
            var random = new Random();

            using (Graphics graphics = Graphics.FromImage(snowPictureBox.Image))
            {
                graphics.SmoothingMode = SmoothingMode.HighQuality;

                float centerX = snowPictureBox.Width / 2;
                float centerY = snowPictureBox.Height / 2;
                graphics.TranslateTransform(centerX, centerY);

                // graphics.DrawEllipse(myPen, x, y, 2, 2); // debug
                var brush = new SolidBrush(colors[random.Next(colors.Count)]);
                graphics.DrawEllipse(myPen, (int)-R, (int)-R, 2*R, 2*R);
                graphics.FillEllipse(brush, (int)-R, (int)-R, 2 * R, 2 * R);

                for (int i = 0; i < k; i++)
                {
                    var subCirlceR = R * delta;
                    var coord = new Point((int)(R * Math.Cos(0)), (int)(R * Math.Sin(0)));
                    for (int j = 0; j < m; j++)
                    {
                        try
                        {
                            brush = new SolidBrush(colors[random.Next(colors.Count)]);
                            graphics.DrawEllipse(myPen, coord.X, coord.Y - subCirlceR, 2 * subCirlceR, 2 * subCirlceR);
                            graphics.FillEllipse(brush, coord.X, coord.Y - subCirlceR, 2 * subCirlceR, 2 * subCirlceR);
                        }
                        catch {}
                        coord.X += (int)(2*subCirlceR);
                        subCirlceR *= delta;
                    }
                    //graphics.DrawLine(myPen, new Point(0, 0), coord);
                    graphics.RotateTransform(360 / k);
                }
            }
        }
        private void DrawWatchPicture(float R)
        {
            var myPen = new Pen(myPenColor, 2f);
            var myMediumPen = new Pen(myPenColor, 3f);
            var myBoldPen = new Pen(myPenColor, 5f);

            //get time
            int ss = DateTime.Now.Second;
            int mm = DateTime.Now.Minute;
            int hh = DateTime.Now.Hour;

            float centerX = watchPictureBox.Width / 2;
            float centerY = watchPictureBox.Height / 2;

            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;

            using (Graphics graphics = Graphics.FromImage(watchPictureBox.Image))
            {
                graphics.SmoothingMode = SmoothingMode.HighQuality;

                graphics.TranslateTransform(centerX, centerY);
                graphics.DrawEllipse(myBoldPen, 0f, 0f, 2, 2);
                
                graphics.DrawEllipse(myBoldPen, x, y, 2, 2); // debug

                graphics.DrawEllipse(myPen, 0f - R, 0f - R, 2 * R, 2 * R);

                for (int i = 0; i < 12; i++)
                {
                    graphics.DrawString($"{i + 1}", new Font("Arial", 12), Brushes.Black, hrCoord(i + 1, 0, (int)(R + 15f)), sf);
                }

                var timeCoord = hrCoord(6, 0, (int)(R + 40f));
                graphics.DrawString($"{hh:00}:{mm:00}:{ss:00}", new Font("Arial", 12), Brushes.Black, timeCoord, sf);

                //second hand
                graphics.DrawLine(myPen, new Point(0, 0), msCoord(ss, (int)R));

                //minute hand
                graphics.DrawLine(myMediumPen, new Point(0, 0), msCoord(mm, (int)(R * 0.8f)));

                //hour hand
                graphics.DrawLine(myBoldPen, new Point(0, 0), hrCoord(hh % 12, mm, (int)(R * 0.5f)));
            }
        }

        //coord for minute and second hand
        private Point msCoord(int val, int hlen)
        {
            Point coord = new Point();
            val *= 6;   //each minute and second make 6 degree

            if (val >= 0 && val <= 180)
            {
                coord.X = +(int)(hlen * Math.Sin(Math.PI * val / 180));
                coord.Y = -(int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                coord.X = -(int)(hlen * -Math.Sin(Math.PI * val / 180));
                coord.Y = -(int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            return coord;
        }

        //coord for hour hand
        private Point hrCoord(int hval, int mval, int hlen)
        {
            Point coord = new Point();

            //each hour makes 30 degree
            //each min makes 0.5 degree
            int val = (int)((hval * 30) + (mval * 0.5));

            if (val >= 0 && val <= 180)
            {
                coord.X = +(int)(hlen * Math.Sin(Math.PI * val / 180));
                coord.Y = -(int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                coord.X = -(int)(hlen * -Math.Sin(Math.PI * val / 180));
                coord.Y = -(int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            return coord;
        }

        private void ReDrawSquarePicture()
        {
            if (!autoReDrawSquare) return;
            squarePictureBox.Image = new Bitmap(squarePictureBox.Width, squarePictureBox.Height);
            DrawSquarePicture((int)aNum.Value, (int)kNum.Value);
        }
        private void ReDrawSnowPicture()
        {
            if (!autoReDrawSnow) return;
            snowPictureBox.Image = new Bitmap(snowPictureBox.Width, snowPictureBox.Height);
            DrawSnowPicture((float)RSnowValue.Value, (float)DeltaSnowValue.Value, (int)KSnowValue.Value, (int)MSnowValue.Value);
        }
        private void ReDrawWatchPicture()
        {
            watchPictureBox.Image = new Bitmap(watchPictureBox.Width, watchPictureBox.Height);
            DrawWatchPicture((float)rWatchNum.Value);
        }
        private void aNum_ValueChanged(object sender, EventArgs e)
        {
            ReDrawSquarePicture();
        }

        private void kNum_ValueChanged(object sender, EventArgs e)
        {
            ReDrawSquarePicture();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ReDrawSnowPicture();
        }

        private void DeltaSnowValue_ValueChanged(object sender, EventArgs e)
        {
            ReDrawSnowPicture();
        }

        private void KSnowValue_ValueChanged(object sender, EventArgs e)
        {
            ReDrawSnowPicture();
        }

        private void MSnowValue_ValueChanged(object sender, EventArgs e)
        {
            ReDrawSnowPicture();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ReDrawWatchPicture();
        }

        private void angelSnowNum_ValueChanged(object sender, EventArgs e)
        {
            ReDrawSnowPicture();
        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            ReDrawWatchPicture();
        }

        private void xnum_ValueChanged(object sender, EventArgs e)
        {
            x = (int)xnum.Value;
            ReDrawWatchPicture();
        }
        private void ynum_ValueChanged(object sender, EventArgs e)
        {
            y = (int)ynum.Value;
            ReDrawWatchPicture();
        }

        private void watchStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void ‚ÍÎ¬˚ÍÎ–ÂÊËÏ¿‚ÚÓÏ‡ÚË˜ÂÒÍÓÈœÂÂËÒÓ‚ÍËœË»ÁÏœ‡‡ÏÂÚÓ‚ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)contextMenuStrip1.Items[0]).Checked = !((ToolStripMenuItem)contextMenuStrip1.Items[0]).Checked;
            if (tabControl1.SelectedIndex == 0) {
                autoReDrawSquare = !autoReDrawSquare;
            } else {
                autoReDrawSnow = !autoReDrawSnow; 
            }
        }

        private void ‚ÍÎ¬˚ÍÎœËÌÛ‰ËÚÂÎ¸ÌÛ˛œÂÂËÒÓ‚ÍÛœË»ÁÏ‘ÓÏ˚ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)contextMenuStrip1.Items[1]).Checked = !((ToolStripMenuItem)contextMenuStrip1.Items[1]).Checked;
            if (tabControl1.SelectedIndex == 0)
            {
                autoReDrawSquare = !autoReDrawSquare;
            }
            else
            {
                autoReDrawSnow = !autoReDrawSnow;
            }
        }

        string inmormationSquare = " ‚‡‰‡Ú";
        string informationSnow = "—ÌÂ„Ó‚ËÍ";

        private void ÒÓı‡ÌËÚ¸»ÁÓ·‡ÊÂÌËÂ¬bmpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(tabControl1.SelectedIndex == 0 ? squarePictureBox.Image : snowPictureBox.Image);
            Font font = new Font(Font, FontStyle.Bold);

            PointF pointF = new PointF(squarePictureBox.Width / 2, squarePictureBox.Height - 20);
            string information = tabControl1.SelectedIndex == 0 ? inmormationSquare : informationSnow;


            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;


            using (Graphics graphics = Graphics.FromImage(bm))
            {
                graphics.DrawString(information, font, Brushes.Green, pointF, sf);
            };

            bm.Save($"{tabControl1.SelectedTab.Text}.bmp", ImageFormat.Bmp);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void watchStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void changePenColorBttn_Click(object sender, EventArgs e)
        {
            myPenColor = Color.FromName((string)(CB.SelectedItem));
            ReDrawSquarePicture();
            ReDrawSnowPicture();
            ReDrawWatchPicture();
        }
    }
}