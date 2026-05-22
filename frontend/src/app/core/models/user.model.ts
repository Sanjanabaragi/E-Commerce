export interface User {
  id: string;
  email: string;
  firstName: string;
  lastName: string;
  role: 'Admin' | 'Customer';
  createdAt: Date;
}

export interface AuthResponse {
  token: string;
  user: User;
}