namespace Week5TaskA
{
    public partial class Form1 : Form
    {
        // we creating an empty graph
        Graph mygraph = new Graph();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Nodevaluebutton_Click(object sender, EventArgs e)
        {
            mygraph.NumOfNodes().ToString();

        }

        private void addedgebutton_Click(object sender, EventArgs e)
        {
            mygraph.AddEdge(Int32.Parse(listBox1.Text), int.Parse(listBox2.Text));
           
            label1.Text = mygraph.NumOfEdges().ToString();
        }
    }
}