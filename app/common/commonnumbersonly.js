(
    function () {
        function cmNumbersOnly() {
            return {
                restrict: "A",
                link: function (scope, element, attrs) {
                    var lengthOfNumbers = attrs["maxnumbers"];
                    element.bind("keypress",function(e){
                       if(e.keyCode>=48 && e.keyCode<=57 && this.value.length<lengthOfNumbers){
                           //Do nothing
                       }
                        else{
                            e.preventDefault();
                        }

                    })
                }
            }
        }

        angular.module("common")
            .directive("cmNumbersOnly", [cmNumbersOnly]);
    }
)();
