/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ['./src/**/*.{js,jsx,ts,tsx}'],
  theme: {
    extend: {
      minWidth: (theme) => ({
        ...theme('spacing'),
      }),
    },
  },
  variants: {},
  plugins: [],
};
