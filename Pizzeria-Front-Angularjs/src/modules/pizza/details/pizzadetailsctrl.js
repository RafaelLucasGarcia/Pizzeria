import { App } from '../../module';

export class PizzaDetailsCtrl {
    constructor(state, pizzaService, commentService) {
        this.state = state;
        this.pizzaService = pizzaService;
        this.commentService = commentService;
        this.id = this.state.params && this.state.params.id
        this.name = null;
        this.img = null;
        this.ingredients = null;
        this.comments = null;
       
        this.comment = {
            score:null,
            text:null
        };
        this.config();
    }
    config() {
        let _this = this;
        this.pizzaService.get(this.id)
            .then(response => {
                let data = response.data;
                _this.name = data.name;
                _this.img = data.img;
                _this.ingredients = data.ingredients;
                _this.comments = data.comments;
            });
    }
    hasIngredients() {
        return this.ingredients && this.ingredients.length > 0;
    }
    hasComments(){
        return this.comments && this.comments.length > 0;
    }
    submitComment() {
        this.comment.date = new Date();
        this.comment.text = this.comment.text || "";
        this.comment.pizza = parseInt(this.id);
        this.comment.user = "Unknown";
        this.commentService.create(this.comment)
            .then(this.state.reload());
    }
}
PizzaDetailsCtrl.$inject = ['$state', 'pizzaService', 'commentService'];
App.controller('pizzaDetailsCtrl', PizzaDetailsCtrl);