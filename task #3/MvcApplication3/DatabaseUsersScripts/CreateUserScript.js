angular.module('CreateUser', [])
     .controller('CreateUserController', ['$scope', '$http', function ($scope, $http) {

         $scope.AddUser = function () {
             var user = {
                 "Fio": Fio.value,
                 "Login": Login.value,
                 "Age": Age.value,
                 "Phone": Phone.value,
                 "Foto": Foto.value.replace(/^.*\\/, "")
             }

             $http.post('http://localhost:53120/api/users', user).
             then(function (data, status, headers, config) {

                 alert('Пользователь добавлен, вернитесь назад');

             });

         };

     }]);