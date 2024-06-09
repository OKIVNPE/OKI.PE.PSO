using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace okipe_soa_warehouse.Models
{
    public abstract class BaseEntity
    {
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }

        protected BaseEntity()
        {
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }

        protected void OnUpdate()
        {
            UpdatedAt = DateTime.Now;
        }
    }
}