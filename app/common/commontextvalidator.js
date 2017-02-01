(
    function () {
        function cmTextOnly() {
            return {
                restrict: "A",
                link: function (scope, element, attrs) {
                    element.bind("keypress",function(e){
                        var regExp = "/^[a-zA-Z']*$/";
                        var validator = regExp.test(e.text);
                        console.log(validator);
                        //return validator;
                    }
        }
                                }
                                 }

        angular.module("common")
            .directive("cmTextOnly", [cmTextOnly]);
    }
)();