namespace File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
          //if( MessageBox.Show("Are you sure want to close" , "Warning" , MessageBoxButtons.YesNo , MessageBoxIcon.Warning) == DialogResult.No )  e.Cancel = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(500, 500);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            btnExit.Click += (sender, e) => this.Close();
            dlgOpen.Filter = "Rich Text Files |*.rtf|Text Files|*.txt";
            dlgSave.Filter = "Rich Text Files |*.rtf|Text Files|*.txt";
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (dlgOpen.ShowDialog() == DialogResult.OK)
                txtInput.LoadFile(dlgOpen.FileName);
            //{
            //    switch (dlgOpen.FilterIndex)
            //    {
            //        case 1:
            //            txtInput.LoadFile(dlgOpen.FileName, RichTextBoxStreamType.RichText);
            //            break;
            //        case 2:
            //            txtInput.LoadFile(dlgOpen.FileName, RichTextBoxStreamType.PlainText);
            //            break;
            //    }
            //}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dlgSave.ShowDialog() == DialogResult.OK)
                txtInput.SaveFile(dlgSave.FileName  ,(RichTextBoxStreamType)dlgSave.FilterIndex-1);
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            if(txtInput.SelectedText.Length>0)
                dlgFont.Font = txtInput.SelectionFont;
            if (dlgFont.ShowDialog() == DialogResult.OK)
                txtInput.SelectionFont = dlgFont.Font;
             
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (txtInput.SelectedText.Length > 0)
                dlgColor.Color = txtInput.SelectionColor;
            if (dlgColor.ShowDialog() == DialogResult.OK)
                txtInput.SelectionColor = dlgColor.Color;

        }

        DlgCustom Dlg = new DlgCustom();
        private void btnDlg_Click(object sender, EventArgs e)
        {
            if (Dlg.ShowDialog() == DialogResult.OK)
                txtInput.AppendText(Dlg.CusText);
        }
    }
}