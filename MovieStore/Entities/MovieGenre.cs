using System.ComponentModel.DataAnnotations.Schema;

namespace MovieStore.Entities
{
    public class MovieGenre
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
       
    }
}
