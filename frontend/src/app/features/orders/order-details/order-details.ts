import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-order-details',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './order-details.html',
  styleUrl: './order-details.css',
})
export class OrderDetails {
  order = {
    id: 101,
    product: 'Sneakers',
    quantity: 1,
    amount: 2999,
    paymentStatus: 'Paid',
    shippingStatus: 'Shipped'
  };

}
