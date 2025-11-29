using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static HotelApplication.Components.RoundedCorners;

namespace HotelApp.UI.Components
{
    public class UIProgressBar : Control
    {
        private int _value = 0;
        private int _minimum = 0;
        private int _maximum = 100;
        private int _borderRadius = 5;

   
        private Color _channelColor = HotelPalette.Surface;
        private Color _sliderColor = HotelPalette.Accent;
        private Color _foreBackColor = HotelPalette.TextPrimary;

        private bool _showValue = false;
        private string _symbolBefore = "";
        private string _symbolAfter = "%";

        public UIProgressBar()
        {
            
            this.DoubleBuffered = true;
            this.Height = 10;
            this.ForeColor = HotelPalette.TextPrimary;
            this.BackColor = HotelPalette.MainBackground;
        }

        [Category("Behavior")]
        public int Value
        {
            get { return _value; }
            set
            {
                if (value < _minimum) _value = _minimum;
                else if (value > _maximum) _value = _maximum;
                else _value = value;

                this.Invalidate();
            }
        }

        [Category("Behavior")]
        public int Maximum
        {
            get { return _maximum; }
            set { _maximum = value; this.Invalidate(); }
        }

        [Category("Appearance")]
        public Color ChannelColor
        {
            get { return _channelColor; }
            set { _channelColor = value; this.Invalidate(); }
        }

        [Category("Appearance")]
        public Color SliderColor
        {
            get { return _sliderColor; }
            set { _sliderColor = value; this.Invalidate(); }
        }

        [Category("Appearance")]
        public bool ShowValue
        {
            get { return _showValue; }
            set { _showValue = value; this.Invalidate(); }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rectChannel = this.ClientRectangle;
            Rectangle rectSlider = this.ClientRectangle;


            if (_maximum != 0)
                rectSlider.Width = (int)((float)_value / _maximum * this.Width);
            else
                rectSlider.Width = 0;


            using (GraphicsPath pathChannel = GetRoundedPath(rectChannel, _borderRadius))
            using (SolidBrush brushChannel = new SolidBrush(_channelColor))
            {
             
                if (this.Parent != null) e.Graphics.Clear(this.Parent.BackColor);
                e.Graphics.FillPath(brushChannel, pathChannel);
            }

            if (rectSlider.Width > 1)
            {
                using (GraphicsPath pathChannel = GetRoundedPath(rectChannel, _borderRadius))
                {
                    Region region = new Region(pathChannel);
                    e.Graphics.SetClip(region, CombineMode.Replace);

                    using (SolidBrush brushSlider = new SolidBrush(_sliderColor))
                    {
                        e.Graphics.FillRectangle(brushSlider, rectSlider);
                    }
                    e.Graphics.ResetClip();
                }
            }


            if (_showValue)
            {
                string text = _symbolBefore + _value.ToString() + _symbolAfter;
                SizeF textSize = e.Graphics.MeasureString(text, this.Font);
                PointF textPoint = new PointF(
                    (this.Width - textSize.Width) / 2,
                    (this.Height - textSize.Height) / 2
                );

                using (SolidBrush brushText = new SolidBrush(this.ForeColor))
                {
                    e.Graphics.DrawString(text, this.Font, brushText, textPoint);
                }
            }
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            if (curveSize > rect.Height) curveSize = rect.Height;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}