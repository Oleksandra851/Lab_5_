using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab_5.Models
{
    [Table("TeacherSubjects")]
    public class TeacherSubject
    {
        public int TeacherID { get; set; }
        public int SubjectID { get; set; }

        [Display(Name = "Прочитані години")]
        [Range(0, 1000, ErrorMessage = "Кількість годин повинна бути від 0 до 1000")]
        public int HoursRead { get; set; }

        [ForeignKey("TeacherID")]
        public virtual Teacher? Teacher { get; set; }

        [ForeignKey("SubjectID")]
        public virtual Subject? Subject { get; set; }
    }
}