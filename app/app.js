(function () {

    //module creation
    //first param: Module Name
    //second params: module names injected.
    angular.module("goodServices", ["ui.bootstrap", "login", "register", "header", "common", "products", "ui.router","pascalprecht.translate"]);

    //consuming the module
    angular.module("goodServices")
        .config(["$stateProvider", "$urlRouterProvider", "$translateProvider",
            function ($stateProvider, $urlRouterProvider,  $translateProvider) {
                //$urlRouterProvider.otherwise("/register");
                $urlRouterProvider.otherwise("/login");  //default page
                //define the routers using $state provider.
                var login = {
                    templateUrl: "app/login/login.tpl.html",
                    url: "/login",
                    controller: "loginCtrl"
                };
                var register = {
                    url: "/register",
                    templateUrl: "app/register/register.tpl.html",
                    controller: "registerCtrl as rc"
                };
                var products = {
                    url: "/products",
                    templateUrl: "app/products/products.tpl.html",
                    controller: "productsCtrl as pc",
                    params: { data: null }
                };

                //declare states
                $stateProvider.state("login", login);
                $stateProvider.state("register", register);
                $stateProvider.state("products", products);

                //delcare laguage translataions.
                $translateProvider.translations('en', {
                    LOGIN: 'Login',
                    REGISTER: 'Register',
                    PRODUCTS: 'Products'
                   
                });
                $translateProvider.translations('de', {
                    LOGIN: 'Anmeldung',
                    REGISTER: 'Neu Registriern',
                    PRODUCTS: 'Produckte'
                    
                });
                $translateProvider.preferredLanguage('en');
            }])
        .run(["$rootScope", function ($rootScope) {
            console.log("I m the good services run function");
            $rootScope.$on('$stateChangeStart',
                function (event, toState, toParams, fromState, fromParams, options) {
                    console.log(toState);
                    console.log(fromState)
                });

        }])
        .provider("init", function () {
            console.log("provider-good");
            this.$get = function () {

            };
        });

})();








