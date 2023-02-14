namespace _2Boy_Ball
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(Pens.Blue, 63, 47, 70, 70);
            e.Graphics.DrawLine(Pens.Blue, 90, 120, 90, 280);
            e.Graphics.DrawLine(Pens.Blue, 90, 130, 130, 200);
            e.Graphics.DrawLine(Pens.Blue, 90, 130, 40, 200);
            e.Graphics.DrawLine(Pens.Blue, 90, 300, 130, 370);
            e.Graphics.DrawLine(Pens.Blue, 90, 300, 40, 370);


            e.Graphics.DrawEllipse(Pens.Blue, 595, 50, 70, 70);
            e.Graphics.DrawLine(Pens.Blue, 630, 130, 670, 200);
            e.Graphics.DrawLine(Pens.Blue, 630, 120, 630, 300);
            e.Graphics.DrawLine(Pens.Blue, 630, 130, 590, 200);
            e.Graphics.DrawLine(Pens.Blue, 630, 300, 670, 370);
            e.Graphics.DrawLine(Pens.Blue, 630, 300, 590, 370);


        }
        Boolean flag = true;
        int x = 120;

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics grfx = this.CreateGraphics();
            grfx.DrawEllipse(Pens.Lavender, x, 300, 70, 70);

            if (x >= 450)
                flag = false;
            else if (x <= 120)
                flag = true;

            if (flag)
                x += 100;
            else x -= 100;

            grfx.DrawEllipse(Pens.Orchid, x, 300, 70, 70);
        }
    }
}