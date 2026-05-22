export interface Payment {
  id: string;
  orderId: string;
  paymentMethod: 'CreditCard' | 'PayPal' | 'Stripe' | 'UPI';
  transactionId: string;
  amount: number;
  status: 'Pending' | 'Completed' | 'Failed' | 'Refunded';
  updatedAt: Date;
}