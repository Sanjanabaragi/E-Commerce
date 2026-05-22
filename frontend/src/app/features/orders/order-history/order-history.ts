import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-order-history',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './order-history.html',
  styleUrl: './order-history.css',
})
export class OrderHistory {
  orders = [
    {
      orderId: 101,
      product: 'Sneakers',
      amount: 2999,
      status: 'Delivered'
    },
    {
      orderId: 102,
      product: 'T-Shirt',
      amount: 999,
      status: 'Shipped'
    }
  ];
}
