namespace CashierApplication
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblTotalAmount = new Label();
            label6 = new Label();
            lblChange = new Label();
            TextItemName = new TextBox();
            TextPrice = new TextBox();
            TextDiscount = new TextBox();
            TextQuantity = new TextBox();
            TextAmountPaid = new TextBox();
            btnCompute = new Button();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 34);
            label1.Name = "label1";
            label1.Size = new Size(99, 21);
            label1.TabIndex = 0;
            label1.Text = "Item Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 118);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 1;
            label2.Text = "Price:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(519, 34);
            label3.Name = "label3";
            label3.Size = new Size(112, 21);
            label3.TabIndex = 2;
            label3.Text = "Discount (%):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(519, 118);
            label4.Name = "label4";
            label4.Size = new Size(81, 21);
            label4.TabIndex = 3;
            label4.Text = "Quantity:";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAmount.Location = new Point(123, 260);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(122, 21);
            lblTotalAmount.TabIndex = 4;
            lblTotalAmount.Text = "Total Amount: ";
            lblTotalAmount.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(86, 305);
            label6.Name = "label6";
            label6.Size = new Size(159, 21);
            label6.TabIndex = 5;
            label6.Text = "Payment Received: ";
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChange.Location = new Point(173, 361);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(72, 21);
            lblChange.TabIndex = 6;
            lblChange.Text = "Change:";
            // 
            // TextItemName
            // 
            TextItemName.Location = new Point(44, 69);
            TextItemName.Name = "TextItemName";
            TextItemName.Size = new Size(370, 23);
            TextItemName.TabIndex = 7;
            TextItemName.TextChanged += TextItemName_TextChanged;
            // 
            // TextPrice
            // 
            TextPrice.Location = new Point(44, 152);
            TextPrice.Name = "TextPrice";
            TextPrice.Size = new Size(370, 23);
            TextPrice.TabIndex = 8;
            TextPrice.TextChanged += TextPrice_TextChanged;
            // 
            // TextDiscount
            // 
            TextDiscount.Location = new Point(519, 69);
            TextDiscount.Name = "TextDiscount";
            TextDiscount.Size = new Size(311, 23);
            TextDiscount.TabIndex = 9;
            TextDiscount.TextChanged += TextDiscount_TextChanged;
            // 
            // TextQuantity
            // 
            TextQuantity.Location = new Point(519, 152);
            TextQuantity.Name = "TextQuantity";
            TextQuantity.Size = new Size(311, 23);
            TextQuantity.TabIndex = 10;
            TextQuantity.TextChanged += TextQuantity_TextChanged;
            // 
            // TextAmountPaid
            // 
            TextAmountPaid.Location = new Point(251, 305);
            TextAmountPaid.Name = "TextAmountPaid";
            TextAmountPaid.Size = new Size(317, 23);
            TextAmountPaid.TabIndex = 11;
            TextAmountPaid.TextChanged += TextAmountPaid_TextChanged;
            // 
            // btnCompute
            // 
            btnCompute.BackColor = Color.Aquamarine;
            btnCompute.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCompute.Location = new Point(334, 196);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(218, 44);
            btnCompute.TabIndex = 12;
            btnCompute.Text = "Compute";
            btnCompute.UseVisualStyleBackColor = false;
            btnCompute.Click += btnCompute_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Aquamarine;
            btnSubmit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(605, 300);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(213, 35);
            btnSubmit.TabIndex = 13;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(905, 450);
            Controls.Add(btnSubmit);
            Controls.Add(btnCompute);
            Controls.Add(TextAmountPaid);
            Controls.Add(TextQuantity);
            Controls.Add(TextDiscount);
            Controls.Add(TextPrice);
            Controls.Add(TextItemName);
            Controls.Add(lblChange);
            Controls.Add(label6);
            Controls.Add(lblTotalAmount);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblTotalAmount;
        private Label label6;
        private Label lblChange;
        private TextBox TextItemName;
        private TextBox TextPrice;
        private TextBox TextDiscount;
        private TextBox TextQuantity;
        private TextBox TextAmountPaid;
        private Button btnCompute;
        private Button btnSubmit;
    }
}
