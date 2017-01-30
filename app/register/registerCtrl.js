(function(){
    
    function registerCtrl(lookupSvc){
        var vm = this;
        vm.user={
            firstName:""
        };
        vm.register=function(){
            console.log(vm.user);
        }
        //vm.countries = lookupSvc.getCountries();
        vm.selectedCountry = lookupSvc.defaultCountry();
       /* angular.forEach( vm.countries, function(item){
           if(item.code=="IN"){
               //vm.selectedCountry=item;
           }
        })*/

        lookupSvc.getCountriesFromJson()
        .then(function(res){
            console.log(res);
            vm.countries = res;
        })
        .catch(function(err){
            console.log(err);
        })
    }
    angular.module("register")
    .controller("registerCtrl",["lookupService",registerCtrl]);
    
})();