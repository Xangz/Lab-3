using Microsoft.AspNetCore.Antiforgery;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace NdsLab1.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Tên tối thiểu 4 ký tự tối đa 100 ký tự")]
        [StringLength(100,MinimumLength =4)]
        public string? Name { get; set; }
        [Required(ErrorMessage ="Emai bắt buộc phải được nhập")]
        [RegularExpression(@"^[A-Za-z0-9._%+-]+@gmail\.com$", ErrorMessage = "Email phải có đuôi @gmail.com hợp lệ")]
        public string? Email {  get; set; }
        //[StringLength(100, MinimumLength = 8)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}",ErrorMessage ="Mật khẩu 8 ký tự trở lên, có viết hoa, viết thường, chữ số và ký tự đặc biêt")]
        [Required(ErrorMessage = "Nhập mật khẩu")]
        public string? Password {  get; set; }
        [Required]
        public Branch? Branch { get; set; }
        [Required(ErrorMessage = "Chọn giới tính")]
        public Gender? Gender { get; set; }
        public bool IsRegular {  get; set; }
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Nhập địa chỉ")]
        public string? Address {  get; set; }
        [Required(ErrorMessage = "Nhập ngày sinh")]
        [Range(typeof(DateTime), "01/01/1963", "12/31/2005",ErrorMessage = "Ngày sinh phải từ 01/01/1963 đến 31/12/2005")]
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }
        [Required(ErrorMessage = "Điểm là bắt buộc nhập!")]
        [Range(0.0, 10.0, ErrorMessage = "Điểm phải nằm trong khoảng từ 0.0 đến 10.0!")]
        public float? Score {  get; set; }
        public IFormFile? Avatar { get; set; }
        public string? AvatarPath {  get; set; }
    }
}
