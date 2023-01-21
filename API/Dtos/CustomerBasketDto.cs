using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace API.Dtos
{
    public class CustomerBasketDto
    {
        [Required]
         public string Id { get; set; }
        public List<BasketItemDto> Items { get; set; } 
    }
}