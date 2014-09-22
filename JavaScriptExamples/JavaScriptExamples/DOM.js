var DOM = DOM || {};

DOM = (function () {

    var selectorHide = function (docElement) {
        SweetSelector.select(docElement)[0].style.display = 'none';
    };

    var selectorShow = function (docElement) {
        SweetSelector.select(docElement)[0].style.display = 'block';
    };

    var selectorAdd = function (docElement, newClass) {
        var thisEl = SweetSelector.select(docElement)[0];
        thisEl.className = thisEl.className + " " + newClass;

        return thisEl;
    };
     
    var selectorRemove = function (docElement, removeClass) {
        var removeName = docElement + "." + removeClass;
        var thisEl = SweetSelector.select(removeName)[0];
        thisEl.className = docElement;
        return thisEl;
    };

    return {
        hide: selectorHide,
        show: selectorShow,
        addClass: selectorAdd,
        removeClass: selectorRemove
        
};

}());

