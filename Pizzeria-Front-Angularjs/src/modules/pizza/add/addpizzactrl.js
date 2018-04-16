import { App } from '../../module';

export class AddPizzaCtrl {
    constructor(state, pizzaService) {
        this.pizzaService = pizzaService;
        this.state = state;
        this.ingredients = null;
        this.pizza = {
            name: null,
            ingredients: [],
            img: null
        };
    }
    savePizza() {
        let self=this;
        this.pizzaService.create(this.pizza)
            .then(function(){
                self.state.go('pizzalist')
            });
    }
    
}
AddPizzaCtrl.$inject = ['$state', 'pizzaService'];
App.controller('addPizzaCtrl', AddPizzaCtrl);