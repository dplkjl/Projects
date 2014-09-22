var SweetSelector = SweetSelector || {};


SweetSelector = (function() {

    var selectorFunction = function(docElement) {
        //console.log("docElement " + docElement);
        var foundElement = document.querySelectorAll(docElement);
        //console.log("foundElement ", foundElement);
        return foundElement;
    };

    return {
    select:selectorFunction
};

}());


