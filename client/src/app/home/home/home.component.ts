import { Component, OnInit } from '@angular/core';
import { ShopService } from 'src/app/shop/shop.service';
import { ShopParams } from 'src/app/shared/models/shopParams';
import { IProduct } from 'src/app/shared/models/product';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss'],
})
export class HomeComponent implements OnInit {
  constructor(private shopService: ShopService) {}
  products: IProduct[];
  shopParams = new ShopParams();
  totalCount: number;
  ngOnInit(): void {
    this.getProducts();
  }

  getProducts() {
    this.shopService.getProducts(this.shopParams).subscribe(
      (response) => {
        this.products = response.data;
        this.shopParams.pageNumber = response.pageIndex;
        this.shopParams.pageSize = response.pageSize;
        this.totalCount = response.count;
      },
      (error) => {
        console.log(error);
      }
    );
  }
}
