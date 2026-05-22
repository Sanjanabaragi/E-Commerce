import { HttpInterceptorFn, HttpErrorResponse } from '@angular/common/http';
import { inject } from '@angular/core';
import { catchError, throwError } from 'rxjs';
import { Router } from '@angular/router';
import { StorageService } from '../services/storage.service';

export const errorInterceptor: HttpInterceptorFn = (req, next) => {
  const router = inject(Router);
  const storageService = inject(StorageService);

  return next(req).pipe(
    catchError((error: HttpErrorResponse) => {
      if (error) {
        switch (error.status) {
          case 401:
            // Auto logout if unauthorized/token expired
            storageService.clear();
            router.navigate(['/login']);
            break;
          case 403:
            router.navigate(['/unauthorized']);
            break;
          case 500:
            console.error('Server side error occurred:', error.message);
            break;
          default:
            console.error('An unexpected error occurred:', error.message);
            break;
        }
      }
      return throwError(() => error);
    })
  );
};