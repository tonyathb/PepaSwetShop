﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Data
{
    public class Candy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } 
        public int Size { get; set; }
        public int ImageURL { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; }
        public DateTime RegisterOn { get; set; }
        ICollection<ShoppingCandy> ShoppingCandies { get; set; }

    }
}
