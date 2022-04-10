namespace ExerciseWeek2TaskB
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
            this.label1 = new System.Windows.Forms.Label();
            this.enqueue = new System.Windows.Forms.Button();
            this.dequeue = new System.Windows.Forms.Button();
            this.displayCustomer = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.inputText = new System.Windows.Forms.TextBox();
            this.FeedbackQueue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // enqueue
            // 
            this.enqueue.Location = new System.Drawing.Point(52, 308);
            this.enqueue.Name = "enqueue";
            this.enqueue.Size = new System.Drawing.Size(136, 60);
            this.enqueue.TabIndex = 1;
            this.enqueue.Text = "ADD CUSTOMER";
            this.enqueue.UseVisualStyleBackColor = true;
            this.enqueue.Click += new System.EventHandler(this.enqueue_Click);
            // 
            // dequeue
            // 
            this.dequeue.Location = new System.Drawing.Point(287, 305);
            this.dequeue.Name = "dequeue";
            this.dequeue.Size = new System.Drawing.Size(159, 63);
            this.dequeue.TabIndex = 2;
            this.dequeue.Text = "REMOVE CUSTOMER";
            this.dequeue.UseVisualStyleBackColor = true;
            this.dequeue.Click += new System.EventHandler(this.dequeue_Click);
            // 
            // displayCustomer
            // 
            this.displayCustomer.Location = new System.Drawing.Point(581, 336);
            this.displayCustomer.Name = "displayCustomer";
            this.displayCustomer.Size = new System.Drawing.Size(132, 79);
            this.displayCustomer.TabIndex = 3;
            this.displayCustomer.Text = "Display Customer";
            this.displayCustomer.UseVisualStyleBackColor = true;
            this.displayCustomer.Click += new System.EventHandler(this.displayCustomer_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(529, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(212, 274);
            this.listBox1.TabIndex = 4;
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(197, 123);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(126, 23);
            this.inputText.TabIndex = 5;
            this.inputText.TextChanged += new System.EventHandler(this.inputText_TextChanged);
            // 
            // FeedbackQueue
            // 
            this.FeedbackQueue.AutoSize = true;
            this.FeedbackQueue.Location = new System.Drawing.Point(123, 92);
            this.FeedbackQueue.Name = "FeedbackQueue";
            this.FeedbackQueue.Size = new System.Drawing.Size(57, 15);
            this.FeedbackQueue.TabIndex = 6;
            this.FeedbackQueue.Text = "Feedback";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FeedbackQueue);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.displayCustomer);
            this.Controls.Add(this.dequeue);
            this.Controls.Add(this.enqueue);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button enqueue;
        private Button dequeue;
        private Button displayCustomer;
        private ListBox listBox1;
        private TextBox inputText;
        private Label FeedbackQueue;
    }
}