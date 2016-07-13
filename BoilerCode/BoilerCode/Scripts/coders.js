var coders = {
    utilities: {}
    , layout: {}
    , page: {
        handlers: {
        }
        , startUp: null
    }
    , services: {}
    , ui: {}
  
};


coders.layout.startUp = function () {

    console.debug("sabio.layout.startUp");

    //this does a null check on sabio.page.startUp
    if (coders.page.startUp) {
        console.debug("sabio.page.startUp");
        coders.page.startUp();
    }

};


$(document).ready(coders.layout.startUp);