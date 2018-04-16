import { App } from '../../module';

export class AddUserCtrl {
    constructor(state, userService) {
        this.userService = userService;
        this.state = state;
        this.user = {
            email: null,
            password: null,
            confirmPassword: null,
            nombre: null,
            apellidos: null,
        };
    }
    saveUser() {
        let self = this;
        this.userService.create(this.user)
            .then(function () {

            })
    };

}


AddUserCtrl.$inject = ['$state', 'userService'];
App.controller('addUserCtrl', AddUserCtrl);