(function(){
    function cmHeaderFn(){
        return {
            templateUrl:"./app/header/header.tpl.html",
            restrict:"A,E,C"       //A- Attribute, E-Element, C-Class
        }
    };

    angular.module("common")
        .directive("cmHeader",[cmHeaderFn]);
})();