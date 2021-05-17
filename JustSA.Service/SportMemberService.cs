using System;
using JustSA.DTO;
using System.Linq;
using JustSA.EnityFrameWork;
using System.Collections.Generic;

namespace JustSA.Service
{
    public class SportMemberService
    {
        private readonly static JustSAEntities context = new JustSAEntities();

        public static List<SportMemberDTO> GetAllSportMemberDetail()
        {
            List<SportMemberDTO> data = context.GetAllSportMemberDetail().Select(x => new SportMemberDTO
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                IsActive = Convert.ToBoolean(x.IsActive),
                DataLookUpId = Convert.ToInt32(x.DataLookUpId),
                SportName = x.Name
            }).ToList();
            return data;
        }

        public static SportMemberDTO SaveSportMemberDetails(SportMemberDTO sportMemberDTO)
        {
            string emailAddresss = string.Empty;
            if (sportMemberDTO.Id == 0)
            {
                context.SportMembers.Add(new SportMembers
                {
                    FirstName = sportMemberDTO.LastName,
                    LastName = sportMemberDTO.LastName,
                    IsActive = true,
                    DataLookUpId = sportMemberDTO.DataLookUpId,
                    DateLogged = DateTime.Now
                });
                context.SaveChanges();
            }
            return sportMemberDTO;
        }
    }
}
