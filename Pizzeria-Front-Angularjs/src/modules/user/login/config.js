import { App } from '../../module';

config.$inject = ["$stateProvider"];
export function config(stateProvider) {
    stateProvider
        .state('loginuser', {
            parent: 'app',
            url: 'users/login',
            component: 'ilLoginUser'
        });
}
App.config(config);  