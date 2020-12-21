using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_004.Models
{
    public partial class Kendaraan
    {
        public int IdKendaraan { get; set; }

        [Required(ErrorMessage = "Nama kendaraan tidak boleh kosong")]
        public string NamaKendaraan { get; set; }

        [Required(ErrorMessage = "No polisi tidak boleh kosong")]
        public string NoPolisi { get; set; }

        [Required(ErrorMessage = "No Stnk tidak boleh kosong")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi dengan angka")]
        public string NoStnk { get; set; }

        [Required(ErrorMessage = "Jenis tidak boleh kosong")]
        public int? IdJenisKendaraan { get; set; }

        [Required(ErrorMessage = "Ketersediaan tidak boleh kosong")]
        public string Ketersediaan { get; set; }

        public JenisKendaraan IdJenisKendaraanNavigation { get; set; }
    }
}
