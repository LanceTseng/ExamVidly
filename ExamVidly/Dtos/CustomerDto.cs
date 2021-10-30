using System;
using System.ComponentModel.DataAnnotations;
using ExamVidly.Models;

namespace ExamVidly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public byte MembershipTypeId { get; set; }

        public MembershipTypeDto MembershipType { get; set; }

        //[Min18YearsIfAMember]
        public DateTime? BirthDate { get; set; }
    }
}