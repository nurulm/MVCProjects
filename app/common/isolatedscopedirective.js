
(function(){
  
  angular.module("isolatedScopeDemo",[])
  .controller("userCtrl",["$scope",userCtrl])
   .controller("productCtrl",["$scope",productCtrl])
  .directive("dirUser",[dirUser])
  
  
  function userCtrl($scope){
    $scope.username="Kiran";
    var vm =this;
    vm.checkname="test";
  }
   function productCtrl($scope){
    $scope.productName="I am the product";
    $scope.anything =" iam anything";
     
   }
  
  function dirUser(){
    return{
      template:"<h1>{{myname}}</h1><h2>{{myid}}</h2>",
      restrict:"E",
      scope:{
        myname:"@",
        myid:"@"
      }
    }
  }
  
})();