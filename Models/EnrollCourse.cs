    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using System;
    using CourseManagementSystemFinal.Models;

    namespace CourseManagementSystemFinal.Models
    {
        public class EnrollCourse
        {
            [Key]
            public long EnrollmentId { get; set; }
            
            public string VideoLinks { get; set; }

            public string Description { get; set; }
             

                 [Required(ErrorMessage = "Course Name is reqd...!!")]
             public string CourseName { get; set; }

                  [Required(ErrorMessage = "Date is reqd...!!")]
             public DateTime StartDate { get; set; }

                   [Required(ErrorMessage = "Date is reqd...!!")]
             public DateTime EndDate { get; set; }

             public string CourseImageLink { get; set; }
            //   public virtual FindCourse Course { get; set; }
            //  public virtual SignUpModel User { get; set; }
        }
    }
