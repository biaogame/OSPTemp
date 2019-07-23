using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace {{cookiecutter.project_name}}.Service.Interfaces
{
    [ServiceContract]
    interface IDemo
    {

        [OperationContract(Name = "GetList")]
        [WebInvoke(Method = "POST", UriTemplate = "GetList", BodyStyle = WebMessageBodyStyle.WrappedRequest, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ApiResult<List<string>> GetList(string p);
    }
}
