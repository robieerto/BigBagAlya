import 'devextreme/dist/css/dx.common.css';
import './themes/generated/theme.base.css';
import './themes/generated/theme.additional.css';
import "bootstrap/dist/css/bootstrap.min.css"
import "bootstrap"
import { createApp } from 'vue';
import router from './router';
import themes from 'devextreme/ui/themes';
import { locale } from "devextreme/localization";
import { localizeMessages } from "@/devextremeMessages";

import App from './App';
import appInfo from './app-info';

locale("sk");
localizeMessages("sk");

themes.initialized(() => {
  const app = createApp(App);
  app.use(router);
  app.config.globalProperties.$appInfo = appInfo;
  app.mount('#app');
});
