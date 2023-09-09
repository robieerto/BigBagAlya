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
        text: 'Zariadenie 1',
        path: '/data?zariadenie=1',
      },
      {
        text: 'Zariadenie 2',
        path: '/data?zariadenie=2',
      },
      {
        text: 'Zariadenie 3',
        path: '/data?zariadenie=3',
      },
    ],
  },
];
