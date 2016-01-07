var app = angular.module("DetailsUser", []);
app.controller("DetailsUserController", function ($scope, $http, $sce, $location) {

    var urlx = $location.absUrl();
    var idu = urlx.replace('http://localhost:53120/Home/Details/', '');

    $http.get('http://localhost:53120/api/users/' + idu).
         success(function (data, status, headers, config) {

             var res = data;

             $scope.Id = res.Id;
             $scope.Fio = res.Fio;
             $scope.Login = res.Login;
             $scope.Age = res.Age;
             $scope.Phone = res.Phone;
             $scope.Foto = $sce.trustAsResourceUrl('/ImagesUsers/' + res.Foto);

         }).
         error(function (data, status, headers, config) {
             alert("erro");

         });

});