import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-address-management',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './address-management.html',
  styleUrl: './address-management.css',
})
export class AddressManagement {
  addresses = [
    {
      city: 'Bangalore',
      state: 'Karnataka',
      pincode: '560001'
    }
  ];

}
