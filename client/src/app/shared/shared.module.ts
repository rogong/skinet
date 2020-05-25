import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PaginationModule } from 'ngx-bootstrap/pagination';
import { CarouselModule } from 'ngx-bootstrap/carousel';
import { PagingHeaderComponent } from './components/paging-header/paging-header.component';
import { PagerComponent } from './components/pager/pager.component';
import { LeftBannerComponent } from './left-banner/left-banner.component';
import { AdComponent } from './ad/ad.component';

@NgModule({
  declarations: [
    PagingHeaderComponent,
    PagerComponent,
    LeftBannerComponent,
    AdComponent,
  ],
  imports: [CommonModule, PaginationModule.forRoot(), CarouselModule.forRoot()],
  exports: [
    PaginationModule,
    CarouselModule,
    PagingHeaderComponent,
    PagerComponent,
    LeftBannerComponent,
    AdComponent,
  ],
})
export class SharedModule {}
