var AjaxWrapper = AjaxWrapper || {};


AjaxWrapper = (function () {

    var ajaxRequest = function(params) {
       var request = new XMLHttpRequest();
        request.open(params.type, params.url, true);

        request.onload = function() {
            if (request.status >= 200 && request.status < 400) {
                // Success!
               var resp = request.responseText;
                params.success(resp);

            } else {
                // We reached our target server, but it returned an error
                params.fail();
            }
        };

        request.onerror = function() {
            // There was a connection error of some sort
            params.fail();
        };

        request.send();
    };
    return {
        request: ajaxRequest
    };

}());



// this should an ajax request to the url and call the success callback if successful and fail callback if unsuccessful.
AjaxWrapper.request({
    url: 'file:///C:/Users/Karen/Documents/GitHub/projects/Projects/JavaScriptExamples/JavaScriptExamples/HtmlPage1.html',
    type: 'GET',
    success: function (response) {
        //do something
        console.log("Success ", response);
    },
    fail: function () {
        //do something
        console.log("Fail ");
    }
});

