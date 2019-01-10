import { Component,OnInit,Inject } from '@angular/core';
import { Http } from '@angular/http';
import { Router } from '@angular/router';
import { ToasterService, Toast } from 'angular2-toaster';
import { HubConnection } from '@aspnet/signalr-client';

@Component({
    templateUrl: './frontlog.component.html',
    styleUrls: ['./frontlog.component.css','./email.component.css']
})
export class FrontLogComponent implements OnInit {
    public logs: Log[];
    private  previousLog:any;   
    private currentLog: any;  
    private router: Router;
    private http: Http;
    private baseUrl: string;
    private sharedLogId: number;
    private showEmailForm: boolean = false;
    private email: string;
    private emailSubject: string;
    private toasterService: ToasterService;
    constructor(http: Http, @Inject('BASE_URL') baseUrl: string, router: Router, toasterService: ToasterService) {
        this.router = router;
        this.baseUrl = baseUrl;
        this.http = http;
        this.toasterService = toasterService;
    }

    ngOnInit(): void {

        this.http.get(this.baseUrl + 'api/Log/Getlogs').subscribe(result => {
            this.logs = result.json() as Log[];
            console.log(this.logs)
        }, error => console.error(error));


        let connection = new HubConnection('/message');
        connection.on('send', data => {
            console.log(data);
            this.popToast();
        });

        connection.start()
            .then(() => console.log('Connected'));
    }

 openLog(m) {
        m.show = !m.show;
        this.previousLog = this.currentLog;
        this.currentLog = m;
        if (this.previousLog != this.currentLog) {
            this.previousLog.show = false;
        }
    }

 openLogDetails() {
     this.router.navigateByUrl('/frontlogdetails');
 }

 shareLog() {
     this.showEmailForm = true;
 }

 closeEmailForm() {
     this.showEmailForm = false;
 }
 sendEmail() {
     console.log(this.emailSubject)
     console.log(this.email)
     this.showEmailForm = false;
 }
 popToast() {
     var toast: Toast = {
         type: 'info',
         title: 'New Log',
         body: 'Here is a Toast Body',
         showCloseButton: true,
         clickHandler: (t, isClosed): boolean => {
             console.log('i am clicked..', isClosed, t);

             // got clicked and it was NOT the close button!
             if (!isClosed) {

             }

             return true; // remove this toast !
         }
     };
     this.toasterService.pop(toast);
 }

}

interface Log {
    logId: number;
    message: string;
    stackTrace: string;
    innerException: string;
}




