import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-track-order',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './track-order.html',
  styleUrl: './track-order.css',
})
export class TrackOrder {
  trackingNumber = 'TRK123456789';
}
