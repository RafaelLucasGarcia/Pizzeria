import {} from './resolveurl';

export class BaseService{
    constructor(http,resolveUrl,path, tokenpath){
        this.http = http;
        this.resolveUrl = resolveUrl;
        this.path = path;
        this.tokenpath = tokenpath;
    }
    getRoute(){
        return this.resolveUrl.getRoute(this.path);
    }
    getRouteById(id){
        return this.resolveUrl.getRouteById(this.path, id);
    }
    getRouteToken(){
        return this.resolveUrl.getRoute(this.tokenpath);
    } 
}
