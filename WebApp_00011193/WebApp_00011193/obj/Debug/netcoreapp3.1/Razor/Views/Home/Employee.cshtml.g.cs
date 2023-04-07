#pragma checksum "C:\Users\Sardor\Desktop\WAD\WAD\WebApp_00011193\WebApp_00011193\Views\Home\Employee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f70e037391cb9a9b97fee89e3e1d9f07232757e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Employee), @"mvc.1.0.view", @"/Views/Home/Employee.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f70e037391cb9a9b97fee89e3e1d9f07232757e0", @"/Views/Home/Employee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad75ef70b162e0119a94c84caf40e268cf376fd1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Employee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
                        templateUrl: 'pages/employee/index.html',
                        controller: 'IndexController'
                    })
                .when('/create',
                    {
                        templateUrl: 'pages/employee/create.html',
                        controller: 'CreateController'
                    })
                .when('/details/:employeeId',
                    {
                        templateUrl: 'pages/em");
            WriteLiteral(@"ployee/details.html',
                        controller: 'DetailsController'
                    })

                .when('/edit/:employeeId',
                    {
                        templateUrl: 'pages/employee/edit.html',
                        controller: 'EditDeleteController'
                    })
                .otherwise({
                    redirectTo: '/'
                });

        })


        .controller('IndexController', ['$scope', '$http', '$filter', function ($scope, $http, $filter) {
            $scope.employees = [];
            $http.get(baseURL + 'Employee/')
                .then(function (res) {
                    $scope.employees = res.data;
                });

        }])


        .controller('CreateController', ['$scope', '$http', '$location', '$filter', function ($scope, $http, $location, $filter) {
            $scope.create =
            {
                firstName: '',
                lastName: '',
                gender: '',
        ");
            WriteLiteral(@"        salary: 0,
                employeeDepartmentId: ''
            };
            $scope.genders = [{""value"": 0, ""text"": 'Male' }, { ""value"": 1, ""text"": 'Female' }];

            $http.get(baseURL + 'Department/')
                .then(function (res) {
                    $scope.departments = res.data;
                });
            

            $scope.Save = function () {
                $scope.create.gender = parseInt($scope.create.gender);
                $scope.create.employeeDepartmentId = parseInt($scope.create.employeeDepartmentId);
                $scope.create.employeeDepartment = { id: $scope.create.employeeDepartmentId }

                $http.post(baseURL + 'Employee/', $scope.create)
                    .then(function (res) {
                        $location.path('/');
                    });
            }
        }])


        .controller('DetailsController', ['$scope', '$http', '$routeParams', '$filter', function ($scope, $http, $routeParams, $filter) {
        ");
            WriteLiteral(@"    $scope.details = [];

            $http.get(baseURL + 'Employee/' + $routeParams.employeeId)
                .then(function (res) {
                    $scope.details = res.data;
                    $http.get(baseURL + 'Department/' + $scope.details.employeeDepartmentId)
                        .then(function (res) {
                            $scope.details.employeeDepartment = res.data;
                        });
                });
        }])


        .controller('EditDeleteController', ['$scope', '$http', '$location', '$routeParams', '$filter', function ($scope, $http, $location, $routeParams) {

            $scope.genders = [{ ""value"": 0, ""text"": 'Male' }, { ""value"": 1, ""text"": 'Female' }];
            $scope.edit = [];

            $http.get(baseURL + 'Employee/' + $routeParams.employeeId)
                .then(function (res) {
                    $scope.edit = res.data;
                    $scope.edit.gender += """";
                    $scope.edit.employeeDepartmentId += """"");
            WriteLiteral(@";
                    $http.get(baseURL + 'Department/')
                        .then(function (res) {
                            $scope.departments = res.data;
                        });
                });

            $scope.Edit = function () {
                $scope.edit.gender = parseInt($scope.edit.gender);
                $scope.edit.employeeDepartmentId = parseInt($scope.edit.employeeDepartmentId);

                $http.put(baseURL + 'Employee/' + $routeParams.employeeId, $scope.edit)
                    .then(function (res) {
                        $location.path('/');
                    });
            };

            $scope.Delete = function () {
                $http.delete(baseURL + 'Employee/' + $routeParams.employeeId, null)
                    .then(function (res) {
                        $location.path('/');
                    });
            };
        }])

        .filter('genderFilter', function() {
            return function (input) {
                s");
            WriteLiteral(@"witch (input) {
                    case 0:
                        return 'Male';
                        break;
                    case 1:
                        return 'Female';
                        break;
                }
            }
        })
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