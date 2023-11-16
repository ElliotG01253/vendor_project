namespace VendorProject
{
    partial class frontPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frontPage));
            userNameBox = new TextBox();
            passwordBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            logInButton = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // userNameBox
            // 
            userNameBox.Location = new Point(94, 22);
            userNameBox.Name = "userNameBox";
            userNameBox.Size = new Size(100, 23);
            userNameBox.TabIndex = 0;
            userNameBox.TextChanged += textBox1_TextChanged;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(94, 51);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(100, 23);
            passwordBox.TabIndex = 1;
            passwordBox.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 23);
            label1.Name = "label1";
            label1.Size = new Size(71, 19);
            label1.TabIndex = 2;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(17, 51);
            label2.Name = "label2";
            label2.Size = new Size(67, 19);
            label2.TabIndex = 3;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // logInButton
            // 
            logInButton.Location = new Point(94, 80);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(75, 23);
            logInButton.TabIndex = 0;
            logInButton.Text = "Log In";
            logInButton.UseVisualStyleBackColor = true;
            logInButton.Click += logInButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(userNameBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(logInButton);
            groupBox1.Controls.Add(passwordBox);
            groupBox1.Location = new Point(690, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 109);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Log In";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(690, 143);
            label3.Name = "label3";
            label3.Size = new Size(87, 19);
            label3.TabIndex = 5;
            label3.Text = "Access Level:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(729, 124);
            label4.Name = "label4";
            label4.Size = new Size(48, 19);
            label4.TabIndex = 6;
            label4.Text = "Name:";
            label4.Click += label4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(254, 254, 252);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(295, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(367, 199);
            button1.Name = "button1";
            button1.Size = new Size(223, 44);
            button1.TabIndex = 8;
            button1.Text = "View Vendors";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(367, 249);
            button2.Name = "button2";
            button2.Size = new Size(223, 44);
            button2.TabIndex = 9;
            button2.Text = "Create Vendors";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(367, 299);
            button3.Name = "button3";
            button3.Size = new Size(223, 44);
            button3.TabIndex = 10;
            button3.Text = "Edit Vendors";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 254, 253);
            ClientSize = new Size(902, 549);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "frontPage";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userNameBox;
        private TextBox passwordBox;
        private Label label1;
        private Label label2;
        private Button logInButton;
        private GroupBox groupBox1;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}