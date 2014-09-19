function BuildString(client) {
    var string = "<li>Client Id: " + client.Id + " Name: " +client.FirstNames + " " + client.LastName + " Ph: " + client.HomePhoneNumber  + "</li>";
    return string;
}
function BuildStringAllClients(client) {
    var string = "<li class='hidden'>" + client.FirstNames + " " + client.LastName + " (Id:"+client.Id + ") Ph: " + client.HomePhoneNumber + "</li>";
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