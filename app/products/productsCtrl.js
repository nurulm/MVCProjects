(function(){
    
    function productsCtrl(productsSvc){
        var vm = this;
        productsSvc.getProducts()
        .then( function(res){
            vm.products= res.data.products;
        })
        .catch(function(err){
            console.log(err);
        })
        
    }
    angular.module("products")
    .controller("productsCtrl",["productsSvc",productsCtrl]);
    
})();
