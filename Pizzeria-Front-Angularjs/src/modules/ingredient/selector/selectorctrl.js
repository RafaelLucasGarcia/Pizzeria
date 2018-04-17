import { App } from '../../module';

export class IngredientSelectorCtrl {
    constructor(ingredientService) {
        this.ingredientService = ingredientService;
        this.ingredients = null;
        this.getIngredients();
    }
    getIngredients() {
        let _this = this;
        this.ingredientService.getAll()
            .then(response => _this.ingredients = response.data);
    }
}
IngredientSelectorCtrl.$inject = ['ingredientService'];
App.controller('ingredientSelectorCtrl', IngredientSelectorCtrl);


