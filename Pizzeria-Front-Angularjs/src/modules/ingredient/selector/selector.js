import { App } from '../../module';
import html from './selector.html';
import {} from './selectorctrl';

export const ilIngredientSelector = {
    template: html,
    controller: 'ingredientSelectorCtrl',
    bindings: {
        pizza: "="
    }
};
App.component('ilIngredientSelector', ilIngredientSelector);
