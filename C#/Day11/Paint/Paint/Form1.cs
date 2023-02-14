namespace Paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /// Two Way To reflect changes in size to detect and redraw 
            /// protected property 
            this.ResizeRedraw= true;

            /// detect that the new Fourma is not Valid Now
            //this.Resize += (sender, e) => Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Font MyFont = new Font( this.Font.FontFamily , 25);
            string Str = "Hello GDI+";
            Brush mybrush = new SolidBrush(Color.FromArgb(this.Height%255 , this.Width % 255, (this.Height/2 + this.Width/2) % 255));   
            e.Graphics.DrawString(Str, MyFont , mybrush , (ClientSize.Width )/2 , (ClientSize.Height)/ 2);
            base.OnPaint(e);
        }
     }
} 