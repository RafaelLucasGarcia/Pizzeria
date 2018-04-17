import { App } from '../../module';
import { BaseService } from '../../baseservice';

export class UserService extends BaseService {
    constructor(http, resolveUrl) {
        super(http, resolveUrl, 'api/Account/Register', 'Token');

    }

    get(id) {
        return this.http.get(
            super.getRouteById(id)
        );
    }
    
    getAll() {
        return this.http.get(
            super.getRoute()
        );
    }

    create(user) {
        return this.http.post(
            super.getRoute(),
            user
        );
    }

    login(user) {
        var data = "grant_type=password&username=" + user.email + "&password=" + user.password;
        return this.http.post(
            super.getRouteToken(),
            data,
            { headers: { 'Content-Type': "application/x-www-form-urlencoded" } },
        );
    }
}
UserService.$inject = ['$http', 'resolveUrl'];
App.service('userService', UserService);