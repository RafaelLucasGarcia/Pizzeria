import uglify from 'rollup-plugin-uglify';
import babel from 'rollup-plugin-babel';
import commonjs from 'rollup-plugin-commonjs';
import resolve from 'rollup-plugin-node-resolve';
import postcss from 'rollup-plugin-postcss';
import cssnext from 'postcss-cssnext';
import string from 'rollup-plugin-string';

export default {
    entry: 'src/index.js',
    dest: 'dist/app.js',
    format: 'umd',
    moduleName: 'PizzaShop',
    plugins: [
        string({
            include: '**/*.html'
        }),
        postcss({
            plugins: [
                cssnext({ warnForDuplicates: false })
            ],
            extensions: ['.css'],
        }),
        resolve({
            main: true
        }),
        commonjs({
            ignoreGlobal: false
        }),
        babel({
            exclude: [
                'node_modules/**',
                '**/*.html',
                '**/*.css'
            ]
        }),
        uglify()
    ],
    sourceMap: true,
    sourceMapFile: 'dist/app.js.map'
};