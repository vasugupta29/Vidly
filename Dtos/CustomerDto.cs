using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }


        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        public byte MembershipTypeId { get; set; }
        public MembershipTypeDto MembershipType { get; set; }


        /*[Min18YrsIfAMember]*/
        public DateTime? BirthDate { get; set; }
    }
}