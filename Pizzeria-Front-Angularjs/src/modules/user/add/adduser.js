import { App } from '../../module';
import {} from './config';
import {} from './adduserctrl';
import html from './adduser.html';

export const ilAddUser = {
    controller: 'addUserCtrl',
    template: html
};
App.component('ilAddUser', ilAddUser)

