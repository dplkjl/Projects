$(document).ready(LoadData);
var notesClientId = 0;


function LoadData() {
    $.ajax({
        url: "api/Client",
        type: "GET",
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function(data) {
            for (var i = 0; i <= data.length - 1; i++) {
                console.log(i);
                console.log(data[i]);

                var addClient = BuildString(data[i]);
                var addSeeNotesButton =BuildSeeNotesButton(data[i]);
                var addAddNotesButton =BuildAddNotesButton(data[i]);

                $("p");
                $("#client").append(addClient).append(addSeeNotesButton).append(addAddNotesButton);
                $(".seeenrolments").click(function() {
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
}

