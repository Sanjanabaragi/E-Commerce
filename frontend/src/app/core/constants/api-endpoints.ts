export const API_ENDPOINTS = {
  AUTH: {
    LOGIN: 'auth/login',
    REGISTER: 'auth/register',
    REFRESH_TOKEN: 'auth/refresh-token'
  },
  PRODUCTS: {
    BASE: 'products',
    GET_BY_ID: (id: string) => `products/${id}`,
    CATEGORIES: 'products/categories'
  },
  ORDERS: {
    BASE: 'orders',
    GET_BY_ID: (id: string) => `orders/${id}`,
    USER_ORDERS: 'orders/my-orders'
  },
  PAYMENTS: {
    PROCESS: 'payments/process',
    STATUS: (transactionId: string) => `payments/status/${transactionId}`
  }
};