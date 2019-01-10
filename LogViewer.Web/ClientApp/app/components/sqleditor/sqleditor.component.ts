import { Component, OnInit, Inject } from '@angular/core';
import { Http } from '@angular/http';
import 'codemirror/mode/sql/sql'
import { Router } from '@angular/router';
@Component({
    templateUrl: './sqleditor.component.html',
    styleUrls: ['./sqleditor.component.css']
})
export class SqlEditorComponent implements OnInit {
    private config: any;
    private content: any;
    private baserUrl: string;
    private http: Http;
    private sqlResult: any;
    private selectedQuery: string='';
    private router: Router;
 

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        this.baserUrl = baseUrl;
        this.http = http;
        this.config = { lineNumbers: true, mode: 'text/x-gpsql' };
        this.content = 'SELECT * FROM ';
    }
    ngOnInit(): void {

 }

    executeQuery(http: Http): void {

        this.http.get(this.baserUrl + 'SqlEditor/MultySelect?query=' + this.selectedQuery).subscribe(result => {
            this.sqlResult = result.json();
        }, error => console.error(error));
    }

    cleanEditor(): void {
        this.content = '';
    }

    setSelected(instance, $event): void {
        this.selectedQuery = '';
        let line: string;
        for (var i = 0; i < $event.instance.lineCount();i++)
        {
            line = $event.instance.getLine(i);
            this.selectedQuery += line + '@';
        }
    }
    private textAreaInitState: boolean = true;
    textAreaBlur($event) {
        let txtAreas: any = $event.target.parentNode.parentNode.parentNode.getElementsByTagName("textarea")
        for (var i = 0; i < txtAreas.length; i++)
        {
            txtAreas[i].style.height = "26px";
            txtAreas[i].style.width = "150px";
        }

    }
    
}



