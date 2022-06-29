namespace Product
{
    partial class frmListView
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
            this.ucForm1 = new Product.UCForm();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // ucForm1
            // 
            this.ucForm1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucForm1.Location = new System.Drawing.Point(13, 14);
            this.ucForm1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucForm1.Name = "ucForm1";
            this.ucForm1.Size = new System.Drawing.Size(908, 184);
            this.ucForm1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 206);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(909, 474);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // frmListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 692);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ucForm1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmListView";
            this.Text = "frmListView";
            this.Load += new System.EventHandler(this.frmListView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UCForm ucForm1;
        private System.Windows.Forms.ListView listView1;
    }
}