import { App } from '../../module';

config.$inject = ["$stateProvider"];
export function config(stateProvider) {
    stateProvider
        .state('adduser', {
            parent: 'app',
            url: 'users/add',
            component: 'ilAddUser'
        });
}
App.config(config);  