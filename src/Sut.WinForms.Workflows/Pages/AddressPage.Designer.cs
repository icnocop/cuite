namespace Sut.WinForms.Workflows.Pages
{
    partial class AddressPage
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
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelPostalCode = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxPostalCode = new System.Windows.Forms.TextBox();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(3, 6);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(48, 13);
            this.labelAddress.TabIndex = 0;
            this.labelAddress.Text = "Address:";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(3, 32);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(27, 13);
            this.labelCity.TabIndex = 0;
            this.labelCity.Text = "City:";
            // 
            // labelPostalCode
            // 
            this.labelPostalCode.AutoSize = true;
            this.labelPostalCode.Location = new System.Drawing.Point(3, 58);
            this.labelPostalCode.Name = "labelPostalCode";
            this.labelPostalCode.Size = new System.Drawing.Size(67, 13);
            this.labelPostalCode.TabIndex = 0;
            this.labelPostalCode.Text = "Postal Code:";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(3, 84);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(35, 13);
            this.labelState.TabIndex = 0;
            this.labelState.Text = "State:";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.AccessibleName = "Address";
            this.textBoxAddress.Location = new System.Drawing.Point(76, 3);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(171, 20);
            this.textBoxAddress.TabIndex = 1;
            // 
            // textBoxCity
            // 
            this.textBoxCity.AccessibleName = "City";
            this.textBoxCity.Location = new System.Drawing.Point(76, 29);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(171, 20);
            this.textBoxCity.TabIndex = 1;
            // 
            // textBoxPostalCode
            // 
            this.textBoxPostalCode.AccessibleName = "PostalCode";
            this.textBoxPostalCode.Location = new System.Drawing.Point(76, 55);
            this.textBoxPostalCode.Name = "textBoxPostalCode";
            this.textBoxPostalCode.Size = new System.Drawing.Size(171, 20);
            this.textBoxPostalCode.TabIndex = 1;
            // 
            // textBoxState
            // 
            this.textBoxState.AccessibleName = "State";
            this.textBoxState.Location = new System.Drawing.Point(76, 81);
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.Size = new System.Drawing.Size(171, 20);
            this.textBoxState.TabIndex = 1;
            // 
            // AddressPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxState);
            this.Controls.Add(this.textBoxPostalCode);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.labelPostalCode);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelAddress);
            this.Name = "AddressPage";
            this.Size = new System.Drawing.Size(250, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelPostalCode;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxPostalCode;
        private System.Windows.Forms.TextBox textBoxState;
    }
}
