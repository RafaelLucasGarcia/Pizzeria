import { App } from '../../module';
import { BaseService } from '../../baseservice';

export class PizzaService extends BaseService {
    constructor(http, resolveUrl) {
        super(http, resolveUrl, 'pizzas');
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
    create(pizza) {
        // in the development database (json-server)
        // we do not store the images
        if(pizza.img) delete pizza.img;
        return this.http.post(
            super.getRoute(),
            pizza
        );

        /*
        return this.http({
            method: 'POST',
            // set content-type to undefined so it is automatically selected
            headers: { 'Content-Type': undefined },
            url: super.getRoute(),
            data: {
                name: pizza.name,
                ingredients: pizza.ingredients,
                image: pizza.img,
            },
            transformRequest: function (data, headersGetter) {
                let formData = new FormData();
                angular.forEach(data, function (value, key) {
                    if (key === 'image' && value) {
                        formData.append(key, value, value.name);
                    }
                    else formData.append(key, value);
                });
                return formData;
            }
        });
        */
    }
}
PizzaService.$inject = ['$http', 'resolveUrl'];
App.service('pizzaService', PizzaService);