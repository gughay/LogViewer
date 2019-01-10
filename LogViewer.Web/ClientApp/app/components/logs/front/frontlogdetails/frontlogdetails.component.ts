import { Component,OnInit,Inject } from '@angular/core';
import { Http } from '@angular/http';
import 'codemirror/mode/xml/xml'

@Component({
    templateUrl: './frontlogdetails.component.html',
    styleUrls: ['./frontlogdetails.component.css']
})
export class FrontLogDetailsComponent implements OnInit {
    private config: any;
    private content: any;
    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        this.config = { lineNumbers: true, mode: 'xml' };
        this.content = 'SELECT * FROM ';

    }
    ngOnInit(): void {

    }
}

