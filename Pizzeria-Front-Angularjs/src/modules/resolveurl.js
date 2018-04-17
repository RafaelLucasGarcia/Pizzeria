import { App } from './module';
import {} from './constant';

export const resolveUrl = function (URL) {
    return {
        getRoute: function (path) {
            return `${URL}/${path}`;
        },
        getRouteById: function(path,id){
            return `${this.getRoute(path)}/${id}`;
        }
    };
}
resolveUrl.$inject['URL'];
App.factory('resolveUrl', resolveUrl);