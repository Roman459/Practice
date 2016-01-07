var app = angular.module("Users", []);
app.controller("UsersController", function ($scope, $http, $sce, $rootScope) {

    $http.get('http://localhost:53120/api/users').
      success(function (data, status, headers, config) {

          $scope.users = data;

      }).
      error(function (data, status, headers, config) {

          alert("erro");

      });

    $scope.GetDeleteUser = function (id) {
        window.location.replace("http://localhost:53120/Home/Delete/" + id);
    };

    $scope.GetEditUser = function (id) {
        window.location.replace("http://localhost:53120/Home/Edit/" + id);
    };

    $scope.GetDitailsUser = function (id) {
        window.location.replace("http://localhost:53120/Home/Details/" + id);
    };

});