using System.Drawing;

namespace Paint2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.White;

        }

        Brush brush = new SolidBrush(Color.Black);
        Brush brush2 = new SolidBrush(Color.White);

        private void Change_Color_Click(object sender, EventArgs e)
        {
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
               brush = new SolidBrush(colorDialog.Color);
            }
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics grfx = this.CreateGraphics();
            if (e.Button == MouseButtons.Left) grfx.FillEllipse(brush, e.X - 5, e.Y - 5, 10, 10);
            if (e.Button == MouseButtons.Right) grfx.FillEllipse(brush2, e.X - 5 ,e.Y - 5, 10, 10);
        }
    }
}