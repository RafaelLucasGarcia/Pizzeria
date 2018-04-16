import { App } from './module';

config.$inject = ["$urlRouterProvider"];
export function config(urlRouterProvider) {
    urlRouterProvider.otherwise('/');  
}

App.config(config);  