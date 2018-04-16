import { App } from '../../module';

export class PizzalistCtrl{
    constructor(pizzaService) {
    this.pizzaService = pizzaService;
    this.pizzas = [];
    this.getPizzas();
    }
    getPizzas() {
        let _this = this;
        this.pizzaService.getAll()
            .then(c => _this.pizzas = c.data);
    }
}
PizzalistCtrl.$inject = ['pizzaService'];
App.controller('pizzaListCtrl', PizzalistCtrl);