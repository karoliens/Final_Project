const url = 'https://localhost:7118/api/Ticket/tickets';
const options = {
    method: 'get'
}

const response = {};

function loadData() {
    fetch(url, options)
    .then((response) => response.json())
    .then((a) => {
        console.log(a);
        const menuContainer = document.getElementById('menu-items');
        let htmlMenuItem = '';

        a.forEach(element => {
            console.log(element);
            let htmlElement = 
            `<article class="menu-item">
                <section class="menu-item-info">
                    <section class="menu-item-name">
                        <h3>${element.clientName}</h3>
                    </section>
                    <section class="menu-item-desc">
                    El. pašto adresas: ${element.clientEmail}
                    </section>
                    <section class="menu-item-price">
                        Telefono numeris: ${element.clientPhoneNumber}
                    </section>
                </section>
            </article>`;
            htmlMenuItem += htmlElement;
        });

        menuContainer.innerHTML = htmlMenuItem;
    })
}

loadData();