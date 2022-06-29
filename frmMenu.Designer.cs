namespace Product
{
    partial class frmMenu
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
            this.btnListBox = new System.Windows.Forms.Button();
            this.btnListView = new System.Windows.Forms.Button();
            this.btnDGV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListBox
            // 
            this.btnListBox.Location = new System.Drawing.Point(64, 17);
            this.btnListBox.Name = "btnListBox";
            this.btnListBox.Size = new System.Drawing.Size(267, 46);
            this.btnListBox.TabIndex = 0;
            this.btnListBox.Text = "List Box";
            this.btnListBox.UseVisualStyleBackColor = true;
            this.btnListBox.Click += new System.EventHandler(this.btnListBox_Click);
            // 
            // btnListView
            // 
            this.btnListView.Location = new System.Drawing.Point(64, 80);
            this.btnListView.Name = "btnListView";
            this.btnListView.Size = new System.Drawing.Size(267, 46);
            this.btnListView.TabIndex = 1;
            this.btnListView.Text = "List View";
            this.btnListView.UseVisualStyleBackColor = true;
            this.btnListView.Click += new System.EventHandler(this.btnListView_Click);
            // 
            // btnDGV
            // 
            this.btnDGV.Location = new System.Drawing.Point(64, 148);
            this.btnDGV.Name = "btnDGV";
            this.btnDGV.Size = new System.Drawing.Size(267, 46);
            this.btnDGV.TabIndex = 2;
            this.btnDGV.Text = "Data Grid View";
            this.btnDGV.UseVisualStyleBackColor = true;
            this.btnDGV.Click += new System.EventHandler(this.btnDGV_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.btnDGV);
            this.Controls.Add(this.btnListView);
            this.Controls.Add(this.btnListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMenu_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListBox;
        private System.Windows.Forms.Button btnListView;
        private System.Windows.Forms.Button btnDGV;
    }
}