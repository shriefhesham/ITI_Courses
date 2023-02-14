using System.Drawing;
using System.Drawing.Drawing2D;



namespace MickeyMouse
{
    public partial class MickeyMouese : Form
    {
        public MickeyMouese()
        {
            InitializeComponent();
            this.FormBorderStyle= FormBorderStyle.None;
          
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(115, 30, 400, 400);
            path.AddEllipse(50, 0, 200, 200);
            path.AddEllipse(400, 0, 200, 200);
            path.FillMode = FillMode.Winding;
            this.Region = new Region(path);
            base.OnPaint(e);
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minmize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
 

        private void MickeyMouese_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.SetDesktopLocation(MousePosition.X, MousePosition.Y);
            }
        }

    }
}