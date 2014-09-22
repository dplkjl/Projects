var miniQuery = miniQuery || {};

miniQuery = (function () {

    var DOM = (function () {

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

    var SweetSelector = (function () {

        var selectorFunction = function (docElement) {
            //console.log("docElement " + docElement);
            var foundElement = document.querySelectorAll(docElement);
            //console.log("foundElement ", foundElement);
            return foundElement;
        };

        return {
            select: selectorFunction
        };

    }());

    var AjaxWrapper = (function () {

        var ajaxRequest = function (params) {
            var request = new XMLHttpRequest();
            request.open(params.type, params.url, true);

            request.onload = function () {
                if (request.status >= 200 && request.status < 400) {
                    // Success!
                    var resp = request.responseText;
                    params.success(resp);

                } else {
                    // We reached our target server, but it returned an error
                    params.fail();
                }
            };

            request.onerror = function () {
                // There was a connection error of some sort
                params.fail();
            };

            request.send();
        };
        return {
            request: ajaxRequest
        };

    }());

}());