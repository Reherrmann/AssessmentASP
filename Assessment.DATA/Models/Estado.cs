﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Assessment.DATA.Models
{
    public partial class Estado
    {
        [Key]
        public int EstadoId { get; set; }
        [StringLength(10)]
        public string EstadoName { get; set; }
    }
}