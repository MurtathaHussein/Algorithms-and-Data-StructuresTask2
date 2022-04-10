using ExerciseWeek2TaskB.Classes;
namespace ExerciseWeek2TaskB
{
    public partial class Form1 : Form
    {

        SQueue myqueue = new SQueue();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void enqueue_Click(object sender, EventArgs e)
        {
            if (myqueue.IsFull())
            {
                //queue is full give feedback to user
                FeedbackQueue.Text = "Queue is full, Dequeue please";
            }
            else
            {
                if (!String.IsNullOrEmpty(inputText.Text))
                {
                    myqueue.Enqueue(inputText.Text); 
                   
                }
                else
                {
                    FeedbackQueue.Text = " Please Input Some Value as there is no value ";
                }
            }
        }

        private void dequeue_Click(object sender, EventArgs e)
        {
            if (myqueue.IsEmpty())
            {
                //queue is empty give feedback to user
                FeedbackQueue.Text = "Cannot Dequeue, Queue Empty!!!";
            }
            else
            {
                //DisplayQueue.Text = myqueue.Dequeue().ToString();
                myqueue.Dequeue();
            }

        }

        private void displayCustomer_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            String[] data = new string[10];
            data = myqueue.queueData(); 
            listBox1.Items.Add("Total Customers in Queue : "+myqueue.countQueue());
            for (int i=0; i < myqueue.countQueue();i++) {
                listBox1.Items.Add(data[i]);
            }
            //listBox1.Items.Add(inputText.Text);

        }

        private void inputText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}