import { Component } from '@angular/core';
import { RouterModule } from '@angular/router';
import { MatListModule } from '@angular/material/list';
import { MatIconModule } from '@angular/material/icon';
import { CommonModule } from '@angular/common';

interface MenuItem {
  icon: string;
  label: string;
  route: string;
}

@Component({
  selector: 'app-sidebar',
  standalone: true,
  imports: [
    CommonModule,
    RouterModule,
    MatListModule,
    MatIconModule
  ],
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.scss']
})
export class SidebarComponent {
  menuItems: MenuItem[] = [
    {
      icon: 'dashboard',
      label: 'Dashboard',
      route: '/app/dashboard'
    },
    {
      icon: 'people',
      label: 'Usuarios',
      route: '/app/users'
    },
    {
      icon: 'inventory_2',
      label: 'Productos',
      route: '/app/products'
    },
    {
      icon: 'assessment',
      label: 'Reporte Stock Bajo',
      route: '/app/reports/low-stock'
    }
  ];
} 