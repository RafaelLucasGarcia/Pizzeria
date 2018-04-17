import { App } from '../../module';
import {} from './imageuploader';
import {} from './config';
import {} from './addpizzactrl';
import html from './addpizza.html';

export const ilAddPizza = {
    controller: 'addPizzaCtrl',
    template: html
};
App.component('ilAddPizza', ilAddPizza)
