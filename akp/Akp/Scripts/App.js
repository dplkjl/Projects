$(document).ready(LoadData);
var notesClientId = 0;


function LoadData() {
    var currentClients = CurrentClients();
    var allClients = AllClients();
    SetupSearchClients();

}

function CurrentClients() {
    $.ajax({
        url: "api/Client",
        type: "GET",
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (data) {
            for (var i = 0; i <= data.length - 1; i++) {
                //console.log(i);
                //console.log(data[i]);

                var addClient = BuildString(data[i]);
                var addSeeNotesButton = BuildSeeNotesButton(data[i]);
                var addAddNotesButton = BuildAddNotesButton(data[i]);

                $("p");
                $("#client").append(addClient).append(addSeeNotesButton).append(addAddNotesButton);
                $(".seeenrolments").click(function () {
                    notesClientId = $(this).data("ClientId");
                    console.log("I have clicked on the button and got ", notesClientId);
                    $(LoadNotes());
                });
                //$(".addnotes").click(function () {
                //    var addNotesForThisClient = BuildAddNotesTextBox($(this).data("clientid"));
                //    notesClientId = $(this).data("clientid");

                //});
                //$(".posttextnotes").click(function () {
                //    console.log("I am in the text click");
                //    $(AddNotes());
                //});

            }
        }
    });
};

function AllClients() {
    $.get("api/ClientAll", function (data) {
        for (var i = 0; i <= data.length - 1; i++) {
            var addClient = BuildStringAllClients(data[i]);
            $("p");
            $("#allclient").append(addClient);
        }
    });
};

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

 
}
