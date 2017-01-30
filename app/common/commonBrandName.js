(function(){
     function brandNameFn(){
         return{
           template:' <a class="navbar-brand" href="#">{{hc.brandName}}</a>'
         };
     }
    
    angular.module("common")
    .directive("cmBrandName",[brandNameFn]);
    
    /* directive definition
    
    directiveName:"cmBrandName"
    onTheHtml :<cm-brand-name></cm-brand-name>
    
    
    
    
    */
})();