import { App } from '../../../module';
import html from './pizzacard.html';

export const ilPizzaCard = {
  template: html,
  bindings:{
    name:"@",
    img:"@"
  }

}
App.component('ilPizzaCard', ilPizzaCard);