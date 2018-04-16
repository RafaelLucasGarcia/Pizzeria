import {App} from '../module';
import {} from './config';
import {} from './menu';
import {} from './toolbar';
import {} from './content'; 
import {} from './appctrl';
import html from './app.html';

export const ilApp = {
    template: html,
    controller: 'appCtrl'
}

App.component('ilApp', ilApp);