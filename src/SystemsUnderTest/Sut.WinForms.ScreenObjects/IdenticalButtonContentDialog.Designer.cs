namespace Sut.WinForms.ScreenObjects
{
    partial class IdenticalButtonContentDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IdenticalButtonContentDialog));
            this.buttonIdenticalContent = new System.Windows.Forms.Button();
            this.labelDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonIdenticalContent
            // 
            this.buttonIdenticalContent.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonIdenticalContent.Location = new System.Drawing.Point(12, 42);
            this.buttonIdenticalContent.Name = "buttonIdenticalContent";
            this.buttonIdenticalContent.Size = new System.Drawing.Size(189, 23);
            this.buttonIdenticalContent.TabIndex = 7;
            this.buttonIdenticalContent.Text = "Identical Button Content";
            this.buttonIdenticalContent.UseVisualStyleBackColor = true;
            // 
            // labelDescription
            // 
            this.labelDescription.Location = new System.Drawing.Point(12, 9);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(189, 30);
            this.labelDescription.TabIndex = 8;
            this.labelDescription.Text = "Button has identical content as the button in the parent window.";
            // 
            // IdenticalButtonContentDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 77);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.buttonIdenticalContent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IdenticalButtonContentDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Identical Button Content Dialog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonIdenticalContent;
        private System.Windows.Forms.Label labelDescription;
    }
}