import { App } from '../../module';
import {} from './config';
import {} from './loginuserctrl';
import html from './loginuser.html';

export const ilLoginUser = {
    controller: 'loginUserCtrl',
    template: html,
};
App.component('ilLoginUser', ilLoginUser)
