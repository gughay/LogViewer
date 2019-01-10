import { Component,OnInit,Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    templateUrl: './apariktexum.component.html',
    styleUrls: ['./apariktexum.component.css']
})
export class AparikTexumLogComponent implements OnInit {
    public forecasts: WeatherForecast[];
    private  previousLog:any;   
    private  currentLog:any;  
    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'api/SampleData/WeatherForecasts').subscribe(result => {
            this.forecasts = result.json() as WeatherForecast[];

        }, error => console.error(error));
    }
    ngOnInit(): void {

    }

 openLog(m) {
        m.show = !m.show;
        this.previousLog = this.currentLog;
        this.currentLog = m;
        if (this.previousLog != this.currentLog) {
            this.previousLog.show = false;
        }
    }

}

interface WeatherForecast {
    dateFormatted: string;
    temperatureC: number;
    temperatureF: number;
    summary: string;
}

