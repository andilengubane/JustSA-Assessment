using System;
using System.Linq;
using System.Web.Mvc;
using JustSA.EnityFrameWork;
using System.Collections.Generic;

namespace JustSA.Service
{
    class DataLookUpService
    {
        private readonly static JustSAEntities context = new JustSAEntities();

        public static IEnumerable<SelectListItem> GetRules()
        {
            var query = context.DataLookUp
                        .Select(x => new SelectListItem
                        {
                            Value = x.Id.ToString(),
                            Text = x.Name
                        });

            return new SelectList(query, "Value", "Text");
        }
    }
}
