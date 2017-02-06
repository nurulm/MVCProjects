
(function () {

    function getPorductsCtrl($http) {
        var vm = this;
        vm.products = {};
        vm.product = {};

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
            $http.post("http://localhost:81/api/Inventory", vm.product)
                .then(Successfun, failedFun);

            function Successfun(response) {
                vm.message = response.data;
                vm.getData();
            }
            function failedFun(err) {

            }
        };

        vm.updateProduct = function () {
            $http.put("http://localhost:81/api/Inventory", vm.product)
                .then(Successfun, failedFun);

            function Successfun(response) {
                vm.message = response.data;
                vm.getData();
            }
            function failedFun(err) {
            }
        };
        vm.deleteProduct = function () {
            $http.delete("http://localhost:81/api/Inventory", { params: { "id": vm.product.PRODID } })
                .then(Successfun, failedFun);

            function Successfun(response) {
                vm.message = response.data;
                vm.getData();
            }
            function failedFun() {

            }
        }

        vm.getProductDetails = function () {
            $http.get("http://localhost:81/api/Inventory", { params: { "id": vm.product.PRODID } })
                .then(Successfun, failedFun);

            function Successfun(response) {
                vm.product = response.data;
            }

            function failedFun() {

            }
        };
    }
   
     angular.module("ProductsModule")
        .controller("PorductsCtrl", ["$http", getPorductsCtrl]);

     
})();