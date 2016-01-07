var app = angular.module("ListUsers", []);
app.controller("ListUsersController", function ($scope, $http, $sce, $rootScope) {

    $scope.sortColumn = "Id";

    $http.get('http://localhost:53120/api/users').
      success(function (data, status, headers, config) {

          $scope.users = data;

      }).
      error(function (data, status, headers, config) {

          alert("erro");

      });

});