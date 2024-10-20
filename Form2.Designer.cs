namespace CashierApplication
{
    partial class frmLoginAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            TextUser = new TextBox();
            TextPass = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(68, 47);
            label1.Name = "label1";
            label1.Size = new Size(101, 22);
            label1.TabIndex = 0;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(68, 135);
            label2.Name = "label2";
            label2.Size = new Size(90, 22);
            label2.TabIndex = 1;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // TextUser
            // 
            TextUser.Location = new Point(68, 88);
            TextUser.Name = "TextUser";
            TextUser.Size = new Size(320, 23);
            TextUser.TabIndex = 2;
            TextUser.TextChanged += TextUser_TextChanged;
            // 
            // TextPass
            // 
            TextPass.Location = new Point(68, 171);
            TextPass.Name = "TextPass";
            TextPass.Size = new Size(320, 23);
            TextPass.TabIndex = 3;
            TextPass.TextChanged += TextPass_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Aquamarine;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(95, 228);
            button1.Name = "button1";
            button1.Size = new Size(237, 69);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // frmLoginAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(478, 329);
            Controls.Add(button1);
            Controls.Add(TextPass);
            Controls.Add(TextUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmLoginAccount";
            Text = "User Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TextUser;
        private TextBox TextPass;
        private Button button1;
    }
}