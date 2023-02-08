"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable the send button until connection is established.
document.getElementById("sendButton").disabled = true;

connection.on("ReceiveMessage", function (user, sendDate, message) {
    var li = document.createElement("li");
    document.getElementById("messagesList").appendChild(li);
    //var img = document.createElement("img");
    //elem.setAttribute("src", userimage);
    //li.appendChild(img)
    // We can assign user-supplied strings to an element's textContent because it
    // is not interpreted as markup. If you're assigning in any other way, you 
    // should be aware of possible script injection concerns.
    li.textContent = ` ${user} : ${message} - ${sendDate}`;
});

connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {
    
    var user = document.getElementById("userInput").value;
    var item = document.getElementById("itemInput").value;
    var message = document.getElementById("messageInput").value;
    
    connection.invoke("SendMessage", user,item, message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});