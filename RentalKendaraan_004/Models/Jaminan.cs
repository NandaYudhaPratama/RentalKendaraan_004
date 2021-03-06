﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_004.Models
{
    public partial class Jaminan
    {
        public int IdJaminan { get; set; }
        [Required(ErrorMessage = "Nama jaminan tidak boleh kosong")]
        public string NamaJaminan { get; set; }
    }
}
