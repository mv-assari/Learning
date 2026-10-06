
var connenction = new signalR.HubConnectionBuilder()
    .withUrl("/chathub")
    .build();

connenction.start();

