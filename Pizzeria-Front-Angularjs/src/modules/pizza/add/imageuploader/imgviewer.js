import { App } from '../../../module';

export const ilImgViewer = function () {
    return {
        restrict: 'A',
        link: function (scope, element, attrs) {
            let input = document.querySelectorAll('[il-img-viewer]')[1];
            let preview = document.getElementById('preview');
            if (input && preview) {
                let handler = function () {
                    if (input.files && input.files[0]) {
                        let reader = new FileReader();
                        reader.onload = function (e) {
                           preview.setAttribute('src', e.target.result);
                        }
                        reader.readAsDataURL(input.files[0]);
                    }
                }
                input.addEventListener('change', handler, false);
                scope.$on('$destroy', function () {
                    input.removeEventListener('change', handler, false)
                });
            }
        }
    };
}
App.directive('ilImgViewer', ilImgViewer)

