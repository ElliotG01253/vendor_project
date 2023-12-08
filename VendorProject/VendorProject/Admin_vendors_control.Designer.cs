namespace VendorProject
{
    partial class Admin_vendors_control
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Emoji", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(47, 42);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(160, 66);
            button1.TabIndex = 0;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(870, 42);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(204, 66);
            button2.TabIndex = 1;
            button2.Text = "login/logout";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(412, 158);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(274, 79);
            button3.TabIndex = 2;
            button3.Text = "View vendors and Services";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(412, 261);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(274, 70);
            button4.TabIndex = 3;
            button4.Text = "Enter New Vendores \r\n";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(412, 364);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(274, 72);
            button5.TabIndex = 4;
            button5.Text = "Edit Vendors";
            button5.UseVisualStyleBackColor = true;
            // 
            // Admin_vendors_control
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 570);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Admin_vendors_control";
            Text = "Admin_vendors_control";
            Load += Admin_vendors_control_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}