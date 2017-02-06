(
    function () {
        function tblProductsFn() {
            return {
                template:"<b>Welcome</b>",
                //templateUrl: "./scripts/commonhtml/tblProducts.tpl.html",
               // controller: "ProductsCtrl as ac",
                restrict: "A,E,C",
            }

        }

        angular.module("common")
            .directive("tblProductsTable", [tblProductsFn]);
    }
)();