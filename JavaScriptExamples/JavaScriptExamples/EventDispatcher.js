var EventDispatcher = EventDispatcher || {};

EventDispatcher = (function () {
    var customEvent = function(docElement, docTrigger,docFunction)
    {
        SweetSelector.select(docElement)[0].addEventListener( docTrigger, docFunction , false);
    };

    var customTrigger = function (docElement, docTrigger) {
        var event = new Event(docTrigger);
        SweetSelector.select(docElement)[0].dispatchEvent(event);
    };


    return {
        on: customEvent,
        trigger: customTrigger,

    };

}());


// this should print "awesome" in the console.
//EventDispatcher.on('.klass', 'shadi', function () { console.log("awesome")});
//EventDispatcher.trigger('.klass', 'shadi');

