![alt text](https://github.com/dplkjl/Projects/blob/master/akp/InitialScreen1.PNG "Image 1")

![alt text](https://github.com/dplkjl/Projects/blob/master/akp/Screen2.PNG "Image 2")

![alt text](https://github.com/dplkjl/Projects/blob/master/akp/Screen3.PNG "Image 3")

Code
function SetupSearchClients() {
    $.extend($.expr[':'], {
        'containsi': function (elem, i, match, array) {
            return (elem.textContent || elem.innerText || '').toLowerCase()
            .indexOf((match[3] || "").toLowerCase()) >= 0;
        }
    });


    $(".sb-search-input").keyup(function () {
        var search = $(this).val().toLowerCase();
        $._list = ($._list) ? $._list : $("#allclient li");
        $._list
            .addClass(function (index, currentClass) {
                var addedClass;
                if (currentClass !== "hidden")
                    addedClass = "hidden";
                return addedClass;
            }).filter(":containsi('" + search + "')").removeClass("hidden");
    });