(function(){
    function headerCtrl(){
        var vm=this;  //VM becomes public variable now

        vm.brandName ="Good Services";
        vm.navItems=["Login","Register","Cart","Products","Logout"];
        vm.loginTemplate = "app/login/login.tpl.html";
        vm.registerTemplate = "app/register/register.tpl.html";
        vm.productsTemplate ="app/products/products.tpl.html";

        vm.loadView = function(param){
            if(param=="Login")
            {
                vm.loadTemplate = vm.loginTemplate;
            }
            else if(param=="Register")
            {
                vm.loadTemplate = vm.registerTemplate;
            }
            else if(param=="Products"){
               vm.loadTemplate=vm.productsTemplate; 
            }
    
        };
    };

    angular.module("header")
        .controller("headerCtrl",[headerCtrl]);
})();