namespace AgeDiff
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            int birth = Convert.ToInt32(txtBirth.Text);
            int yearTo = Convert.ToInt32(txtYearTo.Text);

            int result2 = birth - yearTo;
            int result1 = yearTo - birth;


            
            if(birth > yearTo && result2 > 1)
            {
                MessageBox.Show($"You will be born in {result2} years.");
            }
            else if(birth > yearTo && result2 == 1)
            {
                MessageBox.Show($"You will be born in {result2} year.");
            }
            else if(birth < yearTo && result1 > 1)
            {
                MessageBox.Show($"You are {result1} years old.");
            }
            else if(birth < yearTo && result1 == 1)
            {
                MessageBox.Show($"You are {result1} year old.");
            }
            else if(birth == yearTo)
            {
                MessageBox.Show("You were born this very year!");
            }
            else
            {
                Application.Exit();
            }
           
        }

        private void birthBtn_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}