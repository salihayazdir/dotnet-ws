using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_ws
{
    [Index(nameof(globalatmid), IsUnique = true)]
    public class Atm
    {
        [Key]
        public int id { get; set; }
        public int globalatmid { get; set; }
        public int memberno { get; set; }
        public string? atmreferencecode { get; set; }
        public string? atmname { get; set; }
        public int? licensetag { get; set; }
        public string? adress { get; set; }
        public string? district { get; set; }
        public string? neighborhood { get; set; }
        public bool? servicedependency { get; set; }
        public bool? restrictedatm { get; set; }
        public bool? airportlocated { get; set; }
        public bool? malllocated { get; set; }
        public bool? universitylocated { get; set; }
        public bool? depositflag { get; set; }
        public bool? withdrawflag { get; set; }
        public bool? terminalcoinoperator { get; set; }
        public bool? nfcflag { get; set; }
        public bool? biometryflag { get; set; }
        public bool? visuallyimpairedflag { get; set; }
        public bool? orthopedicdisabledflag { get; set; }
        public string? atmage { get; set; } = null!;

        [Column(TypeName = "decimal(8,6)")]
        public decimal? geocodelatitude { get; set; }

        [Column(TypeName = "decimal(8,6)")]
        public decimal? geocodelongitude { get; set; }
    }
}

