using System;
using System.Web.Mvc;
using System.Collections.Generic;

namespace JustSA.DTO
{
    public class SportMemberDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SportName { get; set; }
        public bool IsActive { get; set; }
        public int DataLookUpId { get; set; }
        public DateTime DateLogged { get; set; }
        public IEnumerable<SelectListItem> DataLookUp { get; set; }
    }
}
