import { App } from '../../../module';
import html from './commentlist.html';

export const ilCommentList = {
    template: html,
    bindings: {
        comments:"<"
    }
}
App.component('ilCommentList', ilCommentList);