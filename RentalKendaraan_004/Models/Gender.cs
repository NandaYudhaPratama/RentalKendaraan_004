﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_004.Models
{
    public partial class Gender
    {
        public int IdGender { get; set; }
        [Required(ErrorMessage = "Nama gender tidak boleh kosong")]
        public string NamaGender { get; set; }
    }
}
