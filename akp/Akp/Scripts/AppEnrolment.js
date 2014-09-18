function LoadNotes() {
    console.log("I am in the LoadNotes and custID " + notesCustomerId);
    //$.ajax({ URL: "api/customers/" + notesCustomerId + "/notes" }).done(console.log($(DisplayNotesClick(data))));
    $.ajax({
        url: 'api/customers/' + notesCustomerId + '/notes',
        type: "GET",
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (data) {
            $("#displayhtmlnotes").html(data);
        }
    });
}

function AddNotesBox(customer) {
    var addNotesBox = BuildAddNotesBox();
    var addNotesButton = BuildAddTextButton(customer);
    $("#addnotesbox").html(addNotesBox).append(addNotesButton);
}
 
function BuildAddNotesTextBox(customer)
{
    $(AddNotesBox(customer));
}

function BuildAddNotesBox(customer) {
    //  var string = "<textarea name='notes' cols='40' rows='5'> </textarea><br>";
    var string = "<input type='text' data-customerid=" + customer + " class='addtextnotes' name='input' /></br></br>";
    return string;
}
function BuildAddTextButton(customer) {
    var string = "<input type='submit' data-customerid=" + customer + " class='posttextnotes btn btn-primary btn-sm' value='New Notes' /></br></br>";
    return string;
}


function AddNotes() {
    console.log("I am in the AddNotes and custID " + $(this).data("customerid"));
    $.ajax({
        url: 'api/customers/' + $(this).data("customerid") + '/'+$(this).data(input),
        type: "POST",
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function () {
            LoadNotes();
        }
    });
}
