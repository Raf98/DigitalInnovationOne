let ids = [];

fetch('https://pro-api.coinmarketcap.com/v1/cryptocurrency/listings/latest?CMC_PRO_API_KEY=' +
  apikey)
  .then((response) => {
    if (!response.ok) throw new Error('Erro ao executar a requisição, status ' + response.status);
    return response.json();
  })
  .then((api) => {

    let text = "";
    for (let i = 0; i < 10; i++) {

      let name = api.data[i].name;
      let symbol = api.data[i].symbol;
      let currentPrice = api.data[i].quote.USD.price.toFixed(2);
      ids.push(api.data[i].id);
      
      let color = "green";
      if (currentPrice < 1) {
        color = "red";
      }
      //Show API information
      text = text + `        
          <div id="media${i}">
              <img src="coin.jpg" class="align-self-center mr-3" alt="coin" width="100" height="60">
              <div class="media-body">
              <h5 class="mt-2">${name}</h5>
              <div style="display:flex;justify-content:space-between">${symbol} <div style="color:${color}">${currentPrice}</div></div>
              </div>
          </div>
          `;

      document.getElementById("coins").innerHTML = text;
      console.log(api.data[i]);

    }
  }).then(
    () => {
      return fetch('https://pro-api.coinmarketcap.com/v1/cryptocurrency/info?CMC_PRO_API_KEY=' +
        apikey + "&id=" + ids.toString())
        .then((response) => {
          if (!response.ok) throw new Error('Erro ao executar a requisição, status ' + response.status);
          return response.json();
        })
    })
  .then((api) => {

    let logos = [];

    for (let i = 0; i < 10; i++) {
      Object.values(api.data).forEach((coin) => {
        logos.push(coin.logo)
      })

      document.getElementById("media" + i).getElementsByTagName("img")[0].getAttributeNode("src").value = logos[i];
      console.log(logos[i]);
    }
  })
  .catch((error) => {
    console.error(error.message);
  })

  .catch((error) => {
    console.error(error.message);
  });


