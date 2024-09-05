using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace asp01_efc.Models
{
    public class Student
    {
        //definice tabulky
        public int StudentId { get; set; } //primární klíč
        /*
        [Key]

        public int Klic {  get; set; }
        */
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        public string? MiddleName { get; set; }

        public int? ShoeSize { get; set; }

    }
}
