namespace YearlyAcademicPlan
{
    public partial class frmYearlyAcademicPlan : Form
    {
        
        private const int MaxCourses = 9;
        private Course[] yearlyPlan; // Array to hold the courses
        private int totalCredits; // Total credits for the courses
        private int totalCreditsCompleted; // Total completed credits
        private TextBox[] courseTextBoxes; // Array of TextBoxes for course names
        public frmYearlyAcademicPlan()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCourse addCourseForm = new AddCourse(); // Create an instance of the AddCourse form
            addCourseForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
