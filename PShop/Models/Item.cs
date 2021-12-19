using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PShop.Models
{
    public class Item
    {
        public Guid Id { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Description")]

        public string Description { get; set; }
        [Display(Name = "Description")]

        public string Characteristics { get; set; }
        public decimal Sale { get; set; } = 0;
        public decimal Price { get; set; }
        public string Img { get; set; }
        public string Img2 { get; set; }
        public string Img3 { get; set; }
        public string Img4 { get; set; }
        public string Img5 { get; set; }
        public string Vid { get; set; }
        public long AvgScore { get; set; }
        public long ScoreSumm { get; set; }
        public long ScoreCount { get; set; }
        public string Tag1 { set; get; }

        public List<Review> Reviews { get; set; }

        public override string ToString()
        {
            return $"{Id}";
        }
        public decimal SalePrice()
        {
            return Price - Price * Sale;
        }

        public void UpdateAvgScore()
        {
            if (ScoreCount == 0)
            {
                AvgScore = -1;
                return;
            }

            AvgScore = ScoreSumm / ScoreCount;
        }
    }
}
