import auth from './auth';
import { createRouter, createWebHashHistory } from 'vue-router';

import data from './views/data-page';
import programy from './views/programy-page';
import uzivatelia from './views/uzivatelia-page';
// import Profile from './views/profile-page';
import defaultLayout from './layouts/side-nav-outer-toolbar';
// import simpleLayout from './layouts/single-card';
import reportPdf from './views/report-pdf'

// function loadView(view) {
//   return () => import(/* webpackChunkName: "login" */ `./views/${view}.vue`);
// }

const router = new createRouter({
  routes: [
    {
      path: '/data',
      name: 'data',
      meta: {
        requiresAuth: true,
        layout: defaultLayout,
      },
      component: data,
    },
    {
      path: '/programy',
      name: 'programy',
      meta: {
        requiresAuth: true,
        layout: defaultLayout,
      },
      component: programy,
    },
    {
      path: '/uzivatelia',
      name: 'uzivatelia',
      meta: {
        requiresAuth: true,
        layout: defaultLayout,
      },
      component: uzivatelia,
    },
    {
      path: '/',
      redirect: '/data',
    },
    {
      path: '/:pathMatch(.*)*',
      redirect: '/data',
    },
    {
      path: '/report',
      name: 'report',
      meta: {
        requiresAuth: true,
        layout: defaultLayout,
      },
      component: reportPdf,
    },
    // {
    //   path: '/profile',
    //   name: 'profile',
    //   meta: {
    //     requiresAuth: true,
    //     layout: defaultLayout,
    //   },
    //   component: Profile,
    // },
    // {
    //   path: '/login-form',
    //   name: 'login-form',
    //   meta: {
    //     requiresAuth: false,
    //     layout: simpleLayout,
    //     title: 'Sign In',
    //   },
    //   component: loadView('login-form'),
    // },
    // {
    //   path: '/reset-password',
    //   name: 'reset-password',
    //   meta: {
    //     requiresAuth: false,
    //     layout: simpleLayout,
    //     title: 'Reset Password',
    //     description: 'Please enter the email address that you used to register, and we will send you a link to reset your password via Email.',
    //   },
    //   component: loadView('reset-password-form'),
    // },
    // {
    //   path: '/create-account',
    //   name: 'create-account',
    //   meta: {
    //     requiresAuth: false,
    //     layout: simpleLayout,
    //     title: 'Sign Up',
    //   },
    //   component: loadView('create-account-form'),
    // },
    // {
    //   path: '/change-password/:recoveryCode',
    //   name: 'change-password',
    //   meta: {
    //     requiresAuth: false,
    //     layout: simpleLayout,
    //     title: 'Change Password',
    //   },
    //   component: loadView('change-password-form'),
    // },

    // {
    //   path: '/recovery',
    //   redirect: '/home',
    // },
  ],
  history: createWebHashHistory(),
});

router.beforeEach((to, from, next) => {
  if (to.name === 'login-form' && auth.loggedIn()) {
    next({ name: 'home' });
  }

  if (to.matched.some((record) => record.meta.requiresAuth)) {
    if (!auth.loggedIn()) {
      next({
        name: 'login-form',
        query: { redirect: to.fullPath },
      });
    } else {
      next();
    }
  } else {
    next();
  }
});

export default router;
