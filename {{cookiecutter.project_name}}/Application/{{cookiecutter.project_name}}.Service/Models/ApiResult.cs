using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace {{cookiecutter.project_name}}.Service
{
    public class ApiResult<T>
    {
        public int code { get; set; }

        public string msg { get; set; }

        public T data { get; set; }

        public string StartIndex { get; set; }

        public string PageSize { get; set; }

        public int Total { get; set; }

    }
}
