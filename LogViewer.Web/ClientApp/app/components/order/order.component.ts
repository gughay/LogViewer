import { Component,OnInit,Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    templateUrl: './order.component.html',
    styleUrls: ['./order.component.css']
})
export class OrderComponent implements OnInit {
    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'Order/GetAll').subscribe(result => {

        }, error => console.error(error));
    }
    ngOnInit(): void {

    }
}


