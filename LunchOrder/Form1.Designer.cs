namespace LunchOrder
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
            gbxMainCourse = new GroupBox();
            mainCourseButton3 = new RadioButton();
            mainCourseButton2 = new RadioButton();
            mainCourseButton1 = new RadioButton();
            groupBox2 = new GroupBox();
            txtOrderTotal = new TextBox();
            label3 = new Label();
            txtSalesTax = new TextBox();
            label2 = new Label();
            txtSubtotal = new TextBox();
            label1 = new Label();
            btnPlaceOrder = new Button();
            btnExit = new Button();
            gbxAddOns = new GroupBox();
            addOnCheckBox3 = new CheckBox();
            addOnCheckBox2 = new CheckBox();
            addOnCheckBox1 = new CheckBox();
            gbxMainCourse.SuspendLayout();
            groupBox2.SuspendLayout();
            gbxAddOns.SuspendLayout();
            SuspendLayout();
            // 
            // gbxMainCourse
            // 
            gbxMainCourse.Controls.Add(mainCourseButton3);
            gbxMainCourse.Controls.Add(mainCourseButton2);
            gbxMainCourse.Controls.Add(mainCourseButton1);
            gbxMainCourse.Location = new Point(39, 22);
            gbxMainCourse.Margin = new Padding(2);
            gbxMainCourse.Name = "gbxMainCourse";
            gbxMainCourse.Padding = new Padding(2);
            gbxMainCourse.Size = new Size(182, 130);
            gbxMainCourse.TabIndex = 0;
            gbxMainCourse.TabStop = false;
            gbxMainCourse.Text = "Main Course";
            // 
            // mainCourseButton3
            // 
            mainCourseButton3.AutoSize = true;
            mainCourseButton3.Location = new Point(5, 85);
            mainCourseButton3.Name = "mainCourseButton3";
            mainCourseButton3.Size = new Size(116, 24);
            mainCourseButton3.TabIndex = 2;
            mainCourseButton3.Text = "Salad - $4.95";
            mainCourseButton3.UseVisualStyleBackColor = true;
            mainCourseButton3.CheckedChanged += radioButton_CheckedChanged;
            // 
            // mainCourseButton2
            // 
            mainCourseButton2.AutoSize = true;
            mainCourseButton2.Location = new Point(5, 55);
            mainCourseButton2.Name = "mainCourseButton2";
            mainCourseButton2.Size = new Size(113, 24);
            mainCourseButton2.TabIndex = 1;
            mainCourseButton2.Text = "Pizza - $5.95";
            mainCourseButton2.UseVisualStyleBackColor = true;
            mainCourseButton2.CheckedChanged += radioButton_CheckedChanged;
            // 
            // mainCourseButton1
            // 
            mainCourseButton1.AutoSize = true;
            mainCourseButton1.Checked = true;
            mainCourseButton1.Location = new Point(5, 25);
            mainCourseButton1.Name = "mainCourseButton1";
            mainCourseButton1.Size = new Size(155, 24);
            mainCourseButton1.TabIndex = 0;
            mainCourseButton1.TabStop = true;
            mainCourseButton1.Text = "Hamburger - $6.95";
            mainCourseButton1.UseVisualStyleBackColor = true;
            mainCourseButton1.CheckedChanged += radioButton_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtOrderTotal);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtSalesTax);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtSubtotal);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(39, 178);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(297, 154);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Order Total";
            // 
            // txtOrderTotal
            // 
            txtOrderTotal.Location = new Point(128, 102);
            txtOrderTotal.Margin = new Padding(2);
            txtOrderTotal.Name = "txtOrderTotal";
            txtOrderTotal.ReadOnly = true;
            txtOrderTotal.Size = new Size(121, 27);
            txtOrderTotal.TabIndex = 5;
            txtOrderTotal.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 106);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 4;
            label3.Text = "Order Total:";
            // 
            // txtSalesTax
            // 
            txtSalesTax.Location = new Point(128, 66);
            txtSalesTax.Margin = new Padding(2);
            txtSalesTax.Name = "txtSalesTax";
            txtSalesTax.ReadOnly = true;
            txtSalesTax.Size = new Size(121, 27);
            txtSalesTax.TabIndex = 3;
            txtSalesTax.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 70);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 2;
            label2.Text = "Tax (7.75%):";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(128, 30);
            txtSubtotal.Margin = new Padding(2);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.ReadOnly = true;
            txtSubtotal.Size = new Size(121, 27);
            txtSubtotal.TabIndex = 1;
            txtSubtotal.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 34);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 0;
            label1.Text = "Subtotal:";
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Location = new Point(366, 190);
            btnPlaceOrder.Margin = new Padding(2);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(89, 34);
            btnPlaceOrder.TabIndex = 2;
            btnPlaceOrder.Text = "Place &Order";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(366, 296);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(89, 34);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // gbxAddOns
            // 
            gbxAddOns.Controls.Add(addOnCheckBox3);
            gbxAddOns.Controls.Add(addOnCheckBox2);
            gbxAddOns.Controls.Add(addOnCheckBox1);
            gbxAddOns.Location = new Point(250, 22);
            gbxAddOns.Name = "gbxAddOns";
            gbxAddOns.Size = new Size(233, 130);
            gbxAddOns.TabIndex = 4;
            gbxAddOns.TabStop = false;
            gbxAddOns.Text = "Add-on Items ($.75/each)";
            gbxAddOns.Enter += groupBox1_Enter;
            // 
            // addOnCheckBox3
            // 
            addOnCheckBox3.AutoSize = true;
            addOnCheckBox3.Location = new Point(6, 86);
            addOnCheckBox3.Name = "addOnCheckBox3";
            addOnCheckBox3.Size = new Size(106, 24);
            addOnCheckBox3.TabIndex = 2;
            addOnCheckBox3.Text = "French fries";
            addOnCheckBox3.UseVisualStyleBackColor = true;
            addOnCheckBox3.CheckedChanged += addOnCheckBox_CheckedChanged;
            // 
            // addOnCheckBox2
            // 
            addOnCheckBox2.AutoSize = true;
            addOnCheckBox2.Location = new Point(6, 56);
            addOnCheckBox2.Name = "addOnCheckBox2";
            addOnCheckBox2.Size = new Size(219, 24);
            addOnCheckBox2.TabIndex = 1;
            addOnCheckBox2.Text = "Ketchup, mustard, and mayo";
            addOnCheckBox2.UseVisualStyleBackColor = true;
            addOnCheckBox2.CheckedChanged += addOnCheckBox_CheckedChanged;
            // 
            // addOnCheckBox1
            // 
            addOnCheckBox1.AutoSize = true;
            addOnCheckBox1.Location = new Point(6, 26);
            addOnCheckBox1.Name = "addOnCheckBox1";
            addOnCheckBox1.Size = new Size(215, 24);
            addOnCheckBox1.TabIndex = 0;
            addOnCheckBox1.Text = "Lettuce, tomato, and onions";
            addOnCheckBox1.UseVisualStyleBackColor = true;
            addOnCheckBox1.CheckedChanged += addOnCheckBox_CheckedChanged;
            // 
            // Form1
            // 
            AcceptButton = btnPlaceOrder;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(495, 366);
            Controls.Add(gbxAddOns);
            Controls.Add(btnExit);
            Controls.Add(btnPlaceOrder);
            Controls.Add(groupBox2);
            Controls.Add(gbxMainCourse);
            Margin = new Padding(2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dylan Bausch's Lunch Order";
            gbxMainCourse.ResumeLayout(false);
            gbxMainCourse.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            gbxAddOns.ResumeLayout(false);
            gbxAddOns.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.GroupBox gbxMainCourse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSalesTax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnExit;
        private RadioButton mainCourseButton3;
        private RadioButton mainCourseButton2;
        private RadioButton mainCourseButton1;
        private GroupBox gbxAddOns;
        private CheckBox addOnCheckBox2;
        private CheckBox addOnCheckBox1;
        private CheckBox addOnCheckBox3;
    }
}
