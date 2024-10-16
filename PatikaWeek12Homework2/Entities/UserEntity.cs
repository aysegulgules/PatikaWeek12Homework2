using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatikaWeek12Homework2.Entities
{
    [Table("Users")]
    public class UserEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Email { get; set; }

        public List<PostEntity> Posts { get; set; }


    }
}
