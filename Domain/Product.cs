﻿using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Domain
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int ProductID { get; set; }
        public virtual string Name { get; set; }
        public virtual decimal Price { get; set; }
        public virtual decimal BasePrice { get; set; }
        public virtual int CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        public virtual ICollection<Category> Categories { get; set; }
    }
}
