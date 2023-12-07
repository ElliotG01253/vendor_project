namespace VendorProject
{
    partial class changeRightsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(changeRightsForm));
            pictureBox1 = new PictureBox();
            dgvUsers = new DataGridView();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            Groups = new ListBox();
            Submit_Button = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(254, 254, 252);
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(295, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += button1_Click;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(12, 194);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowTemplate.Height = 25;
            dgvUsers.Size = new Size(375, 343);
            dgvUsers.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(583, 194);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Search_Button_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(412, 194);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 23);
            textBox1.TabIndex = 12;
            textBox1.Text = "Search";
            textBox1.Enter += textBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(412, 164);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(412, 265);
            label2.Name = "label2";
            label2.Size = new Size(181, 15);
            label2.TabIndex = 14;
            label2.Text = "Type username to change Group ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(412, 283);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(181, 23);
            textBox2.TabIndex = 15;
            textBox2.Text = "Username";
            textBox2.Enter += textBox2_Enter;
            // 
            // Groups
            // 
            Groups.FormattingEnabled = true;
            Groups.ItemHeight = 15;
            Groups.Items.AddRange(new object[] { "Standard User", "System Admin", "Directing Manager" });
            Groups.Location = new Point(412, 312);
            Groups.Name = "Groups";
            Groups.Size = new Size(181, 49);
            Groups.TabIndex = 16;
            // 
            // Submit_Button
            // 
            Submit_Button.Location = new Point(412, 367);
            Submit_Button.Name = "Submit_Button";
            Submit_Button.Size = new Size(181, 35);
            Submit_Button.TabIndex = 17;
            Submit_Button.Text = "Submit";
            Submit_Button.UseVisualStyleBackColor = true;
            Submit_Button.Click += Submit_Button_Click;
            // 
            // changeRightsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 254, 252);
            ClientSize = new Size(902, 549);
            Controls.Add(Submit_Button);
            Controls.Add(Groups);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(dgvUsers);
            Controls.Add(pictureBox1);
            Name = "changeRightsForm";
            Text = "changeRightsForm";
            Load += changeRightsForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView dgvUsers;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private ListBox Groups;
        private Button Submit_Button;
    }
}