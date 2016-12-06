import { Component } from '@angular/core';

@Component({
    selector: 'm-main-app-component',
    template: '<h1>{{title}}</h1>'
})

export class MyAppComponent {
    title = 'Tour of Heroes';
}