import { App } from '../../module';
import html from './toolbar.html';

export const ilToolBar = {
    template: html,
    bindings: {
        isSidenavClosed: "=",
        openSidenav:"=",
        mdSidenav:"="
    }
}
App.component('ilToolBar', ilToolBar);