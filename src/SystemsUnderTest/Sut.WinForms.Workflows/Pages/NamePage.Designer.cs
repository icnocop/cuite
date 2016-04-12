namespace Sut.WinForms.Workflows.Pages
{
    partial class NamePage
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
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(3, 6);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(58, 13);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First name:";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(3, 32);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(52, 13);
            this.labelSurname.TabIndex = 0;
            this.labelSurname.Text = "Surname:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.AccessibleName = "FirstName";
            this.textBoxFirstName.Location = new System.Drawing.Point(76, 3);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(171, 20);
            this.textBoxFirstName.TabIndex = 0;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.AccessibleName = "Surname";
            this.textBoxSurname.Location = new System.Drawing.Point(76, 29);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(171, 20);
            this.textBoxSurname.TabIndex = 1;
            // 
            // NamePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelFirstName);
            this.Name = "NamePage";
            this.Size = new System.Drawing.Size(250, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxSurname;
    }
}
