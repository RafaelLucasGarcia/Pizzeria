import { App } from '../../module';
import html from './menu.html';

export const ilMenu = {
  template: html,
  bindings:{
      closeSidenav: "=",
      mdSidenav:"=",
            
  }
}
App.component('ilMenu', ilMenu); 