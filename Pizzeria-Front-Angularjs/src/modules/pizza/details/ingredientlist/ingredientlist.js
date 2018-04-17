import { App } from '../../../module';
import html from './ingredientlist.html';

export const ilIngredientList = {
    template: html,
    bindings:{
        ingredients:"<"
    }

}
App.component('ilIngredientList', ilIngredientList);