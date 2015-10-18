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
            this.groupBoxUpperLeft = new System.Windows.Forms.GroupBox();
            this.groupBoxUpperRight = new System.Windows.Forms.GroupBox();
            this.groupBoxLowerLeft = new System.Windows.Forms.GroupBox();
            this.groupBoxLowerRight = new System.Windows.Forms.GroupBox();
            this.buttonOpenModalDialog = new System.Windows.Forms.Button();
            this.buttonOpenNonModalDialog = new System.Windows.Forms.Button();
            this.groupBoxUpperLeft.SuspendLayout();
            this.groupBoxUpperRight.SuspendLayout();
            this.groupBoxLowerLeft.SuspendLayout();
            this.groupBoxLowerRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxUpperLeft
            // 
            this.checkBoxUpperLeft.AutoSize = true;
            this.checkBoxUpperLeft.Location = new System.Drawing.Point(6, 19);
            this.checkBoxUpperLeft.Name = "checkBoxUpperLeft";
            this.checkBoxUpperLeft.Size = new System.Drawing.Size(107, 17);
            this.checkBoxUpperLeft.TabIndex = 0;
            this.checkBoxUpperLeft.Text = "Upper left control";
            this.checkBoxUpperLeft.UseVisualStyleBackColor = true;
            // 
            // radioButtonLowerLeft
            // 
            this.radioButtonLowerLeft.AutoSize = true;
            this.radioButtonLowerLeft.Location = new System.Drawing.Point(6, 19);
            this.radioButtonLowerLeft.Name = "radioButtonLowerLeft";
            this.radioButtonLowerLeft.Size = new System.Drawing.Size(106, 17);
            this.radioButtonLowerLeft.TabIndex = 1;
            this.radioButtonLowerLeft.TabStop = true;
            this.radioButtonLowerLeft.Text = "Lower left control";
            this.radioButtonLowerLeft.UseVisualStyleBackColor = true;
            // 
            // checkBoxUpperRight
            // 
            this.checkBoxUpperRight.AutoSize = true;
            this.checkBoxUpperRight.Location = new System.Drawing.Point(6, 19);
            this.checkBoxUpperRight.Name = "checkBoxUpperRight";
            this.checkBoxUpperRight.Size = new System.Drawing.Size(113, 17);
            this.checkBoxUpperRight.TabIndex = 0;
            this.checkBoxUpperRight.Text = "Upper right control";
            this.checkBoxUpperRight.UseVisualStyleBackColor = true;
            // 
            // radioButtonLowerRight
            // 
            this.radioButtonLowerRight.AutoSize = true;
            this.radioButtonLowerRight.Location = new System.Drawing.Point(6, 19);
            this.radioButtonLowerRight.Name = "radioButtonLowerRight";
            this.radioButtonLowerRight.Size = new System.Drawing.Size(112, 17);
            this.radioButtonLowerRight.TabIndex = 1;
            this.radioButtonLowerRight.TabStop = true;
            this.radioButtonLowerRight.Text = "Lower right control";
            this.radioButtonLowerRight.UseVisualStyleBackColor = true;
            // 
            // groupBoxUpperLeft
            // 
            this.groupBoxUpperLeft.Controls.Add(this.checkBoxUpperLeft);
            this.groupBoxUpperLeft.Location = new System.Drawing.Point(12, 12);
            this.groupBoxUpperLeft.Name = "groupBoxUpperLeft";
            this.groupBoxUpperLeft.Size = new System.Drawing.Size(134, 50);
            this.groupBoxUpperLeft.TabIndex = 2;
            this.groupBoxUpperLeft.TabStop = false;
            this.groupBoxUpperLeft.Text = "Upper Left Group";
            // 
            // groupBoxUpperRight
            // 
            this.groupBoxUpperRight.Controls.Add(this.checkBoxUpperRight);
            this.groupBoxUpperRight.Location = new System.Drawing.Point(152, 12);
            this.groupBoxUpperRight.Name = "groupBoxUpperRight";
            this.groupBoxUpperRight.Size = new System.Drawing.Size(134, 50);
            this.groupBoxUpperRight.TabIndex = 3;
            this.groupBoxUpperRight.TabStop = false;
            this.groupBoxUpperRight.Text = "Upper Right Group";
            // 
            // groupBoxLowerLeft
            // 
            this.groupBoxLowerLeft.Controls.Add(this.radioButtonLowerLeft);
            this.groupBoxLowerLeft.Location = new System.Drawing.Point(12, 97);
            this.groupBoxLowerLeft.Name = "groupBoxLowerLeft";
            this.groupBoxLowerLeft.Size = new System.Drawing.Size(134, 50);
            this.groupBoxLowerLeft.TabIndex = 3;
            this.groupBoxLowerLeft.TabStop = false;
            this.groupBoxLowerLeft.Text = "Lower Left Group";
            // 
            // groupBoxLowerRight
            // 
            this.groupBoxLowerRight.Controls.Add(this.radioButtonLowerRight);
            this.groupBoxLowerRight.Location = new System.Drawing.Point(152, 97);
            this.groupBoxLowerRight.Name = "groupBoxLowerRight";
            this.groupBoxLowerRight.Size = new System.Drawing.Size(134, 50);
            this.groupBoxLowerRight.TabIndex = 4;
            this.groupBoxLowerRight.TabStop = false;
            this.groupBoxLowerRight.Text = "Lower Left Group";
            // 
            // buttonOpenModalDialog
            // 
            this.buttonOpenModalDialog.Location = new System.Drawing.Point(12, 68);
            this.buttonOpenModalDialog.Name = "buttonOpenModalDialog";
            this.buttonOpenModalDialog.Size = new System.Drawing.Size(134, 23);
            this.buttonOpenModalDialog.TabIndex = 5;
            this.buttonOpenModalDialog.Text = "Open Modal Dialog";
            this.buttonOpenModalDialog.UseVisualStyleBackColor = true;
            this.buttonOpenModalDialog.Click += new System.EventHandler(this.buttonOpenModalDialog_Click);
            // 
            // buttonOpenNonModalDialog
            // 
            this.buttonOpenNonModalDialog.Location = new System.Drawing.Point(152, 68);
            this.buttonOpenNonModalDialog.Name = "buttonOpenNonModalDialog";
            this.buttonOpenNonModalDialog.Size = new System.Drawing.Size(134, 23);
            this.buttonOpenNonModalDialog.TabIndex = 5;
            this.buttonOpenNonModalDialog.Text = "Open Non-Modal Dialog";
            this.buttonOpenNonModalDialog.UseVisualStyleBackColor = true;
            this.buttonOpenNonModalDialog.Click += new System.EventHandler(this.buttonOpenNonModalDialog_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 159);
            this.Controls.Add(this.buttonOpenNonModalDialog);
            this.Controls.Add(this.buttonOpenModalDialog);
            this.Controls.Add(this.groupBoxLowerRight);
            this.Controls.Add(this.groupBoxLowerLeft);
            this.Controls.Add(this.groupBoxUpperRight);
            this.Controls.Add(this.groupBoxUpperLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "System Under Test (WinForms)";
            this.groupBoxUpperLeft.ResumeLayout(false);
            this.groupBoxUpperLeft.PerformLayout();
            this.groupBoxUpperRight.ResumeLayout(false);
            this.groupBoxUpperRight.PerformLayout();
            this.groupBoxLowerLeft.ResumeLayout(false);
            this.groupBoxLowerLeft.PerformLayout();
            this.groupBoxLowerRight.ResumeLayout(false);
            this.groupBoxLowerRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxUpperLeft;
        private System.Windows.Forms.RadioButton radioButtonLowerLeft;
        private System.Windows.Forms.CheckBox checkBoxUpperRight;
        private System.Windows.Forms.RadioButton radioButtonLowerRight;
        private System.Windows.Forms.GroupBox groupBoxUpperLeft;
        private System.Windows.Forms.GroupBox groupBoxUpperRight;
        private System.Windows.Forms.GroupBox groupBoxLowerLeft;
        private System.Windows.Forms.GroupBox groupBoxLowerRight;
        private System.Windows.Forms.Button buttonOpenModalDialog;
        private System.Windows.Forms.Button buttonOpenNonModalDialog;
    }
}

