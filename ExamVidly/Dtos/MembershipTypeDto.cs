using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamVidly.Dtos
{
    public class MembershipTypeDto
    {
        //We don't need to add all properties here because
        //if a client wants to know the details about a given membership type,
        //they can use the ID here to send a request to potential a new endpoint for membership types.
        //keep the DTO in a light way
        public byte Id { get; set; }
        public string Name { get; set; }
    }
}