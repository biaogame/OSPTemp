<%@ Page Language="C#" MasterPageFile="~site/_catalogs/masterpage/{{cookiecutter.project_name}}.Protal.master" Inherits="Microsoft.SharePoint.WebPartPages.WebPartPage,Microsoft.SharePoint,Version=16.0.0.0,Culture=neutral,PublicKeyToken=71e9bce111e9429c" meta:progid="SharePoint.WebPartPage.Document" meta:webpartpageexpansion="full" %>

<asp:Content ContentPlaceHolderID="PlaceHolderMain" runat="server">
    <div class="jumbotron" id="Demo_Index">
        <ul class="list-group" v-for="(k,v) in list">
            <li class="list-group-item" v-html="v"></li>
        </ul>
    </div>
    <script>
        $(function () {
            var app;
            ExecuteOrDelayUntilScriptLoaded(function () { //先要判断sp.js是否已经加载完成
                app = new Vue({
                    el: '#Demo_Index',
                    data: {
                        list: []
                    },
                    mounted: function () { },
                    methods: {
                        GetList: function () {
                            var param = {};
                            var _this = this;
                            param.p = "";
                            $.ajax({
                                type: "post",
                                contentType: "application/json",
                                dataType: "json",
                                url: _spPageContextInfo.siteAbsoluteUrl + "/_vti_bin/{{cookiecutter.project_name}}/Demo.svc/" + GetList,
                                data: JSON.stringify(param),
                                success: function (message) {
                                    if (message.code == 0) {
                                        _this.list = message.data;
                                    } else {
                                        alert(message.msg);
                                    }
                                },
                                error: function (e) {
                                    console.log(e);
                                },
                                dataType: "json"
                            });
                        }
                    }
                })
            })
        })
    </script>
</asp:Content>
