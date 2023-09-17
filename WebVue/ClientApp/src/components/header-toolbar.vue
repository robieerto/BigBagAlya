<template>
  <header class="header-component">
    <dx-toolbar class="header-toolbar">
      <dx-item :visible="menuToggleEnabled" location="before" css-class="menu-button">
        <template #default>
          <dx-button icon="menu" styling-mode="text" @click="toggleMenuFunc" />
        </template>
      </dx-item>

      <dx-item v-if="title" location="before" css-class="header-title dx-toolbar-label">
        <div>{{ title }}</div>
      </dx-item>

      <dx-item location="center" css-class="header-title dx-toolbar-label">
        <template #default>
          <div class="col h4 mb-0 mx-5">
            <span class="align-middle">Váha 1: </span>
            <span :class="['badge ms-1', calculateVahaClass(state?.vahyData[0])]">{{ calculateVahaText(state?.vahyData[0]) }}</span>
          </div>
        </template>
      </dx-item>

      <dx-item location="center" css-class="header-title dx-toolbar-label">
        <template #default>
          <div class="col h4 mb-0 mx-5">
            <span class="align-middle">Váha 2: </span>
            <span :class="['badge ms-1', calculateVahaClass(state?.vahyData[1])]">{{ calculateVahaText(state?.vahyData[1]) }}</span>
          </div>
        </template>
      </dx-item>

      <dx-item location="center" css-class="header-title dx-toolbar-label">
        <template #default>
          <div class="col h4 mb-0 mx-5">
            <span class="align-middle">Váha 3: </span>
            <span :class="['badge ms-1', calculateVahaClass(state?.vahyData[2])]">{{ calculateVahaText(state?.vahyData[2]) }}</span>
          </div>
        </template>
      </dx-item>

      <!-- <dx-item location="after" locate-in-menu="auto" menu-item-template="menuUserItem">
        <template #default>
          <div>
            <dx-button class="user-button authorization" :width="210" height="100%" styling-mode="text">
              <user-panel :email="email" :menu-items="userMenuItems" menu-mode="context" />
            </dx-button>
          </div>
        </template>
      </dx-item> -->

      <template #menuUserItem>
        <user-panel :email="email" :menu-items="userMenuItems" menu-mode="list" />
      </template>
    </dx-toolbar>
  </header>
</template>

<script setup>
import DxButton from 'devextreme-vue/button';
import DxToolbar, { DxItem } from 'devextreme-vue/toolbar';
import auth from '../auth';
import { useRouter, useRoute } from 'vue-router';
import { reactive, ref, defineProps } from 'vue';

import UserPanel from './user-panel';

const props = defineProps({
  menuToggleEnabled: Boolean,
  title: String,
  toggleMenuFunc: Function,
  logOutFunc: Function,
});

const router = useRouter();
const route = useRoute();

const state = reactive({
  vahyData: [null, null, null],
});

setInterval(() => {
  try {
    fetch('/aktualneData')
      .then((response) => response.json())
      .then((data) => {
        if (data && data.length) {
          state.vahyData.fill(-1);
          data.forEach((element) => {
            state.vahyData[element.zariadenie - 1] = element.vaha.toFixed(1);
          });
        }
      });
  } catch (error) {
    console.log(error);
  }
}, 2000);

const calculateVahaText = (vaha) => {
  if (vaha === null) return 'Načítavanie';
  else if (vaha < 0) return 'Nepripojená';
  else return vaha;
};

const calculateVahaClass = (vaha) => {
  if (vaha === null) return 'bg-secondary';
  else if (vaha < 0) return 'bg-danger';
  else return 'bg-success';
};

const email = ref('');
auth.getUser().then((e) => (email.value = e.data.email));

const userMenuItems = [
  {
    text: 'Profile',
    icon: 'user',
    onClick: onProfileClick,
  },
  {
    text: 'Logout',
    icon: 'runner',
    onClick: onLogoutClick,
  },
];

function onLogoutClick() {
  auth.logOut();
  router.push({
    path: '/login-form',
    query: { redirect: route.path },
  });
}

function onProfileClick() {
  router.push({
    path: '/profile',
    query: { redirect: route.path },
  });
}
</script>

<style lang="scss">
@import '../themes/generated/variables.base.scss';
@import '../dx-styles.scss';

.header-component {
  flex: 0 0 auto;
  z-index: 1;
  box-shadow:
    0 1px 3px rgba(0, 0, 0, 0.12),
    0 1px 2px rgba(0, 0, 0, 0.24);

  .dx-toolbar .dx-toolbar-item.menu-button > .dx-toolbar-item-content .dx-icon {
    color: $base-accent;
  }
}

.dx-toolbar.header-toolbar .dx-toolbar-items-container .dx-toolbar-after {
  padding: 0 40px;

  .screen-x-small & {
    padding: 0 20px;
  }
}

.dx-toolbar .dx-toolbar-item.dx-toolbar-button.menu-button {
  width: $side-panel-min-width;
  text-align: center;
  padding: 0;
}

.header-title .dx-item-content {
  padding: 0;
  margin: 0;
}

.dx-theme-generic {
  .dx-toolbar {
    padding: 10px 0;
  }

  .user-button > .dx-button-content {
    padding: 3px;
  }
}
</style>
