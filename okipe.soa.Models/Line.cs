using okipe_soa_warehouse.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace okipe.soa.Models
{
    public class Line : BaseEntity
    {
        public Guid? Id { get; set; }
        public string LineName { get; set; }
        public string Note { get; set; }
    }
}