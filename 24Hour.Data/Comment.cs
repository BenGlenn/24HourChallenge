using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.Data
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public string Text { get; set; }
        [ForeignKey("User")]
        public int Author { get; set; }
        public virtual User User { get; set; }
        [ForeignKey("Post")]
        public int CommentedPost { get; set; }
        public virtual Post Post { get; set; }
    }
}
