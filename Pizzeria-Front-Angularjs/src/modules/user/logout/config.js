import { App } from '../../module';

config.$inject = ["$stateProvider"];
export function config(stateProvider) {
    stateProvider
        .state('logoutuser', {
            parent: 'app',
            url: 'users/logout',
            component: 'ilLogoutUser'
        });
}
App.config(config);  