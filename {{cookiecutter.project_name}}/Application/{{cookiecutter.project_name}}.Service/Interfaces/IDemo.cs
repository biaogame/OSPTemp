using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace {{cookiecutter.project_name}}.Service.Interfaces
{
    [ServiceContract]
    interface IDemo
    {
    //添加SP用户组
    [OperationContract(Name = "Demo")]
    [WebInvoke(Method = "POST", UriTemplate = "Demo", BodyStyle = WebMessageBodyStyle.WrappedRequest, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
    ApiResult<List<string>> GetList(string p);
    }
}
