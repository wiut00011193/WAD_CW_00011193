#pragma checksum "C:\Users\Sardor\Desktop\WAD\WAD\WebApp_00011193\WebApp_00011193\Views\Home\Department.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74606afdcb46b2efbd98fd5f470680eb65e1d8f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Department), @"mvc.1.0.view", @"/Views/Home/Department.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Sardor\Desktop\WAD\WAD\WebApp_00011193\WebApp_00011193\Views\_ViewImports.cshtml"
using WebApp_00011193;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sardor\Desktop\WAD\WAD\WebApp_00011193\WebApp_00011193\Views\_ViewImports.cshtml"
using WebApp_00011193.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74606afdcb46b2efbd98fd5f470680eb65e1d8f1", @"/Views/Home/Department.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad75ef70b162e0119a94c84caf40e268cf376fd1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Department : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div ng-app=""webApp"">
    <div ng-view></div>
</div>
<script type=""text/javascript"" src=""https://ajax.googleapis.com/ajax/libs/angularjs/1.8.2/angular.min.js""></script>
<script type=""text/javascript"" src=""https://ajax.googleapis.com/ajax/libs/angularjs/1.8.2/angular-route.min.js""></script>
<script type=""text/javascript"">

    var baseURL = 'http://localhost:41522/api/'
    angular
        .module('webApp', ['ngRoute'])
        .config(function ($routeProvider) {
            $routeProvider
                .when('/',
                    {
                        templateUrl: 'pages/department/index.html',
                        controller: 'IndexController'
                    })
                .when('/create',
                    {
                        templateUrl: 'pages/department/create.html',
                        controller: 'CreateController'
                    })
                .when('/details/:departmentId',
                    {
                        templateUrl: 'pa");
            WriteLiteral(@"ges/department/details.html',
                        controller: 'DetailsController'
                    })

                .when('/edit/:departmentId',
                    {
                        templateUrl: 'pages/department/edit.html',
                        controller: 'EditDeleteController'
                    })
                .otherwise({
                    redirectTo: '/'
                });

        })


        .controller('IndexController', ['$scope', '$http', '$filter', function ($scope, $http, $filter) {
            $scope.departments = [];
            $http.get(baseURL + 'Department/')
                .then(function (res) {
                    $scope.departments = res.data;
                });
        }])


        .controller('CreateController', ['$scope', '$http', '$location', '$filter', function ($scope, $http, $location, $filter) {
            $scope.create =
            {
                title: ''
            };

            $scope.Save = function () {");
            WriteLiteral(@"

                $http.post(baseURL + 'Department/', $scope.create)
                    .then(function (res) {
                        $location.path('/');
                    });
            }
        }])


        .controller('DetailsController', ['$scope', '$http', '$routeParams', '$filter', function ($scope, $http, $routeParams, $filter) {
            $scope.details = [];

            $http.get(baseURL + 'Department/' + $routeParams.departmentId)
                .then(function (res) {
                    $scope.details = res.data;
                });
        }])


        .controller('EditDeleteController', ['$scope', '$http', '$location', '$routeParams', '$filter', function ($scope, $http, $location, $routeParams) {
            $scope.edit = [];

            $http.get(baseURL + 'Department/' + $routeParams.departmentId)
                .then(function (res) {
                    $scope.edit = res.data;
                });

            $scope.Edit = function () {
             ");
            WriteLiteral(@"   $scope.edit.frequency = parseInt($scope.edit.frequency);
                $http.put(baseURL + 'Department/' + $routeParams.departmentId, $scope.edit)
                    .then(function (res) {
                        $location.path('/');
                    });
            };
            $scope.Delete = function () {
                $http.delete(baseURL + 'Department/' + $routeParams.departmentId, null)
                    .then(function (res) {
                        $location.path('/');
                    });
            };
        }])
</script>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
