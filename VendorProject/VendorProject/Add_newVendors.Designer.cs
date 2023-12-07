namespace VendorProject
{
    partial class Add_newVendors
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
            add_vonders_back = new Button();
            add_Vonders = new Button();
            SuspendLayout();
            // 
            // add_vonders_back
            // 
            add_vonders_back.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point);
            add_vonders_back.Location = new Point(57, 47);
            add_vonders_back.Name = "add_vonders_back";
            add_vonders_back.Size = new Size(131, 51);
            add_vonders_back.TabIndex = 0;
            add_vonders_back.Text = "BACK";
            add_vonders_back.UseVisualStyleBackColor = true;
            // 
            // add_Vonders
            // 
            add_Vonders.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            add_Vonders.Location = new Point(991, 590);
            add_Vonders.Name = "add_Vonders";
            add_Vonders.Size = new Size(168, 52);
            add_Vonders.TabIndex = 1;
            add_Vonders.Text = "Add Vendors";
            add_Vonders.UseVisualStyleBackColor = true;
            add_Vonders.Click += add_Vonders_Click;
            // 
            // Add_newVendors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1261, 696);
            Controls.Add(add_Vonders);
            Controls.Add(add_vonders_back);
            Name = "Add_newVendors";
            Text = "Add_newVendors";
            ResumeLayout(false);
        }

        #endregion

        private Button add_vonders_back;
        private Button add_Vonders;
    }
}