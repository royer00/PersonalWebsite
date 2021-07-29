using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace PersonalSite.MVC.UI.Models
{
    public class ContactViewModel
    {
        [Required(ErrorMessage = "You must enter a name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "You must enter an email address.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "You must enter a subject.")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "You must enter a message.")]
        [UIHint("MultilineText")]
        public string Message { get; set; }

    }
}