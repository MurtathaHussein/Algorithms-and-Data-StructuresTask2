namespace Week3TaskB
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InsertButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.OutputListBox = new System.Windows.Forms.ListBox();
            this.AvaliableButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(314, 275);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(131, 26);
            this.InsertButton.TabIndex = 0;
            this.InsertButton.Text = "Insert";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(468, 269);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(184, 38);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(513, 202);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(118, 23);
            this.NameTextBox.TabIndex = 2;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(294, 202);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(187, 23);
            this.idTextBox.TabIndex = 3;
            // 
            // DisplayButton
            // 
            this.DisplayButton.Location = new System.Drawing.Point(81, 314);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(127, 38);
            this.DisplayButton.TabIndex = 4;
            this.DisplayButton.Text = "Display";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // OutputListBox
            // 
            this.OutputListBox.FormattingEnabled = true;
            this.OutputListBox.ItemHeight = 15;
            this.OutputListBox.Location = new System.Drawing.Point(81, 65);
            this.OutputListBox.Name = "OutputListBox";
            this.OutputListBox.Size = new System.Drawing.Size(139, 199);
            this.OutputListBox.TabIndex = 5;
            this.OutputListBox.SelectedIndexChanged += new System.EventHandler(this.OutputListBox_SelectedIndexChanged);
            // 
            // AvaliableButton
            // 
            this.AvaliableButton.Location = new System.Drawing.Point(678, 270);
            this.AvaliableButton.Name = "AvaliableButton";
            this.AvaliableButton.Size = new System.Drawing.Size(103, 32);
            this.AvaliableButton.TabIndex = 6;
            this.AvaliableButton.Text = "Available";
            this.AvaliableButton.UseVisualStyleBackColor = true;
            this.AvaliableButton.Click += new System.EventHandler(this.AvaliableButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AvaliableButton);
            this.Controls.Add(this.OutputListBox);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.InsertButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button InsertButton;
        private Button RemoveButton;
        private TextBox NameTextBox;
        private TextBox idTextBox;
        private Button DisplayButton;
        private ListBox OutputListBox;
        private Button AvaliableButton;
    }
}