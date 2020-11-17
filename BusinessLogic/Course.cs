using System;
using System.Collections.Generic;
using System.Text;

//  The method signature consists of a method name and the type and kind 
// (value, reference, or output) of each of its formal parameters. 
// Method signature does not include the return type.

// Without changing the method signature 
// Code the course class so the CourseTests unit tests pass

namespace BusinessLogic
{
    public class Course
    {
        private byte numberOfCredits;
        private string courseName;

        public Course(string courseName)
        {
            CourseName = courseName;
            InstructorName = "STAFF"; // default instructor name must be "STAFF"
        }

        /// <summary>
        /// The instructor teaching the course
        /// </summary>
        public string InstructorName { get; set; }

        /// <summary>
        /// The name of the course
        /// </summary>
        public string CourseName 
        { 
            get => courseName; 
            set 
            {
                courseName = value ?? throw new ArgumentNullException
                             ($"{nameof(courseName)} cannot be null");
            } 
        }

        /// <summary>
        /// Number of credits for the course
        /// </summary>
        public byte NumberOfCredits
        {
            get => numberOfCredits;
            set
            {
                if (value == 0 || value > 29)
                    throw new ArgumentException("Number of credits must be between 1 and 29.");
                numberOfCredits = value;
            }
        }

    }
}
