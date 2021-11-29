using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DAB.Client.Models
{
    public class SearchForm
    {
        [StringLength(16, ErrorMessage = "Le numéro contient 16 caractères maximum.")]
        public string? StringToSearch { get; set; }
    }
}
