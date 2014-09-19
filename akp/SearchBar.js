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
