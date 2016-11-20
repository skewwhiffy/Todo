var app = angular.module("Todo", []);
app.controller("homeController",
    function($scope, $http) {
        "use strict";

        $http.get("/api/todo")
            .then(function(response) {
                $scope.list = response.data;
            });
    });