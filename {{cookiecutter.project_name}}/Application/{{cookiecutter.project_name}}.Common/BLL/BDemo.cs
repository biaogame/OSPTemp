using Microsoft.SharePoint;
using OSP.Core.SitesWebs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace {{cookiecutter.project_name}}.Common.BLL
{
    public class BDemo
    {
        public List<string> GetAllList()
        {
            List<string> ls = new List<string>();
            SPSiteWebHelper.RunWithElevatedPrivileges(delegate (SPSite site, SPWeb web)
            {
                foreach (SPList l in web.Lists)
                {
                    ls.Add(l.Title);
                }
            });
            return ls;
        }
    }
}
