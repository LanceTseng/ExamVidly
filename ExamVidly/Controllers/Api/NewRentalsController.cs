using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ExamVidly.Dtos;

namespace ExamVidly.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        [HttpPost]
        public IHttpActionResult CreateRentals(NewRentalDto rentalDto)
        {
            throw new NotImplementedException();
        }
    }
}
