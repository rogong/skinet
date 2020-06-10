import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PaginationModule } from 'ngx-bootstrap/pagination';
import { CarouselModule } from 'ngx-bootstrap/carousel';
import {BsDropdownModule} from 'ngx-bootstrap/dropdown';
import { PagingHeaderComponent } from './components/paging-header/paging-header.component';
import { PagerComponent } from './components/pager/pager.component';
import { LeftBannerComponent } from './left-banner/left-banner.component';
import { AdComponent } from './ad/ad.component';
import { OrderTotalsComponent } from './components/order-totals/order-totals.component';
import { ReactiveFormsModule } from '@angular/forms';
import { TextInputComponent } from './components/text-input/text-input.component';


@NgModule({
  declarations: [
    PagingHeaderComponent,
    PagerComponent,
    LeftBannerComponent,
    AdComponent,
    OrderTotalsComponent,
    TextInputComponent,

  ],
  imports: [
    CommonModule,
    PaginationModule.forRoot(),
    CarouselModule.forRoot(),
    BsDropdownModule.forRoot(),
    ReactiveFormsModule,
  ],
  exports: [
    PaginationModule,
    CarouselModule,
    BsDropdownModule,
    PagingHeaderComponent,
    PagerComponent,
    LeftBannerComponent,
    AdComponent,
    OrderTotalsComponent,
    ReactiveFormsModule,
    TextInputComponent
  ],
})
export class SharedModule {}
