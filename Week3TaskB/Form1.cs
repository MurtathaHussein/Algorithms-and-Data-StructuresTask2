
using Week3TaskB.Classes;
namespace Week3TaskB

{
    public partial class Form1 : Form
    {
        Dictionary<int, Employee> employeeDictionary = new Dictionary<int, Employee>();
        public Form1()
        {
           
          
        
                Employee employee1 = new Employee(1,"Ali", true);
                Employee employee2 = new Employee(2,"jaffa", true);
                Employee employee3 = new Employee(3,"kalts", true);
                Employee employee4 = new Employee(4,"jake", true);
            employeeDictionary[employee1.ID] = employee1;
            employeeDictionary[employee2.ID] = employee2;
            employeeDictionary[employee3.ID] = employee3;
            employeeDictionary[employee4.ID] = employee4;
            InitializeComponent();
        }


        private void InsertButton_Click(object sender, EventArgs e)
        {
            int AvailableValue= Int32.Parse(idTextBox.Text);
            bool myBool = true; 

            //mybool bool will convert.tooboolean(availabevalue)
            Employee employee = new Employee( AvailableValue,NameTextBox.Text, myBool);
            employeeDictionary[AvailableValue] = employee;
        }  

        private void OutputListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int sid  = Int32.Parse(idTextBox.Text);
            employeeDictionary.Remove(sid);

        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            OutputListBox.Items.Clear();
            foreach(KeyValuePair<int, Employee> currentItem in employeeDictionary)
                OutputListBox.Items.Add(currentItem.Value.ID+ " "+currentItem.Value.Name + " " + currentItem.Value.Avalibility);
        }

        private void AvaliableButton_Click(object sender, EventArgs e)
        {
            int sid = Int32.Parse(idTextBox.Text);
            bool myBool = false;
            Employee employee = new Employee(sid, myBool);
            employeeDictionary[sid] = employee;

        }
    }
    }
