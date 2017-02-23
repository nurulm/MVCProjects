(
    function () {
        function cmLogin() {
            return {
                templateUrl:"app/login/login.tpl.html",
                controller:"loginCtrl as lc",
                restrict:"E",
                link:function(scope,element,attrs){
                    console.log(scope);
                }
            }

        }

        angular.module("common")
            .directive("cmLogin", [cmLogin]);
    }
)();
(
 function(){
     function checkuser(){
         return {
           require:"ngModel",
             link:function(scope,element,attrs,ctrl){
                 ctrl.$parsers.unshift(checkValue);
                 ctrl.$formatters.unshift(checkValue);
                 
                 
                 function checkValue(val){
                     var users=["kiran","Ravi","shyam"];
                     var isExistingUser= _.contains(users, val);
                     console.log(isExistingUser);
                      ctrl.$setValidity("checkuser",!isExistingUser)
                      return val;
                     
                 }
             }
         };
     }
     angular.module("common")
     .directive("checkuser",[checkuser]);
 }
)();