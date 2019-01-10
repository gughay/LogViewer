import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

//import { CodemirrorComponent } from './codemirror.component';

import { YaCoreModuleForRoot } from 'angular2-yandex-maps';

/**
 * CodemirrorModule
 */
@NgModule({
  imports: [
      YaCoreModuleForRoot()
  ],
  declarations: [
    //CodemirrorComponent,
     
  ],
  exports: [
    //CodemirrorComponent,
  ]
})

export class YandexMapModule {}
