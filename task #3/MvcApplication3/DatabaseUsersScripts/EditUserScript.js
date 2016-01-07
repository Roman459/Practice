var app = angular.module("EditUser", []);
app.controller("EditUserController", function ($scope, $http, $rootScope, $location) {

    var urlx = $location.absUrl();
    var idu = urlx.replace('http://localhost:53120/Home/Edit/', '');

    $http.get('http://localhost:53120/api/users/' + idu).
         success(function (data, status, headers, config) {

             var res = data;

             Id.value = res.Id;
             Fio.value = res.Fio;
             Login.value = res.Login;
             Age.value = res.Age;
             Phone.value = res.Phone;
             Foto.value = res.Foto;
         }).
         error(function (data, status, headers, config) {
             alert("erro");
         });

    $scope.file_changed = function () {
        Foto.value = FotoFile.value.replace(/^.*\\/, "");
    }

    $scope.SaveEditUser = function (id) {

        var id = Id.value;

        var user = {
            "Id": Id.value,
            "Fio": Fio.value,
            "Login": Login.value,
            "Age": Age.value,
            "Phone": Phone.value,
            "Foto": Foto.value
        }
        $http.put('http://localhost:53120/api/users/' + id, user).
          then(function (data, status, headers, config) {

              alert('Данные о пользователе изменены, вернитесь назад');

          });
    };

});