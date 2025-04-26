using StudentPortal.Models.Abstract;

namespace StudentPortal.Models
{
    public class Student : ModelBase
    {
        /// <summary>
        /// Represents the First Student Name.
        /// </summary>
        public string Name { get; set; }
        public string Major { get; set; }
        public DateOnly DateOfBirth { get; set; }
    }
}
