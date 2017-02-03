(
    function () {
        function cmTextOnly() {
            return {
                restrict: "A",
                link: function (scope, element, attrs) {
                   
                    element.bind("keypress",function(e){
                       // console.log(e);
                        var regExp = "/^[a-zA-Z']*$/";
                        console.log(e.key.match(regExp));
                       // var validator = regExp.match(e.key);
                       // console.log(regExp.test(e.key));
                        
                       //if(e.keyCode>=48 && e.keyCode<=57 && this.value.length<lengthOfNumbers){
                           //Do nothing
                       //}
                        //else{
                          //  e.preventDefault();
                        //}

                    })
                }
            }
        }

        angular.module("common")
            .directive("cmTextOnly", [cmTextOnly]);
    }
)();