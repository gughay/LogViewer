import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { InfiniteScrollModule } from 'ngx-infinite-scroll';
import { CodemirrorModule } from './components/codemirror/codemirror.module';
import {ToasterModule} from 'angular2-toaster';
import { EmailComponent } from './components/email/email.component'

import { AppComponent } from './components/app/app.component';
import { HomeComponent } from './components/home/home.component';
import { FrontLogComponent } from './components/logs/front/frontlog.component';
import { AparikTexumLogComponent } from './components/logs/apariktexum/apariktexum.component';
import { CustomersLogComponent } from './components/logs/customers/customers.component';
import { OrderComponent } from './components/order/order.component';
import { SqlEditorComponent } from './components/sqleditor/sqleditor.component';
import { FrontLogDetailsComponent } from './components/logs/front/frontlogdetails/frontlogdetails.component';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { YaCoreModule } from 'angular2-yandex-maps';

//import { SplitModule } from 'ng2-split'

@NgModule({
    declarations: [
        AppComponent,
        HomeComponent,
        FrontLogComponent,
        CustomersLogComponent,
        AparikTexumLogComponent,
        OrderComponent,
        SqlEditorComponent,
        FrontLogDetailsComponent,
        EmailComponent
    ],
    imports: [
        CommonModule,
        HttpModule,
        FormsModule,
        BrowserAnimationsModule,
        CodemirrorModule,
        InfiniteScrollModule, 
        ToasterModule,
        YaCoreModule.forRoot(),
        //ToastModule
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'frontLogs', component: FrontLogComponent },
            { path: 'customersLogs', component: CustomersLogComponent },
            { path: 'aparikTexumLogs', component: AparikTexumLogComponent },
            { path: 'orders', component: OrderComponent },
            { path: 'sqleditor', component: SqlEditorComponent },
            { path: 'frontlogdetails/:id', component: FrontLogDetailsComponent },            //{ path: '**', redirectTo: 'home' }
        ])
    ]
})
export class AppModuleShared {
}

