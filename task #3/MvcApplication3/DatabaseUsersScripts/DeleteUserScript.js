var app = angular.module("DeleteUser", []);
app.controller("DeleteUserController", function ($scope, $http, $sce, $location) {

    var urlx = $location.absUrl();
    var idu = urlx.replace('http://localhost:53120/Home/Delete/', '');

    $http.get('http://localhost:53120/api/users/' + idu).
         success(function (data, status, headers, config) {

             var res = data;

             Id.value = res.Id;
             Fio.value = res.Fio;
             Login.value = res.Login;
             Age.value = res.Age;
             Phone.value = res.Phone;
             $scope.Foto = $sce.trustAsResourceUrl('/ImagesUsers/' + res.Foto);

         }).
         error(function (data, status, headers, config) {

             alert("erro");

         });

    $scope.DeleteUser = function (id) {
        var id = Id.value;
        $http.delete('http://localhost:53120/api/users/' + id).
          success(function (data, status, headers, config) {

              window.location.replace("http://localhost:53120/Home/Admin");

          }).
          error(function (data, status, headers, config) {

              alert("erro");

          });
    };

});