/** @type {import('tailwindcss').Config} */
// const defaultTheme = require('tailwindcss/defaultTheme');

module.exports = {
  content: ['./src/**/*.{js,jsx,ts,tsx}'],
  theme: {
    extend: {
      minWidth: (theme) => ({
        ...theme('spacing'),
      }),
    },
    // screens: {
    //   xs: '475px',
    //   ...defaultTheme.screens,
    // },
  },
  variants: {},
  plugins: [],
};
