using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegularGeometricFigures.Controller
{
    public abstract class CBase
    {
        protected float perimeter;
        protected float area;
        protected Graphics graphics;
        protected const float scale = 20;
        protected Pen pen;
        public CBase()
        {
            Initialize();
        }
        protected void Initialize()
        {
            perimeter = 0.0f;
            area = 0.0f;
        }
        protected void GraphShape(PictureBox picCanvas, int weight, Color color)
        {
            graphics = picCanvas.CreateGraphics();
            pen = new Pen(color, weight);
        }
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtArea.Text = this.area.ToString();
            txtPerimeter.Text = this.perimeter.ToString();
        }
        public void CloseForm(Form form)
        {
            form.Close();
        }
        public abstract void Perimeter();
        public abstract void Area();

    }
}
