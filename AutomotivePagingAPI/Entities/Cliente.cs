using System.ComponentModel.DataAnnotations;

namespace AutomotivePagingAPI.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
    }
}
