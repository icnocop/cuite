namespace Sut.WinForms.ScreenComponents
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.checkBoxUpperLeft = new System.Windows.Forms.CheckBox();
            this.radioButtonLowerLeft = new System.Windows.Forms.RadioButton();
            this.checkBoxUpperRight = new System.Windows.Forms.CheckBox();
            this.radioButtonLowerRight = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // checkBoxUpperLeft
            // 
            this.checkBoxUpperLeft.AutoSize = true;
            this.checkBoxUpperLeft.Location = new System.Drawing.Point(12, 36);
            this.checkBoxUpperLeft.Name = "checkBoxUpperLeft";
            this.checkBoxUpperLeft.Size = new System.Drawing.Size(72, 17);
            this.checkBoxUpperLeft.TabIndex = 0;
            this.checkBoxUpperLeft.Text = "Upper left";
            this.checkBoxUpperLeft.UseVisualStyleBackColor = true;
            // 
            // radioButtonLowerLeft
            // 
            this.radioButtonLowerLeft.AutoSize = true;
            this.radioButtonLowerLeft.Location = new System.Drawing.Point(12, 110);
            this.radioButtonLowerLeft.Name = "radioButtonLowerLeft";
            this.radioButtonLowerLeft.Size = new System.Drawing.Size(71, 17);
            this.radioButtonLowerLeft.TabIndex = 1;
            this.radioButtonLowerLeft.TabStop = true;
            this.radioButtonLowerLeft.Text = "Lower left";
            this.radioButtonLowerLeft.UseVisualStyleBackColor = true;
            // 
            // checkBoxUpperRight
            // 
            this.checkBoxUpperRight.AutoSize = true;
            this.checkBoxUpperRight.Location = new System.Drawing.Point(94, 36);
            this.checkBoxUpperRight.Name = "checkBoxUpperRight";
            this.checkBoxUpperRight.Size = new System.Drawing.Size(78, 17);
            this.checkBoxUpperRight.TabIndex = 0;
            this.checkBoxUpperRight.Text = "Upper right";
            this.checkBoxUpperRight.UseVisualStyleBackColor = true;
            // 
            // radioButtonLowerRight
            // 
            this.radioButtonLowerRight.AutoSize = true;
            this.radioButtonLowerRight.Location = new System.Drawing.Point(94, 110);
            this.radioButtonLowerRight.Name = "radioButtonLowerRight";
            this.radioButtonLowerRight.Size = new System.Drawing.Size(77, 17);
            this.radioButtonLowerRight.TabIndex = 1;
            this.radioButtonLowerRight.TabStop = true;
            this.radioButtonLowerRight.Text = "Lower right";
            this.radioButtonLowerRight.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 162);
            this.Controls.Add(this.radioButtonLowerRight);
            this.Controls.Add(this.radioButtonLowerLeft);
            this.Controls.Add(this.checkBoxUpperRight);
            this.Controls.Add(this.checkBoxUpperLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "System Under Test (WinForms)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxUpperLeft;
        private System.Windows.Forms.RadioButton radioButtonLowerLeft;
        private System.Windows.Forms.CheckBox checkBoxUpperRight;
        private System.Windows.Forms.RadioButton radioButtonLowerRight;
    }
}

