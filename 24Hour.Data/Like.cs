using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.Data
{
    public class Like
    {
        [Key]
        public int LikeId { get; set; }
        [ForeignKey("User")]
        public User Liker { get; set; }
        public virtual User User { get; set; }
        [ForeignKey("Post")]
        public Post LikedPost { get; set; }
        public virtual Post Post { get; set; }

    }
}
