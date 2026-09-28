var chatbox=$("#ChatBox")
var connection = new signalR.HubConnectionBuilder().withUrl("/chathub").build();

connection.start();

//connection.invoke('SendNewMessage', "بازدید کننده", "این پیام از سمت کلاینت ارسال شده است");


//نمایش چت باکس برای کاربر
function showChatDialog() {
    chatbox.css("display", "block");
}

function Init() {
    debugger
    setTimeout(showChatDialog, 1000);

    var NewMessageForm = $("#NewMessageForm");

    NewMessageForm.on("submit", function (e) {
        e.preventDefault();
        var message = e.target[0].value;
        e.target[0].value = '';
        sendMessage(message);
    });
}

function sendMessage(text) {
    connection.invoke('SendNewMessage', "بازدیدکننده", text);
}

$(document).ready(function () {
    Init();
});