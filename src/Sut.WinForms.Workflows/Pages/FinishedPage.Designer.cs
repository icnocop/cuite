namespace Sut.WinForms.Workflows.Pages
{
    partial class FinishedPage
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
            this.labelCongratulations = new System.Windows.Forms.Label();
            this.labelPraise = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCongratulations
            // 
            this.labelCongratulations.Location = new System.Drawing.Point(3, 39);
            this.labelCongratulations.Name = "labelCongratulations";
            this.labelCongratulations.Size = new System.Drawing.Size(244, 23);
            this.labelCongratulations.TabIndex = 0;
            this.labelCongratulations.Text = "Congratulations!!!";
            this.labelCongratulations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPraise
            // 
            this.labelPraise.Location = new System.Drawing.Point(3, 62);
            this.labelPraise.Name = "labelPraise";
            this.labelPraise.Size = new System.Drawing.Size(244, 23);
            this.labelPraise.TabIndex = 0;
            this.labelPraise.Text = "You made it through this worthless wizard.";
            this.labelPraise.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FinishedPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelPraise);
            this.Controls.Add(this.labelCongratulations);
            this.Name = "FinishedPage";
            this.Size = new System.Drawing.Size(250, 150);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCongratulations;
        private System.Windows.Forms.Label labelPraise;
    }
}
