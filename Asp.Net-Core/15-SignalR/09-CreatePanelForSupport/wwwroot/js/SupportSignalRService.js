var connectionsup = new signalR.HubConnectionBuilder().withUrl('/supporthub').build();

var a = connectionsup.on("GetRooms",loadrooms);

function Init() {

    connectionsup.start();
}

$(document).ready(function () {
    Init();
});

var roomListEl = document.getElementById('roomList');
function loadrooms(rooms) {
    debugger
    if (!rooms) return;

    var roomIds = Object.keys(rooms);
    if (!roomIds.length) return;

    removeAllChildren(roomListEl);

    roomIds.forEach(function (id) {
        var roomInfo = rooms[id];
        if (!roomInfo) return;

        return $("#roomList").append("<a class='list-group-item list-group-item-action d-flex justify-content-between align-items-center' data-id='" + id + "' href='#'>" + roomInfo + "</a>");
    })

}


function removeAllChildren(node) {
    if (!node) return;
    while (node.lastChild) {
        node.removeChild(node.lastChild)
    }
}
