function BuildString(client) {
    var string = "<p>Client Id: " + client.Id + "</b></p>";
    string = string + "<p>" + client.FirstNames + " " + client.LastName + " Ph: " + client.HomePhoneNumber + " Email: " + client.MobilePhone + "</p>";
    return string;
}
function BuildSeeNotesButton(client) {
    var string = "<input type='submit' data-Clientid=" + client.ClientId + " class='seenotes btn btn-primary btn-sm'value='See Notes' />";
    return string;
}
function BuildAddNotesButton(client) {
    var string = "<input type='submit' data-Clientid=" + client.ClientId + " class='addnotes btn btn-primary btn-sm'value='Add Notes' /></br></br>";
    return string;
}
$(".addnotes").click(function () {
    var addNotesForThisCustomer = BuildAddNotesTextBox($(this).data("clientId"));
    notesClientId = $(this).data("clientId");

});