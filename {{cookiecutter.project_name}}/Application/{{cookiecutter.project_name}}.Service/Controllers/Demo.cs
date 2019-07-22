using {{cookiecutter.project_name}}.Service.Interfaces;
using OSP.Common.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace {{cookiecutter.project_name}}.Service.Controllers
{
    public class Demo : IDemo
    {
    ApiResult<List<string>> GetList(string p)
    {
        BDemo bll = new BDemo();
        return new ApiResult<List<string>>() { code = 0, msg = "", data = bll.GetAllList() };
        }
    }
}
