import { HttpInterceptorFn } from '@angular/common/http';
import { inject } from '@angular/core';
import { finalize } from 'rxjs';
import { SignalStoreService } from '../services/signal-store.service';

export const loadingInterceptor: HttpInterceptorFn = (req, next) => {
  // Using your SignalStore to manage loading state globally
  const store = inject(SignalStoreService);
  
  store.showLoader();

  return next(req).pipe(
    finalize(() => {
      store.hideLoader();
    })
  );
};