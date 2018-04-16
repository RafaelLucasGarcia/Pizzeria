import { App } from '../../../module';
import {} from './imgviewer';
import html from './imguploader.html';

export const ilImgUploader = {
  template: html,
  bindings:{
    pizza: '='
  }
}

App.component('ilImgUploader', ilImgUploader);