import { App } from '../../module';
import {} from './config';
import {} from './pizzalistctrl';
import html from './pizzalist.html';

export const ilPizzaList = {
    controller: 'pizzaListCtrl',
    template: html
};
App.component('ilPizzaList', ilPizzaList);





