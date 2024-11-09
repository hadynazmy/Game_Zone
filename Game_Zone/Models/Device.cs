﻿

using System.ComponentModel.DataAnnotations;

namespace Game_Zone.Models
{
    public class Device:BaseEntity
    {
        [MaxLength(length:50)]
        public string Icon { get; set; } = string.Empty;
    }
}
