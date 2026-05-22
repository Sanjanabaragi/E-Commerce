import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShipmentManagement } from './shipment-management';

describe('ShipmentManagement', () => {
  let component: ShipmentManagement;
  let fixture: ComponentFixture<ShipmentManagement>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ShipmentManagement],
    }).compileComponents();

    fixture = TestBed.createComponent(ShipmentManagement);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
