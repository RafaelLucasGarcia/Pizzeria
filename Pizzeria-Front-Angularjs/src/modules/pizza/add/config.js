import { App } from '../../module';

config.$inject = ["$stateProvider"];
export function config(stateProvider) {
    stateProvider
        .state('addpizza', {
            parent: 'app',
            url: 'pizzas/add',
            component: 'ilAddPizza'
        });
}
App.config(config);  