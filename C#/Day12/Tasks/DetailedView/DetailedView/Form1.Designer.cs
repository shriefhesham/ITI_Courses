namespace DetailedView
{
    partial class Form1
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
            this.CategoryID = new System.Windows.Forms.ComboBox();
            this.btnExcute = new System.Windows.Forms.Button();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtQuntityPerUnit = new System.Windows.Forms.TextBox();
            this.UDUnitsInStock = new System.Windows.Forms.NumericUpDown();
            this.UDUnitsOnOrder = new System.Windows.Forms.NumericUpDown();
            this.UDReorderLevel = new System.Windows.Forms.NumericUpDown();
            this.UDUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRecoderlvlAdd = new System.Windows.Forms.TextBox();
            this.txtUnitStockAdd = new System.Windows.Forms.TextBox();
            this.txtSupIdAdd = new System.Windows.Forms.TextBox();
            this.txtDiscountAdd = new System.Windows.Forms.TextBox();
            this.txtQuantityAdd = new System.Windows.Forms.TextBox();
            this.txtPnameAdd = new System.Windows.Forms.TextBox();
            this.txtUnitOrderAdd = new System.Windows.Forms.TextBox();
            this.txtUnitPriceAdd = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.Categories = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.UDUnitsInStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDUnitsOnOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDReorderLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDUnitPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoryID
            // 
            this.CategoryID.AllowDrop = true;
            this.CategoryID.FormattingEnabled = true;
            this.CategoryID.Location = new System.Drawing.Point(191, 176);
            this.CategoryID.Name = "CategoryID";
            this.CategoryID.Size = new System.Drawing.Size(151, 28);
            this.CategoryID.TabIndex = 1;
            // 
            // btnExcute
            // 
            this.btnExcute.Location = new System.Drawing.Point(191, 380);
            this.btnExcute.Name = "btnExcute";
            this.btnExcute.Size = new System.Drawing.Size(94, 29);
            this.btnExcute.TabIndex = 0;
            this.btnExcute.Text = "Excute";
            this.btnExcute.UseVisualStyleBackColor = true;
            this.btnExcute.Click += new System.EventHandler(this.btnExcute_Click);
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(191, 46);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(28, 20);
            this.lblEmployeeID.TabIndex = 2;
            this.lblEmployeeID.Text = " ID";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(191, 78);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(150, 27);
            this.txtProductName.TabIndex = 3;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(191, 144);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(150, 27);
            this.txtDiscount.TabIndex = 4;
            // 
            // txtQuntityPerUnit
            // 
            this.txtQuntityPerUnit.Location = new System.Drawing.Point(191, 111);
            this.txtQuntityPerUnit.Name = "txtQuntityPerUnit";
            this.txtQuntityPerUnit.Size = new System.Drawing.Size(150, 27);
            this.txtQuntityPerUnit.TabIndex = 5;
            // 
            // UDUnitsInStock
            // 
            this.UDUnitsInStock.Location = new System.Drawing.Point(191, 210);
            this.UDUnitsInStock.Name = "UDUnitsInStock";
            this.UDUnitsInStock.Size = new System.Drawing.Size(150, 27);
            this.UDUnitsInStock.TabIndex = 6;
            // 
            // UDUnitsOnOrder
            // 
            this.UDUnitsOnOrder.Location = new System.Drawing.Point(191, 276);
            this.UDUnitsOnOrder.Name = "UDUnitsOnOrder";
            this.UDUnitsOnOrder.Size = new System.Drawing.Size(150, 27);
            this.UDUnitsOnOrder.TabIndex = 7;
            // 
            // UDReorderLevel
            // 
            this.UDReorderLevel.Location = new System.Drawing.Point(191, 243);
            this.UDReorderLevel.Name = "UDReorderLevel";
            this.UDReorderLevel.Size = new System.Drawing.Size(150, 27);
            this.UDReorderLevel.TabIndex = 8;
            // 
            // UDUnitPrice
            // 
            this.UDUnitPrice.Location = new System.Drawing.Point(191, 309);
            this.UDUnitPrice.Name = "UDUnitPrice";
            this.UDUnitPrice.Size = new System.Drawing.Size(150, 27);
            this.UDUnitPrice.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(49, 380);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "ProductName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "QuntityPerUnit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Discount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Category ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "UnitsInStock";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "ReorderLevel";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 283);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "UnitsOnOrder";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 316);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "UnitPrice";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Product ID";
            // 
            // txtRecoderlvlAdd
            // 
            this.txtRecoderlvlAdd.Location = new System.Drawing.Point(513, 247);
            this.txtRecoderlvlAdd.Name = "txtRecoderlvlAdd";
            this.txtRecoderlvlAdd.Size = new System.Drawing.Size(125, 27);
            this.txtRecoderlvlAdd.TabIndex = 24;
            // 
            // txtUnitStockAdd
            // 
            this.txtUnitStockAdd.Location = new System.Drawing.Point(513, 210);
            this.txtUnitStockAdd.Name = "txtUnitStockAdd";
            this.txtUnitStockAdd.Size = new System.Drawing.Size(125, 27);
            this.txtUnitStockAdd.TabIndex = 25;
            // 
            // txtSupIdAdd
            // 
            this.txtSupIdAdd.Location = new System.Drawing.Point(513, 176);
            this.txtSupIdAdd.Name = "txtSupIdAdd";
            this.txtSupIdAdd.Size = new System.Drawing.Size(125, 27);
            this.txtSupIdAdd.TabIndex = 26;
            // 
            // txtDiscountAdd
            // 
            this.txtDiscountAdd.Location = new System.Drawing.Point(513, 144);
            this.txtDiscountAdd.Name = "txtDiscountAdd";
            this.txtDiscountAdd.Size = new System.Drawing.Size(125, 27);
            this.txtDiscountAdd.TabIndex = 27;
            // 
            // txtQuantityAdd
            // 
            this.txtQuantityAdd.Location = new System.Drawing.Point(513, 111);
            this.txtQuantityAdd.Name = "txtQuantityAdd";
            this.txtQuantityAdd.Size = new System.Drawing.Size(125, 27);
            this.txtQuantityAdd.TabIndex = 28;
            // 
            // txtPnameAdd
            // 
            this.txtPnameAdd.Location = new System.Drawing.Point(513, 78);
            this.txtPnameAdd.Name = "txtPnameAdd";
            this.txtPnameAdd.Size = new System.Drawing.Size(125, 27);
            this.txtPnameAdd.TabIndex = 29;
            // 
            // txtUnitOrderAdd
            // 
            this.txtUnitOrderAdd.Location = new System.Drawing.Point(513, 280);
            this.txtUnitOrderAdd.Name = "txtUnitOrderAdd";
            this.txtUnitOrderAdd.Size = new System.Drawing.Size(125, 27);
            this.txtUnitOrderAdd.TabIndex = 30;
            // 
            // txtUnitPriceAdd
            // 
            this.txtUnitPriceAdd.Location = new System.Drawing.Point(513, 313);
            this.txtUnitPriceAdd.Name = "txtUnitPriceAdd";
            this.txtUnitPriceAdd.Size = new System.Drawing.Size(125, 27);
            this.txtUnitPriceAdd.TabIndex = 31;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(527, 380);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Categories
            // 
            this.Categories.AllowDrop = true;
            this.Categories.FormattingEnabled = true;
            this.Categories.Location = new System.Drawing.Point(356, 176);
            this.Categories.Name = "Categories";
            this.Categories.Size = new System.Drawing.Size(151, 28);
            this.Categories.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 450);
            this.Controls.Add(this.Categories);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtUnitPriceAdd);
            this.Controls.Add(this.txtUnitOrderAdd);
            this.Controls.Add(this.txtPnameAdd);
            this.Controls.Add(this.txtQuantityAdd);
            this.Controls.Add(this.txtDiscountAdd);
            this.Controls.Add(this.txtSupIdAdd);
            this.Controls.Add(this.txtUnitStockAdd);
            this.Controls.Add(this.txtRecoderlvlAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.UDUnitPrice);
            this.Controls.Add(this.UDReorderLevel);
            this.Controls.Add(this.UDUnitsOnOrder);
            this.Controls.Add(this.UDUnitsInStock);
            this.Controls.Add(this.txtQuntityPerUnit);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.CategoryID);
            this.Controls.Add(this.btnExcute);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UDUnitsInStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDUnitsOnOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDReorderLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDUnitPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnExcute;
        private ComboBox CategoryID;
        private Label lblEmployeeID;
        private TextBox txtProductName;
        private TextBox txtDiscount;
        private TextBox txtQuntityPerUnit;
        private NumericUpDown UDUnitsInStock;
        private NumericUpDown UDUnitsOnOrder;
        private NumericUpDown UDReorderLevel;
        private NumericUpDown UDUnitPrice;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnSave;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label1;
        private TextBox txtRecoderlvlAdd;
        private TextBox txtUnitStockAdd;
        private TextBox txtSupIdAdd;
        private TextBox txtDiscountAdd;
        private TextBox txtQuantityAdd;
        private TextBox txtPnameAdd;
        private TextBox txtUnitOrderAdd;
        private TextBox txtUnitPriceAdd;
        private Button btnAdd;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private ComboBox Categories;
    }
}