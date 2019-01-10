import { Component,OnInit } from '@angular/core';
import { HubConnection } from '@aspnet/signalr-client';

@Component({
    selector: 'app',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {

    ngOnInit(): void {

        let connection = new HubConnection('/message');

        connection.on('send', data => {
            console.log(data);
        });

        connection.start()
            .then(() => console.log('Connected'));
    }

}
