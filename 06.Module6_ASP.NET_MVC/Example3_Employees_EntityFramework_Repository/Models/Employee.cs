using System.ComponentModel.DataAnnotations;


namespace WebApplication37.Models
{
    public class Employee
    {
        [Key]
        public int Empno { get; set; }

        [Required(ErrorMessage = "Ename is required")]
        [StringLength(50, ErrorMessage = "Ename can't be longer than 50 characters")]
        public string Ename { get; set; }


        [Required(ErrorMessage = "Job is required")]
        [StringLength(30, ErrorMessage = "Job title can't be longer than 30 characters")]
        public string Job { get; set; }

        [Required(ErrorMessage = "Salary is required")]
        [Range(1000, 100000, ErrorMessage = "Salary must be between 1000 and 100000")]
        public decimal Sal { get; set; }

        [Required(ErrorMessage = "Deptno is required")]
        [Range(1, 99, ErrorMessage = "Deptno must be between 1 and 99")]
        public int Deptno { get; set; }
    }
}
