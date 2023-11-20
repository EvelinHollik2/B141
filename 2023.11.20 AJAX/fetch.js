const inputid = document.querySelector("#id");
const inputUsernames = document.querySelector("#usernames");
const inputDarab = document.querySelector("#darab");
const buttonRead = document.querySelector("#read");
const body = document.getElementsByTagName("body")[0];

body.addEventListener("load", getAllUsers); //-- a lap betöltésekor is..
buttonRead.addEventListener("click", getAllUsers);

async function getAllUsers() {
    let endpoint = "https://retoolapi.dev/Hfa9uy/data";
    try {
        const response = await fetch(endpoint); //--head, body
        const users = await response.json(); //--body to JSON
        console.log(users);
    } catch (error) {
        console.log(error);
    }
}

function showAllUsers(params) {
    params.forEach(user => {
        card="<div class=\"card\" style=\"width: 18rem;\">"
        +"<img src=\"noimage.jpg\" class=\"card-img-top\" alt=\"...\">"
        +"<div class=\"card-body\"><h5 class=\"card-title\">Card title</h5>" + user.id + "</h5>";
    });    
}