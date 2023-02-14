namespace MickeyMouse
{
    partial class MickeyMouese
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_minmize = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_minmize
            // 
            this.btn_minmize.Location = new System.Drawing.Point(124, 78);
            this.btn_minmize.Name = "btn_minmize";
            this.btn_minmize.Size = new System.Drawing.Size(34, 29);
            this.btn_minmize.TabIndex = 0;
            this.btn_minmize.Text = "_";
            this.btn_minmize.UseVisualStyleBackColor = true;
            this.btn_minmize.Click += new System.EventHandler(this.btn_minmize_Click);
            // 
            // btnX
            // 
            this.btnX.Location = new System.Drawing.Point(459, 78);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(34, 29);
            this.btnX.TabIndex = 1;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // MickeyMouese
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btn_minmize);
            this.Name = "MickeyMouese";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MickeyMouese";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MickeyMouese_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_minmize;
        private Button btnX;
    }
}