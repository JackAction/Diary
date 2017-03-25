namespace MainForm
{
    partial class ucNewSingleItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAddNewSingleItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 5);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(21, 20);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "...";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(10, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(175, 26);
            this.txtName.TabIndex = 4;
            // 
            // btnAddNewSingleItem
            // 
            this.btnAddNewSingleItem.Location = new System.Drawing.Point(192, 5);
            this.btnAddNewSingleItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddNewSingleItem.Name = "btnAddNewSingleItem";
            this.btnAddNewSingleItem.Size = new System.Drawing.Size(106, 49);
            this.btnAddNewSingleItem.TabIndex = 3;
            this.btnAddNewSingleItem.Text = "New ...";
            this.btnAddNewSingleItem.UseVisualStyleBackColor = true;
            this.btnAddNewSingleItem.Click += new System.EventHandler(this.btnAddNewSingleItem_Click);
            // 
            // ucNewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnAddNewSingleItem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucNewItem";
            this.Size = new System.Drawing.Size(304, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAddNewSingleItem;
    }
}
