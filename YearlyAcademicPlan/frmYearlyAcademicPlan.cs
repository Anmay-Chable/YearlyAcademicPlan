namespace YearlyAcademicPlan
{
    public partial class frmYearlyAcademicPlan : Form
    {
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
    }
}
