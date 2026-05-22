import { Routes } from '@angular/router';
import { CustomerLayoutComponent } from './layouts/customer-layout/customer-layout';
import { AdminLayoutComponent } from './layouts/admin-layout/admin-layout';
import { AuthLayoutComponent } from './layouts/auth-layout/auth-layout';
import { authGuard } from './core/guards/auth.guard';
import { adminGuard } from './core/guards/admin.guard';
import { Payment } from './features/checkout/payment/payment';
import { OrderManagement } from './features/admin/order-management/order-management';
import { CustomerManagement } from './features/admin/customer-management/customer-management';
import { Analytics } from './features/admin/analytics/analytics';
import { Picking } from './features/warehouse/picking/picking';
import { Packing } from './features/warehouse/packing/packing';
import { Dispatch } from './features/warehouse/dispatch/dispatch';      
import { ProductList } from './features/products/product-list/product-list';
import { ProductDetails } from './features/products/product-details/product-details';
import { ProductSearch } from './features/products/product-search/product-search';
import { ProductFilter } from './features/products/product-filter/product-filter';
import { CartPage } from './features/cart/cart-page/cart-page';
import { CartSummary } from './features/cart/cart-summary/cart-summary';
import { OrderSuccess } from './features/checkout/order-success/order-success';
import { OrderReview } from './features/checkout/order-review/order-review';
import { Shipping } from './features/checkout/shipping/shipping';
import { OrderHistory } from './features/orders/order-history/order-history';
import { OrderDetails } from './features/orders/order-details/order-details';
import { TrackOrder } from './features/orders/track-order/track-order';
import { ProfilePage } from './features/profile/profile-page/profile-page';
import { AddressManagement } from './features/profile/address-management/address-management';
import { Wishlist } from './features/profile/wishlist/wishlist';
import { Login } from './features/auth/login/login';
import { Register } from './features/auth/register/register';
import { ForgotPassword } from './features/auth/forgot-password/forgot-password';
import { ShipmentManagement } from './features/admin/shipment-management/shipment-management';
import { InventoryManagement } from './features/admin/inventory-management/inventory-management';
import { ProductManagement } from './features/admin/product-management/product-management';
import { Dashboard } from './features/admin/dashboard/dashboard';

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
  },

   /* PRODUCTS */
      { path: 'products', component: ProductList },
      { path: 'products/details', component: ProductDetails }, // Placeholder for ProductDetailsComponent
      { path: 'products/search', component: ProductSearch},
      { path: 'products/filter', component: ProductFilter },

  /* CART */
      { path: 'cart', component: CartPage },
      { path: 'cart-summary', component: CartSummary },

   /* CHECKOUT */
      { path: 'shipping', component: Shipping },
      { path: 'payment', component: Payment },
      { path: 'order-review', component: OrderReview },
      { path: 'order-success', component: OrderSuccess },

   /* ORDERS */
      { path: 'orders', component: OrderHistory},
      { path: 'orders/details', component: OrderDetails },
      { path: 'track-order', component: TrackOrder },

   /* PROFILE */
      { path: 'profile', component: ProfilePage },
      { path: 'manage-address', component: AddressManagement },
      { path: 'wishlist', component: Wishlist },

  /* =========================
      AUTH LAYOUT
  ========================== */

  {
    path: '',
    component: AuthLayoutComponent,
    children: [

      { path: 'login', component: Login },
      { path: 'register', component: Register },
      { path: 'forgot-password', component: ForgotPassword}

    ]
  },

  /* =========================
      ADMIN LAYOUT
  ========================== */

  {
    path: 'admin',
    component: AdminLayoutComponent,
    canActivate: [authGuard, adminGuard],
    children: [

      { path: 'dashboard', component: Dashboard },

      { path: 'products', component: ProductManagement},

      { path: 'inventory', component: InventoryManagement },

      { path: 'orders', component: OrderManagement },

      { path: 'shipments', component: ShipmentManagement },

      { path: 'customers', component: CustomerManagement },

      { path: 'analytics', component: Analytics },


     /* WAREHOUSE */

      { path: 'picking', component: Picking},

      { path: 'packing', component: Packing },

      { path: 'dispatch', component: Dispatch }

    ]
  },

   /* =========================
      WILDCARD ROUTE
  ========================== */

  {
    path: '**',
    redirectTo: ''
  }

];