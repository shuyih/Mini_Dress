(function () {    
    var app = angular.module('miniDress', []);

    // angular controller 
    app.controller('mainController', ["$scope", "DataService", function ($scope, DataService) {
        DataService.getProducts().then(
            //success
            function (result) {
                $scope.products = result.data;
            }, function (error) {
                //error
                alert(error);
            }
        );      





        //-------- controller: functions -------------
        $scope.getProduct = function (id) {
            DataService.getProduct(id).then(            
            function (success) {
                $scope.product = success.data;
            }, function (error) {
                alert(error);
            });
        };
      
        $('button[data-dismiss]').click(function () {
            $scope.product = {}; 
        })
    }]);


    

    //------- UI effects -----------
    // Fade in the web page when initially visited
    $('body').css('opacity', '0').fadeTo(1000, 1, 'swing');

    // Toggle drop down hidden special products container
    $(".specials").hide();
    $(".header-button").show();
    $(".cart-item").hide();

    

    $('.header-button').click(function () {
        $(".specials").slideToggle();
    });
})();
