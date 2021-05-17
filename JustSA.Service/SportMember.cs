using System;
using JustSA.DTO;
using System.Linq;
using JustSA.EnityFrameWork;
using System.Collections.Generic;

namespace JustSA.Service
{
    public class SportMember
    {
        private readonly static JustSAEntities context = new JustSAEntities();


        //public static List<SportMemberDTO> GetAllSportMemberDetails()
        //{
        //    List<SportMemberDTO> data = context.GetAllSportMemberDetails().Select(x => new SportMemberDTO
        //    {
        //        Id = x.Id,
        //        FirstName = x.Name,
        //        LastName = x.SerialNumber,
        //        IsActive = x.Model,
        //        DataLookUpId = x.Supplier,
        //    }).ToList();
        //    return data;
        //}

        public static void SaveSportMemberDetails(SportMemberDTO sportMember)
        {
            if (sportMember.Id == 0)
            {
                context.SportMembers.Add(new SportMembers
                {
                    FirstName = sportMember.LastName,
                    LastName = sportMember.LastName,
                    IsActive = true,
                    DataLookUpId = sportMember.DataLookUpId,
                    DateLogged = DateTime.Now
                });
                context.SaveChanges();
            }
            else {
                var data = context.SportMembers.Where(s => s.Id == sportMember.Id).FirstOrDefault();
                data.FirstName = sportMember.LastName;
                data.LastName = sportMember.LastName;
                data.IsActive = true;
                data.DataLookUpId = sportMember.DataLookUpId;
                context.SportMembers.Add(data);
                context.SaveChanges();
            }

        }
    }
}
