import { App } from '../module';

config.$inject = ["$stateProvider"];
export function config(stateProvider) {
    stateProvider
        .state('app', {
            url: '/',
            component: 'ilApp'
        });
}
App.config(config); 