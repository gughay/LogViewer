import { Component, OnInit } from '@angular/core';


@Component({
    selector: 'email',
    templateUrl: './email.component.html',
    styleUrls: ['./email.component.css'],
    inputs:["logId","show"]
})
export class EmailComponent implements OnInit {
    private logId: number;
    private show: boolean;
    ngOnInit(): void {
        console.log(this.logId)
        console.log(this.show)
    }

}
