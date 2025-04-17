using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YearlyAcademicPlan
{
    public struct Course
    {
        /// Properties
        public string CourseName { get; set; }
        public int CourseCredits { get; set; }
        public Status CourseStatus { get; set; }
        public string PrecedingCourseName { get; set; }
        public string FollowingCourseName { get; set; }

            /// Constructor
        public Course (string name, int credits, Status status, string precedingCourse = null, string followingCourse = null)
        {
            CourseName = name;
            CourseCredits = credits;
            CourseStatus = status;
            PrecedingCourseName = precedingCourse;
            FollowingCourseName = followingCourse;
        }
    }

    /// Enum for course status
    public enum Status
    {
        NotStarted,
        InProgress,
        Completed
    }
}
