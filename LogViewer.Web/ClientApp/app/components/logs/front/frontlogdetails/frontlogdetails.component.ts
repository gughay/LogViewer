import { Component, OnInit, Inject } from '@angular/core';
import { Router, ActivatedRoute, Params } from '@angular/router';
import { Http } from '@angular/http';
import 'codemirror/mode/clike/clike'

@Component({
    templateUrl: './frontlogdetails.component.html',
    styleUrls: ['./frontlogdetails.component.css']
})
export class FrontLogDetailsComponent implements OnInit {
    private log: Log;
    private config: any;
    private content: any;
    private http: Http;
    private baseUrl: string;
    private id: number;
    private router: Router;
    private activatedRoute: ActivatedRoute;
    private sub: any;
    constructor(http: Http, @Inject('BASE_URL') baseUrl: string, router: Router, activatedRoute: ActivatedRoute) {
        this.http = http;
        this.baseUrl = baseUrl;
        this.router = router;
        this.activatedRoute = activatedRoute;
    }
    ngOnInit(): void {
        console.log("log details")
        this.config = { lineNumbers: true, mode: 'text/x-csharp', matchBrackets: true, };
        this.content = '';
        this.sub = this.activatedRoute.params.subscribe(params => {
            this.id = +params['id'];
            this.getLog(this.id);
        });
    }
    ngOnDestroy() {
        this.sub.unsubscribe();
    }
    getLog(id: number) {
        this.http.get(this.baseUrl + 'Log/Get/' + this.id).subscribe(result => {
            this.log = result.json() as Log;
            this.setStackTraceHtml();

        }, error => console.error(error));
    }


    setStackTraceHtml() {
        let logLines = this.log.stackTrace.split('\r\n');
        let tt = Array() as string[];
        let stackTraceHtml: string = '';
        this.log.stakTraceFull = [];
        for (var i = 0; i < logLines.length; i++) {
            if (logLines[i].includes(' in ')) {
                tt = logLines[i].split(' in ');
                let ttt = Array() as string[];
                ttt.push(tt[0])
                ttt.push(tt[1])
                this.log.stakTraceFull.push({ "lines": ttt })
            }
            else {
                let ttt = Array() as string[];
                ttt.push(logLines[i]);
                this.log.stakTraceFull.push({ "lines": ttt });
            }
        }
        //this.log.stackTrace = stackTraceHtml;
    }

    getFileContentFromTfs(path: string) {

        var index = path.indexOf(":line");
        path = path.slice(0, index - path.length)
        this.http.get(this.baseUrl + 'Log/GetFileContentFromFileSystem' + '?path=' + path).subscribe(result => {
            this.content = (result.json() as Path).content;
            console.log(this.content);
        }, error => console.error(error));

    }
}
interface Log {
    id: number;
    createdOn: any;
    logger: string;
    logLevel: string;
    exceptionType: string;
    message: string;
    stackTrace: string;
    clientIp: string;
    userName: string;
    stakTraceFull: any;
}


interface Path {
    content: string;
}
