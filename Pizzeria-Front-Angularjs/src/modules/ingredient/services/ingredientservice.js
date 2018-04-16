import { App } from '../../module';
import {} from '../../resolveurl';
import {BaseService} from '../../baseservice';

export class IngredientService extends BaseService{
    constructor(http,resolveUrl){
        super(http,resolveUrl,'ingredients');
    }
    getAll(){
        return this.http.get(
            super.getRoute()
        );
    }
}
IngredientService.$inject = ['$http','resolveUrl'];
App.service('ingredientService', IngredientService);