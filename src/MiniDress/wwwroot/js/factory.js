app = angular.module("miniDress");
app.factory('DataService',
    ["$http",
    function ($http) {
        var getProducts = function () {
        return $http.get("Products/GetProducts");
        };

        var getProduct = function (id) {
            return $http.get("Products/GetProduct/" + id);
        };
        
        return {
            getProducts: getProducts,
            getProduct: getProduct
    };
}]);