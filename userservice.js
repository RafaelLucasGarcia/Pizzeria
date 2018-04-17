import { App } from '../../module';
import { BaseService } from '../../baseservice';

export class UserService extends BaseService {
    constructor(http, resolveUrl,localStorageService) {
        super(http, resolveUrl,'api/Account/Register', 'Token');
        this._localStorage = localStorageService;
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
        var self = this;
        return this.http.post(super.getRouteToken(), data,{headers: { 'Content-Type': "application/x-www-form-urlencoded" } },
        ).then(function(response){
            self._localStorage.set('authorizationData', { token: response.data.access_token, mail: user.mail});    
            return response;
        },function error(response){
            return response
        });
    }   
}
UserService.$inject = ['$http', 'resolveUrl','localStorageService'];
App.service('userService', UserService);