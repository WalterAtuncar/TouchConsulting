import { Routes } from '@angular/router';
import { AuthGuard } from './core/guards/auth.guard';
import { MainLayoutComponent } from './layout/main-layout/main-layout.component';

export const routes: Routes = [
  {
    path: 'app',
    component: MainLayoutComponent,
    canActivate: [AuthGuard],
    children: [
      {
        path: 'dashboard',
        loadComponent: () => import('./dashboard/dashboard.component').then(m => m.DashboardComponent)
      },
      {
        path: 'users',
        loadComponent: () => import('./users/components/user-list/user-list.component').then(m => m.UserListComponent)
      },
      {
        path: 'products',
        loadComponent: () => import('./products/components/product-list/product-list.component').then(m => m.ProductListComponent)
      },
      {
        path: 'reports/low-stock',
        loadComponent: () => import('./reports/components/low-stock-report/low-stock-report.component').then(m => m.LowStockReportComponent)
      },
      {
        path: '',
        redirectTo: 'dashboard',
        pathMatch: 'full'
      }
    ]
  },
  {
    path: 'login',
    loadComponent: () => import('./authentication/login/login.component').then(m => m.LoginComponent)
  },
  {
    path: '',
    redirectTo: 'app',
    pathMatch: 'full'
  },
  {
    path: '**',
    redirectTo: 'app'
  }
];
