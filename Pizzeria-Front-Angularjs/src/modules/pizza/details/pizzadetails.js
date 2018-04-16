import { App } from '../../module';
import {} from './pizzacard';
import {} from './commentlist';
import {} from './ingredientlist';
import {} from './config';
import {} from './pizzadetailsctrl';
import html from './pizzadetails.html';

export const ilPizzaDetails = {
    controller: 'pizzaDetailsCtrl',
    template: html
};
App.component('ilPizzaDetails', ilPizzaDetails)





