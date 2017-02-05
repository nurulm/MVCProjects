
(function () {

    function getPorductsCtrl($http) {
        var vm = this;
        vm.products = {};

        vm.getData = function () {
            $http.get("http://localhost:81/api/Inventory", { headers: { 'myToken': 'xyz123' } })
                .then(Successfun, failedFun);

            function Successfun(response) {
                vm.products = response.data;
            }
            function failedFun(err) {
                //alert(JSON.stringify(err));
            }
        };

        vm.saveProduct = function () {
            $http.post("http://localhost:81/api/Inventory", vm.products)
                .then(Successfun, failedFun);

            function Successfun(response) {
                vm.message = response.data;
                vm.getData();
                vm.products = {};
            }
            function failedFun(err) {

            }
        };
    }
   
     angular.module("ProductsModule")
        .controller("PorductsCtrl", ["$http", getPorductsCtrl]);

     
})();