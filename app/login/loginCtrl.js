(function (){
    function loginCtrl($scope){
        $scope.user={};
        angular.module("login",[])
            .controller("loginCtrl",[loginCtrl]);
    }
})();