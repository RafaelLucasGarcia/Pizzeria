import { App } from '../../module';
import {} from '../../resolveurl';
import {BaseService} from '../../baseservice';

export class CommentService extends BaseService{
    constructor(http,resolveUrl){
        super(http,resolveUrl,'comments');
    }
    create(comment){
        return this.http.post(
            super.getRoute(),
            comment
        );
    }
}
CommentService.$inject = ['$http','resolveUrl'];
App.service('commentService', CommentService);