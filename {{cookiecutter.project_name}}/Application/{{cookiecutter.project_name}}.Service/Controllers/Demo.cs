using {{cookiecutter.project_name}}.Service.Interfaces;
using {{cookiecutter.project_name}}.Common.BLL;
using Microsoft.SharePoint.Client.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Activation;
using System.Text;
using System.Threading.Tasks;


namespace {{cookiecutter.project_name}}.Service.Controllers
{
        [BasicHttpBindingServiceMetadataExchangeEndpoint]
        //[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
        [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
        public class Demo : IDemo
        {
            public ApiResult<List<string>> GetList(string p)
            {
                BDemo bll = new BDemo();
                try
                {
                    return new ApiResult<List<string>>() { code = 0, msg = "", data = bll.GetAllList() };
                }
                catch (Exception ex)
                {
                    return new ApiResult<List<string>>() { code = 0, msg = ex.ToString(), data = null };
                }
            }
        }
}
