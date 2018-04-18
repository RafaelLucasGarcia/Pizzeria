import { App } from '../module';

export class AppCtrl {
    constructor(mdSidenav) {
        this.mdSidenav = mdSidenav;
    }
    isSidenavClosed() {
        return !(this.mdSidenav("sidenav").isOpen() || this.mdSidenav("sidenav").isLockedOpen());
    }
    openSidenav() {
        this.mdSidenav("sidenav").toggle();
    }
    closeSidenav() {
        this.mdSidenav("sidenav").close();
    }
    
}
AppCtrl.$inject = ['$mdSidenav', 'localStorageService'];
App.controller('appCtrl', AppCtrl);