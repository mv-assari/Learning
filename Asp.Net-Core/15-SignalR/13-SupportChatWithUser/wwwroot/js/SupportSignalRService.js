var activeRoomId = '';



var connectionsup = new signalR.HubConnectionBuilder().withUrl('/supporthub').build();

var chatConnection = new signalR.HubConnectionBuilder().withUrl('/chathub').build();

connectionsup.on('GetNewMessage', addMessages);

function addMessages(messages) {
    if (!messages) return;

    messages.forEach(function (m) {
        showMessage(m.sender, m.message, m.time);
    })
}

function showMessage(sender, message, time) {
    $("#ChatMessage").append("<li><div><samp class='name'>" + sender + "</samp><samp class='time'>" + time + "</samp></div><div class='message'>" + message + "</div></li>")
}



connectionsup.on("GetRooms",loadrooms);

function Init() {

    connectionsup.start();
    chatConnection.start();

    var answerForm = $("#answerForm");
    answerForm.on('submit', function (e) {
        e.preventDefault();
        var text = e.target[0].value;
        e.target[0].value = '';
        sendMessage(text)
    })
}

function sendMessage(text) {
    if (text && text.length) {
    connectionsup.invoke('SendMessage', activeRoomId,text)
    } 
}


chatConnection.on('GetNewMessage', showMessage)



$(document).ready(function () {
    Init();
});

var roomListEl = document.getElementById('roomList');
var roomMessagesEl = document.getElementById('ChatMessage');
function loadrooms(rooms) {
    debugger
    if (!rooms) return;

    var roomIds = Object.keys(rooms);
    if (!roomIds.length) return;

    removeAllChildren(roomListEl);

    roomIds.forEach(function (id) {
        var roomInfo = rooms[id];
        if (!roomInfo) return;

        return $("#roomList").append("<a class='list-group-item list-group-item-action d-flex justify-content-between align-items-center' data-id='" + roomInfo + "' href='#'>" + roomInfo + "</a>");
    })

}


function removeAllChildren(node) {
    if (!node) return;
    while (node.lastChild) {
        node.removeChild(node.lastChild)
    }
}


function setActiveRoomButton(el) {
    var allbuttons = roomListEl.querySelectorAll('a.list-group-item');

    allbuttons.forEach(function (btn) {
        btn.classList.remove('active');
    });

    el.classList.add('active');
}

function switchActiveRoomTo(id) {
    if (id === activeRoomId) return;

    removeAllChildren(roomMessagesEl);
    if (activeRoomId) {
        chatConnection.invoke('LeaveRoom', activeRoomId);
    }
    activeRoomId = id;

    chatConnection.invoke('JoinRoom', activeRoomId)
    connectionsup.invoke('LoadMessage', activeRoomId);
}

roomListEl.addEventListener('click', function (e) {
    roomMessagesEl.style.display = 'block';
    setActiveRoomButton(e.target);
    var roomId = e.target.getAttribute('data-id');
    switchActiveRoomTo(roomId);
})
