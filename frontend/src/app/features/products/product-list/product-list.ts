import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-product-list',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './product-list.html',
  styleUrl: './product-list.css',
})
export class ProductList {
  products = [
    { id: 1, name: 'Sneakers', price: 1999 },
    { id: 2, name: 'T-Shirt', price: 999 }
  ];
}
