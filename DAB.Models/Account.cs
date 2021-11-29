using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DAB.Webservice.Models
{
    public class Account
    {
        #region Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Number { get; set; }

        public string Pin { get; set; }

        public double Balance { get; set; }

        public int AuthenticationTries { get; set; }

        #endregion Properties
    }
}
