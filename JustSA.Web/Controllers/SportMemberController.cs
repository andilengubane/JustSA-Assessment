using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using JustSA.DTO;
using JustSA.Service;

namespace JustSA.Web.Controllers
{
    public class SportMemberController : ApiController
    {
        [HttpPost]
        public IHttpActionResult GetAllSportMemberDetail()
        {
            var results = SportMemberService.GetAllSportMemberDetail();

            if (results != null)
            {
                return Ok(results);
            }
            return BadRequest("Something went wrong");
        }

        [HttpPost]
        public IHttpActionResult SaveUser([FromBody] SportMemberDTO sportMember)
        {
            var results = SportMemberService.SaveSportMemberDetails(sportMember);
            if (results != null)
            {
                return Ok(results);
            }
            return BadRequest("Something went wrong");
        }
    }
}
