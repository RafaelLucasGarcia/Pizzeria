import { App } from '../../module';

config.$inject = ["$stateProvider"];
export function config(stateProvider) {
    stateProvider
        .state('pizzalist', {
            parent: 'app',
            url: 'pizzas',
            component: 'ilPizzaList'
        });
}
App.config(config); 