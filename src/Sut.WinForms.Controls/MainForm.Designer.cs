namespace Sut.WinForms.Controls
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Program Files");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Program Files (x86)");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("ProgramData");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Users");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Windows");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("C:", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button = new System.Windows.Forms.Button();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.groupBoxLabel = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.listBox = new System.Windows.Forms.ListBox();
            this.listView = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCustomer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.radioButton = new System.Windows.Forms.RadioButton();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageOne = new System.Windows.Forms.TabPage();
            this.tabPageTwo = new System.Windows.Forms.TabPage();
            this.tabPageThree = new System.Windows.Forms.TabPage();
            this.textBox = new System.Windows.Forms.TextBox();
            this.treeView = new System.Windows.Forms.TreeView();
            this.flowLayoutPanel.SuspendLayout();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel.Controls.Add(this.button);
            this.flowLayoutPanel.Controls.Add(this.checkBox);
            this.flowLayoutPanel.Controls.Add(this.comboBox);
            this.flowLayoutPanel.Controls.Add(this.dateTimePicker);
            this.flowLayoutPanel.Controls.Add(this.groupBox);
            this.flowLayoutPanel.Controls.Add(this.label);
            this.flowLayoutPanel.Controls.Add(this.linkLabel);
            this.flowLayoutPanel.Controls.Add(this.listBox);
            this.flowLayoutPanel.Controls.Add(this.listView);
            this.flowLayoutPanel.Controls.Add(this.maskedTextBox);
            this.flowLayoutPanel.Controls.Add(this.monthCalendar);
            this.flowLayoutPanel.Controls.Add(this.numericUpDown);
            this.flowLayoutPanel.Controls.Add(this.progressBar);
            this.flowLayoutPanel.Controls.Add(this.radioButton);
            this.flowLayoutPanel.Controls.Add(this.richTextBox);
            this.flowLayoutPanel.Controls.Add(this.tabControl);
            this.flowLayoutPanel.Controls.Add(this.textBox);
            this.flowLayoutPanel.Controls.Add(this.treeView);
            this.flowLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(760, 538);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // button
            // 
            this.button.AutoSize = true;
            this.button.Location = new System.Drawing.Point(3, 3);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(89, 23);
            this.button.TabIndex = 0;
            this.button.Text = "This is a button";
            this.button.UseVisualStyleBackColor = true;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(98, 3);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(118, 17);
            this.checkBox.TabIndex = 1;
            this.checkBox.Text = "This is a check box";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // comboBox
            // 
            this.comboBox.DisplayMember = "Name";
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(222, 3);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 21);
            this.comboBox.TabIndex = 2;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(349, 3);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 3;
            // 
            // groupBox
            // 
            this.groupBox.AutoSize = true;
            this.groupBox.Controls.Add(this.groupBoxLabel);
            this.groupBox.Location = new System.Drawing.Point(555, 3);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(78, 45);
            this.groupBox.TabIndex = 4;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Group box";
            // 
            // groupBoxLabel
            // 
            this.groupBoxLabel.AutoSize = true;
            this.groupBoxLabel.Location = new System.Drawing.Point(6, 16);
            this.groupBoxLabel.Name = "groupBoxLabel";
            this.groupBoxLabel.Size = new System.Drawing.Size(66, 13);
            this.groupBoxLabel.TabIndex = 0;
            this.groupBoxLabel.Text = "This is a text";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(639, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(71, 13);
            this.label.TabIndex = 5;
            this.label.Text = "This is a label";
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Location = new System.Drawing.Point(3, 51);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(90, 13);
            this.linkLabel.TabIndex = 6;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "This is a link label";
            // 
            // listBox
            // 
            this.listBox.DisplayMember = "Name";
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(99, 54);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(120, 95);
            this.listBox.TabIndex = 7;
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnCustomer,
            this.columnGender});
            this.listView.FullRowSelect = true;
            this.listView.Location = new System.Drawing.Point(225, 54);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(200, 97);
            this.listView.TabIndex = 8;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            // 
            // columnCustomer
            // 
            this.columnCustomer.Text = "Customer";
            // 
            // columnGender
            // 
            this.columnGender.Text = "Gender";
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(431, 54);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(140, 20);
            this.maskedTextBox.TabIndex = 9;
            this.maskedTextBox.Text = "This is a masked text box";
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(9, 163);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 10;
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(192, 157);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown.TabIndex = 11;
            this.numericUpDown.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(318, 157);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 23);
            this.progressBar.TabIndex = 12;
            this.progressBar.Value = 25;
            // 
            // radioButton
            // 
            this.radioButton.AutoSize = true;
            this.radioButton.Location = new System.Drawing.Point(424, 157);
            this.radioButton.Name = "radioButton";
            this.radioButton.Size = new System.Drawing.Size(123, 17);
            this.radioButton.TabIndex = 13;
            this.radioButton.TabStop = true;
            this.radioButton.Text = "This is a radio button";
            this.radioButton.UseVisualStyleBackColor = true;
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(553, 157);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(100, 96);
            this.richTextBox.TabIndex = 14;
            this.richTextBox.Text = "This is a rich text box";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageOne);
            this.tabControl.Controls.Add(this.tabPageTwo);
            this.tabControl.Controls.Add(this.tabPageThree);
            this.tabControl.Location = new System.Drawing.Point(3, 337);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(200, 100);
            this.tabControl.TabIndex = 15;
            // 
            // tabPageOne
            // 
            this.tabPageOne.Location = new System.Drawing.Point(4, 22);
            this.tabPageOne.Name = "tabPageOne";
            this.tabPageOne.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOne.Size = new System.Drawing.Size(192, 74);
            this.tabPageOne.TabIndex = 0;
            this.tabPageOne.Text = "One";
            this.tabPageOne.UseVisualStyleBackColor = true;
            // 
            // tabPageTwo
            // 
            this.tabPageTwo.Location = new System.Drawing.Point(4, 22);
            this.tabPageTwo.Name = "tabPageTwo";
            this.tabPageTwo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTwo.Size = new System.Drawing.Size(192, 74);
            this.tabPageTwo.TabIndex = 1;
            this.tabPageTwo.Text = "Two";
            this.tabPageTwo.UseVisualStyleBackColor = true;
            // 
            // tabPageThree
            // 
            this.tabPageThree.Location = new System.Drawing.Point(4, 22);
            this.tabPageThree.Name = "tabPageThree";
            this.tabPageThree.Size = new System.Drawing.Size(192, 74);
            this.tabPageThree.TabIndex = 2;
            this.tabPageThree.Text = "Three";
            this.tabPageThree.UseVisualStyleBackColor = true;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(209, 337);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(100, 20);
            this.textBox.TabIndex = 16;
            this.textBox.Text = "This is a text box";
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(315, 337);
            this.treeView.Name = "treeView";
            treeNode1.Name = "NodeProgramFiles";
            treeNode1.Text = "Program Files";
            treeNode2.Name = "NodeProgramFilesx86";
            treeNode2.Text = "Program Files (x86)";
            treeNode3.Name = "NodeProgramData";
            treeNode3.Text = "ProgramData";
            treeNode4.Name = "NodeUsers";
            treeNode4.Text = "Users";
            treeNode5.Name = "NodeWindows";
            treeNode5.Text = "Windows";
            treeNode6.Name = "NodeRoot";
            treeNode6.Text = "C:";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.treeView.Size = new System.Drawing.Size(150, 120);
            this.treeView.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.flowLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "System Under Test (WinForms)";
            this.flowLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanel.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.LinkLabel linkLabel;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.RadioButton radioButton;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageOne;
        private System.Windows.Forms.TabPage tabPageTwo;
        private System.Windows.Forms.Label groupBoxLabel;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnCustomer;
        private System.Windows.Forms.ColumnHeader columnGender;
        private System.Windows.Forms.TabPage tabPageThree;

    }
}

