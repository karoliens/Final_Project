const registrationForm = document.querySelector("#new-ticket-form");
const registrationFormSbmBtn = document.querySelector("#ticket-submit-button");

const url = "https://localhost:7118/api/Ticket/tickets";

function sendData() {
  let data = new FormData(registrationForm);
  let obj = {};

  console.log(data);

  data.forEach((value, key) => {
    obj[key] = value;
  });

  console.log(obj);

  
  fetch("https://localhost:7118/api/Ticket/tickets", {
    method: "post",
    headers: {
      "Accept": "application/json",
      "Content-Type": "application/json",
    },
    body: JSON.stringify(obj),
  })
    .then((obj) => console.log(obj.json()))
    .catch((error) => console.log(error));
    
}

registrationFormSbmBtn.addEventListener("submit", (e) => {
  e.preventDefault();
  sendData();
});
