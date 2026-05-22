import { Routes } from '@angular/router';
import { CustomerLayoutComponent } from './layouts/customer-layout/customer-layout';
import { AdminLayoutComponent } from './layouts/admin-layout/admin-layout';
import { AuthLayoutComponent } from './layouts/auth-layout/auth-layout';
import { authGuard } from './core/guards/auth.guard';
import { adminGuard } from './core/guards/admin.guard';

export const routes: Routes = [
  // 1. Customer Storefront Layout Branch
  {
    path: '',
    component: CustomerLayoutComponent,
    children: [
      // Feature components (like Home, Products, Cart) will go here later
    ]
  },

  // 2. Auth Layout Branch (Sign In / Registration Canvas)
  {
    path: '',
    component: AuthLayoutComponent,
    children: [
      // Authentication components (like Login, Register) will go here later
    ]
  },

  // 3. Admin Management Dashboard Branch (Protected by Guards)
  {
    path: 'admin',
    component: AdminLayoutComponent,
    canActivate: [authGuard, adminGuard],
    children: [
      // Control panel components (like Dashboard, Product Management) will go here later
    ]
  }
];