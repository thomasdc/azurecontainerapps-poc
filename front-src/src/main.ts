import { createApp } from 'vue'
import { Quasar, Loading } from 'quasar'

// Import icon libraries
import '@quasar/extras/roboto-font/roboto-font.css'
import '@quasar/extras/material-icons/material-icons.css'

// Import Quasar css
import 'quasar/src/css/index.sass'

import App from "./App.vue";
import router from "./router";

import "./assets/main.css";

const app = createApp(App);

app.use(router);
app.use(Quasar, {
    plugins: { // import Quasar plugins and add here
      Loading
    },
  })

app.mount("#app");
