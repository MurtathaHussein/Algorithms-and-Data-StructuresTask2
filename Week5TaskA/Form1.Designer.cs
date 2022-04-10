namespace Week5TaskA
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
            this.Value = new System.Windows.Forms.TextBox();
            this.Nodevaluebutton = new System.Windows.Forms.Button();
            this.addedgebutton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Value
            // 
            this.Value.Location = new System.Drawing.Point(92, 288);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(213, 23);
            this.Value.TabIndex = 0;
            // 
            // Nodevaluebutton
            // 
            this.Nodevaluebutton.Location = new System.Drawing.Point(92, 340);
            this.Nodevaluebutton.Name = "Nodevaluebutton";
            this.Nodevaluebutton.Size = new System.Drawing.Size(228, 39);
            this.Nodevaluebutton.TabIndex = 1;
            this.Nodevaluebutton.Text = "addnode";
            this.Nodevaluebutton.UseVisualStyleBackColor = true;
            this.Nodevaluebutton.Click += new System.EventHandler(this.Nodevaluebutton_Click);
            // 
            // addedgebutton
            // 
            this.addedgebutton.Enabled = false;
            this.addedgebutton.Location = new System.Drawing.Point(416, 325);
            this.addedgebutton.Name = "addedgebutton";
            this.addedgebutton.Size = new System.Drawing.Size(184, 45);
            this.addedgebutton.TabIndex = 2;
            this.addedgebutton.Text = "add edge";
            this.addedgebutton.UseVisualStyleBackColor = true;
            this.addedgebutton.Click += new System.EventHandler(this.addedgebutton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(400, 277);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(124, 34);
            this.listBox1.TabIndex = 3;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(540, 277);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(152, 34);
            this.listBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(547, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.addedgebutton);
            this.Controls.Add(this.Nodevaluebutton);
            this.Controls.Add(this.Value);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Value;
        private Button Nodevaluebutton;
        private Button addedgebutton;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label label1;
        private Label label2;
    }
}