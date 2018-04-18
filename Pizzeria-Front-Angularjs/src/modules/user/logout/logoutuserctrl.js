import { App } from '../../module';

export class LogoutUserCtrl {
    constructor(state, userService) {
        this.userService = userService;
        this.state = state;
        this.user = {
            email: null,
            password: null,
            grant_type: "password",
        }
        this.IsAuth = false;
    }

    logoutUser() {
        this.userService.logout()
    }
}

LogoutUserCtrl.$inject = ['$state', 'userService'];
App.controller('logoutUserCtrl', LogoutUserCtrl);