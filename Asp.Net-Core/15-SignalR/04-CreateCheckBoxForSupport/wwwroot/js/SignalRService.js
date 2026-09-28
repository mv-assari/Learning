var chatbox=$("#ChatBox")
var connection = new signalR.HubConnectionBuilder().withUrl("/chathub").build();

connection.start();

//connection.invoke('SendNewMessage', "بازدید کننده", "این پیام از سمت کلاینت ارسال شده است");


//نمایش چت باکس برای کاربر
function showChatDialog() {
    chatbox.css("display", "block");
}

function Init() {
    setTimeout(showChatDialog, 1000);
}

$(document).ready(function () {
    Init();
});