using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using VendorProject.Properties;

namespace VendorProject
{
    partial class viewVendors
    {
        private IContainer components = null;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private TextBox searchTextBox; // Added TextBox for search
        private Button filterButton; // Added Button for filter
        private SaveFileDialog saveFileDialog1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            searchTextBox = new TextBox();
            filterButton = new Button();
            saveFileDialog1 = new SaveFileDialog();
            Search = new Label();
            ((ISupportInitialize)pictureBox1).BeginInit();
            ((ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(254, 254, 252);
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(295, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(509, 105);
            label1.Name = "label1";
            label1.Size = new Size(0, 21);
            label1.TabIndex = 11;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(447, 12);
            label2.Name = "label2";
            label2.Size = new Size(221, 43);
            label2.TabIndex = 12;
            label2.Text = "View vendors";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 186);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(878, 351);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(334, 156);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(429, 23);
            searchTextBox.TabIndex = 14;
            // 
            // filterButton
            // 
            filterButton.Location = new Point(788, 156);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(102, 23);
            filterButton.TabIndex = 15;
            filterButton.Text = "Filter";
            filterButton.UseVisualStyleBackColor = true;
            filterButton.Click += filterButton_Click;
            // 
            // Search
            // 
            Search.AutoSize = true;
            Search.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Search.Location = new Point(334, 133);
            Search.Name = "Search";
            Search.Size = new Size(59, 20);
            Search.TabIndex = 16;
            Search.Text = "Search";
            // 
            // viewVendors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 254, 252);
            ClientSize = new Size(902, 549);
            Controls.Add(Search);
            Controls.Add(filterButton);
            Controls.Add(searchTextBox);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "viewVendors";
            Text = "View vendors";
            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label Search;
    }
}
