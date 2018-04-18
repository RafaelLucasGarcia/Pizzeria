import { App } from '../../module';

export class LoginUserCtrl {
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
    loginUser() {
        let self = this;
        this.userService.login(this.user)
            .then(function (response) {
                self.IsAuth = true;        
            },function (response){                
            })
    };
}


LoginUserCtrl.$inject = ['$state', 'userService'];
App.controller('loginUserCtrl', LoginUserCtrl);