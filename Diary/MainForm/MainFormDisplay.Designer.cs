namespace MainForm
{
    partial class MainFormDisplay
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
            this.mstControl = new System.Windows.Forms.TabControl();
            this.tabDiary = new System.Windows.Forms.TabPage();
            this.tabPerson = new System.Windows.Forms.TabPage();
            this.mstControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstControl
            // 
            this.mstControl.Controls.Add(this.tabDiary);
            this.mstControl.Controls.Add(this.tabPerson);
            this.mstControl.Location = new System.Drawing.Point(12, 98);
            this.mstControl.Name = "mstControl";
            this.mstControl.SelectedIndex = 0;
            this.mstControl.Size = new System.Drawing.Size(880, 487);
            this.mstControl.TabIndex = 0;
            // 
            // tabDiary
            // 
            this.tabDiary.Location = new System.Drawing.Point(4, 22);
            this.tabDiary.Name = "tabDiary";
            this.tabDiary.Padding = new System.Windows.Forms.Padding(3);
            this.tabDiary.Size = new System.Drawing.Size(872, 461);
            this.tabDiary.TabIndex = 0;
            this.tabDiary.Text = "Diary";
            this.tabDiary.UseVisualStyleBackColor = true;
            // 
            // tabPerson
            // 
            this.tabPerson.Location = new System.Drawing.Point(4, 22);
            this.tabPerson.Name = "tabPerson";
            this.tabPerson.Padding = new System.Windows.Forms.Padding(3);
            this.tabPerson.Size = new System.Drawing.Size(872, 461);
            this.tabPerson.TabIndex = 1;
            this.tabPerson.Text = "Persons";
            this.tabPerson.UseVisualStyleBackColor = true;
            // 
            // MainFormDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 613);
            this.Controls.Add(this.mstControl);
            this.Name = "MainFormDisplay";
            this.Text = "D&D Diary";
            this.mstControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mstControl;
        private System.Windows.Forms.TabPage tabDiary;
        private System.Windows.Forms.TabPage tabPerson;
    }
}

