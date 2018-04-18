import { App } from '../../module';
import {} from './config';
import {} from './logoutuserctrl';
import html from './logoutuser.html';

export const ilLogoutUser = {
    controller: 'logoutUserCtrl',
    template: html,
};
App.component('ilLogoutUser', ilLogoutUser)
