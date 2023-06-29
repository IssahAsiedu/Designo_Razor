module.exports = {
    content: [
        './Pages/**/*.cshtml',
        './Views/**/*.cshtml'
    ],
    purge: [
        './Pages/**/*.cshtml',
        './Views/**/*.cshtml'
    ],
    darkMode: 'media', // or 'media' or 'class'
    theme: {
        extend: {
            gridTemplateRows: {
                '3': 'repeat(3, 250px)',
                'md-3': 'repeat(3, 200px)'
            },
        }
    },
    variants: {
        extend: {},
    },
    plugins: [
        require('tailwindcss'),
        require('autoprefixer')],
}
