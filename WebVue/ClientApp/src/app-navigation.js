export default [
  {
    text: 'Všetky váženia',
    path: '/data',
    icon: 'home',
  },
  {
    text: 'Váženia',
    icon: 'folder',
    items: [
      {
        text: 'Váha 1',
        path: '/data?vaha=1',
      },
      {
        text: 'Váha 2',
        path: '/data?vaha=2',
      },
      {
        text: 'Váha 3',
        path: '/data?vaha=3',
      },
    ],
  },
  {
    text: 'Programy',
    icon: 'fields',
    items: [
      {
        text: 'Váha 1',
        path: '/programy?vaha=1',
      },
      {
        text: 'Váha 2',
        path: '/programy?vaha=2',
      },
      {
        text: 'Váha 3',
        path: '/programy?vaha=3',
      },
    ],
  },
  {
    text: 'Užívatelia',
    icon: 'user',
    items: [
      {
        text: 'Váha 1',
        path: '/uzivatelia?vaha=1',
      },
      {
        text: 'Váha 2',
        path: '/uzivatelia?vaha=2',
      },
      {
        text: 'Váha 3',
        path: '/uzivatelia?vaha=3',
      },
    ],
  },
];
