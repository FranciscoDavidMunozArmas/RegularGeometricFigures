using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegularGeometricFigures.Controller
{
    public class RegularFigure : CBase
    {
        private float size;
        private int numberSides;
        public RegularFigure() : base()
        {
            size = 0.0f;
        }
        public void ReadData(TextBox txtSize, int numberSides)
        {
            try
            {
                size = float.Parse(txtSize.Text);
                this.numberSides = numberSides;
            }
            catch (Exception)
            {
                MessageBox.Show("The input is not right!!");
            }

        }
        public void Initialize(TextBox txtSize, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas, int numberSides)
        {
            txtSize.Text = txtPerimeter.Text = txtArea.Text = string.Empty;
            base.Initialize();
            this.size = 0.0f;
            this.numberSides = numberSides;
            picCanvas.Refresh();
        }
        public override void Area()
        {
            Perimeter();
            this.area = (this.perimeter * CalculateApothem()) / 2;
        }
        public override void Perimeter()
        {
            this.perimeter = numberSides * size;
        }
        public void GraphShape(PictureBox picCanvas)
        {
            base.GraphShape(picCanvas, 3, Color.Blue);
            for (int i = 0; i < this.numberSides; i++)
            {
                PointF start = new PointF(this.size + (this.size * (float)Math.Cos((2*Math.PI)/numberSides * i)), this.size + (this.size * (float)Math.Sin((2 * Math.PI) / numberSides * i)));
                PointF end = new PointF(this.size + (this.size * (float)Math.Cos((2 * Math.PI) / numberSides * (i + 1))), this.size + (this.size * (float)Math.Sin((2 * Math.PI) / numberSides * (i + 1))));
                graphics.DrawLine(this.pen, start.X * scale, start.Y * scale, end.X * scale, end.Y * scale);
            }
        }
        private float CalculateApothem()
        {
            return (float)(size / (2 * Math.Tan(Math.PI / numberSides)));
        }
    }
}
