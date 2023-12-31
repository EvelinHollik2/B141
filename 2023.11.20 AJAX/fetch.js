const inputid = document.querySelector("#id");
const inputUsername = document.querySelector("#username");
const inputDarab = document.querySelector("#darab");
const buttonRead = document.querySelector("#read");
const buttonCreate = document.querySelector("#create");
const buttonUpdate = document.querySelector("#update");
const buttonDelete = document.querySelector("#delete");
const cards = document.querySelector("#cards");

window.addEventListener("load", getAllUsers); //-- a lap betöltésekor is..
buttonRead.addEventListener("click", getAllUsers);

async function getAllUsers() {
    let endpoint = "https://retoolapi.dev/Hfa9uy/data";
    try {
        const response = await fetch(endpoint); //--head, body
        const users = await response.json(); //--body to JSON
        showAllUsers(users);
    } catch (error) {
        console.log(error);
    }
}

function showAllUsers(params) {
    let html = "";
    params.forEach(user => {
        html += `<div class="card" style="width: 18rem;">
        <img src="noimage.jpg" class="card-img-top" alt="...">
        <div class="card-body">
            <h5 class="card-title">${user.id}. ${user.username}</h5>
            <p class="card-text">Some quick example text to build on the card title and make up the bulk of
                the
                card's content.</p>
                <p class="card-text">Darab: ${user.darab}</p>
            <button class="btn btn-primary" onclick="betoltInputMezobe(${user.id})">Kiválaszt</button>
        </div>
    </div>`;
    });
    cards.innerHTML = html;
}

async function betoltInputMezobe(id) {
    let url = `https://retoolapi.dev/Hfa9uy/data/${id}`;
    try {
        const response = await fetch(url);
        const users = await response.json();
        inputid.value = users.id;
        inputUsername.value = users.username;
        inputDarab.value = users.darab;
        location.href = "#formEleje";
    } catch (error) {
        console.log(error);
    }
}

//-- új user létrehozása
buttonCreate.addEventListener("click", async () => {
    let url = "https://retoolapi.dev/Hfa9uy/data"
    let data = {
        username: inputUsername.value,
        darab: inputDarab.value
    };
    try {
        const response = await fetch(url, {
            method: "POST",
            headers: {
                "Content-type": "application/json"
            },
            body: JSON.stringify(data),
        });
        const user = await response.json();
        bevitelimezoAlaphelyzetbe();
        getAllUsers();
    } catch (error) {
        console.log(error);
    }
});

//--user felülírása
buttonUpdate.addEventListener("click", async () => {
    let url = `https://retoolapi.dev/Hfa9uy/data/${inputid.value}`;
    let data = {
        username: inputUsername.value,
        darab: inputDarab.value
    };
    try {
        const response = await fetch(url, {
            method: "PUT",
            headers: {
                "Content-type": "application/json"
            },
            body: JSON.stringify(data),
        });
        const user = await response.json();
        console.log(user);
        bevitelimezoAlaphelyzetbe();
        getAllUsers();
    } catch (error) {
        console.log(error);
    }
});

//-- user törlése
buttonDelete.addEventListener("click", async () => {
    let url = `https://retoolapi.dev/Hfa9uy/data/${inputid.value}`;
    try {
        const response = await fetch(url, {
            method: "DELETE",
        });
        const user = await response.json();
        console.log(user);
        bevitelimezoAlaphelyzetbe();
        getAllUsers();
    } catch (error) {
        console.log(error);
    }
});

function bevitelimezoAlaphelyzetbe() {
    inputid.value ="";
    inputUsername.value ="";
    inputDarab.value ="";
}
