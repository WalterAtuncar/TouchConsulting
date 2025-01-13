import { Injectable } from '@angular/core';
import { CanActivate, Router } from '@angular/router';
import { Observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {
  constructor(private router: Router) {}

  canActivate(): Observable<boolean> {
    // Temporalmente retornamos true para permitir acceso mientras se desarrolla
    return of(true);

    // Implementación futura:
    // if (/* verificar autenticación */) {
    //   return of(true);
    // }
    // this.router.navigate(['/auth/login']);
    // return of(false);
  }
} 